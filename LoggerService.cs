using System;
using System.Collections.Generic;

namespace TestTask
{
    public static class LoggerService
    {
        private static readonly Lazy<ILogger> _logger;
        private static readonly Lazy<IBatchLogger> _batchLogger;

        static LoggerService()
        {
			string fileName = $"Log_{DateTime.Now.ToFileTime()}.txt";
			Lazy<IWriter> writer = new Lazy<IWriter>(() => new WriterPool(new List<IWriter> { new ConsoleWriter(), new FileLogWriter(fileName) }));
			Lazy<IBatchWriter> batchWriter = new Lazy<IBatchWriter>(() => new BatchWriterPool(new List<IBatchWriter> { new BatchConsoleWriter(), new BatchFileLogWriter(fileName) }));
            _logger = new Lazy<ILogger>(() => new Logger(writer.Value));
            _batchLogger = new Lazy<IBatchLogger>(() => new BatchLogger(batchWriter.Value));
        }

        public static ILogger GetLogger()
        {
            return _logger.Value;
        }

        public static IBatchLogger GetBatchLogger()
        {
            return _batchLogger.Value;
        }
    }
}
