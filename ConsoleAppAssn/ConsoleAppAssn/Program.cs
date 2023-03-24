using System;

namespace ConsoleAppAssn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gimme a number"); //Asks for input
            string userInput = Console.ReadLine(); //Gets input data
            int userInputInt = Convert.ToInt32(userInput); //Converts it to integer
            int mathIt = userInputInt * 50; //Math's it
            Console.WriteLine(mathIt); //Writes it

            Console.WriteLine("Gimme another one");
            userInput = Console.ReadLine();
            userInputInt = Convert.ToInt32(userInput);
            mathIt = userInputInt + 25;
            Console.WriteLine(mathIt);

            Console.WriteLine("Gimme another one");
            userInput = Console.ReadLine();
            double userInputDouble = Convert.ToDouble(userInput); //Floating point this time
            double mathItDouble = userInputDouble / 12.5;
            Console.WriteLine(mathItDouble);

            Console.WriteLine("Gimme another one");
            userInput = Console.ReadLine();
            userInputInt = Convert.ToInt32(userInput);
            bool userInputBool = userInputInt > 50; //Bool it
            Console.WriteLine(userInputBool);

            Console.WriteLine("Gimme another one");
            userInput = Console.ReadLine();
            userInputDouble = Convert.ToDouble(userInput);
            mathItDouble = userInputDouble % 7; //Modulize it
            Console.WriteLine(mathItDouble);
            Console.WriteLine("All done");
            Console.ReadLine(); 
        }
    }
}
