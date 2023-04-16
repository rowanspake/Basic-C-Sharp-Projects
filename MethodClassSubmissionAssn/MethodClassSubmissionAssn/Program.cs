using System;

namespace MethodClassSubmissionAssn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate our class
            Class1 class1 = new Class1();
            //Call our method, give it two numbers
            Class1.Method1(5, 4);
            //Call our method again, this time specifying the parameters by name
            Class1.Method1(input1: 3, input2: 6);

        }
    }
}
