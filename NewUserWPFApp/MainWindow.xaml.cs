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

namespace NewUserWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
  
    
    public partial class MainWindow : Window
    {
        public static List<User> users = new List<User>();
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void CheckRadioSelection(object sender, RoutedEventArgs e)
        {  
            if (sender.ToString().Contains("Create")==true)
            {
                CreateUser.Foreground = Brushes.Blue;
                CreateUser.Background = Brushes.Yellow;
                RemoveUser.Foreground = Brushes.Black;
                RemoveUser.Background = Brushes.White;
                InsertUser.Foreground = Brushes.Black;
                InsertUser.Background = Brushes.White;
                ShowSaveUserCheck.Foreground = Brushes.Black;
                ShowSaveUserCheck.Background = Brushes.White;
            }

            if (sender.ToString().Contains("Remove") == true)
            {
                
                CreateUser.Foreground = Brushes.Black;
                CreateUser.Background = Brushes.White;
                RemoveUser.Foreground = Brushes.Blue;
                RemoveUser.Background = Brushes.Yellow;
                InsertUser.Foreground = Brushes.Black;
                InsertUser.Background = Brushes.White;
                ShowSaveUserCheck.Foreground = Brushes.Black;
                ShowSaveUserCheck.Background = Brushes.White;
            }
            if (sender.ToString().Contains("Insert") == true)
            {
                CreateUser.Foreground = Brushes.Black;
                CreateUser.Background = Brushes.White;
                RemoveUser.Foreground = Brushes.Black;
                RemoveUser.Background = Brushes.White;
                InsertUser.Foreground = Brushes.Blue;
                InsertUser.Background = Brushes.Yellow;
                ShowSaveUserCheck.Foreground = Brushes.Black;
                ShowSaveUserCheck.Background = Brushes.White;
            }
            if (sender.ToString().Contains("Show") == true)
            {
                CreateUser.Foreground = Brushes.Black;
                CreateUser.Background = Brushes.White;
                RemoveUser.Foreground = Brushes.Black;
                RemoveUser.Background = Brushes.White;
                InsertUser.Foreground = Brushes.Black;
                InsertUser.Background = Brushes.White;
                ShowSaveUserCheck.Foreground = Brushes.Blue;
                ShowSaveUserCheck.Background = Brushes.Yellow;
            } 
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            if (CreateUser.IsChecked == true)
            {
                AddUser AddUserWindow = new AddUser(users);
                AddUserWindow.Show();
            }
            else if (ShowSaveUserCheck.IsChecked == true)
            {
                NewUserWPFApp.Handlers.ShowSaveUser ShowSaveWindow = new NewUserWPFApp.Handlers.ShowSaveUser(users);
                ShowSaveWindow.Show();

            }
            else if (RemoveUser.IsChecked == true)
            {

                NewUserWPFApp.Handlers.RemoveUser RemoveUserWindow = new NewUserWPFApp.Handlers.RemoveUser(users);
                RemoveUserWindow.Show();
            }

            else if (InsertUser.IsChecked == true)
            {
                NewUserWPFApp.Handlers.InsertUser InsertUserWindow = new NewUserWPFApp.Handlers.InsertUser(users);
                InsertUserWindow.Show();
             }

           
            else MessageBox.Show("Please select any option.");
        }

       
    }
}
