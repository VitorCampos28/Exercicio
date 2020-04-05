using Exercicio_de_Fixacao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_de_Fixacao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public List<Order_Item> Items = new List<Order_Item>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void addItem(Order_Item item)
        {
            Items.Add(item);
        }

        public void removeItem(Order_Item item)
        {
            Items.Remove(item);
        }

    }
}
