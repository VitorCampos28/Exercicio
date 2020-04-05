using Exercicio_de_Fixacao.Entities;
using Exercicio_de_Fixacao.Entities.Enums;
using System;

namespace Exercicio_de_Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data :");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (MM/DD/YYYY): ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client1 = new Client(name,email,birthday);
            Order order = new Order(DateTime.Now, status ,client1);
            Console.WriteLine("How many items to this order? ");
            int norder = int.Parse(Console.ReadLine());

            for (int i = 1; i <= norder; i++)
            {
                Console.WriteLine("Enter #{0} item data: ",i);
                Console.Write("Product name: ");
                string pname = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());

                Product product = new Product(pname, price);
                
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Order_Item orderI = new Order_Item(quantity, price, product );

                order.addItem(orderI);
            }

            Console.WriteLine("Order Summary: ");
            Console.WriteLine(order);

        }
    }
}
