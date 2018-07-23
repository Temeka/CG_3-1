using System;

namespace Month
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asking user for the month using the "if/else if/else Descision Statement"
            //The end results should print "December & January"

            Console.Write("Please enter the number of the first OR last month of the year: ");
            string userValue = Console.ReadLine();

            if (userValue == "12")
            {
                string message = "December";
                Console.WriteLine(message);
            }
            

            else if (userValue == "1")
            {
                string message = "January";
                Console.WriteLine(message);
            }

            else 
            {
                string message = "Sorry, that is incorrect. Please try again.";
                Console.WriteLine(message);
            }

            Console.ReadLine();
            
            

        

        }
    }
}
