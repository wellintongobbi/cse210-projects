using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 (USA)
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P001", 800, 1));
        order1.AddProduct(new Product("Mouse", "P002", 20, 2));

        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}");
        Console.WriteLine("\n---------------------\n");

        // Order 2 (International)
        Address address2 = new Address("Rua das Flores", "Curitiba", "PR", "Brazil");
        Customer customer2 = new Customer("Gobbi", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Keyboard", "P003", 100, 1));
        order2.AddProduct(new Product("Monitor", "P004", 300, 1));

        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}