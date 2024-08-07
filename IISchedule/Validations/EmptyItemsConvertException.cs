namespace IISchedule.Validations
{
    class EmptyItemsConvertException : Exception
    {
        public EmptyItemsConvertException() { }
        public EmptyItemsConvertException(string message) : base(message) { }
        public EmptyItemsConvertException(string message, Exception inner) : base(message, inner) { }
    }
}
