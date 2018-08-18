using System;
using System.IO;
using System.Text;

namespace Wincubate.DisposeExamples
{
    class FileWriter : IDisposable
    {
        private readonly FileStream _fs;
        private bool _isDisposed = false;

        public FileWriter() =>
            _fs = File.Create(@"FileWriter.txt");

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_isDisposed == false)
            {
                if (disposing)
                {
                    _fs?.Dispose();
                }
            }
        }

        public void Log()
        {
            if (_isDisposed)
            {
                throw new ObjectDisposedException(nameof(FileWriter));
            }

            string s = $"{DateTime.Now.ToLongTimeString()}{Environment.NewLine}";
            _fs.Write(Encoding.ASCII.GetBytes(s), 0, s.Length);
        }
    }
}
