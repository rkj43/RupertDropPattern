using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemPoC
{
    public interface ILoggingService
    {
        void Log(string message);
    }

    public class LoggingService : ILoggingService
    {
        public void Log(string message)
        {
            // Simulate a potential failure in the logging service
            if (new Random().Next(0, 5) == 0)
            {
                throw new Exception("Logging service failed!");
            }
            Console.WriteLine($"Log: {message}");
        }
    }

    public class BankingSystem
    {
        private readonly ILoggingService _loggingService;

        public BankingSystem(ILoggingService loggingService)
        {
            _loggingService = loggingService;
        }

        public void Deposit(decimal amount)
        {
            // Core banking operation
            Console.WriteLine($"Deposited: {amount}");

            // Logging operation (sensitive component)
            try
            {
                _loggingService.Log($"Deposited: {amount}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Logging failed, but banking operation succeeded. Error: {ex.Message}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            var loggingService = new LoggingService();
            var bankingSystem = new BankingSystem(loggingService);

            bankingSystem.Deposit(100);
        }
    }
}

