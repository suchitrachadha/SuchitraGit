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
using System.IO;

namespace NewWPFProductApp.Handlers
{
    /// <summary>
    /// Interaction logic for FileSave.xaml
    /// </summary>
   

    public partial class FileSave : Window
    {

        public List<Product> products = new List<Product>();
        public FileSave()
        {
            InitializeComponent();
        }

        public FileSave(List<Product> products)
        {
            InitializeComponent();
            this.products = products;
        }


        private void SaveProductListinFile(object sender, RoutedEventArgs e)
        {
            string FilePath = UIFilePathName.Text;
            try
            {
                if (products.Count() > 0)
                {
                    if (FilePath.ToString() != "")
                    {
                        Directory.CreateDirectory(FilePath);
                        var timeStamp = DateTime.Now.ToFileTime();
                        FilePath = FilePath + @"\" + timeStamp + ".txt";
                        int varTemp = 0;

                        foreach (Product singleProduct in products)
                        {
                            if (varTemp == 0)
                                System.IO.File.WriteAllText(FilePath, (singleProduct.ToString() + Environment.NewLine));
                            else
                                System.IO.File.AppendAllText(FilePath, (singleProduct.ToString() + Environment.NewLine));
                            varTemp = varTemp + 1;
                        }
                        MessageBox.Show("Product List has been saved in file " + FilePath);
                    }
                    else MessageBox.Show("Please enter a valid file name.");
                }
                else MessageBox.Show("There are no products to be saved. Please create Products");
            }
            catch
            {
                MessageBox.Show("Please enter a valid file name.");

            }
         }
    }
}
