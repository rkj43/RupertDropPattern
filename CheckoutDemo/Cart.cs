public class Cart // Sensitive Component (Tail)
{
    private List<Item> _items;

    public Cart()
    {
        _items = new List<Item>();
    }

    public void AddItem(Item item)
    {
        _items.Add(item);
    }

    public decimal CalculateTotal()
    {
        return _items.Sum(item => item.Price);
    }

    // This method checks the integrity of the cart
    public bool IsCartIntegrityMaintained()
    {
        // Check if cart is empty
        if (!_items.Any())
        {
            return false;
        }

        // Check for any corrupted items (e.g., negative prices)
        if (_items.Any(item => item.Price <= 0))
        {
            return false;
        }

        return true;
    }
}