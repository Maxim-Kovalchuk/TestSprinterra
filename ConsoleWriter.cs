using System;

namespace TestTask
{
    class ConsoleWriter : IWriter
    {
        public void Write(ILoggerMessage message)
        {
            Console.WriteLine(message);
        }
    }
}
