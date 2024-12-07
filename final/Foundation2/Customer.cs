public class Customer
{
    //Attributes
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    // Calls IsInUSA on the Address object
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
}


