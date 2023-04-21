using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassSubmissionAssn
{
    //Declare class that inherits from class Person and interface IQuittable
    class Employee : Person, IQuittable
    {
        //Implement abstract method from class Person
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }

        //Implement method from interface IQuittable
        public void Quit()
        {
            Console.WriteLine("I quit!");
        }
    }
}
