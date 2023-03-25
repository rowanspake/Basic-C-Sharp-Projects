using System;

namespace MathAndComparisonOperatorSubmissionAssn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            System.Threading.Thread.Sleep(1000); //Little bit of code to create a pause between lines
            Console.WriteLine("Person 1");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Hourly Rate: Please input number of dollars earned per hour for Person 1");
            int p1hr = Convert.ToInt32(Console.ReadLine()); //Reads the input, converts it to an integer, and assigns it to a variable
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Weekly Hours: Please input number of hours worked per week by Person 1");
            float p1wh = Convert.ToSingle(Console.ReadLine()); ////Reads the input, converts it to a float, and assigns it to a variable
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Thank you.");
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Person 2");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Hourly Rate: Please input number of dollars earned per hour for Person 2");
            int p2hr = Convert.ToInt32(Console.ReadLine());
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Weekly Hours: Please input number of hours worked per week by Person 2");
            float p2wh = Convert.ToSingle(Console.ReadLine());
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Thank you.");
            System.Threading.Thread.Sleep(750);

            Console.WriteLine("Processing...");
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("Assuming two weeks of vacation and perfect work attendance...");
            System.Threading.Thread.Sleep(1500);
            float p1as = p1hr * p1wh * 50; //Multiplies hourly rate by weekly hours and weeks generally worked in a year
            Console.WriteLine("Annual salary of Person 1: $" + p1as + " per year.");
            System.Threading.Thread.Sleep(2000);
            float p2as = p2hr * p2wh * 50;
            Console.WriteLine("Annual salary of Person 2: $" + p2as + " per year.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            System.Threading.Thread.Sleep(1500);
            bool whoMakesMore = p1as > p2as; //Compares annual salary of both people
            if (whoMakesMore == true) //Writes a different output depending on what the boolean value is
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Thank you for using the Anonymous Income Comparison Program");
            Console.ReadLine();

        }
    }
}
