using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_de_Fixacao.Entities
{
    class Product
    {
        public string name { get; set; }
        public double price { get; set; }

        public Product()
        {

        }

        public Product(string name, double price)
        {
            name = name;
            price = price;
        }
    }
}
