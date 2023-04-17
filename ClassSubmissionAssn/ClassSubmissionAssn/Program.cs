using System;

namespace ClassSubmissionAssn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get a number input by the user
            Console.WriteLine("Input a number");
            int input1 = Convert.ToInt32(Console.ReadLine());

            //Instantiate our first class
            Class1 class1 = new Class1();

            //Call our first method and write the result
            class1.Method1(input1);
            Console.WriteLine(class1.output1);

            //Declare a new variable, call our second method, and write the result
            int output2;
            class1.Method2(out output2);
            Console.WriteLine(output2);

            //Call our overloaded method and write the result
            class1.Method2(output2);
            
            //Call the method from our static class
            Console.WriteLine(Class2.Method1());

            Console.ReadLine();
        }
    }
}
