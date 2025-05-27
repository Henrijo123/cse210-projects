public class Order
{
    private List<Product> _products = [];
    private Customer _customer;

    public Order(List<Product> product, Customer customer)
    {
        _products = product;
        _customer = customer;
    }

    public double CalculateTotalCost()
    {
        double total = 0;
        foreach (Product item in _products)
        {
            total += item.TotalPrice();
        }
        ;
        if (_customer.LivesInUsa())
        {
            return total += 5;
        }
        return total += 35;
    }

    public string PackingLabel()
    {
        string pacakingLabel = "";
        foreach (Product item in _products)
        {
            pacakingLabel += $"Product: {item.GetName()} | ID: {item.GetProductId()}\n";
        }
        return pacakingLabel;
    }
    public string ShippingLabel()
    {
        return $"{_customer.GetName()} - {_customer.GetAddress()}";
    }
}