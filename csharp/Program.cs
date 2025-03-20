using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [1, 5, 4, 2, 9];

            Array.Sort(nums);
            Console.WriteLine(string.Join(", ", nums));
        }
    }
}

