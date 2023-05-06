using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace ConstructorSubmissionAssn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare a constant variable
            const string constantly = "This is constant ";
            //Declare a variable using the keyword "var"
            var isAString = "This is a var string";

            //Instantiate our class with two input values
            Class1 instanceOne = new Class1(constantly, isAString);
            //Instantiate our class with one input value
            Class1 instanceTwo = new Class1(constantly);
            //Display the properties of both instances
            Console.WriteLine(instanceOne.putEmTogether);
            Console.WriteLine(instanceTwo.putEmTogether);
            Console.ReadLine();

        }
    }
}
