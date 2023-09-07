In this PoC, the BankingSystem class represents the system that uses the Rupert's Drop Pattern. The Deposit method is a core banking operation (robust component). The logging operation, which is done by the LoggingService, is the sensitive component. If the logging service fails (simulated randomly), the banking operation continues without any issues, demonstrating the resilience of the system.

To see the pattern in action, run the program multiple times. Occasionally, you'll see the logging service fail, but the deposit operation will always succeed.
