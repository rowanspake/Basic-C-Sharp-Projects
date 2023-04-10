using System;

namespace CallingMethodsSubmissionAssn
{
    //Declare our public class
    public class MathClass
    {
        //Declare our first method; it is static, outputs an integer, and takes a string input
        public static int Math1(string userInput)
        {
            //Convert the user input to integer
            int intInput = Convert.ToInt32(userInput);
            //Does some math, in this case multiplies by five
            int output = intInput * 5;
            //Returns the output
            return output;
        }

        //Second method, starts with the input already as the correct data type
        public static int Math2(int output)
        {
            //Adds twelve then returns output
            int output2 = output + 12;
            return output2;
        }

        //Same as above but divides by two insteady of adding
        public static int Math3(int output2)
        {
            int output3 = output2 / 2;
            return output3;
        }
    }
}
