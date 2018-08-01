using System;
using OrderApp.Core;

namespace OrderApp.Infra.Logger.ConsoleLogger
{
    public class ConsoleLogger : ILogger 
    {
        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}