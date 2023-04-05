using System;
using System.Collections.Generic;

namespace StringsAndIntegersSubmissionAssn
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integerList = new List<int>() { 10, 20, 30, 40, 50};

            try
            {
                Console.WriteLine("Let's do some division.\nGive me a number to divide by.");
                int userInput = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < integerList.Count; i++)
                    Console.WriteLine(integerList[i] + " divided by " + userInput + " is " + integerList[i] / userInput);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Alright, done with that.  Let's continue!");
            }
            Console.WriteLine("Just kidding, that's all for now.  Good bye!");
        }
    }
}
