using System.Collections.Generic;

namespace TestTask
{
    interface IBatchWriter : IWriter
    {
        void Write(IList<ILoggerMessage> messages);
        void Flush();
    }
}
