﻿using System;

using SingleResponsibilityPrinciple.Contracts;
using System.IO;

namespace SingleResponsibilityPrinciple
{
    public class ConsoleLogger : ILogger
    {
        public void LogWarning(string message, params object[] args)
        {
            Console.WriteLine(string.Concat("WARN: ", message), args);
            using (StreamWriter logfile = File.AppendText("log.xml"))
            {
                logfile.WriteLine("<log><message>" + message + "</message></log>", args);
            }
        }

        private void LogMessage(string type, string message, params object[] args)
        {
            Console.WriteLine(message, args);

        }

        public void LogInfo(string message, params object[] args)
        {
            Console.WriteLine(string.Concat("INFO: ", message), args);
        }
    }
}
