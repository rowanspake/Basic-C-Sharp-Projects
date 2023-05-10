using System;

namespace TryCatchAssn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            try
            {
                int userAge = Convert.ToInt32(Console.ReadLine());
                decimal zeroCheck = 1 / userAge;

            }
            catch (FormatException)
            {
                Console.WriteLine("That wasn't a number");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You aren't zero years old.");
            }


        }
    }
}
