using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask
{
    public interface IBatchLogger
    {
        public void Debug(string message);
        public void Error(string message);
        public void Fatal(string message);
        public void Info(string message);
        public void Warn(string message);
        void Flush();
    }
}
