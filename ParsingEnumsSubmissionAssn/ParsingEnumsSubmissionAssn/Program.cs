using System;
using System.Collections.Generic;
using System.Text;

namespace ParsingEnumsSubmissionAssn
{
    class Program
    {
        //Create enum for the days of the week
        enum Weekdays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday
        }
        static void Main(string[] args)
        {
            //Prompt user for current day of the week
            Console.WriteLine("What day of the week is it?");
            //Store input value
            string rawInput = Console.ReadLine();

            //Try/catch block
            try
            {
                //Try to assign the input value to a variable of our enum data type
                Weekdays weekday = (Weekdays)Enum.Parse(typeof(Weekdays), rawInput);
                //Write it to the console
                Console.WriteLine(weekday);
            }
            //Catch incase the user input cannot be parsed
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week");
            }

        }
    }
}
