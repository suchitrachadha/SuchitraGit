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
using System.Windows.Navigation;
using System.Windows.Shapes;
using NewWPFProductApp;

namespace NewWPFProductApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    /******************************************
     * Created by Suchitra Chadha
     * Created on 5 January 2022
     * WPF application to create,remove, view Products,
     * View By Product Category, View any Product and 
     * Save Product List
     * ****************************************/
    public partial class MainWindow : Window
    {
        public static List<Product> products = new List<Product>();
        public MainWindow()
        {
            InitializeComponent();

        }
        private void CheckRadioSelection(object sender, RoutedEventArgs e)
        {
            if (sender.ToString().Contains("Create") == true)
            {
                CreateProduct.Foreground = Brushes.Blue;
                CreateProduct.Background = Brushes.Yellow;
                RemoveProduct.Foreground = Brushes.Black;
                RemoveProduct.Background = Brushes.White;
                ViewProduct.Foreground = Brushes.Black;
                ViewProduct.Background = Brushes.White;
                ShowSaveProductList.Foreground = Brushes.Black;
                ShowSaveProductList.Background = Brushes.White;
                ViewByProductCategory.Foreground = Brushes.Black;
                ViewByProductCategory.Background = Brushes.White;
                FileSave.Foreground = Brushes.Black;
                FileSave.Background = Brushes.White;
            }

            if (sender.ToString().Contains("Remove") == true)
            {

                CreateProduct.Foreground = Brushes.Black;
                CreateProduct.Background = Brushes.White;
                RemoveProduct.Foreground = Brushes.Blue;
                RemoveProduct.Background = Brushes.Yellow;
                ViewProduct.Foreground = Brushes.Black;
                ViewProduct.Background = Brushes.White;
                ShowSaveProductList.Foreground = Brushes.Black;
                ShowSaveProductList.Background = Brushes.White;
                ViewByProductCategory.Foreground = Brushes.Black;
                ViewByProductCategory.Background = Brushes.White;
                FileSave.Foreground = Brushes.Black;
                FileSave.Background = Brushes.White;
            }
            if (sender.ToString().Contains("View") == true)
            {
                CreateProduct.Foreground = Brushes.Black;
                CreateProduct.Background = Brushes.White;
                RemoveProduct.Foreground = Brushes.Black;
                RemoveProduct.Background = Brushes.White;
                ViewProduct.Foreground = Brushes.Blue;
                ViewProduct.Background = Brushes.Yellow;
                ShowSaveProductList.Foreground = Brushes.Black;
                ShowSaveProductList.Background = Brushes.White;
                ViewByProductCategory.Foreground = Brushes.Black;
                ViewByProductCategory.Background = Brushes.White;
                FileSave.Foreground = Brushes.Black;
                FileSave.Background = Brushes.White;
            }
            if (sender.ToString().Contains("Show") == true)
            {
                CreateProduct.Foreground = Brushes.Black;
                CreateProduct.Background = Brushes.White;
                RemoveProduct.Foreground = Brushes.Black;
                RemoveProduct.Background = Brushes.White;
                ViewProduct.Foreground = Brushes.Black;
                ViewProduct.Background = Brushes.White;
                ShowSaveProductList.Foreground = Brushes.Blue;
                ShowSaveProductList.Background = Brushes.Yellow;
                ViewByProductCategory.Foreground = Brushes.Black;
                ViewByProductCategory.Background = Brushes.White;
                FileSave.Foreground = Brushes.Black;
                FileSave.Background = Brushes.White;
            }
            if (sender.ToString().Contains("Category") == true)
            {
                CreateProduct.Foreground = Brushes.Black;
                CreateProduct.Background = Brushes.White;
                RemoveProduct.Foreground = Brushes.Black;
                RemoveProduct.Background = Brushes.White;
                ViewProduct.Foreground = Brushes.Black;
                ViewProduct.Background = Brushes.White;
                ShowSaveProductList.Foreground = Brushes.Black;
                ShowSaveProductList.Background = Brushes.White;
                ViewByProductCategory.Foreground = Brushes.Blue;
                ViewByProductCategory.Background = Brushes.Yellow;
                FileSave.Foreground = Brushes.Black;
                FileSave.Background = Brushes.White;
            }
            if (sender.ToString().Contains("File") == true)
            {
                CreateProduct.Foreground = Brushes.Black;
                CreateProduct.Background = Brushes.White;
                RemoveProduct.Foreground = Brushes.Black;
                RemoveProduct.Background = Brushes.White;
                ViewProduct.Foreground = Brushes.Black;
                ViewProduct.Background = Brushes.White;
                ShowSaveProductList.Foreground = Brushes.Black;
                ShowSaveProductList.Background = Brushes.White;
                ViewByProductCategory.Foreground = Brushes.Black;
                ViewByProductCategory.Background = Brushes.White;
                FileSave.Foreground = Brushes.Blue;
                FileSave.Background = Brushes.Yellow;
            }
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            if (CreateProduct.IsChecked == true)
            {
                NewWPFProductApp.Handlers.AddProduct AddProductWindow = new NewWPFProductApp.Handlers.AddProduct(products);
                AddProductWindow.Show();
            }
            else if (ShowSaveProductList.IsChecked == true)
            {
                NewWPFProductApp.Handlers.ShowSaveProduct ShowSaveWindow = new NewWPFProductApp.Handlers.ShowSaveProduct(products);
                ShowSaveWindow.Show();

            }
            else if (RemoveProduct.IsChecked == true)
            {

                NewWPFProductApp.Handlers.RemoveProduct RemoveProductWindow = new NewWPFProductApp.Handlers.RemoveProduct(products);
                RemoveProductWindow.Show();
            }

            else if (ViewProduct.IsChecked == true)
            {
                NewWPFProductApp.Handlers.ViewProduct ViewProductWindow = new NewWPFProductApp.Handlers.ViewProduct(products);
                ViewProductWindow.Show();
            }

            else if (ViewByProductCategory.IsChecked == true)
            {
                NewWPFProductApp.Handlers.ViewProductByCategory ViewProductByCategoryWindow = new NewWPFProductApp.Handlers.ViewProductByCategory(products);
                ViewProductByCategoryWindow.Show();
            }
            else if (FileSave.IsChecked == true)
            {
                NewWPFProductApp.Handlers.FileSave FileSaveWindow = new NewWPFProductApp.Handlers.FileSave(products);
                FileSaveWindow.Show();
            }


            else MessageBox.Show("Please select any option.");
        }


    }
}
