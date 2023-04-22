using System;

namespace OperatorsSubmissionAssn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate our class twice with different values
            Employee emp1 = new Employee
            {
                Id = 0001,
                FirstName = "Joe",
                LastName = "Schmo"
            };
            Employee emp2 = new Employee
            {
                Id = 0002,
                FirstName = "Bina",
                LastName = "Burner"
            };

            //Compare our instances with both overloaded operators and write the result
            string result = emp1 == emp2;
            Console.WriteLine(result);
            result = emp1 != emp2;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
