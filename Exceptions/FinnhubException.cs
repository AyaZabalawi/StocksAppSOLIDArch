namespace Exceptions
{
    /// <summary>
    ///  Represents a database connection or database update failure
    /// </summary>
    public class FinnhubException : Exception
    {
        public FinnhubException() { }
        public FinnhubException(string message) : base(message) { }
        public FinnhubException(string message, Exception? innerException) : base(message, innerException) { }
    }
}
