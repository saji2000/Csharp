using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Guess a number between 1 and 1000: ");
            int num = Convert.ToInt16(Console.ReadLine());
            
            Random random = new Random();
            int randomNum = random.Next(1, 1000);

            if (randomNum == num)
            {
                Console.WriteLine("You guessed the number!");
            }
            else
            {
                Console.WriteLine("You guessed the wrong number try again!");
            }
        }
    }
}

