using System;
using System.Collections.Generic;
using System.Linq;

namespace CheckoutDemo
{


    class Program
    {
        static void Main(string[] args)
        {
            // Create a new user
            User user = new User { Name = "Rahul", PaymentDetails = "Credit Card" };

            // Create a new cart and add items
            Cart cart = new Cart();
            cart.AddItem(new Item { Name = "Laptop", Price = 1000m });
            cart.AddItem(new Item { Name = "Mouse", Price = 50m });

            // Initialize the checkout process
            EcommerceCheckout checkout = new EcommerceCheckout(cart);

            // Execute the checkout
            bool success = checkout.Checkout(user);

            if (success)
            {
                Console.WriteLine("Thank you for your purchase!");
            }
            else
            {
                Console.WriteLine("There was an issue with your checkout. Please try again.");
            }

            // To demonstrate a failure, let's create an empty cart and try to checkout
            Cart emptyCart = new Cart();
            EcommerceCheckout failedCheckout = new EcommerceCheckout(emptyCart);
            bool failedSuccess = failedCheckout.Checkout(user);

            if (failedSuccess)
            {
                Console.WriteLine("Thank you for your purchase!");
            }
            else
            {
                Console.WriteLine("There was an issue with your checkout. Please try again.");
            }
        }
    }
}