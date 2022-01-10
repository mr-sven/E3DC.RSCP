namespace E3DC.RSCP.Lib
{
    /// <summary>
    /// This enum contains all error codes the S10 can produce.
    /// </summary>
    public enum ErrorCode : uint
    {
        /// <summary>
        /// Unhandled error.
        /// </summary>
        NotHandled = 0x01,

        /// <summary>
        /// Authorization error.
        /// </summary>
        AccessDenied = 0x02,

        /// <summary>
        /// Invalid format.
        /// </summary>
        Format = 0x03,

        /// <summary>
        /// Again error (whatever that means).
        /// </summary>
        Again = 0x04,

        /// <summary>
        /// if array request out of bounds
        /// </summary>
        OutOfBounds = 0x05,

        /// <summary>
        /// if data is not available
        /// </summary>
        NotAvailable = 0x06,

        /// <summary>
        /// if tag not known
        /// </summary>
        UnknownTag = 0x07,

        /// <summary>
        /// if element is in use
        /// </summary>
        AlreadyInUse = 0x08
    }
}
