using System;

namespace MethodsAndObjectsSubmissionAssn
{
    class Program
    {
        //Main method
        static void Main(string[] args)
        {
            //Instantiate and initialize the Employee class
            Employee emp1 = new Employee()
            {
                //Initialize with values for the two public strings inherited from the Person class
                FirstName = "Sample",
                LastName = "Student"
            };

            //Call the SayName method from Person on the instance of Employee
            emp1.SayName();

        }
    }
}
