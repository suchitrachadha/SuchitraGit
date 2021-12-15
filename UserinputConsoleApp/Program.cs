using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
**************************************************************************************
   Created static List of names on 10 december 2021 by Suchitra
   Modified to include Dynamic List of names on 13 december 2021 by Suchitra
   Modified to Add new user and remove user on 14 december 2021 by Suchitra
***************************************************************************************
*/
public class User: IEquatable<User>
    {
        public string UserName { get; set; }
        public int UserId { get; set; }
        
        public override string ToString()
        {
        
           return "User ID: " + UserId + "   Name: " + UserName;
           
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            User objAsUser = obj as User;
            if (objAsUser == null) return false;
            else return Equals(objAsUser);
        }
        public override int GetHashCode()
        {
            return UserId;
        }

        public bool Equals(User other)
        {
            if (other == null) return false;
            return (this.UserId.Equals(other.UserId));
        }
        
    }
public class Particpant
{
    public static void Main()
    {
        // Create a list of users.
        List<User> users = new List<User>();
        // variable to capture number of users 
        int No_Names;   
        Console.WriteLine("Enter Number of Names");
        No_Names = int.Parse(Console.ReadLine());

       // Capturing names dynamically 
        for (int i = 1; i <= No_Names; i++)
        {           
              Console.WriteLine($"Enter User Name {i}");
              users.Add(new User() {UserName = Console.ReadLine(), UserId = 1000 + i});              
        }

        // Write out the users in the list. This will call the overridden ToString method
        // in the User class.
        Console.WriteLine();
        foreach (User singleUser in users)
        {
        
                        Console.Write(singleUser + "  Position: ");
                        Console.WriteLine(users.FindIndex(x=>x.UserName == singleUser.UserName));
        
        }

         // To capture the new position for the new user.
         Console.WriteLine("Please enter the position you want to add in");
         // Variable for the new position
         int NewPosition;
         NewPosition = int.Parse(Console.ReadLine());

         // To capture the new User Name
         Console.WriteLine("Please enter the User Name you want to add");
         // Insert the new User in the position entered
         users.Insert(NewPosition, new User(){UserName = Console.ReadLine(), UserId = 2000});
         
        // Display User Names, User IDs and Position in the list
        foreach (User singleUser in users)
        {
            
            Console.Write(singleUser + "  Position: ");
            Console.WriteLine(users.FindIndex(x=>x.UserName == singleUser.UserName));
        
        }

        // 14 december 2022 - To remove User Name from the position entered
        // Enter the position where the user needs to be removed
        Console.WriteLine("Enter the Position to be removed");
        users.RemoveAt(int.Parse(Console.ReadLine()));
        Console.WriteLine();
        foreach (User singleUser in users)
        {
            //Console.WriteLine(singleUser);
            Console.Write(singleUser + "  Position: ");
            Console.WriteLine(users.FindIndex(x=>x.UserName == singleUser.UserName));
        }

    }
}