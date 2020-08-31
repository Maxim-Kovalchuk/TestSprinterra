using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TestTask
{
	class BatchFileLogWriter : IBatchWriter
    {
        private readonly IList<ILoggerMessage> loggerMessages = new List<ILoggerMessage>();
        public string FileName { get; private set; }

        public BatchFileLogWriter(string fileName)
        {
            FileName = fileName;
        }

        public void Flush()
        {
            File.AppendAllLines(FileName, loggerMessages.Select(lm => $"[{lm.LogDateTime}] {lm.Level}: {lm.Message}"));
        }

        public void Write(IList<ILoggerMessage> messages)
        {
            foreach (ILoggerMessage message in messages)
            {
                loggerMessages.Add(message);
            }
        }

        public void Write(ILoggerMessage message)
        {
            loggerMessages.Add(message);
        }
    }
}
