using System;
using System.Collections.Generic;
using System.Text;
using Bai3.QuanLyMarks.Models;

namespace Bai3.QuanLyMarks
{
    public class StudentTest
    {
        public static StudentMark studentMark = new StudentMark();
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
                Console.WriteLine("*******************************************");
                Console.WriteLine("MARKS MANAGEMENT SYSTEM");
                Console.WriteLine("1. Insert new Student");
                Console.WriteLine("2. View list of Students");
                Console.WriteLine("3. Average Mark");
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
                        Console.WriteLine("Insert new .......");
                        Id += 1;
                        CreateNew();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("View list news............");
                        studentMark.DisPlay();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Average Mark...........");
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
            studentMark.Id = Id;
            Console.Write("Input FullName:  ");
            studentMark.FullName = Console.ReadLine();

            Console.Write("Input Class Name:  ");
            studentMark.ClassName = Console.ReadLine();

            Console.Write("Input Semester: ");
            studentMark.Semester = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentMark.SubjectMarkList.Length; i++)
            {
                Console.Write("Input mark of subject {0} ", i + 1);
                studentMark.SubjectMarkList[i] = int.Parse(Console.ReadLine());
            }
            studentMark.InsertNews(Id);
        }
    }
}
