using System;
using System.Runtime.Serialization;

namespace QuartoModulo
{
    [Serializable]
    internal class FakeException : Exception
    {
        public FakeException()
        {
            Console.WriteLine("Questa è una eccezione personalizzata");
        }

        public FakeException(string message) : base(message)
        {
        }

        public FakeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FakeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}