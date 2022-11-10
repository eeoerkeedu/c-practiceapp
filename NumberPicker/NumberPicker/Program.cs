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
            // ctrl+f5 to launch
            // start, dispalys app info
            GetAppInfo();

            // greets user and sets username
            GreetUser();

            while (true)
            {

                // sets the number to guess
                Random rand = new Random();
                int correctNum = rand.Next(1, 10);

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
                       PrintColorMsg(ConsoleColor.Red, "Please enter a number between 1 - 10");
                    }

                    // parse and change guess value
                    guess = Int32.Parse(input);

                    // match guess to correct num
                    if (guess != correctNum)
                    {
                        // print incorrect guess response
                        PrintColorMsg(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }
                // output success message
                PrintColorMsg(ConsoleColor.Green, "Correct Well Done!");

                // Ask to play again
                PrintColorMsg(ConsoleColor.Blue, "Play again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                } else
                {
                    return;
                }
            }

        }

        static void GetAppInfo()
        {
            string appName = "NumberGuesser";
            string appVersion = "1.0.0";
            string appAuthor = "EEO";
            string appInfo = (appName + ": Version " + appVersion + " by "+appAuthor);

            // prints message on init
            PrintColorMsg(ConsoleColor.Yellow, appInfo);
        }

        static void GreetUser()
        {
            // ask user's name
            Console.WriteLine("What is your usename?");

            // Get input
            String name = Console.ReadLine();

            // read back name
            Console.WriteLine("Hello " + name + ", lets play!");
        }

        // change color of messages function
        static void PrintColorMsg(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // display message
            Console.WriteLine(message);

            // reset the console color
            Console.ResetColor();
        }
    }
}
