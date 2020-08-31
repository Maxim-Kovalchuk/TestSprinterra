using System;

namespace TestTask
{
    class Logger : LoggerBase
    {

        public Logger(IWriter writer) : base(writer)
        {
        }

        public override void WriteLog(LogLevel level, string message)
        {
            writer.Write(GetLoggerMessage(level, message));
        }
    }
}
