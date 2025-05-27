public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.CompleteAddress();
    }
    public bool LivesInUsa()
    {
        return _address.InTheUSA();
    }
}