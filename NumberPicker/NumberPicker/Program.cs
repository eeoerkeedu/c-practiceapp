using System;
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
        }
    }
}
