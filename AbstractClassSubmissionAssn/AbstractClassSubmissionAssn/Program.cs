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

            //Create object of type IQuittable
            IQuittable quitobject = new Employee();

            //Call Quit method on object
            quitobject.Quit();
        }
    }
}
