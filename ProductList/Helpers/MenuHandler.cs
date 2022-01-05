using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*****************************************************
 * Menu Handler class that implements the Menu
 * 
 *  Developed by Suchitra Chadha 
 *  Developed on 23 December 2021
 * ***************************************************/

namespace ProductList.Helpers
{
   
    public class MenuHandler
    {
        public static int Show_Menu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("Please select any option");
            Console.WriteLine("1: Create Product");
            Console.WriteLine("2: View any Product");
            Console.WriteLine("3: Remove Product");
            Console.WriteLine("4: Show/Save Product List");
            Console.WriteLine("5. View by Product Category");
            Console.WriteLine("6: Exit");

            int menuChoice = int.Parse(Console.ReadLine());
            return menuChoice;
        }
   }
}
