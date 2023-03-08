using System;

namespace ProductOrderingSystem
{
 class Program
    {
        static void Main(string[] args)
        {
            // Create some sample data for testing
            Product product1 = new Product("Product 1", "123", 10.0, 2);
            Product product2 = new Product("Product 2", "456", 5.0, 3);
            List<Product> products1 = new List<Product> { product1, product2 };
            Customer customer1 = new Customer("John Doe", new Address("123 Main St", "Anytown", "CA", "USA"));
            Order order1 = new Order(products1, customer1);

            Product product3 = new Product("Product 3", "789", 20.0, 1);
            List<Product> products2 = new List<Product> { product2, product3 };
            Customer customer2 = new Customer("Jane Smith", new Address("456 High St", "Somewhere", "Ontario", "Canada"));
            Order order2 = new Order(products2, customer2);

            // Display the packing labels, shipping labels, and total prices for the orders
            Console.WriteLine("Order 1:");
            Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
            Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());
            Console.WriteLine("Total Price: $" + order1.GetTotalPrice());

            Console.WriteLine();

            Console.WriteLine("Order 2:");
            Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
            Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
            Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
        }
    }

   
}