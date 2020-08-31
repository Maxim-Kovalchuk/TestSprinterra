using System;

namespace TestTask
{
    abstract class LoggerBase : ILogger
    {
        protected readonly IWriter writer;
        public void Debug(string message)
        {
            writer.Write(GetLoggerMessage(LogLevel.Debug, message));
        }

        public void Error(string message)
        {
            writer.Write(GetLoggerMessage(LogLevel.Error, message));
        }

        public void Fatal(string message)
        {
            writer.Write(GetLoggerMessage(LogLevel.Fatal, message));
        }

        public void Info(string message)
        {
            writer.Write(GetLoggerMessage(LogLevel.Info, message));
        }

        public void Warn(string message)
        {
            writer.Write(GetLoggerMessage(LogLevel.Warn, message));
        }
        public LoggerBase(IWriter writer)
        {
            this.writer = writer;
        }

        public LoggerMessage GetLoggerMessage(LogLevel level, string message)
        {
            return new LoggerMessage(level, message);
        }

        public virtual void WriteLog(LogLevel level, string message)
        {
            writer.Write(GetLoggerMessage(level, message));
        }
    }
}
