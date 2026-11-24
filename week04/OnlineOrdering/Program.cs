using System;

class Program
{
    static void Main(string[] args)
    {
        // First customer address
        Address address1 = new Address(
            "1600 Montclair Rd",
            "Birmingham",
            "Birmingham",
            "USA"
        );

        // First customer details
        Customer customer1 = new Customer("Prince Okoi", address1);

        // Order one
        Order order1 = new Order(customer1);

        // First products
        Product product1 = new Product("Laptop", "P001", 500, 2);
        Product product2 = new Product("Modem", "P002", 20, 3);
        Product product3 = new Product("Table lamp", "P003", 40, 1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);


        // Second customer address
        Address address2 = new Address(
            "15 Marian Market",
            "Calabar",
            "Cross River State",
            "Nigeria"
        );

        // Second customer details
        Customer customer2 = new Customer("Susan Pius", address2);

        // Order two
        Order order2 = new Order(customer2);

        // Products for second order
        Product product4 = new Product("Iphone 14 Pro", "P004", 300, 2);
        Product product5 = new Product("Type C charger", "P005", 50, 2);
        Product product6 = new Product("Flash drive", "P006", 15, 3);

        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);


        // Display customer first order
        Console.WriteLine("ORDER ONE: ");

        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");


        // Display customer second order
        Console.WriteLine("\nORDER TWO: ");

        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}