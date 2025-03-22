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
            int[] result = Plus3(new int[] {1, 2, 3});
            Console.WriteLine(string.Join(", ", result));
        }
        static void PrintName(string name = "Sajad")
        {
            Console.WriteLine($"Hello, {name}!");
        }

        static int[] Plus3(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] + 3;
            }

            return nums;
        }
    }
}

