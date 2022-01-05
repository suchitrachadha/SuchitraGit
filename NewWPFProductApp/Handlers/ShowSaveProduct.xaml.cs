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
    /// Interaction logic for ShowSaveProduct.xaml
    /// </summary>
    public partial class ShowSaveProduct : Window
    {
        public List<Product> products = new List<Product>();
        
        public ShowSaveProduct()
        {
            InitializeComponent();
        }

        public ShowSaveProduct(List<Product> products)
        {
            InitializeComponent();
            this.products = products;
            if (products.Count > 0)
            {
                ShowSaveDataGrid.ItemsSource = products;
                NumberofProducts.Content = "Total Number of Products: " + products.Count();
            }
            else MessageBox.Show("There are no products to be shown.");

        }


    }
}
