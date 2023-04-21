using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassSubmissionAssn
{
    //Declare class that inherits from class Person
    class Employee : Person
    {
        //Implement abstract class from class Person
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
