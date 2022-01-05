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
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        public List<Product> products = new List<Product>();
        public AddProduct()
        {
            InitializeComponent();
        }

        public AddProduct(List<Product> products)
        {
            InitializeComponent();
            this.products = products;

        }

        private void AddProductToList(object sender, RoutedEventArgs e)
        {
            Product newProduct = new Product();

            newProduct.ProductName = UIProductName.Text;
            newProduct.ProductDescription = UIProductDescription.Text;
            newProduct.ProductCategory = UIProductCategory.Text;
            newProduct.ProductPrice = double.Parse(UIProductPrice.Text);
            newProduct.ProductId = Guid.NewGuid();
            
            products.Add(newProduct);
            MessageBox.Show("Product " + newProduct.ProductName + " has been created and added to the list.");
            ClearForm(sender, e);

        }

        private void ClearForm(object sender, RoutedEventArgs e)
        {
            UIProductName.Text = "";
            UIProductDescription.Text = "";
            UIProductCategory.Text = "";
            UIProductPrice.Text = "";
        }
    }
}
