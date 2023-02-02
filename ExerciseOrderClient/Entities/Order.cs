using ExerciseOrderClient.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExerciseOrderClient.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
                public List<OrderItem> Products { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
            
        }

        public void AddItem(OrderItem item)
        {
            Products.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Products.Remove(item);
        }

        
        public double Total(double sum)
        {
            
            foreach(OrderItem products in Products)
            {
                sum += products.SubTotal();
            }
            return sum;
        }

    }
}
