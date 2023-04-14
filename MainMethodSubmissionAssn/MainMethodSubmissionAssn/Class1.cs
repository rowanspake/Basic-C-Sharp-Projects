using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethodSubmissionAssn
{
    //Create our class
    public class Class1
    {
        //Declare the fields for our class constructor
        public int number;
        public decimal decNumber;
        public string word;

        //Declare our class constructor and initial values for fields
        public Class1()
        {
            number = 0;
            decNumber = 0;
            word = "";
        }

        //First method, taking in and putting out an integer
        public static int Method1(int number1)
        {
            //Math
            int output = number1 + 100;
            return output;
        }

        //Second method, taking in a decimal and putting out an integer
        public static decimal Method1(decimal decimal1)
        {
            //Math
            decimal intermediate = decimal1 / 2;
            //Convert to integer
            int output = Convert.ToInt32(intermediate);
            return output;
        }

        //Third method, taking in a string and putting out an integer
        public static int Method1(string string1)
        {
            //Convert string to integer
            int intermediate = Convert.ToInt32(string1);
            //Math
            int output = intermediate * 2;
            return output;
        }

    }
}
