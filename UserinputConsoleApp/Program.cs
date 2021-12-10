﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

/*
 Windows Console Application using List<> to capture and display User Information 
 Created by: Suchitra
 Date: 10 December 2022
*/


namespace UserInputListConsoleApp
{
    using System;
    using System.Collections.Generic;
    // Simple business object. A UserId is used to identify the type of user
    // but the user name can change.
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
    // Should also override == and != operators.
    }
public class Example
{
    public static void Main()
    {
        // Create a list of users.
        List<User> users = new List<User>();

        // Add users to the list.
        users.Add(new User() { UserName = "Suchitra", UserId = 1000 });
        users.Add(new User() { UserName = "Annie", UserId = 1001 });
        users.Add(new User() { UserName = "Malin", UserId = 1012 });
        users.Add(new User() { UserName = "Karin", UserId = 1023 });
        users.Add(new User() { UserName = "Pernilla", UserId = 1005 });
        users.Add(new User() { UserName = "Lena", UserId = 1007 });

        // Write out the users in the list. This will call the overridden ToString method
        // in the User class.
        Console.WriteLine();
        foreach (User singleUser in users)
        {
            Console.WriteLine(singleUser);
        }

        // Check the list for user #1005. This calls the IEquatable.Equals method
        // of the User class, which checks the UserId for equality.
        Console.WriteLine("\nContains(\"1005\"): {0}",
        users.Contains(new User { UserId = 1734, UserName = "" }));

        // Insert a new item at position 2.
        Console.WriteLine("\nInsert(2, \"1007\")");
        users.Insert(2, new User() { UserName = "Ing-Marie", UserId = 1800 });

        //Console.WriteLine();
        foreach (User singleUser in users)
        {
            Console.WriteLine(singleUser);
        }

        Console.WriteLine("\nUsers[3]: {0}", users[3]);

        Console.WriteLine("\nRemove(\"1800\")");

        // This will remove user 1012 even though the UserName is different,
        // because the Equals method only checks UserId for equality.
        users.Remove(new User() { UserId = 1012, UserName = "Malin" });

        Console.WriteLine();
        foreach (User singleUser in users)
        {
            Console.WriteLine(singleUser);
        }
        Console.WriteLine("\nRemoveAt(3)");
        // This will remove the User at index 3.
        users.RemoveAt(3);

        Console.WriteLine();
        foreach (User singleUser in users)
        {
            Console.WriteLine(singleUser);
        }
}
}
}