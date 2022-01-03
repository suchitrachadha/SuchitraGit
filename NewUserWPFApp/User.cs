using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewUserWPFApp
{
   
    public class User
    {
        public int UserPosition { get; set; }
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string GoalDesc { get; set; }
        

        public override string ToString()
        {
            return "User Position " + UserPosition + " First Name " + FirstName + "  Last Name: " + LastName + "  Email Address:" + EmailAddress + "  Goal:" + GoalDesc + "  UserId:" + UserId;
        }

        
    }
}
