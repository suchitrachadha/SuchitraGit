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


namespace NewUserWPFApp
{
    /// <summary>
    /// Interaction logic for AddUser.xaml
    /// </summary>
    public partial class AddUser : Window
    
    {
        public List<User> users = new List<User>();
      
        public AddUser()
        {
            InitializeComponent();
            

        }

        public AddUser(List<User> users)
        {
            InitializeComponent();
            this.users = users;
            
        }
        public void AddUserToList(object sender, RoutedEventArgs e)
        {
            User newUser = new User();

            newUser.FirstName = "";
            newUser.LastName = "";
            newUser.EmailAddress = "";
            newUser.GoalDesc = "";

            newUser.FirstName = UIFirstName.Text;
            newUser.LastName = UILastName.Text;
            newUser.EmailAddress = UIEmailAddr.Text;
            newUser.GoalDesc = UIGoalDesc.Text;
            newUser.UserId = Guid.NewGuid();

            
            newUser.UserPosition = users.Count;


            users.Add(newUser);
            string FullName = newUser.FirstName + " " + newUser.LastName;
            MessageBox.Show("User " + FullName + " has been created and added to the list.");
            ClearForm(sender, e);


        }

        private void ClearForm(object sender, RoutedEventArgs e)
        {
            UIFirstName.Text = "";
            UILastName.Text = "";
            UIEmailAddr.Text = "";
            UIGoalDesc.Text = "";
        }
    }
}
