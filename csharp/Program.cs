using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] nums = {{1, 2, 3}, {4, 5, 6}};

            foreach (int num in nums)
            {
                Console.WriteLine(num.ToString());
            }
        }
    }
}

