using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_de_Fixacao.Entities
{
    class Order_Item
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public Order_Item()
        {

        }

        public Order_Item(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double subTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return Product.Name + ", " + Price + ", " + "Quantity: " + Quantity + ", Subtotal: $" + subTotal(); 
        }
    }
}
