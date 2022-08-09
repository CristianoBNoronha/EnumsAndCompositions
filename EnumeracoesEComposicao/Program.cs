using System;
using EnumeracoesEComposicao.Entities.Enums;
using EnumeracoesEComposicao.Entities;


namespace EnumeracoesEComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus Status = Enum.Parse<OrderStatus>(Console.ReadLine());

        }
    }
}
