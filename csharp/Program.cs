using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write down a list of shopping items you want to buy seperated with comma \",\": ");
            string input = Console.ReadLine();
            
            string[] items = input.Split(',');
            
            
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}

