using System;
using System.Collections.Generic;
using System.Text;

namespace MethodSubmissionAssn
{
    //Declare a class
    class Class1
    {
        //Declare strings for constructor
        public int input1;
        public int input2;
        //Declare constructor and initial string values
        public Class1()
        {
            input1 = 0;
            input2 = 5;
        }
        //Declare method with two integer inputs
        public static int Method1(int input1, int input2)
        {
            //Do some math and return the result
            int output1 = input1 * input2;
            return output1;
        }
    }
}
