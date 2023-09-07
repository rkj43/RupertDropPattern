public class EcommerceCheckout // Robust Component (Bulbous End)
{
    private Cart _cart;
    private PaymentProcessor _paymentProcessor;

    public EcommerceCheckout(Cart cart)
    {
        _cart = cart;
        _paymentProcessor = new PaymentProcessor();
    }

    public bool Checkout(User user)
    {
        // Check the integrity of the cart (sensitive component)
        if (!_cart.IsCartIntegrityMaintained())
        {
            Console.WriteLine("Failed to checkout. Cart is empty or corrupted.");
            return false;
        }

        decimal totalAmount = _cart.CalculateTotal();

        // Process payment (robust component)
        bool paymentSuccess = _paymentProcessor.ProcessPayment(user, totalAmount);
        if (paymentSuccess)
        {
            Console.WriteLine("Checkout successful!");
            return true;
        }
        else
        {
            Console.WriteLine("Payment failed. Please try again.");
            return false;
        }
    }
}