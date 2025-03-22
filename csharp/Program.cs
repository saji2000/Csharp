using System;

namespace csharp
{
    class Program{
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! What is your name?");
            string name = Console.ReadLine();
            PrintName(name);
            PrintName();
        }
        static void PrintName(string name = "Sajad")
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}

