using System;

namespace TestTask
{
    interface ILoggerMessage
    {
        public LogLevel Level { get; }
        public DateTime LogDateTime { get; }
        public string Message { get; }

        public string ToString();
    }
}
