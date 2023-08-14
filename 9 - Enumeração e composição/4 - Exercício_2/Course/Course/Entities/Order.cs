using Course.Entities.Enums;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    internal class Order
    {
        CultureInfo ci = CultureInfo.InvariantCulture;
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime date, OrderStatus status, Client client)
        {
            Moment = date;
            this.Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total() 
        {
            double sum = 0.0;
            foreach(OrderItem item in Items) 
            {
                sum = sum + item.SubTotal();
            }
            return sum;
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/mm/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(Items.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
