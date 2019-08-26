using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Bai3.QLSinhVien
{
    public class StudentTest
    {
        public static ArrayList StudentList = new ArrayList();
        public static int id = 0;
       
        public static void Main()
        {
            InitMenu();
        }

        public static void InitMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("*******************************************");
                Console.WriteLine("STUDENTS MANAGEMENT SYSTEM");
                Console.WriteLine("1. Insert new Student");
                Console.WriteLine("2. View list of Students");
                Console.WriteLine("3. Search Students");
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
                        Console.WriteLine("Insert new Student.......");
                        CreateNew();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("View list of Sudent............");
                        DisPlayStudent();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Search Students...........");
                        SearchStudents();
                        break;
                    }
                case 4:
                default:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            InitMenu();
        }
        public static void CreateNew()
        {
            var student = new Student();
            id += 1;
            student.Id = id;
            Console.Write("Input FullName:  ");
            student.FullName = Console.ReadLine();

            Console.Write("Input DateofBirth:  ");
            student.DateofBirth = Console.ReadLine();

            Console.Write("Input Class Name:  ");
            student.ClassName = Console.ReadLine();

            Console.Write("Input Ntive:  ");
            student.Native = Console.ReadLine();

            Console.Write("Input PhoneNo: ");
            student.PhoneNo = Console.ReadLine();

            Console.Write("Input Mobile:  ");
            student.Mobile = int.Parse(Console.ReadLine());

            StudentList.Add(student);
        }
        public static void DisPlayStudent()
        {
            foreach (Student student in StudentList)
            {
                student.DisPlay();
            }
        }
        public static void SearchStudents()
        {
            if(StudentList.Count > 0)
            {
                Console.WriteLine("Enter the student you want to search");
                string name = Console.ReadLine();

                foreach (Student student in StudentList)
                {
                    if (name == student.FullName)
                    {
                        student.DisPlay();
                        break;
                    } 
                }
            }
        }
    }
}
