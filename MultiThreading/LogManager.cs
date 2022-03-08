using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class LogManager
    {
        private static LogManager logManager;

        public static LogManager Default => logManager ??=new LogManager();

        public event EventHandler<string> OnLogAdded;

        public void Log(string logMessage)
        {
            OnLogAdded?.Invoke(this, logMessage);
        }

    }
}
