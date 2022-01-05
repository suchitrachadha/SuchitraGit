using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWPFProductApp
{
    public class Product
    {

        public Guid ProductId { get; set; } = Guid.Empty;
        public string ProductName { get; set; } = string.Empty;
        public string ProductDescription { get; set; } = string.Empty;
        public string ProductCategory { get; set; } = string.Empty;
        public double ProductPrice { get; set; } = 0.0;


        public override string ToString()
        {
            return "Product Name " + ProductName + "  Product Description: " + ProductDescription + "  Product Price:" + ProductPrice + "  Product Category:" + ProductCategory + "  ProductId:" + ProductId;
        }


    }
}

