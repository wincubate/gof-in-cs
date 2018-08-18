using System;
using System.IO;
using System.Text;

namespace Wincubate.DisposeExamples
{
    class FileWriter
    {
        private readonly FileStream _fs;

        public FileWriter() =>
            _fs = File.Create(@"FileWriter.txt");

        public void Log()
        {
            string s = $"{DateTime.Now.ToLongTimeString()}{Environment.NewLine}";
            _fs.Write(Encoding.ASCII.GetBytes(s), 0, s.Length);
        }
    }
}
