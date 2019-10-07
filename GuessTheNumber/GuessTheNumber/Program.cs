using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random x = new Random();
            int guess = 0;
            int num = 0;
            bool again = true;
            Console.WriteLine("Welcome to: Guess the number!");
            Console.WriteLine("In how few guesses can you find the number I'm thinking of?");
            Console.WriteLine("I'm thinking of a number between 1 and 100.");
            while (again)
            {
                int y = x.Next(1, 101);
                while (guess != y)
                {
                    guess = int.Parse(Console.ReadLine());
                    if (guess < y)
                    {
                        Console.WriteLine("Your guess is too low, go higher.");
                        num++;
                    }
                    else if (guess > y)
                    {
                        Console.WriteLine("Your guess is too high, go lower.");
                        num++;
                    }
                    else if (guess == y)
                    {
                        num++;
                        Console.WriteLine("Yes, you guessed my number, and it only took " + num + " guesses.");
                    }
                }
                Console.WriteLine("Want to play again? yes or no");
                string ask = Console.ReadLine();
                if (ask == "no")
                {
                    again = false;
                }
                else if (ask == "yes")
                {
                    guess = 0;
                    num = 0;
                }
            }
        }
    }
}
