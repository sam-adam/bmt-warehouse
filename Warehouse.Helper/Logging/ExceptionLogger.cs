namespace Warehouse.Helper.Logging
{
    using System;
    using System.IO;
    using System.Text;

    public class ExceptionLogger : ILogger
    {
        private readonly IFileWriter _fileWriter;
        private readonly string _logDirectory;
        private readonly string _logFileName;
        private readonly StringBuilder _sb;

        private Exception _exception;

        private const string LogFolder = "Log";
        
        public ExceptionLogger(IFileWriter fileWriter)
        {
            _fileWriter = fileWriter;

            _logFileName = string.Format("Warehouse{0}", DateTime.Now.ToString("ddMMyyHHmmssf"));
            _logDirectory = string.Format("{0}/{1}", AppDomain.CurrentDomain.BaseDirectory, LogFolder);

            if (!Directory.Exists(_logDirectory))
            {
                Directory.CreateDirectory(_logDirectory);
            }

            _sb = new StringBuilder();
        }

        public void Log(Exception exception)
        {
            _exception = exception;

            Log();
        }

        public void Log()
        {
            CreateExceptionString(_sb, _exception, string.Empty);

            _fileWriter.Write(_logDirectory, _logFileName, _sb.ToString());
        }

        private void CreateExceptionString(StringBuilder sb, Exception ex, string indent)
        {
            if (indent == null)
            {
                indent = string.Empty;
            }
            else if (indent.Length > 0)
            {
                sb.AppendFormat("{0}Inner ", indent);
            }

            sb.AppendFormat("Exception Found:\n{0}Type: {1}", indent, ex.GetType().FullName);
            sb.AppendFormat("\n{0}Message: {1}", indent, ex.Message);
            sb.AppendFormat("\n{0}Source: {1}", indent, ex.Source);
            sb.AppendFormat("\n{0}Stacktrace: {1}", indent, ex.StackTrace);

            if (ex.InnerException != null)
            {
                sb.Append(Environment.NewLine);
                CreateExceptionString(sb, ex.InnerException, indent + "  ");
            }
        }
    }
}
