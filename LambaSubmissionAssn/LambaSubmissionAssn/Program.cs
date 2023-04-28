using System;
using System.Collections.Generic;
using System.Linq;

namespace LambaSubmissionAssn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create list of type Employee
            List<Employee> employeeList = new List<Employee>();

            //Add ten employees, two named Joe
            employeeList.Add(new Employee( 0001, "Joe","Leen" ));
            employeeList.Add(new Employee( 0002, "Bill", "Gronkowski" ));
            employeeList.Add(new Employee( 0003, "Kim", "Bop" ));
            employeeList.Add(new Employee( 0004, "Poppy", "McFlower" ));
            employeeList.Add(new Employee( 0005, "Chum", "L\'Buqet" ));
            employeeList.Add(new Employee( 0006, "Mari", "O\'World" ));
            employeeList.Add(new Employee( 0007, "Phil", "Mahart" ));
            employeeList.Add(new Employee( 0008, "Joe", "Naandthewail" ));
            employeeList.Add(new Employee( 0009, "Hotcuppa", "Joe" ));
            employeeList.Add(new Employee( 0010, "Tim", "Beurre" ));

            //Create empty list for foreach loop
            List<Employee> joeListForeach = new List<Employee>();

            //Foreach loop that goes through our employee list and adds Joes to the empty list
            foreach (Employee employee in employeeList)
            {
                if (employee.FirstName == "Joe")
                    joeListForeach.Add(employee);
            }

            //Print the contents of the Joe list
            foreach (Employee employee in joeListForeach)
            {
                Console.WriteLine("Employee number " + employee.Id + " has the first name \"Joe\"");
            }

            //Lambda expression that makes a new list and adds all Joes from the employee list
            List<Employee> joeListLambda = employeeList.Where(x => x.FirstName == "Joe").ToList();

            //Print the contents of the new Joe list
            foreach (Employee employee in joeListLambda)
            {
                Console.WriteLine("\"Joe\" is the first name of employee number " + employee.Id);
            }

            //Lambda expression that makes a new list of employees with ID numbers over five
            List<Employee> overFiveListLambda = employeeList.Where(x => x.Id > 5).ToList();
            
            //Print the results of the over five list
            foreach (Employee employee in overFiveListLambda)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " has an ID number over five.");
            }
        }
    }
}
