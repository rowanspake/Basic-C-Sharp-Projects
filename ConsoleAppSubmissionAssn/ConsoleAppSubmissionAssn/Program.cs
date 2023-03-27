using System;

namespace ConsoleAppSubmissionAssn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the animal");
            string animalGuess = Console.ReadLine().ToLower(); //Get user input, make lowercase
            bool correctAnswer = animalGuess == "cat"; //Set correct answer as a bool variable
            while (!correctAnswer) //Do stuff until the user inputs the correct answer
            {
                switch (animalGuess) //Makin a switch
                {
                    case "cat": //Cat is correct
                        Console.WriteLine("Cat is correct");
                        correctAnswer = true; //Changing bool to true breaks out of the loop
                        break;
                    default:
                        Console.WriteLine("Nope"); //Otherwise, try again
                        Console.WriteLine("Guess again");
                        animalGuess = Console.ReadLine().ToLower(); //Makes the user input a new guess
                        break;
                }
            }
            
            Console.WriteLine("Let's play again. Guess the animal"); //Round two
            animalGuess = Console.ReadLine().ToLower();
            correctAnswer = animalGuess == "dog"; //Different answer

            do //Do-while instead of just while
            {
                switch (animalGuess) //Same idea
                {
                    case "dog":
                        Console.WriteLine("You got it, goodbye!");
                        correctAnswer = true;
                        break;
                    default:
                        Console.WriteLine("Wrong, try again");
                        animalGuess = Console.ReadLine().ToLower();
                        break;
                }
            } while (!correctAnswer); //The while condition in question of the do-while
        }
    }
}
