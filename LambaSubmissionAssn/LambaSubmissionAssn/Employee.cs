using System;
using System.Collections.Generic;
using System.Text;

namespace LambaSubmissionAssn
{
    //Create Employee class
    public class Employee
    {
        //Declare our properties
        public int Id;
        public string FirstName;
        public string LastName;
        
        //Declare constructor using properties
        public Employee (int id, string firstname, string lastname)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
        }
    }
    
}
