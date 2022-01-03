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

namespace NewUserWPFApp.Handlers
{
    /// <summary>
    /// Interaction logic for ShowSaveUser.xaml
    /// </summary>
    public partial class ShowSaveUser : Window
    {
        public List<User> users = new List<User>();
        public ShowSaveUser()
        {
            InitializeComponent();
        
        }

        public ShowSaveUser(List<User> users)
        {
            InitializeComponent();
            this.users = users;

            if (users.Count > 0)
                ShowSaveDataGrid.ItemsSource = users;
            else MessageBox.Show("There are no users to be shown.");
            
        }

       
    }
}
