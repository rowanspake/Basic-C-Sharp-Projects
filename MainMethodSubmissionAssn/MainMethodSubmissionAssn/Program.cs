using System;

namespace MainMethodSubmissionAssn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get a number, convert and store it
            Console.WriteLine("Please input an integer");
            int input = Convert.ToInt32(Console.ReadLine());
            
            //Instantiate our class, set the number field to the input number
            Class1 instance1 = new Class1
            {
                number = input
            };
            //Call the first method with the input number as the argument
            int output1 = Class1.Method1(instance1.number);
            //Write the result
            Console.WriteLine(output1);

            //Same idea but convert the input number to decimal
            Console.WriteLine("Please input a decimal number");
            decimal inputDec = Convert.ToDecimal(Console.ReadLine());
            Class1 instance2 = new Class1
            {
                decNumber = inputDec
            };
            //Call the second method on the decimal, output it
            decimal output2 = Class1.Method1(instance2.decNumber);
            Console.WriteLine(output2);

            //This time let the third method convert the input string into integer
            //Then do math and output the result
            Console.WriteLine("Please input another integer");
            string inputString = Console.ReadLine();
            Class1 instance3 = new Class1
            {
                word = inputString
            };
            int output3 = Class1.Method1(instance3.word);
            Console.WriteLine(output3);
        }
    }
}