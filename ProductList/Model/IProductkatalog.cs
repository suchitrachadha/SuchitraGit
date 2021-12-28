using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/****************************************
 * Interface file that has the signatures for methods used to perform 
 * operations on the product(s).
 * 
 *  Developed by Suchitra Chadha 
 *  Developed on 23 December 2021
 * **************************************/

namespace ProductList.Model
{
    public interface IProductkatalog
    {
       string ProductName { get; } 
       string ProductDescription { get; } 
       double ProductPrice { get; }

       string ProductId { get;  } 
       string ProductCategory { get; }

        void ViewProductDetails(ProductList.Product viewProduct);

        void ShowSave_Product();
    }
}
