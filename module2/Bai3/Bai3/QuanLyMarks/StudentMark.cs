using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Bai3.QuanLyMarks.Models;

namespace Bai3.QuanLyMarks
{
    public class StudentMark : IStudentMark
    {
        private string fullName;
        private int id;
        private string className;
        private int semester;
        private float averageMark;

        public int[] SubjectMarkList = new int[5];
        public StudentItem[] ArrayList = new StudentItem[10];

        public string FullName { get => fullName; set => fullName = value; }
        public int Id { get => id; set => id = value; }
        public string ClassName { get => className; set => className = value; }
        public int Semester { get => semester; set => semester = value; }
        public float AverageMark { get => averageMark; }

        public void DisPlay()
        {
            foreach (var item in ArrayList)
            {
                if (item != null)
                {
                    Console.WriteLine("ID: {0} \tFullName: {1} \tClassName: {2} \tSemester: {3} \tAverageMark: {4}",
                         item.Id, item.FullName, item.ClassName, item.Semester, item.AverageMark);
                }
            }

        }
        public void AveCal()
        {
            var total = 0;
            foreach (var item in SubjectMarkList)
            {
                total += item;
            }
            averageMark = (float)(total / 5);
        }
        public void InsertNews(int index)
        {
            AveCal();
            var studentItem = new StudentItem()
            {
                Id = id,
                FullName = fullName,
                ClassName = className,
                Semester = semester,
                AverageMark = averageMark
            };
            ArrayList[index] = studentItem;
        }
    }
}
