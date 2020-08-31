using System;

namespace TestTask
{
    class LoggerMessage : ILoggerMessage
    {
        public LogLevel Level { get; }

        public DateTime LogDateTime { get; }

        public string Message { get; }

        public LoggerMessage(LogLevel level, string message)
        {
            Level = level;
            Message = message;
            LogDateTime = DateTime.Now;
        }
        public override string ToString()
        {
            return $"[{LogDateTime}] {Level}: {Message}";
        }
    }
}
