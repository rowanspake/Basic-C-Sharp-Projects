using System;

namespace DailyReportApp
{
    class Program //defines the overall program
    {
        static void Main() //gives us entry into our program Main(), which returns no value (void)
        {
            Console.WriteLine("The Tech Academy"); //writes our into lines
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What is your name?"); //asks for input
            string name = Console.ReadLine(); //reads input and saves it as a string variable

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            
            Console.WriteLine("What page number?");
            bool tryAgain = true; //sets a boolean variable for a while loop
            while (tryAgain) //begins our while loop
            {
                try //opens the try block
                {
                    string pageNumberString = Console.ReadLine(); //reads input from previous question and saves it as a string variable
                    short pageNumber = Convert.ToInt16(pageNumberString); //attempts to convert string variable to short (16B int)
                    tryAgain = false; //if successful, switch boolean variable, ending loop
                }
                catch //catch block incase an exception is thrown
                {
                    Console.WriteLine("Invalid input, please enter a numeric value."); //we assume the user input a string
                    //loop repeats until successful
                }
                
            } //program continues
            
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            tryAgain = true;
            while (tryAgain) //another while loop
            {
                try //this time we want a true/false boolean input
                {
                    string helpString = Console.ReadLine();
                    bool help = Convert.ToBoolean(helpString);
                    tryAgain = false;
                }
                catch
                {
                    Console.WriteLine("Invalid input, please answer \"true\" or \"false.\"");
                }
            } //continue

            Console.WriteLine("Were there any positive experiences you’d like to share?\nPlease give specifics.");
            string posExperiences = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            tryAgain = true;
            while (tryAgain) //numeric try/catch while loop again
            {
                try
                {
                    string studyHoursString = Console.ReadLine();
                    float studyHours = Convert.ToSingle(studyHoursString);
                    tryAgain = false;
                }
                catch
                {
                    Console.WriteLine("Invalid input, please enter a numeric value.");
                }

            }
            

            Console.WriteLine("Thank you for your answers.\nAn instructor will respond to this shortly.\nHave a great day!");
            Console.ReadLine(); //finished!

        }
    }
}
