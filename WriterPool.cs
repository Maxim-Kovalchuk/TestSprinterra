using System.Collections.Generic;

namespace TestTask
{
    class WriterPool : IWriter
    {
        public IList<IWriter> Writers { get; set; } = new List<IWriter>();

        public WriterPool(IEnumerable<IWriter> writers)
        {
            foreach (IWriter writer in writers)
                Writers.Add(writer);
        }

        public void Write(ILoggerMessage message)
        {
            foreach (IWriter writer in Writers)
                writer.Write(message);
        }

        public void Write(IList<ILoggerMessage> messages)
        {
            foreach (IWriter writer in Writers)
                foreach (ILoggerMessage message in messages) 
                    writer.Write(message);
        }
    }
}
