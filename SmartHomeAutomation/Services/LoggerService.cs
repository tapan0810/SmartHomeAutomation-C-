using SmartHomeAutomation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeAutomation.Services
{
    public class LoggerService : ILogger
    {
        private readonly string _logFile;

        public LoggerService()
        {
            _logFile = "SmartHomeLogs.txt";
        }


        public void Log(string message)
        {
            string logMessage =
                $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} : {message}";

            File.AppendAllText(
                _logFile,
                logMessage + Environment.NewLine);

            Console.WriteLine($"[LOGGED] {message}");
        }

    }
}
