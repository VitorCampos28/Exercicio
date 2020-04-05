using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_de_Fixacao.Entities
{
    class Order_Item
    {
        public int Quantity { get; set; }
        public Product Price { get; set; }

        public Order_Item()
        {

        }

        public Order_Item(int quantity, Product price)
        {
            Quantity = quantity;
            Price = price;
        }

        public double subTotal()
        {
            return Quantity * Price.price;
        }
    }
}
