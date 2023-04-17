using System;
using System.Collections.Generic;
using System.Text;

namespace ClassSubmissionAssn
{
    class Class1
    {
        //Declare a public integer for our constructor
        public int output1;
        //Declare class constructor with field
        public Class1()
        {
            output1 = 0;
        }
        //Declare first method that outputs an integer and divides it by 2
        public void Method1(int input1)
        {
            int number1 = input1 / 2;
            //Set the field in our instance to the result
            output1 = number1;
        }
        //Declare a method with output parameter
        public void Method2(out int output2)
        {
            output2 = 42;
        }
        //Declare another method that overloads the previous one
        public void Method2(int input2)
        {
            int output3 = input2 * 2;
            Console.WriteLine(output3);
        }
    }
}
