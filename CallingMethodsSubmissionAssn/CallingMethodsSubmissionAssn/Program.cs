using System;

namespace CallingMethodsSubmissionAssn
{
    class Program
    {
        //The method for our progam
        static void Main(string[] args)
        {
            //Ask for an input
            Console.WriteLine("Gimme a number (an integer please) and I'll do math on it.\nI'll multiply it by five, add twelve, and halve it");
            //Get the input
            string userInput = Console.ReadLine();
            //Apply the first method from our secondary class to our input and save it as a variable
            int output = MathClass.Math1(userInput);
            //Write the result to the console
            Console.WriteLine(output);
            //Continue and repeat for our outher two methods
            Console.WriteLine("Next...");
            int output2 = MathClass.Math2(output);
            Console.WriteLine(output2);
            Console.WriteLine("And finally...");
            int output3 = MathClass.Math3(output2);
            Console.WriteLine(output3);
            Console.ReadLine();

        }
    }
}
    