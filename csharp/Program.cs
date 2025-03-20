using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}

