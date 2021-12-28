using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using ProductList.Model.ProductList;
using ProductList.Helpers;
using System.Runtime.Serialization;

/*************************************************************
 * Console Application that allows users to creates, remove products,
 * view any product details, view product by category and allows to show 
 * and save product list/catalog in a file. Application has a menu with  
 * 6 different operations.
 * 
 * Developed by Suchitra Chadha
 * Developed on 23 December 2021
 * 
 * ***********************************************************/

class Program

{
    static void Main(string[] args)
    {
            int choice = 0;
            Product singleProduct = new Product();
            while (choice != 6)
            {

            try
            {
                // Calling the MenuHandler to display Menu and get the selected value of menu
                choice = ProductList.Helpers.MenuHandler.Show_Menu();
                Console.WriteLine("Choice: " + choice);

                switch (choice)
                {

                    // Create Product
                    case 1:
                        {
                           
                        ProductHandler.Create_Product(singleProduct);
                        break;
                        }

                    // View any Product
                    case 2:
                        {   Console.WriteLine("Please enter the Product Id you want to view details of");
                            string viewProduct = Console.ReadLine();
                            singleProduct = ProductHandler.GetProduct(viewProduct);
                            ProductHandler.ViewProductDetails(singleProduct);
                            
                            break;
                        }
                    // Remove Product
                    case 3:
                        {
                            ProductHandler.Remove_Product(singleProduct);
                             break;
                        }
                    // Show/Save Product List
                    case 4:
                        {
                            ProductHandler.ShowSave_Product();
                            break;
                        }
                    // View by Category
                    case 5:
                        {
                            ProductHandler.View_ByCategory();
                            break;

                        }

                    // Exit
                    case 6:
                        {

                           break;
                        }
                    
                    default:
                        { 
                           break;
                        }

                }                                            

            } // try

            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Please enter a valid value.");

            }


        }// while loop

   } // static

}