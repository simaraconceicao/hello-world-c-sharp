using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nQual seu nome?");
            var nome = Console.ReadLine();
            Console.WriteLine($"\nHello {nome}!");
        }
    }
}
