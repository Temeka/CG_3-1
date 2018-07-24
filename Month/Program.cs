using System;

namespace Month
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asking user for the month using the "if/else if/else Descision Statement"
            //The end results should print "December & January"

            Console.Write("Please enter the number of the first OR last month of the year as MM: ");
            string userValue = Console.ReadLine();
            string message = "";

            if (userValue == "12")
            {
                 message = "December";
            }           
            else if (userValue == "01")
            {
                 message = "January";               
            }
            else 
            {
                 message = "Sorry, that is incorrect. Please try again.";                
            }
            Console.WriteLine(message);
            Console.ReadLine();
            
            

        

        }
    }
}
