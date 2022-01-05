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
    /// Interaction logic for ViewProduct.xaml
    /// </summary>
    public partial class ViewProduct : Window
    {
        public List<Product> products = new List<Product>();
        public ViewProduct()
        {
            InitializeComponent();
        }

        public ViewProduct(List<Product> products)
        {
            InitializeComponent();
            this.products = products;
        }

        private void ViewProductFromList(object sender, RoutedEventArgs e)
        {
            string ViewProductID = UIViewProductId.Text;
            int View_Index = products.FindIndex(x => x.ProductId.ToString().Trim().ToUpper() == ViewProductID.Trim().ToUpper());
            if (View_Index != -1)
            {
                ViewProductIDContent.Content = products[View_Index].ProductId.ToString();
                ViewProductName.Content = products[View_Index].ProductName;
                ViewProductDescription.Text = products[View_Index].ProductDescription;
                ViewProductCategory.Content = products[View_Index].ProductCategory;
                ViewProductPrice.Content = products[View_Index].ProductPrice;

                ViewProductIDLabel.Visibility = Visibility.Visible;
                ViewProductIDContent.Visibility = Visibility.Visible;

                ViewProductNameLabel.Visibility = Visibility.Visible;
                ViewProductName.Visibility = Visibility.Visible;

                ViewProductDescriptionLabel.Visibility = Visibility.Visible;
                ViewProductDescription.Visibility = Visibility.Visible;

                ViewProductCategoryLabel.Visibility = Visibility.Visible;
                ViewProductCategory.Visibility = Visibility.Visible;

                ViewProductPriceLabel.Visibility = Visibility.Visible;
                ViewProductPrice.Visibility = Visibility.Visible;

            }
            else
            {
                MessageBox.Show("Please enter the correct Product ID");
                ViewProductIDLabel.Visibility = Visibility.Hidden;
                ViewProductIDContent.Visibility = Visibility.Hidden;

                ViewProductNameLabel.Visibility = Visibility.Hidden;
                ViewProductName.Visibility = Visibility.Hidden;

                ViewProductDescriptionLabel.Visibility = Visibility.Hidden;
                ViewProductDescription.Visibility = Visibility.Hidden;

                ViewProductCategoryLabel.Visibility = Visibility.Hidden;
                ViewProductCategory.Visibility = Visibility.Hidden;

                ViewProductPriceLabel.Visibility = Visibility.Hidden;
                ViewProductPrice.Visibility = Visibility.Hidden;

            }

        }
    }
}
