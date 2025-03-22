using System;

namespace csharp
{
    class Program{
    
        static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! What is your name?");
            string name = Console.ReadLine();
            PrintName(name);
        }
    }
}

