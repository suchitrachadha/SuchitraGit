using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NewWPFProductApp.Handlers
{
    /// <summary>
    /// Interaction logic for ViewProductByCategory.xaml
    /// </summary>
    public partial class ViewProductByCategory : Window
    {
        public List<Product> products = new List<Product>();
       

        public ViewProductByCategory()
        {
            InitializeComponent();
        }

        public ViewProductByCategory(List<Product> products)
        {
            InitializeComponent();
            this.products = products;
        }

        private void ViewByProductCategoryList(object sender, RoutedEventArgs e)
        {
            string Prod_Category = string.Empty;
            Prod_Category = UIViewByProductCategoryId.Text;
            List<Product> productsbycategory = new List<Product>();
            
            if (Prod_Category != string.Empty)
            {
                foreach(Product matchProductforCategory in products)
                {
                    if (matchProductforCategory.ProductCategory.Trim().ToUpper() == Prod_Category.Trim().ToUpper())
                    productsbycategory.Add(matchProductforCategory);
                    
                }

                if (productsbycategory != null)
                {
                    ShowSaveProduct showSaveProductByCategory = new ShowSaveProduct(productsbycategory);
                    showSaveProductByCategory.Show();
                }
                else
                {

                    MessageBox.Show("No Product Category found. Please enter a valid category.");
                }
            }
            else MessageBox.Show("Please enter a valid Product Category");


        }
    }
}
