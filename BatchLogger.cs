namespace TestTask
{
    internal class BatchLogger : IBatchLogger
    {
        private readonly IBatchWriter writer;

        public BatchLogger(IBatchWriter writer)
        {
            this.writer = writer;
        }

        public void Debug(string message)
        {
            writer.Write(new LoggerMessage(LogLevel.Debug, message));
        }

        public void Error(string message)
        {
            writer.Write(new LoggerMessage(LogLevel.Error, message));
        }

        public void Fatal(string message)
        {
            writer.Write(new LoggerMessage(LogLevel.Fatal, message));
        }

        public void Flush()
        {
            writer.Flush();
        }

        public void Info(string message)
        {
            writer.Write(new LoggerMessage(LogLevel.Info, message));
        }

        public void Warn(string message)
        {
            writer.Write(new LoggerMessage(LogLevel.Warn, message));
        }
    }
}