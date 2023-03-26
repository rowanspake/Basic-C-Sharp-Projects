using System;

namespace BranchingSubmissionAssn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("How many pounds is your package?");
            float packageWeight = Convert.ToSingle(Console.ReadLine()); //Get input, convert to float
            if (packageWeight > 50) //Is it more than 50?
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Environment.Exit(0);  //Yes, goodbye
            }
            else
            {
                Console.WriteLine("Package is within weight limit."); //Its not, continue
            }
            Console.WriteLine("Please input package width.");           //Lets
            float packageWidth = Convert.ToSingle(Console.ReadLine());//Get
            Console.WriteLine("Please input package height.");          //Those
            float packageHeight = Convert.ToSingle(Console.ReadLine());//Dimensions
            Console.WriteLine("Please input package length.");
            float packageLength = Convert.ToSingle(Console.ReadLine());
            float packageDimensions = packageWidth + packageHeight + packageLength; //Add em up
            if (packageDimensions > 50) //Does it add up to more than 50?
            {
                Console.WriteLine("Package too big to be shipped via Package Express."); //Yes
                Environment.Exit(0); //Go away
            }
            else
            {
                Console.WriteLine("Package is within dimensional limit."); //You're good
            }
            double packageVolume = packageWidth * packageHeight * packageLength; //Multiplication station
            double quote = packageVolume * packageWeight / 100; //More math
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote + "\nThank You!"); //Give 'em the quote



        }
    }
}
