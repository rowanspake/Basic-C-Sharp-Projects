using System;

namespace BoolenLogicSubmissionAssn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine()); //Gets input, converts to integer

            Console.WriteLine("Have you ever had a DUI?");
            string dui = Console.ReadLine().ToLower(); //Gets string input, makes it lowercase
            bool duiBool = dui == "no"; //If the answer is a no, boolean variable duiBool will be true

            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine()); //Gets input, converts to integer

            bool qualifies = (age > 15 && duiBool && tickets <= 3); //Compares the age, dui, and number of tickets to see if the user is over 15, has no DUIs, and less than 3 speeding tickets

            Console.WriteLine("Qualified?");
            Console.WriteLine(qualifies);
        }
    }
}
