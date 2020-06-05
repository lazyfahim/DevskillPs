using System;

namespace SingleTonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var _logger = ErrorLogger.CreateLogger();
            _logger.Log();
        }
    }
    class ErrorLogger
    {
        private static ErrorLogger _errorlogger;
        private ErrorLogger()
        {

        }
        public static ErrorLogger CreateLogger()
        {
            if(_errorlogger == null)
                return new ErrorLogger();
            else
                return _errorlogger;
        }
        public void Log()
        {
            Console.WriteLine("Logging");
        }
    }
}
