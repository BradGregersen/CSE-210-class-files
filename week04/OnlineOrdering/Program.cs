using System;

public class Program
{
    public static void Main()
    {

        Address address1 = new Address("64 Shoehorn Street", "Santa Barbara", "CA", "USA");
        Address address2 = new Address("18 Railroad Avenue", "Flagstaff", "AZ", "Arizona");


        Customer customer1 = new Customer("Josh Spiegel", address1);
        Customer customer2 = new Customer("Dorothy Jergensen", address2);


        Product product1 = new Product("Digital camera Accessory", "C678", 25.00m, 2);
        Product product2 = new Product("Umbrella holder", "U856", 20.00m, 1);
        Product product3 = new Product("Extra large pillow ", "P037", 15m, 3);


        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine(order1.RetrievePackingLabel());
        Console.WriteLine(order1.RetrieveShippingLabel());
        Console.WriteLine($"Grand total: ${order1.DetermineTotalCost()}\n");

        Console.WriteLine(order2.RetrievePackingLabel());
        Console.WriteLine(order2.RetrieveShippingLabel());
        Console.WriteLine($"Grand total: ${order2.DetermineTotalCost()}");
    }
}
