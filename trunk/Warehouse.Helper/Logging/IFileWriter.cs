namespace Warehouse.Helper.Logging
{
    public interface IFileWriter
    {
        void Write(string path, string fileName, string toWrite);
    }
}