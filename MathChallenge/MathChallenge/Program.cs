using System;

namespace MathChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            short num1 = 2;
            short num2 = 5;
            Console.WriteLine(num1 + num2); 
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
            float num3 = 2;
            float num4 = 5;
            Console.WriteLine(num3 / num4);
            //Console.ReadLine();

            int product = 10 * 5;
            Console.WriteLine(product);
            //Console.ReadLine();

            double quotient = 100.0 / 17.0;
            Console.WriteLine(quotient);
            //Console.ReadLine();

            int remainder = 11 % 2;
            Console.WriteLine(remainder);
            //Console.ReadLine();

            bool trueOrFalse = 12 < 5;
            Console.WriteLine(trueOrFalse);
            //Console.ReadLine();

            int roomTemp = 70;
            int currentTemp = 72;
            bool isWarm = currentTemp >= roomTemp;
            Console.WriteLine(isWarm);
            Console.ReadLine();
        }
    }
}
