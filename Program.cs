using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("Welcome to the high-low game");

            while (true)
            {

                // Generates a random number
                Random rng = new Random();
                int number = rng.Next(1, 11);
                int tries = 0;

                while (true)
                {

                    // User enters guess
                    Console.Write("Enter guess: ");
                    int guess = Convert.ToInt32(Console.ReadLine());

                    // Compare guess to number
                    if (guess < number)
                    {
                        Console.WriteLine("Your guess is lower than the number, try again.");
                        tries = tries + 1;

                    }
                    else if (guess > number)
                    {
                        Console.WriteLine("Your guess is higher than the nuber, try again.");
                        tries = tries + 1;
                    }
                    else
                    {
                        Console.WriteLine("Correct, you guessed the number.");
                        Console.WriteLine("\nIt took you " + tries + " attempts to guess the number");
                        break;
                    }
                }

                Console.WriteLine("\nDo you wish to play again(Y/N)?");
                string again = Console.ReadLine();
                again = again.ToLower();

                if (again == "y")
                {
                    Console.WriteLine("Welcome to the high-low game");
                }
                else
                {
                    break;
                }
            }

            // Waits for key press
            Console.ReadKey();
        }
    }
}
