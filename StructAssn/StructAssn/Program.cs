using System;

namespace StructAssn
{
    class Program
    {

        //Create a struct with a decimal property
        public struct Number
        {
            public decimal Amount;
        }

        static void Main(string[] args)
        {
            //Create object of the struct and assign a value to the decimal property
            Number number1 = new Number
            {
                Amount = 0.5m
            };

            //Print it to the console
            Console.WriteLine(number1.Amount);
        }
    }
}
