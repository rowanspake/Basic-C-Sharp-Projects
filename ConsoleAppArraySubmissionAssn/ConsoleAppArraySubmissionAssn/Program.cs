using System;
using System.Collections.Generic;

namespace ConsoleAppArraySubmissionAssn
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "Gimli", "Jonesy", "Mystic" }; //Make string array of pets
            Console.WriteLine("Please select animal number 1, 2, or 3"); //Ask for an input
           
            bool tryAgain = true; //Bool for try/catch block
            while (tryAgain) //While bool is true
                try //Try this
                {
                    int userInput = Convert.ToInt32(Console.ReadLine()) - 1; //Get user input, convert to int, subtract 1 to get proper index
                    Console.WriteLine(stringArray[userInput]); //Write string at specified index in console
                    tryAgain = false; //Make bool false so it stops
                }
                catch //If it doesn't work 
                {
                    Console.WriteLine("Invalid selection, please try again"); //Let them know

                }

            int[] intArray = { 4, 1, 2 }; //Same idea but this one's an integer array
            Console.WriteLine("Please select again to view an animal's age");
            tryAgain = true;
            while (tryAgain)
                try
                {
                    int userInput = Convert.ToInt32(Console.ReadLine())  - 1;
                    Console.WriteLine(intArray[userInput]);
                    tryAgain = false;
                }
                catch
                {
                    Console.WriteLine("Invalid selection, please try again");
                }

            List<string> stringList = new List<string>(); //Make a string list
            stringList.AddRange(stringArray); //Cheating by populating our list with the strings in our string array
            Console.WriteLine("Select an animal again"); //Do the same stuff again
            tryAgain = true;
            while (tryAgain)
                try
                {
                    int userInput = Convert.ToInt32(Console.ReadLine()) - 1;
                    Console.WriteLine(stringList[userInput]);
                    tryAgain = false;
                }
                catch
                {
                    Console.WriteLine("Invalid selection, please try again");
                }




        }
    }
}
    