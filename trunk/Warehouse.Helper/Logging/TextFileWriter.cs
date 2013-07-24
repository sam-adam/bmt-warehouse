namespace Warehouse.Helper.Logging
{
    public class TextFileWriter : BaseFileWriter
    {
        protected override string FileExtension
        {
            get { return ".txt"; }
        }
    }
}
