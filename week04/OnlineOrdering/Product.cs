using System;
public class Product
{
    // Private member variables
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // Constructor Declaration
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Getters Methods
    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public double GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    // Calculate the total cost
    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}
