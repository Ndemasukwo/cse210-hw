using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Military Way St", "Akwa Ibom", "AK", "Nigeria");
        Address address2 = new Address("C6 Rd", "Calabar", "CAL", "Nigeria");

        Customer customer1 = new Customer("Monkey D. Luffy", address1);
        Customer customer2 = new Customer("Jecintha Odok", address2);

        Product product1 = new Product("One Piece", "A123", 999.99m, 1);
        Product product2 = new Product("Zanpkuto", "B456", 25.99m, 2);
        Product product3 = new Product("Ship", "C789", 49.99m, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Cost: ${order.GetTotalCost():F2}");
        Console.WriteLine();
    }
}
