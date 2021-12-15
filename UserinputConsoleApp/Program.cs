﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

/****************************************************************************
Program created to provide Menu for different Operations Like
1. Add User 2. Remove User 3. Show Users  4. Insert User 5. Exit
Created on: 15 December 2021
Created by: Suchitra Chadha
/***************************************************************************/

static class Program
{
 static void Main()
  {

     User NewUser = new User();
     List<User> users = new List<User>();
     int choice = 0;

     while (choice != 5)
     {

         Console.WriteLine("Menu");
         Console.WriteLine("Please select any option");
         Console.WriteLine("1. Add User");
         Console.WriteLine("2. Remove User");
         Console.WriteLine("3. Show Users");
         Console.WriteLine("4. Insert User");
         Console.WriteLine("5. Exit");

         choice = int.Parse(Console.ReadLine());
         
         switch (choice)
         {

            case 1: 
                int No_Users;
                Console.WriteLine("Please enter the number of users you wish to add");
                No_Users = int.Parse(Console.ReadLine());
                

                for(int i= 1; i <= No_Users; i++)
                {
                  Console.WriteLine($"******User No.{i}******");
                  Console.WriteLine("Please enter First Name");
                  string varFirstName = Console.ReadLine();
                  Console.WriteLine(" ");

                  Console.WriteLine("Please enter Last Name");
                  string varLastName = Console.ReadLine();
                  Console.WriteLine(" ");

                  Console.WriteLine("Please enter Email address");
                  string varEmailAddr = Console.ReadLine();
                  Console.WriteLine(" ");

                  Console.WriteLine("Please enter the Goal");
                  string varGoalDesc = Console.ReadLine();
                  Console.WriteLine();            
                // Adding Users to the List
                  users.Add(new User() {FirstName = varFirstName, LastName = varLastName, EmailAddr = varEmailAddr, GoalDesc = varGoalDesc, UserId = Guid.NewGuid().ToString("N")});
                  Console.WriteLine(" ");
                }
                  break;

                case 2:
                  // Remove User at a given position
                  int Remove_Position;
                  Console.WriteLine("Please enter the Position to be removed");
                  Remove_Position = int.Parse(Console.ReadLine());
                  users.RemoveAt(Remove_Position);
                  Console.WriteLine();
                  foreach (User singleUser in users)
                  {
                    int Remove_Index = users.FindIndex(x=>x.UserId == singleUser.UserId);
                    Console.WriteLine($"******User No.{Remove_Index}******");
                    Console.Write(singleUser);
                    Console.WriteLine("***************************************************");
                  }
                  break;

                case 3:
    
                   Console.WriteLine("User List is as follows:");
                   foreach (User singleUser in users)
                   {
                      int ShowUserIndex = users.FindIndex(x=>x.UserId == singleUser.UserId);
                      Console.WriteLine($"******User No.{ShowUserIndex}******");
                      Console.WriteLine(singleUser);
                      Console.WriteLine("***************************************************");
                  }
                  break;

                  case 4:
                   // To capture the insert position for the new user.
                   Console.WriteLine("Please enter the position you want to insert the user in");
                   // Variable for the new position
                  int NewPosition;
                  NewPosition = int.Parse(Console.ReadLine());

                  // To capture the new User Name
                  Console.WriteLine("Please enter the User details");
                  Console.WriteLine("Please enter the First Name");
                  string newFirstName = Console.ReadLine();
                  Console.WriteLine("Please enter Last Name");
                  string newLastName = Console.ReadLine();
                  Console.WriteLine("Please enter Email address");
                  string newEmailAddr = Console.ReadLine();
                  Console.WriteLine("Please enter Goal Description");
                  string newGoalDesc = Console.ReadLine();
                  // Insert the new User in the position entered
                  users.Insert(NewPosition, new User() {FirstName = newFirstName, LastName = newLastName, EmailAddr = newEmailAddr, GoalDesc = newGoalDesc, UserId = Guid.NewGuid().ToString("N")});
                  Console.WriteLine(" ");
                  Console.WriteLine(" The Updated list is as follows:");
         
                  // Display User Names, User IDs and Position in the list
                  foreach (User singleUser in users)
                  {
                    int UserIndex = users.FindIndex(x=>x.UserId == singleUser.UserId);
                    Console.WriteLine($"******User No.{UserIndex}******");
                    Console.Write(singleUser);
                    Console.WriteLine("***************************************************");
                  }
                  break;

              case 5:
                  
                    break;
              
              default:
              
                    Console.WriteLine("Sorry, invalid selection");
                    break;

         }

     }

  }

  public class User : IEquatable<User>
  {
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public string EmailAddr {get; set;}
    public string GoalDesc {get; set;}

    public String UserId {get; set;}

    

   public override string ToString()
     {
            return "First Name " + FirstName + "  Last Name: " + LastName + "  Email Address:" + EmailAddr + "  Goal:" + GoalDesc +  "  UserId:" + UserId ;
      }

      public override bool Equals(object obj)
        {
            if (obj == null) return false;
            User objAsUser = obj as User;
            if (objAsUser == null) return false;
            else return Equals(objAsUser);
        }

     
       public string generateID()
      {
        return Guid.NewGuid().ToString("N");
          
      }


        public bool Equals(User other)
        {
            if (other == null) return false;
            return (this.UserId.Equals(other.UserId));
        }
     
  }



}