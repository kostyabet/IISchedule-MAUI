namespace IISchedule.Validations
{
    class StatusCodeException : Exception
    {
        public StatusCodeException() { }
        public StatusCodeException(string message) : base(message) { }
        public StatusCodeException(string message, Exception inner) : base(message, inner) { }
    }
}
