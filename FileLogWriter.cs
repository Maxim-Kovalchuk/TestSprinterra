using System.IO;

namespace TestTask
{
    internal class FileLogWriter : IWriter
    {
        public string FileName { get; private set; }

        public FileLogWriter(string fileName)
        {
            FileName = fileName;
        }

        public void Write(ILoggerMessage message)
        {
            File.AppendAllText(FileName, message.ToString()+"\r\n");
        }
    }
}