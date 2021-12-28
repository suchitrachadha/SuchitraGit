using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductList.Model;

/***********************************************************************
 *  Class file that defines the properties of a product - ProductName,
 *  Product Description, Product Price and Product Category.
 *  It implements the interface IProductkatalog.
 *  Developed by Suchitra Chadha 
 *  Developed on 23 December 2021
 ***********************************************************************/


namespace ProductList.Model
{
  
    namespace ProductList
    {
        public class Product : IProductkatalog
        {

            public string ProductName { get; set; } = string.Empty;
            public string ProductDescription { get; set; } = string.Empty;
            public double ProductPrice { get; set; } = double.NaN;

            public string ProductId { get; set; } = Guid.NewGuid().ToString("N");

            public string ProductCategory { get; set; } = string.Empty;

            public static List<Product> products = new List<Product>();

            public override string ToString()
            {
                return "Product Name " + ProductName + "  Product Description: " + ProductDescription + "  Product Price:" + ProductPrice + "  Product Category:" + ProductCategory + "  ProductId:" + ProductId;
            }

            /*public override bool Equals(object obj)
            {
                if (obj == null) return false;
                Product objAsProduct = obj as Product;
                if (objAsProduct == null) return false;
                else return Equals(objAsProduct);
            }*/



            public void ViewProductDetails(Product viewProduct)
            
            {
                Console.WriteLine("Product Details is as follows:");
                Console.WriteLine(viewProduct.ToString());
                Console.WriteLine("*****************************");

            }


            public void ShowSave_Product()
            {   
                foreach (Product indProduct in products)
                {
                    int productlistnumber = (products.FindIndex(x => x.ProductId == indProduct.ProductId)) + 1;
                    Console.WriteLine("**** " + productlistnumber + ". " + indProduct.ProductName + " , Product code " + indProduct.ProductId + " , Product Description: " + indProduct.ProductDescription + " , Product Price: " + indProduct.ProductPrice + " , Product Category: " + indProduct.ProductCategory);
                    Console.WriteLine("************");
                }
                Console.WriteLine(" ");
                Console.WriteLine("Total number of products in product list: " + products.Count);
            }


        }
    }

}
