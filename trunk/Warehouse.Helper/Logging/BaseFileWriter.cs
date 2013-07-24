namespace Warehouse.Helper.Logging
{
    using System;
    using System.IO;

    public abstract class BaseFileWriter : IFileWriter
    {
        protected abstract string FileExtension { get; }

        public void Write(string path, string fileName, string toWrite)
        {
            if (string.IsNullOrEmpty(FileExtension))
            {
                throw new NullReferenceException("File Extension cannot be null");
            }

            File.WriteAllText(Path.Combine(path, string.Format("{0}.{1}", fileName, FileExtension)), toWrite);
        }
    }
}
