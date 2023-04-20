using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsAndObjectsSubmissionAssn
{
    public class Person
    {
        //Declare two public string properties
        public string FirstName = "";
        public string LastName = "";
        
        //Declare a void method
        public void SayName()
        {
            //Write the two properties with some additional contextual text
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
