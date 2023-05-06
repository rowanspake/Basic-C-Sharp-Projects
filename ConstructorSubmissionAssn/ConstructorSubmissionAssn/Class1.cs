using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorSubmissionAssn
{
    public class Class1
    {
        //Declare a public string field
        public string putEmTogether;
        //Declare two class constructors and chain them together
        public Class1(string constantly) : this(constantly, "This is a string too")
        {

        }
        public Class1(string constantly, string isAString)
        {
           putEmTogether = constantly + isAString;
        }
    }
}
