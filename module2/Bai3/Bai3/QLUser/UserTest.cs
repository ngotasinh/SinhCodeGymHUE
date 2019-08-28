using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Bai3.QLUser
{
    public class UserTest
    {
        public static Dictionary<int, User> PhoneList = new Dictionary<int,User>();
        public static int Id = 0;
        public static void Main()
        {
            InitMenu();
        }
        public static void InitMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("*******************************************************");
                Console.WriteLine("USER MANAGEMENT SYSTEM");
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Check User");
                Console.WriteLine("3. Display all Users");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Please select an option");
                Console.Write("Option: ");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }
            }
            while (option > 4 || option <= 0);
            Process(option);
        }
        public static void Process(int selected)
        {
            switch (selected)
            {
                case 1:
                    {
                        AddUser();
                        break;
                    }
                case 2:
                    {
                        CheckUser();
                        break;
                    }
                case 3:
                    {
                        DispLay();
                        break;
                    }
                case 4:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            InitMenu();
        }
        public static void AddUser()
        {
            User user = new User();
            Id += 1;
            user.ID = Id;
            Console.Write("Input the Name:  ");
            user.Name = Console.ReadLine();
            Console.Write("Input a Password:  ");
            user.Password= Console.ReadLine();
            var phoneNumber = 0;
            do
            {
                Console.Write("Input a PhoneNumber:  ");
                if (int.TryParse(Console.ReadLine(), out phoneNumber))
                {
                    if (phoneNumber > 0)
                    {
                        user.phoneList.Add(phoneNumber);
                    }
                }
            }
            while (phoneNumber > 0);
            
            PhoneList.Add(Id, user);
        }
        public static void CheckUser()
        {
            Console.WriteLine("**********CheckUser User*************");
            Console.Write("Input Name:  ");
            string checkName = Console.ReadLine();
            Console.Write("Input Password:  ");
            string checkPassword = Console.ReadLine();
            var isExit = false;
            foreach(KeyValuePair<int,User> item in PhoneList)
            {
                if (item.Value.Name == checkName && item.Value.Password == checkPassword)
                {
                    isExit = true;
                    break;
                }               
            }
            if (isExit)
            {
                Console.WriteLine("User Checked.");
            }
            else
            {
                Console.WriteLine("User not found");
            }
        }
        public static void DispLay()
        {
            foreach (KeyValuePair<int, User> item in PhoneList)
            {
                Console.WriteLine(item.Value.Info());
            }
        }
    }
}
