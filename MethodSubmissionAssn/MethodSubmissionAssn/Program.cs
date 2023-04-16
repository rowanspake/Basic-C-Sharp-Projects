using System;

namespace MethodSubmissionAssn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate our class
            Class1 class1One = new Class1();

            //Ask for first input, make it an integer, and store it in our class instance
            Console.WriteLine("Please input a number");
            int input1 = Convert.ToInt32(Console.ReadLine());
            class1One.input1 = input1;

            //Ask for another input number
            Console.WriteLine("Please input another number. Or don't. I don't care.");
            string input2string = Console.ReadLine();
            
            //If the input is null, we'll use the initial value we set in our class declaration
            if (input2string == "")
                Console.WriteLine("Okay, I'll pick my own second number\n" + class1One.input2);
            //Otherwise, set the second value in our class instance to the second input
            else
                class1One.input2 = Convert.ToInt32(input2string);

            //Call our class' method and give it our class instance's values
            Console.WriteLine("Math!");
            int output1 = Class1.Method1(class1One.input1, class1One.input2);
            
            //Display result
            Console.WriteLine(output1);
            Console.ReadLine();

        }
    }
}
