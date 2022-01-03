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
    /// Interaction logic for InsertUser.xaml
    /// </summary>
    public partial class InsertUser : Window
    {
        public List<User> users = new List<User>();
        public InsertUser()
        {
            InitializeComponent();
        }

        public InsertUser(List<User> users)
        {
            InitializeComponent();
            this.users = users;

        }

        private void InsertUserToList(object sender, RoutedEventArgs e)
        {
            try
            {
                int InsertPosition = int.Parse(UIInsertPosition.Text);
                if (InsertPosition > users.Count) MessageBox.Show("Please enter valid User Position.");
                else
                {
                    User newInsertUser = new User();

                    newInsertUser.FirstName = "";
                    newInsertUser.LastName = "";
                    newInsertUser.EmailAddress = "";
                    newInsertUser.GoalDesc = "";

                    newInsertUser.FirstName = UIInsertFirstName.Text;
                    newInsertUser.LastName = UIInsertLastName.Text;
                    newInsertUser.EmailAddress = UIInsertEmailAddr.Text;
                    newInsertUser.GoalDesc = UIInsertGoalDesc.Text;

                    newInsertUser.UserId = Guid.NewGuid();
                    newInsertUser.UserPosition = InsertPosition;

                    users.Insert(InsertPosition, newInsertUser);
                    int i = 0;

                    foreach (User reorderUser in users)
                    {
                        reorderUser.UserPosition = i;
                        i++;

                    }

                    string FullName = newInsertUser.FirstName + " " + newInsertUser.LastName;
                    MessageBox.Show("User " + FullName + " has been inserted at position " + UIInsertPosition.Text + " in the list.");
                    ClearForm(sender, e);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Please enter a valid value.");

            }

        }

        private void ClearForm(object sender, RoutedEventArgs e)
        {
            UIInsertPosition.Text = "";
            UIInsertFirstName.Text = "";
            UIInsertLastName.Text = "";
            UIInsertEmailAddr.Text = "";
            UIInsertGoalDesc.Text = "";
            
        }
    }
    
}
