using System;
using System.IO;

namespace InputAssn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for a number
            Console.WriteLine("Please input a number");
            //Store input as a string
            string input = Console.ReadLine();
            //Use StreamWriter to access our log file and add the user input to the file
            using (StreamWriter file = new StreamWriter(@"C:\Users\15036\OneDrive\Documents\Logs\inputlog.txt", true))
            {
                file.WriteLine(input);
            }
            //Read the contents of the file back to the user
            Console.WriteLine(File.ReadAllText(@"C:\Users\15036\OneDrive\Documents\Logs\inputlog.txt"));

        }
    }
}
