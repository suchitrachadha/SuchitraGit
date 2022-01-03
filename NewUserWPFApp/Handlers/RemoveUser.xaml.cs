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
    /// Interaction logic for RemoveUser.xaml
    /// </summary>
    public partial class RemoveUser : Window
    {
        public List<User> users = new List<User>();
        public RemoveUser()
        {
            InitializeComponent();
        }

        public RemoveUser(List<User> users)
        {
            InitializeComponent();
            this.users = users;
        }

        private void RemoveUserFromList(object sender, RoutedEventArgs e)
        {
            string RemoveUserId;
            RemoveUserId = String.Empty;
            RemoveUserId = UIRemoveUserId.Text;

            if (users.Count == 0) MessageBox.Show("No Users to be removed.");
            else
            { 
                int Remove_Index = users.FindIndex(x => x.UserId.ToString().Trim().ToUpper() == RemoveUserId.Trim().ToUpper());
            
                if (Remove_Index != -1)
                { 
                    string UserDetailString = RemoveUserId + " - " + users[Remove_Index].FirstName + " " + users[Remove_Index].LastName + " with Email address: " + users[Remove_Index].EmailAddress + " and Goal: " + users[Remove_Index].GoalDesc;
                
                    if (MessageBox.Show("Are you sure you want to remove User with ID and details ? " + UserDetailString, "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                    {
                        users.RemoveAt(Remove_Index);
                        MessageBox.Show("User with User ID " + RemoveUserId + " is removed");
                        UIRemoveUserId.Text = "";
                    }
                   else MessageBox.Show("Please enter the correct User Id to be removed");
                }
            
            else MessageBox.Show("Please enter the correct User Id");
            }
        }
    }
}
