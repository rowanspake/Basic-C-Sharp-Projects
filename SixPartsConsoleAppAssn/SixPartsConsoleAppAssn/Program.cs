using System;
using System.Threading;
using System.Collections.Generic;

namespace SixPartsConsoleAppAssn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            string[] boyNames = { "Gerald", "Hieronymus", "Incognito", "Hank", "Pillson", "Henk" }; //Creates array of strings

            Console.WriteLine("Baby name simulator (boy)");
            Console.WriteLine("Please enter your last name to see how it looks with different names for a baby boy"); //Asks for input of last name
            string lastName = Console.ReadLine(); //Stores input

            for (int i = 0; i < boyNames.Length; i++) //Iterates through each string in the array
                boyNames[i] = boyNames[i] + " " + lastName; //Adds the input to end of string

            for (int i = 0; i < boyNames.Length; i++) //Iterates through the arrray again
                Console.WriteLine(boyNames[i]); //Prints each string

            Console.WriteLine("Choose a baby name from the previous list (pick number 1 through 6)"); //Get user selection from array
            int nameChoice = Convert.ToInt32(Console.ReadLine()) - 1; //Substract 1 so input matches index
            //Part 2
            for (int i = 0; i < boyNames.Length; i++) //Iterate through array
                while (nameChoice == i) //While the user input equals the index of the particular assocaited string
                {
                    Console.WriteLine(boyNames[i]); //Write the string.  It loops infinitely if you don't break the loop.
                    break; //Break out of loop
                }

            Console.WriteLine("Good choice!");
            Thread.Sleep(1000);

            //Part 3
            Console.WriteLine("Let's compare baby name lengths\n");
            Thread.Sleep(1000);
            Console.WriteLine("Who would have a short first name?\n");

            for (int i = 0; i < boyNames.Length; i++)
                if (boyNames[i].Length - lastName.Length - 1 < 6) //Loop using "<" comparison operator
                {
                    Console.WriteLine(boyNames[i] + " would have a short first name");
                    Thread.Sleep(500);
                }
                else
                {
                    Console.WriteLine(boyNames[i] + " would not have a short first name");
                    Thread.Sleep(500);
                }
            Thread.Sleep(1000);
            Console.WriteLine("\nWho would have a long first name?\n");
            Thread.Sleep(1000);
            for (int i = 0; i < boyNames.Length; i++)
                if (8 <= boyNames[i].Length - lastName.Length - 1) //Loop using "<=" comparison operator
                {
                    Console.WriteLine(boyNames[i] + " would have a long first name");
                    Thread.Sleep(500);
                }
                else
                {
                    Console.WriteLine(boyNames[i] + " would not have a long first name");
                    Thread.Sleep(500);
                }
            Thread.Sleep(1000);

            //Part 4
            //List of unique strings
            List<string> girlNames = new List<string>() { "Olivia", "Emma", "Charlotte", "Amelia", "Ava" };

            Console.WriteLine("\nLets's look at popular girls' names");
            Thread.Sleep(1000);
            //User input to search in list
            Console.WriteLine("\nGuess a name and I'll tell you if it's one of the top five girls' names for 2023!");
            string nameGuess = Console.ReadLine().ToLower();

            bool correctGuess = false;

            //Do-while with switch to iterate through list and display index of input
            do
            {
                string firstUpper = char.ToUpper(nameGuess[0]) + nameGuess[1..];
                string caseMessage = "Good guess! " + firstUpper + " is at index " + girlNames.IndexOf(firstUpper) + "\nGuess again or type STOP if you're done, and I'll show you the rest of the list!";
                switch (nameGuess)
                {
                    case "olivia":
                        Console.WriteLine(caseMessage);
                        nameGuess = Console.ReadLine().ToLower();
                        break;
                    case "emma":
                        Console.WriteLine(caseMessage);
                        nameGuess = Console.ReadLine().ToLower();
                        break;
                    case "charlotte":
                        Console.WriteLine(caseMessage);
                        nameGuess = Console.ReadLine().ToLower();
                        break;
                    case "amelia":
                        Console.WriteLine(caseMessage);
                        nameGuess = Console.ReadLine().ToLower();
                        break;
                    case "ava":
                        Console.WriteLine(caseMessage);
                        nameGuess = Console.ReadLine().ToLower();
                        break;
                    //Break out of loop when you want
                    case "stop":
                        Console.WriteLine("Thanks for playing, here's the full list!");
                        girlNames.ForEach(Console.WriteLine);
                        correctGuess = true;
                        break;
                    //Code incase the input isn't on the list
                    default:
                        Console.WriteLine("It's a nice name, but it's not on the list!\nGuess again or type STOP if you're done, and I'll show you the list!");
                        nameGuess = Console.ReadLine().ToLower();
                        break;
                }
            } while (!correctGuess);
            Thread.Sleep(1000);

            //Part 5
            //List of strings with two identical values
            List<string> prezNames = new List<string>() { "George", "John", "Thomas", "James", "James" }; //

            Console.WriteLine("Let's look at the first names of the first five U.S. presidents!");
            Thread.Sleep(500);
            Console.WriteLine("Guess a name and I'll tell you where they they are in the list");

            string prezGuess = Console.ReadLine().ToLower();
            string firstUpper2 = char.ToUpper(prezGuess[0]) + prezGuess.Substring(1);
            string caseMessage2 = "Good guess! " + firstUpper2 + " is at index: ";

            //Iterates through list
            switch (prezGuess)
            {
                case "george":
                    Console.WriteLine(caseMessage2 + "\n" + prezNames.IndexOf(firstUpper2));
                    break;
                case "john":
                    Console.WriteLine(caseMessage2 + "\n" + prezNames.IndexOf(firstUpper2));
                    break;
                case "thomas":
                    Console.WriteLine(caseMessage2 + "\n" + prezNames.IndexOf(firstUpper2));
                    break;
                //Case with multiple values in list has code to iterate through list multiple times.
                //Could have used for all cases but opted not to.
                case "james":
                    Console.WriteLine(caseMessage2);
                    for (int i = 0; i < prezNames.Count; i++)
                        if (prezNames[i] == firstUpper2)
                        {
                            Console.WriteLine(i);
                        }
                    break;
                //Code to execute if input is not on the list, not extra chances to guess!
                default:
                    Console.WriteLine("Not on the list, sorry!");
                    break;

            }
            Thread.Sleep(1000);
            
            //Part 6
            List<string> prezNames2 = new List<string>() { "John", "Andrew", "Martin", "William", "John" }; //List of strings with two identical strings
            Console.WriteLine("Finally, we'll look at the first names of the five most recent British monarchs");
            Thread.Sleep(500);

            List<string> searchedList = new List<string>() { }; //Empty list to store previously checked values
            foreach (string name in prezNames2) //Foreach loop evaluating the list
            {
                if (searchedList.Contains(name)) //Check if we've already searched for the given value
                {
                    Console.WriteLine(name + ", again"); //If we have, say so
                    Thread.Sleep(500);
                }
                else
                {
                    Console.WriteLine(name); //If not, write it to the console
                    searchedList.Add(name); //And add it to the searched list
                    Thread.Sleep(500);
                }

            }

            Console.WriteLine("Thank you, goodbye!"); //Done!


             
        }
    }
}
