using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Address address3 = new Address("199 EastSide", "Rexburg", "ID", "USA");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);
        Customer customer3 = new Customer("Holden Turman", address3);

        // Create products
        Product product1 = new Product("Widget", "W123", 3.99, 4);
        Product product2 = new Product("Gadget", "G456", 15.49, 2);
        Product product3 = new Product("Thingamajig", "T789", 8.99, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Order order3 = new Order(customer3);
        order3.AddProduct(product1);
        order3.AddProduct(product3);

        // Display results
        Console.WriteLine();
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.GetTotalCost().ToString("0.00") + "\n");

        Console.WriteLine("--------------------------------------");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.GetTotalCost().ToString("0.00") + "\n");

        Console.WriteLine("--------------------------------------");

        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order3.GetTotalCost().ToString("0.00"));

        Console.WriteLine("--------------------------------------");
    }
}
