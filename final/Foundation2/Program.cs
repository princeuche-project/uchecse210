class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Al Talay St", "Al Quoz", "Dubai", "UAE");
        Customer customer1 = new Customer("Uchenna Godstime Owuamanam", address1);

        Product product1 = new Product("Product 1", 1, 10.00, 2);
        Product product2 = new Product("Product 2", 2, 15.00, 1);

        Order order1 = new Order(new Product[] { product1 }, customer1);
        order1.AddProduct(product2);

        Console.WriteLine("Order 1 - Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Order 1 - Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine("Order 1 - Total Price: ${0:F2}", order1.GetTotalPrice());

        Address address2 = new Address("456 Elm St", "Salt Lake City", "Idaho", "USA");
        Customer customer2 = new Customer("Victor I Iwike", address2);

        Product product3 = new Product("Product 3", 3, 20.00, 1);

        Order order2 = new Order(new Product[] { product2, product3 }, customer2);

        Console.WriteLine("Order 2 - Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Order 2 - Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine("Order 2 - Total Price: ${0:F2}", order2.GetTotalPrice());

    }
}
