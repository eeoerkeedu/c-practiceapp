using System;
using System.Runtime.Remoting.Lifetime;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;


// namespace
namespace NumberPicker
{   
    // main class
    internal class Program
    {
        // entry point method (void means there is not any return type required)
        static void Main(string[] args)
        {
            //start

            string appName = "NumberGuesser";
            string appVersion = "1.0.0";
            string appAuthor = "EEO";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor); //ctrl+f5 to launch

            // Reset Text Color
            Console.ResetColor();

            //ask user's name
            Console.WriteLine("What is your usename?");

            // Get input
            String name = Console.ReadLine();

            // read back name
            Console.WriteLine("Hello "+ name + ", lets play!");

            // sets the number to guess
            Random rand = new Random();
            int correctNum = rand.Next(1,10);

            // users guess
            int guess = 0;

            Console.WriteLine("Guess a # between 1 and 10");

            // while guess is incorrect continue game
            while (guess != correctNum)
            {
                //get input
                string input = Console.ReadLine();
                if (!int.TryParse(input, out guess))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a number between 1 - 10");
                    Console.ResetColor();
                }

                // parse and change guess value
                guess = Int32.Parse(input);

                //match guess to correct num
                if (guess != correctNum)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong number, please try again");
                    Console.ResetColor();

                }
            }
            //output success message
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Correct Well Done!");
            Console.ResetColor();


        }
    }
}
