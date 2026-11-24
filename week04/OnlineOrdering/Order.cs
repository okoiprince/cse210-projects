using System;

public class Order
{
    // Private member variables
    private List<Product> _products;
    private Customer _customer;

    // Constructor Declaration
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Add the products to order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Calculate total order for the cost
    public double GetTotalCost()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        // Schedule the shipping cost
        double shippingCost;

        if (_customer.LiveInUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        return total + shippingCost;
    }

    // Generate the packing label
    public string GetPackingLabel()
    {
        string label = "PRODUCT PACKING LABEL\n";

        foreach (Product product in _products)
        {
            label += $"Product: {product.GetName()} | ID: {product.GetProductId()}\n";
        }

        return label;
    }

    // Generate the shipping label
    public string GetShippingLabel()
    {
        string label = "CUSTOMER SHIPPING LABEL\n";

        label += $"Customer: {_customer.GetName()}\n";
        label += _customer.GetAddress().GetFullAddress();

        return label;
    }
}