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
        }
    }
}
