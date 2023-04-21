using System;

namespace AbstractClassSubmissionAssn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate an Employee object
            Employee employee1 = new Employee { firstName = "Sample", lastName = "Student" };

            //Call SayName method on object
            employee1.SayName();
        }
    }
}
