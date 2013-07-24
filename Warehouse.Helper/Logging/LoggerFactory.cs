namespace Warehouse.Helper.Logging
{
    public static class LoggerFactory
    {
        public static ExceptionLogger GetExceptionLogger(string loggerType)
        {
            var logger = new ExceptionLogger(new TextFileWriter());

            return logger;
        }
    }
}
