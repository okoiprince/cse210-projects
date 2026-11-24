using System;
public class Customer
{
    // Private member variables
    private string _name;
    private Address _address;

    // Constructor Declaration
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Get the customer name
    public string GetName()
    {
        return _name;
    }

    // Get the customer home address
    public Address GetAddress()
    {
        return _address;
    }

    // Check if customer lives in the USA
    public bool LiveInUSA()
    {
        return _address.LiveInUSA();
    }
}