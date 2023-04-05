using System;
using System.Collections.Generic;

namespace StringsAndIntegersSubmissionAssn
{
    class Program
    {
        static void Main(string[] args)
        {
            //List of integers
            List<int> integerList = new List<int>() { 10, 20, 30, 40, 50}; 

            try
            {
                Console.WriteLine("Let's do some division.\nGive me a number to divide by.");
                //Get user input number and make it an integer
                int userInput = Convert.ToInt32(Console.ReadLine());
                //Iterate through list and divide contents by the input
                for (int i = 0; i < integerList.Count; i++)
                    //Output the results
                    Console.WriteLine(integerList[i] + " divided by " + userInput + " is " + integerList[i] / userInput);
            }
            //Oops, not a number
            catch (FormatException ex)
            {
                //Tell 'em
                Console.WriteLine(ex.Message);
            }
            //Can't divide by zero
            catch (DivideByZeroException ex)
            {
                //Nuh-uh
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //Peace out
                Console.WriteLine("Alright, done with that.  Let's continue!");
            }
            //We're done with all that.
            Console.WriteLine("Just kidding, that's all for now.  Good bye!");
        }
    }
}
