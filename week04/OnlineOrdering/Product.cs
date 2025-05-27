using System.Runtime.CompilerServices;

public class Product
{
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }
    public double TotalPrice()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public int GetProductId()
    {
        return _productId;
    }
    public void SetProductId(int id)
    {
        _productId = id;
    }
    public double GetPrice()
    {
        return _price;
    }
    public void SetPrice(double id)
    {
        _price = id;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
}