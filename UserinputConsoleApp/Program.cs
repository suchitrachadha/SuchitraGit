using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace UserinputConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
           /* Declaring variables to capture user inputs */
            string FirstName, LastName, EmailAddr, GoalDesc;
            /* Capturing First Name */
            Console.WriteLine("Enter your First Name:");
            FirstName = Convert.ToString(Console.ReadLine());

            /* Capturing Last Name */
            Console.WriteLine("Enter your Last Name:");
            LastName = Convert.ToString(Console.ReadLine());

            /* Capturing Email Address */
            Console.WriteLine("Enter your Email Address:");
            EmailAddr = Convert.ToString(Console.ReadLine());

            /* Capturing Goal description */
            Console.WriteLine("Describe your goal:");
            GoalDesc = Convert.ToString(Console.ReadLine());
            
           /* Console.ReadLine(); */
            

            /*Console.WriteLine("Hello World!");*/

            
        }
    }
}
