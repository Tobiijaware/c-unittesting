using System;
using UnderstandingTestingandDI.Lib.Core;

namespace UnderstandingTestingandDI
{
    class Program
    {
        static void Main(string[] args)
        {
            GlobalConfig.AddIinstance();
            var UserService = GlobalConfig.UserService;
            var UserRepository = GlobalConfig.UserRepository;

            Console.WriteLine("WELCOME\n");
            Console.WriteLine("TO REGISTER PRESS 1, TO LOGIN PRESS 2, TO GET USER PRESS 3\n");

            var input = int.Parse(Console.ReadLine());

            while (input != 1 && input !=2 && input != 3)
            {
                Console.Clear();
                Console.WriteLine("Invalid Input\n");
                input = int.Parse(Console.ReadLine());
            }

            if (input == 1)
            {
                string firstname = "Tobi";
                string lastname = "Ijaware";
                string email = "Tobi@gmail.com";
                string password = "12345";



                try
                {
                    var success = UserService.Registration(firstname, lastname, email, password);
                    if (success)
                    {
                        Console.WriteLine("Registration Successful");
                    }
                }catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
             
            }
            else if(input == 2)
            {
                try
                {
                    Console.Clear();
                    string email = "Tobi@gmail.com";
                    string password = "12345";
                    var success = UserService.Login(email, password);
                    if(success == true)
                    {
                        Console.WriteLine("You are Logged IN");
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }
            else if (input == 3)
            {
                try
                {
                    Console.Clear();
                    var firstname = "Tobi";
                    var user = UserRepository.Get(firstname);

                    if (user == null)
                    {
                        Console.WriteLine("No Record Found");
                    }
                    else
                    {
                        Console.WriteLine($"{user.FirstName} {user.LastName}");
                    }
                   
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
