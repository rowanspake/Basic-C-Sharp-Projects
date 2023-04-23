using System;
using System.Collections.Generic;
using System.Text;

namespace ParametersAssn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate class Employee with type string as list parameter
            Employee<string> emp1 = new Employee<string>();

            //Assign list of strings to Things property of our instantiation
            emp1.Things = new List<string>
            {
                "one",
                "two",
                "three",
                "four",
                "five"
            };

            //Instantiate class Employee again, with integer type list
            Employee<int> emp2 = new Employee<int>();

            //Assign list of integers to second instance of Employee
            emp2.Things = new List<int>
            {
                1,
                2,
                3,
                4,
                5
            };

            //Loop through each list and print it
            foreach (var i in emp1.Things)
            {
                Console.WriteLine(i);
            };
            foreach (var i in emp2.Things)
            {
                Console.WriteLine(i);
            };



        }
    }
}
