# Ecommerce Checkout Library with Rupert's Drop Pattern
This library provides a simple implementation of an ecommerce checkout process, demonstrating the application of the Rupert's Drop Pattern.

## Introduction
The Rupert's Drop Pattern is inspired by the unique physical properties of a Prince Rupert's Drop. The pattern emphasizes the importance of protecting a system's most vulnerable point while ensuring the robustness of its other components.

In the context of this library:

## Implementation
### Cart (Sensitive Component - Tail)
The Cart class represents the sensitive component of the system. It holds the items for checkout and provides methods to add items and calculate the total. The integrity of the cart is crucial for the checkout process.
Robust Component (Bulbous End): Represents the main functionality of the system that remains robust and unaffected by minor issues.
Sensitive Component (Tail): Represents the vulnerable point of the system, which, if compromised, can cause the entire system to fail.

```csharp
public bool IsCartIntegrityMaintained()
{
    // Check if cart is empty or has corrupted items
}
```
### EcommerceCheckout (Robust Component - Bulbous End)
The EcommerceCheckout class represents the robust component. It uses the Cart to calculate the total amount and processes the payment. If the cart's integrity is compromised, the checkout process fails.

```csharp
public bool Checkout(User user)
{
    // Check the integrity of the cart
    // Process payment
}
```
## Usage
-Create a new Cart and add items.
-Create an EcommerceCheckout instance with the cart.
-Call the Checkout method to process the payment.
```csharp
Cart cart = new Cart();
cart.AddItem(new Item("Book", 10.99m));

EcommerceCheckout checkout = new EcommerceCheckout(cart);
bool success = checkout.Checkout(user);
```
## Conclusion
This library demonstrates the application of the Rupert's Drop Pattern in a simple ecommerce context. By ensuring the integrity of the cart (sensitive component), the checkout process (robust component) can proceed smoothly.
