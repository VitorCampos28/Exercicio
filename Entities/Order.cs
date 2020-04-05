using Exercicio_de_Fixacao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio_de_Fixacao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }

        public List<Order_Item> Items = new List<Order_Item>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void addItem(Order_Item item)
        {
            Items.Add(item);
        }

        public void removeItem(Order_Item item)
        {
            Items.Remove(item);
        }

        public double total()
        {
            double sum = 0;
            foreach(Order_Item item in Items)
            {
                sum += item.subTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach(Order_Item obj in Items)
            {
                sb.AppendLine(obj.ToString());
            }
            sb.AppendLine("Total price: $" + total().ToString("F2",CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
