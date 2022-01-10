namespace E3DC.RSCP.Lib
{
    /// <summary>
    /// Exception raised on frame parsing error
    /// </summary>
    public class ProtocolException : Exception
    {
        public ProtocolException(string? message) : base(message)
        {
        }

        public ProtocolException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}