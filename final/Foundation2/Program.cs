using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // Order 1
        Address address1 = new Address("Saturio Rios 15", "San Lorenzo", "Central", "Paraguay"); 
        Customer newCustomer1 = new Customer("Adrian Lopez", address1);
        Product product1 = new Product("Mattress", 594, 201.99, 1);
        Product product2 = new Product("Bed Sheets", 821, 21.50, 6);
        Order newOrder1 = new Order(newCustomer1);
        newOrder1.AddProduct(product1);
        newOrder1.AddProduct(product2);

        Console.WriteLine("Order #1\n");
        Console.WriteLine(newOrder1.PackingLabel());
        Console.WriteLine(newOrder1.ShippingLabel());
        Console.WriteLine($"\nTotal Price (with Shipping): ${newOrder1.calculateTotalPrice()}\n");

        // Order 2
        Address address2 = new Address("36 Sunrise Rd", "Livington", "PA", "USA"); 
        Customer newCustomer2 = new Customer("Mary Doe", address2);
        Product product3 = new Product("Pillows", 876, 10.25, 3);
        Product product4 = new Product("Table Lamp", 1121, 95.60, 2);
        Product product5 = new Product("Fan", 211, 120, 1);
        Order newOrder2 = new Order(newCustomer2);
        newOrder2.AddProduct(product3);
        newOrder2.AddProduct(product4);
        newOrder2.AddProduct(product5);

        Console.WriteLine("Order #2\n");
        Console.WriteLine(newOrder2.PackingLabel());
        Console.WriteLine(newOrder2.ShippingLabel());
        Console.WriteLine($"\nTotal Price (with Shipping): ${newOrder2.calculateTotalPrice()}\n");
        
    }
}