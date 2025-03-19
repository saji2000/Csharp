using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many starts to you want to write: ");
            int num = Convert.ToInt16(Console.ReadLine());
            int i = 0;
            while (i < num)
            {
                Console.Write("*");
                i++;
            }
        }
    }
}

