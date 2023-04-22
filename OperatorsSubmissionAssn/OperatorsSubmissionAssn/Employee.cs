using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsSubmissionAssn
{
    //Create employee class and declare properties
    class Employee
    {
        public int Id;
        public string FirstName;
        public string LastName;

        //Overload the == operator
        public static string operator== (Employee emp1, Employee emp2)
        {
            //Compare two inputs and return a string as the result
            bool result = emp1.Id == emp2.Id;
            if (result)
                return "Yes, these employee IDs match";
            else
                return "No, these employee IDs do not match";

        }

        //Overload the corresponding operator in a similar way
        public static string operator!= (Employee emp1, Employee emp2)
        {
            bool result = emp1.Id != emp2.Id;
            if (result)
                return "Yes, these employee IDs do not match";
            else
                return "No, these employee IDs do not not match";
        }


    }
}
