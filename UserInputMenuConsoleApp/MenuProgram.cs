using System;
using System.Collections;
using System.Linq;
using System.exception;
using System.text;


static class MenuProgram
{
 static void Main(string FirstName, string LastName, string EmailAddr, string GoalDesc)
  {

     User NewUser = new User();
     int choice = 0;

     while (choice != 4)
     {

         Console.WriteLine("Menu");
         Console.WriteLine("Please select any option");
         Console.WriteLine("1. Add User");
         Console.WriteLine("2. Remove User");
         Console.WriteLine("3. Show Users");
         Console.WriteLine("4. Exit");

         choice = int.Parse(Console.ReadLine());
         {

            case 1: 
                Console.WriteLine("Please enter First Name");
                NewUser.FirstName = Console.ReadLine();
                UserFirstName = Console.ReadLine();
                Console.WriteLine(" ");

                Console.WriteLine("Please enter Last Name");
                NewUser.LastName = Console.ReadLine();
                UserLastName = Console.ReadLine();
                Console.WriteLine(" ");

                Console.WriteLine("Please enter Email address");
                NewUser.EmailAddr = Console.ReadLine();
                UserEmailAddr = Console.ReadLine();
                Console.WriteLine(" ");

                Console.WriteLine("Please enter the Goal");
                NewUser.GoalDesc = Console.ReadLine();
                UserGoalDesc = Console.ReadLine();
                Console.WriteLine();

                break;
        







         }





     }





  }

  class User
  {
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public string EmailAddr {get; set;}
    public string GoalDesc {get; set;}
 
    public List<string> UserList(User NewUser)
    {
       
       List<String> UserAdd = new List<string>();
       UserAdd.Add(NewUser.FirstName);
       String UserFirstName = NewUser.FirstName;

       UserAdd.Add(NewUser.LastName);
       String UserLastName = NewUser.LastName;

       UserAdd.Add(NewUser.EmailAddr);
       String UserEmailAddr = NewUser.EmailAddr;

       UserAdd.Add(NewUser.GoalDesc);
       String UserGoalDesc = NewUser.GoalDesc;

       return UserAdd;

    }

  }



}