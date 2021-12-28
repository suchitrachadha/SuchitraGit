using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductList.Model.ProductList;
/*****************************************************
 * Product Handler class that implements methods for different operations 
 * on the product(s).
 * 
 *  Developed by Suchitra Chadha 
 *  Developed on 23 December 2021
 * ***************************************************/


namespace ProductList.Helpers
{
    
    
    public class ProductHandler
    {

        public static List<Product> products = new List<Product>();
        public static Product Create_Product(Product singleProduct)
        {
          try
          {
            singleProduct = new Product();
            Console.WriteLine("Please enter product name");
            singleProduct.ProductName = Console.ReadLine();

            Console.WriteLine("Please enter product description");
            singleProduct.ProductDescription = Console.ReadLine();

            Console.WriteLine("Please enter product price in SEK");
            double ProdPrice = 0.0;
            while (!double.TryParse(Console.ReadLine(), out ProdPrice))
            { 
               Console.Clear();
               Console.WriteLine("You entered an invalid number/price.");
               Console.Write("Please enter a valid number.");
            }
            singleProduct.ProductPrice = ProdPrice;
            Console.WriteLine("Please enter product category");
            singleProduct.ProductCategory = Console.ReadLine();

            singleProduct.ProductId = Guid.NewGuid().ToString("N");

            string strProductname = singleProduct.ProductName.ToString();
            string strProductDesc = singleProduct.ProductDescription.ToString();
            double strProductPrice = singleProduct.ProductPrice;
            string strProductCategory = singleProduct.ProductCategory.ToString();
            string guidProductId = singleProduct.ProductId;
                
            // invoking method to add product to the list.
            ProductHandler.Add_Product(strProductname, strProductDesc, strProductPrice, strProductCategory, guidProductId);
            
         }
         catch (Exception ex)
         {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Please enter a valid value");
            
         }
            return singleProduct;
        }


        public static void Add_Product(string strProductName, string strProductDesc, double strProductPrice, string strProductCategory, string guidProductId)
        {
            // Adding product to the product list
            ProductHandler.products.Add(new Product() {ProductName = strProductName, ProductDescription = strProductDesc, ProductPrice = strProductPrice, ProductCategory = strProductCategory, ProductId = guidProductId});
            Console.WriteLine("Product " + strProductName + " with product code " + guidProductId + " is created and added to the list");
            Console.WriteLine(" ");
        }


        public static IEnumerable<Product>GetProductList()
        {
            return products.OrderBy(x => x.ProductName);
        }


        public static Product GetProduct(string ProductId)

        {
          return products.FirstOrDefault(x => x.ProductId.ToLower().Trim() == ProductId.ToLower().Trim());
        }


        public static void ViewProductDetails(Product viewProduct)
        {
            if (viewProduct != null)
            {
                Console.WriteLine("Product details is as follows:");
                Console.WriteLine(viewProduct.ToString());
                Console.WriteLine("*****************************");
            }
            else
                Console.WriteLine("No Product ID found. Please enter a valid Product ID.");
  
        }

        public static void View_ByCategory()
        {
            Console.WriteLine("Please enter the category you want to see the products of:");
            string Prod_Category = string.Empty;
            Prod_Category = Console.ReadLine();
            var result = products.Where(x => x.ProductCategory.TrimEnd().ToLower() == Prod_Category.TrimEnd().ToLower());
            if (result != null)
            {
                foreach (Product Category_Product in result)
                {
                    Console.WriteLine("Product Name: " + Category_Product.ProductName + "  Product Description: " + Category_Product.ProductDescription + " Product Price: " + Category_Product.ProductPrice + " Product Id: " + Category_Product.ProductId);
                    Console.WriteLine(" ");
                }

                Console.WriteLine("Total Number of products in category " + Prod_Category + " is: " + result.Count());
                Console.WriteLine(" ");
            }
            else
            {

                Console.WriteLine("No Product Category found. Please enter a valid category.");
            }

        }

        public static void ShowSave_Product()
        {
            if (products.Count != 0)
            {
                foreach (Product indProduct in ProductHandler.products)
                {
                    int productlistnumber = (ProductHandler.products.FindIndex(x => x.ProductId == indProduct.ProductId)) + 1;
                    Console.WriteLine("**** " + productlistnumber + ". " + indProduct.ProductName + " , Product code " + indProduct.ProductId + " , Product Description: " + indProduct.ProductDescription + " , Product Price: " + indProduct.ProductPrice + " , Product Category: " + indProduct.ProductCategory);
                    Console.WriteLine("************");
                }
                Console.WriteLine(" ");
                Console.WriteLine("Total number of products in product list: " + ProductHandler.products.Count);
                Console.WriteLine("Do you want to save the product List? Please answer Y or N");
                string FileSave;
                FileSave = Console.ReadLine();
                if (FileSave.ToUpper().TrimEnd() == "Y")
                {
                    string FilePath = ProductList.Helpers.FileHandler.WriteToFile();
                    int varTemp = 0;
                    foreach (Product singleProduct in products)
                    {
                        if (varTemp == 0)
                            System.IO.File.WriteAllText(FilePath, (singleProduct.ToString() + Environment.NewLine));
                        else
                            System.IO.File.AppendAllText(FilePath, (singleProduct.ToString() + Environment.NewLine));
                        varTemp = varTemp + 1;
                    }
                    Console.WriteLine("Product List has been saved in file " + FilePath);
                }
            }
            else
            {
                Console.WriteLine("There are no products in the product catalog.");


            }
       
         }


          public static void Remove_Product(Product RemoveProductObj)
          {
            if (products.Count == 0) Console.WriteLine("There are no products to be removed.");
            else
               {
                  string RemoveId;
                  Console.WriteLine("Please enter the Product Id to be removed");
                  RemoveId = Console.ReadLine().ToString();
                  int RemovePosition = products.FindIndex(x => x.ProductId == RemoveId);
                  if (RemovePosition == -1)
                   {
                    Console.WriteLine("Product ID not found. Please enter a valid Product ID.");
                   }
                  else
                   {
                     products.RemoveAt(RemovePosition);
                     Console.WriteLine(" ");
                     Console.WriteLine("Product " + RemoveProductObj.ProductId + " , " + RemoveProductObj.ProductName + " at position " + RemovePosition + " removed.");
                   }
                  
               }
         }

    }
}

