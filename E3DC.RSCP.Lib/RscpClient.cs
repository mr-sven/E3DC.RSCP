using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;
using System.Net.Sockets;
using System.Text;
using System;

namespace E3DC.RSCP.Lib
{
    /// <summary>
    /// Main Client Logic
    /// </summary>
    public class RscpClient
    {
        /// <summary>
        /// Default RSCP Port
        /// </summary>
        public const int DEFAULT_PORT = 5033;

        /// <summary>
        /// Size of AES Input Vector
        /// </summary>
        public const int IV_SIZE = 32;

        /// <summary>
        /// username value
        /// </summary>
        private readonly string username;

        /// <summary>
        /// password value
        /// </summary>
        private readonly string password;

        /// <summary>
        /// tcp client object
        /// </summary>
        private readonly TcpClient tcpClient = new();

        /// <summary>
        /// send Queue Semaphore for cancelation token
        /// </summary>
        private readonly SemaphoreSlim sendQueue = new(1);

        /// <summary>
        /// holds the network stream object
        /// </summary>
        private NetworkStream? networkStream;

        /// <summary>
        /// Input Vector cache for encryption
        /// </summary>
        private byte[] ivEncryption = Array.Empty<byte>();

        /// <summary>
        /// Input Vector cache for decryption
        /// </summary>
        private byte[] ivDecryption = Array.Empty<byte>();

        /// <summary>
        /// AES Key Bytes
        /// </summary>
        private readonly byte[] encryptionPassword = Enumerable.Repeat((byte)0xff, IV_SIZE).ToArray();

        /// <summary>
        /// AES encryption algo
        /// </summary>
        private PaddedBufferedBlockCipher? encryptAlg;

        /// <summary>
        /// AES decryption algo
        /// </summary>
        private PaddedBufferedBlockCipher? decryptAlg;

        /// <summary>
        /// Is client connected
        /// </summary>
        public bool Connected => tcpClient.Connected;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="encryptionPassword"></param>
        /// <exception cref="ArgumentException">if encryptionPassword is to large</exception>
        public RscpClient(string username, string password, string encryptionPassword)
        {
            if (encryptionPassword.Length > IV_SIZE)
            {
                throw new ArgumentException("invalid encryption password");
            }
            this.username = username;
            this.password = password;
            Encoding.ASCII.GetBytes(encryptionPassword).CopyTo(this.encryptionPassword, 0);
        }

        /// <summary>
        /// Connects and authorizes the user vial RSCP Protocol
        /// </summary>
        /// <param name="address">Host address to connect</param>
        /// <param name="port">Port, default 5033</param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>connect task</returns>
        public async Task<UserLevel> ConnectAsync(string address, int port = DEFAULT_PORT, CancellationToken cancellationToken = default)
        {
            try
            {
                await tcpClient.ConnectAsync(address, port).ConfigureAwait(false);
                networkStream = tcpClient.GetStream();
                InitEncryption();

                Frame frame = new()
                {
                    [Tags.RSCP.AUTHENTICATION] = new Container()
                    {
                        [Tags.RSCP.AUTHENTICATION_USER] = username,
                        [Tags.RSCP.AUTHENTICATION_PASSWORD] = password
                    }
                };

                Frame frm = await SendAsync(frame, cancellationToken);

                if (frm != null)
                {
                    // user level is not returned as RSCP_USER_LEVEL, it's container response
                    byte userLevel = frm.Get<Tags.RSCP, byte>(Tags.RSCP.AUTHENTICATION);
                    if (Enum.IsDefined(typeof(UserLevel), userLevel))
                    {
                        return (UserLevel)userLevel;
                    }
                }
            }
            catch
            {
                tcpClient.Close();
                throw;
            }

            return UserLevel.NotAuthorized;
        }

        public async Task<Frame> SendAsync(Frame frame, CancellationToken cancellationToken = default)
        {
            if (!tcpClient.Connected)
            {
                throw new ProtocolException("connection closed");
            }

            await sendQueue.WaitAsync(cancellationToken);

            try
            {
                byte[] encrypted = Encrypt(frame.GetBytes());
                await networkStream!.WriteAsync(encrypted, cancellationToken).ConfigureAwait(false);
                while (!networkStream.DataAvailable)
                {
                    await Task.Delay(100, cancellationToken).ConfigureAwait(false);
                }

                using MemoryStream memoryStream = new();
                do
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = await networkStream.ReadAsync(buffer.AsMemory(), cancellationToken).ConfigureAwait(false);
                    await memoryStream.WriteAsync(buffer.AsMemory(0, bytesRead), cancellationToken).ConfigureAwait(false);
                }
                while (networkStream.DataAvailable);

                return Frame.FromBytes(Decrypt(memoryStream.ToArray()));
            }
            finally
            {
                sendQueue.Release();
            }
        }

        /// <summary>
        /// init IV and create algos
        /// </summary>
        private void InitEncryption()
        {
            ivEncryption = Enumerable.Repeat((byte)0xff, IV_SIZE).ToArray();
            ivDecryption = Enumerable.Repeat((byte)0xff, IV_SIZE).ToArray();

            encryptAlg = new PaddedBufferedBlockCipher(new CbcBlockCipher(new RijndaelEngine(256)), new ZeroBytePadding());
            decryptAlg = new PaddedBufferedBlockCipher(new CbcBlockCipher(new RijndaelEngine(256)), new ZeroBytePadding());
        }

        /// <summary>
        /// encrypt data
        /// </summary>
        /// <param name="data">byte data</param>
        /// <returns>encrypted data</returns>
        private byte[] Encrypt(byte[] data)
        {
            // Algo needs to reinit with last IV, because DoFinal resets the IV
            encryptAlg!.Init(true, new ParametersWithIV(new KeyParameter(encryptionPassword), ivEncryption, 0, IV_SIZE));
            byte[] cipherTextBytes = new byte[encryptAlg!.GetOutputSize(data.Length)];
            int length = encryptAlg.ProcessBytes(data, cipherTextBytes, 0);
            length += encryptAlg.DoFinal(cipherTextBytes, length);

            // some evil behavior of bouncy castle, discoused in meany threads,
            // on n times IV_SIZE the cipher adds a full block of padding (zero) to output.
            // Encryption on E3DC does not support this, and dies, so remove block of nothing
            if (data.Length % IV_SIZE == 0 && length > data.Length)
            {
                cipherTextBytes = cipherTextBytes[..data.Length];
            }
            Array.Copy(cipherTextBytes, cipherTextBytes.Length - ivEncryption.Length, ivEncryption, 0, ivEncryption.Length);
            return cipherTextBytes;
        }

        /// <summary>
        /// decrypt data
        /// </summary>
        /// <param name="data">byte data</param>
        /// <returns>decrypted data</returns>
        private byte[] Decrypt(byte[] data)
        {
            // Algo needs to reinit with last IV, because DoFinal resets the IV
            decryptAlg!.Init(false, new ParametersWithIV(new KeyParameter(encryptionPassword), ivDecryption, 0, IV_SIZE));
            byte[] plainTextBytes = new byte[decryptAlg!.GetOutputSize(data.Length)];
            int length = decryptAlg.ProcessBytes(data, plainTextBytes, 0);
            decryptAlg.DoFinal(plainTextBytes, length);
            Array.Copy(data, data.Length - ivDecryption.Length, ivDecryption, 0, ivDecryption.Length);
            return plainTextBytes;
        }

        /// <summary>
        /// Disconnect from storage
        /// </summary>
        public void Disconnect()
        {
            if (tcpClient.Connected)
            {
                tcpClient.Close();
            }
        }
    }
}
