using System;
using System.IO;

namespace DateTimeSubmissionAssn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get the current date and time
            DateTime timeNow = DateTime.Now;
            //Print it
            Console.WriteLine(timeNow);

            //Ask for a number input
            Console.WriteLine("Give me a number");
            //Store it as an integer
            int userInput = Convert.ToInt32(Console.ReadLine());
            //Declare a TimeSpan with the value of the user input for the hours value
            TimeSpan userDate = new TimeSpan(0, userInput, 0, 0);
            //Add those hours to the current date and time
            DateTime laterDate = timeNow + userDate;
            //Print the results
            Console.WriteLine("In {0} hours it will be {1}.", userInput, laterDate);

        }
    }
}
