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
    /// Interaction logic for RemoveProduct.xaml
    /// </summary>
    public partial class RemoveProduct : Window
    {
        public List<Product> products = new List<Product>();
        public RemoveProduct()
        {
            InitializeComponent();
        }

        public RemoveProduct(List<Product> products)
        {
            InitializeComponent();
            this.products = products;
        }

        private void RemoveProductFromList(object sender, RoutedEventArgs e)
        {
            string RemoveProductId;
            RemoveProductId = String.Empty;
            RemoveProductId = UIRemoveProductId.Text;

            if (products.Count == 0) MessageBox.Show("No Products to be removed.");
            else
            {
                int Remove_Index = products.FindIndex(x => x.ProductId.ToString().Trim().ToUpper() == RemoveProductId.Trim().ToUpper());

                if (Remove_Index != -1)
                {
                    string ProductDetailString = RemoveProductId + " - " + products[Remove_Index].ProductName + "  with Product Category: " + products[Remove_Index].ProductCategory + " and Product Price: " + products[Remove_Index].ProductPrice;

                    if (MessageBox.Show("Are you sure you want to remove Product with ID and details ? " + ProductDetailString, "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                    {
                        products.RemoveAt(Remove_Index);
                        MessageBox.Show("Product with Product ID " + RemoveProductId + " is removed");
                        UIRemoveProductId.Text = "";
                    }
                    else MessageBox.Show("Please enter the correct Product Id to be removed");
                }

                else MessageBox.Show("Please enter the correct Product Id");
            }
        }
    }
}
