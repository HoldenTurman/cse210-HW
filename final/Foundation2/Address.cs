public class Address
{
    //Attributes
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    // Constructor
    public Address(string street, string town, string state, string nation)
    {
        _streetAddress = street;
        _city = town;
        _stateOrProvince = state;
        _country = nation;
    }

    // Method to check if the address is in the USA
    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }

    // Method to return the full address as a string
    public string GetFullAddress()
    {
        return _streetAddress + "\n" + _city + ", " + _stateOrProvince + "\n" + _country;
    }
}
