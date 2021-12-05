using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4

{
    
    class program
    {
        static List<User> Users = new List<User>();
        static int auto_increment = 1;
        static void Main(string[] args)
        {
            bool exx = false;
             

            while (exx == false)
            {
                string name = Console.ReadLine();
                switch (name)
                {
                    case "exit":
                        exx = true;
                            break;

                    case "Add":
                        AddUser();
                        
                        break;
                        
                    case "list":
                        ShowUsers(); 

                        break;

                    case "edit":
                        EditUser(); 
                        break;

                    case "delete":
                        AddUser();

                        break;

                    case "save":
                        AddUser();

                        break;

                    case "load":
                        AddUser();

                        break;
                        
                }
            }
           

        }

        

        static void AddUser()
       {
           
            var name = Console.ReadLine();
            int.TryParse(Console.ReadLine(), out int age);
            User User = new User
            {
                Name = name,
                Age = age,
                Id = auto_increment++

            };
            Users.Add(User);
       }

        static void ShowUsers()
        {
            for (int i = 0; i < auto_increment; i++)
            {
                Console.WriteLine(Users[i]);   
            }
        }
         static void EditUser()
        {

        }
    }    
}                             
