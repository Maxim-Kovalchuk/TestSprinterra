using System;

namespace TestTask
{
    internal class Program
    {
		static void Main(string[] args)
		{
			ILogger logger = LoggerService.GetLogger();
            logger.Info("Simple logger: Info message");
            logger.Warn("Simple logger: Warn message");
            logger.Error("Simple logger: Error message");
            logger.Debug("Simple logger: Debug message");
            logger.Fatal("Simple logger: Fatal message");

            Console.WriteLine("************************");

			IBatchLogger batchLogger = LoggerService.GetBatchLogger();
            batchLogger.Info("Batch logger: Info message");
            batchLogger.Warn("Batch logger: Warn message");
            batchLogger.Error("Batch logger: Error message");
            batchLogger.Debug("Batch logger: Debug message");
            batchLogger.Fatal("Batch logger: Fatal message");
            batchLogger.Flush();

            Console.WriteLine("************************");
        }
    }
}
