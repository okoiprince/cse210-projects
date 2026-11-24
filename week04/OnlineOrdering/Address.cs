using System;
public class Address
{
    // Private member variables
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Constructor Declaration
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Check if the address is in USA
    public bool LiveInUSA()
    {
        return _country.ToUpper() == "USA";
    }

    // Get the complete address
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}
