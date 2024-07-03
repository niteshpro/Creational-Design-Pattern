using System;

namespace LoggerSingleton
{
    public sealed class Log : ILog
    {
        private static readonly Lazy<Log> instance = new Lazy<Log>(() => new Log());
        private Log() 
        {
            TimeSpan currentTime = DateTime.Now.TimeOfDay;
            Console.WriteLine(currentTime);
        }

        public static Log GetInstance
        {
            get
            {
                return instance.Value;
            }
        }

        public void LogException(string message)
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Error Log: " + message);
            Console.WriteLine("------------------------------------------------------------------------------");
        }
    }
}
