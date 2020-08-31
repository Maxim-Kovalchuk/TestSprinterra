using System;
using System.Collections.Generic;
using System.Linq;

namespace TestTask
{
    internal class BatchConsoleWriter : IBatchWriter
    {
        private readonly IList<ILoggerMessage> loggerMessages = new List<ILoggerMessage>();

        public void Flush()
        {
            foreach (ILoggerMessage loggerMessage in loggerMessages) 
            { 
                Console.WriteLine(loggerMessage.ToString()); 
            }
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