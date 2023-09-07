public class PaymentProcessor
{
    public bool ProcessPayment(User user, decimal amount)
    {
        Console.WriteLine("Processing payment...");
        // Logic to securely process the payment
        // For simplicity, we'll assume the payment is always successful
        return true;
    }
}