﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;



/****************************************************************************
***15 December 2021*** Author: Suchitra 
Program created to provide Menu for different Operations Like
1. Add User 2. Remove User 3. Show/Save Users  4. Insert User 5. Generate Discount code 6. Exit

***16 December 2021*** Author: Suchitra 
-Modified to do validations and handle exceptions.
-Modified to include writing the user list to text file.

***17 December 2021*** Author: Suchitra
-Modified to remove hardcoding of file name and generating unique filename.
-Modified to include Generate Discount Code in the menu and functionality.
/***************************************************************************/

static class Program
{
 static void Main()
  {

     User NewUser = new User();
     List<User> users = new List<User>();
     int choice = 0;

           
      while (choice != 6)
      {
          try
        {

            Console.WriteLine("Menu");
            Console.WriteLine("Please select any option");
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. Remove User");
            Console.WriteLine("3. Show/Save Users");
            Console.WriteLine("4. Insert User");
            Console.WriteLine("5. Generate a discount code");
            Console.WriteLine("6. Exit");
         

            choice = int.Parse(Console.ReadLine());
            
              switch (choice)
            {

              case 1:

                try{  
            
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
                    Console.WriteLine("New User " + varFirstName + " " + varLastName + " is created");
                    Console.WriteLine(" ");
                  }
                  
              }
            catch (Exception ex)
              {
                Console.WriteLine("Error Message: " + ex.Message);
                Console.WriteLine("Sorry, Please enter a valid format");
                  
              }
              break;


            case 2:
             try
              {
                // To check if request is to remove from list with no users.
                if(users.Count == 0) Console.WriteLine("There are no users to be removed.");
                else
                {
                   // Remove User at a given position
                   int Remove_Position;
                   Console.WriteLine("Please enter the Position to be removed");
                   Remove_Position = int.Parse(Console.ReadLine());
                   users.RemoveAt(Remove_Position);
                   Console.WriteLine(" ");
                   Console.WriteLine("User at position " + Remove_Position + " removed.");
                   Console.WriteLine("The updated list is as follows:");
                   Console.WriteLine(" ");
                   foreach (User singleUser in users)
                    {
                      int Remove_Index = users.FindIndex(x=>x.UserId == singleUser.UserId);
                      Console.WriteLine($"******User No.{Remove_Index}******");
                      Console.Write(singleUser);
                      Console.WriteLine("***************************************************");
                    }
                  }
                }
              catch (Exception ex)
              {
                  Console.WriteLine("Error message: " + ex.Message);
                  if(users.Count == 1)
                  {
                    Console.WriteLine("Please enter 0 as there is just 1 user.");
                    
                  }
                  else
                  {
                    Console.WriteLine("Please enter a valid number.Contact the administrator");
                  }

               }
              break;

          case 3:
            try
              {   
                  // Case where there are no users in the list and still the request to show users is fired. 
                  if(users.Count == 0) Console.WriteLine("There are no users to be displayed.");
                  else
                  {
                      Console.WriteLine("User List is as follows:");
                      foreach (User singleUser in users)
                      {
                        int ShowUserIndex = users.FindIndex(x=>x.UserId == singleUser.UserId);
                        Console.WriteLine($"******User No.{ShowUserIndex}******");
                        Console.WriteLine(singleUser);
                        Console.WriteLine("***************************************************");
                      }
                      // To save List to a text file
                      Console.WriteLine(" ");
                      try
                      {
                        Console.WriteLine("Do you want to save the list to a text file? Please enter Y or N");
                        string saveFile = (Console.ReadLine()).TrimEnd();
                      
                        if (saveFile.ToUpper() == "Y") 
                        {
                          int varTemp = 0;
                          var timeStamp = DateTime.Now.ToFileTime();
                          
                          foreach (User singleUser in users)
                          {
                            if(varTemp == 0)
                        
                            System.IO.File.WriteAllText(timeStamp + ".txt", (singleUser.ToString() + Environment.NewLine));
                            else
                            System.IO.File.AppendAllText(timeStamp + ".txt", (singleUser.ToString() + Environment.NewLine));
                            varTemp = varTemp + 1;
                          }
                          Console.WriteLine("User List has been saved in file " + timeStamp + ".txt");
                        }
                      }
                      catch (Exception ex)
                      {
                        Console.WriteLine("Error Message: " + ex.Message);
                        Console.WriteLine("Please enter Y or N");  

                      }
                      
                  }
              }
            catch(Exception ex)
              {
                    Console.WriteLine("Error Message: " + ex.Message);
                    Console.WriteLine("There is an error displaying list. Contact administrator.");

              }
              break;

          case 4:
            try
              {
                    // If the list has no users, then client should choose Add User instead of Insert
                    if(users.Count == 0) Console.WriteLine("Please select Add option to create users");
                    else
                    {
                      // To capture the insert position for the new user.
                      Console.WriteLine("Please enter the position you want to insert the user in");
                      // Variable for the new position
                      int NewPosition;
                      NewPosition = int.Parse(Console.ReadLine());

                      // compare NewPosition with List length
                      if(NewPosition > users.Count || NewPosition < 0) Console.WriteLine("Please enter a valid position");
                      else
                      {
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
                        Console.WriteLine("New User at position " + NewPosition + " inserted.");
                        Console.WriteLine(" The Updated list is as follows:");
         
                        // Display User Names, User IDs and Position in the list
                        foreach (User singleUser in users)
                        {
                          int UserIndex = users.FindIndex(x=>x.UserId == singleUser.UserId);
                          Console.WriteLine($"******User No.{UserIndex}******");
                          Console.Write(singleUser);
                          Console.WriteLine("***************************************************");
                        }
                    } // else
                  }
              }
              catch(Exception ex)
                {
                    Console.WriteLine("Error Message: " + ex.Message);
                    Console.WriteLine("Please enter a valid number. Contact the administrator");
                }
                  
               break;

              case 5:
               // Generating a unique discount code
               string uniqueCode = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
               Console.WriteLine("**Use discount code!** " + " CHRISTMAS 2022 " + uniqueCode);
               break;

              case 6:
                  
                break;
              
              default:
              
                Console.WriteLine("Sorry, invalid selection. Please contact the system administrator.");
                 break;

         } // switch
      
      } // try
      
    catch (Exception ex)
    {
      Console.WriteLine("Error Message: " + ex.Message);
      Console.WriteLine("Please enter a valid number from 1 to 5.");
    }
  } // while
        
  
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

        public override int GetHashCode()
        {
            return int.Parse(UserId);
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