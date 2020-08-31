using System.Collections.Generic;

namespace TestTask
{
    class BatchWriterPool : IBatchWriter
    {
        public IList<IBatchWriter> Writers { get; set; } = new List<IBatchWriter>();

        public BatchWriterPool(IEnumerable<IBatchWriter> writers)
        {
            foreach (IBatchWriter writer in writers)
            {
                Writers.Add(writer);
            }
        }

        public void Write(ILoggerMessage message)
        {
            foreach (IBatchWriter writer in Writers)
            {
                writer.Write(message);
            }
        }

        public void Write(IList<ILoggerMessage> messages)
        {
            foreach (IBatchWriter writer in Writers)
            {
                foreach (ILoggerMessage message in messages) { writer.Write(message); }
            }
        }

        public void Flush()
        {
            foreach (IBatchWriter writer in Writers) 
            {
                writer.Flush();
            }
        }
    }
}
