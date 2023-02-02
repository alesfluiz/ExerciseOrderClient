using System;
using ExerciseOrderClient.Entities;
using ExerciseOrderClient.Entities.Enums;
using System.Globalization;

namespace OrderCient
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string nameClient = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();                       
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());


            Client client = new Client(nameClient, email, birthDate);


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string product = Console.ReadLine();
                Console.Write("Product price: ");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                int quantity = int.Parse(Console.ReadLine());
                Order order = new Order(DateTime.Now, priceProduct, quantity);
                    Order.AddItem(order);

            }

        }
    }
}