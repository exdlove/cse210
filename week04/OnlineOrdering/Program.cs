using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Customer 1 (USA)
        Address address1 = new Address(
            "123 Main Street",
            "Dallas",
            "Texas",
            "USA");

        Customer customer1 = new Customer(
            "John Smith",
            address1);

        List<Product> products1 = new List<Product>();

        products1.Add(
            new Product("Laptop", "P100", 800, 1));

        products1.Add(
            new Product("Mouse", "P101", 25, 2));

        Order order1 = new Order(
            customer1,
            products1);

        // Customer 2 (Outside USA)
        Address address2 = new Address(
            "15 Victoria Road",
            "Lagos",
            "Lagos State",
            "Nigeria");

        Customer customer2 = new Customer(
            "Excellence Bassi",
            address2);

        List<Product> products2 = new List<Product>();

        products2.Add(
            new Product("Phone", "P200", 500, 1));

        products2.Add(
            new Product("Headphones", "P201", 50, 2));

        products2.Add(
            new Product("Charger", "P202", 20, 3));

        Order order2 = new Order(
            customer2,
            products2);

        // Display Order 1
        Console.WriteLine("===== ORDER 1 =====");

        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine(
            $"\nTotal Cost: ${order1.CalculateTotalCost()}");

        // Display Order 2
        Console.WriteLine("\n==============================");

        Console.WriteLine("\n===== ORDER 2 =====");

        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine(
            $"\nTotal Cost: ${order2.CalculateTotalCost()}");
    }
}