using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.QLSinhVien
{
    public class Student : IStudent
    {

        public string FullName { get; set; }
        public int Id { get; set; }
        public string DateofBirth { get; set; }
        public string Native { get; set; }
        public string ClassName { get; set; }
        public string PhoneNo { get; set; }
        public int Mobile { get; set; }

        public int[] PropertiesList = new int[6];
        public void DisPlay()
        {
            Console.WriteLine("ID: {0}\t FullName: {1}\t DateofBirth: {2}\t Native: {3}\t ClassName: {4}\t PhoneNo: {5}\t Mobile: {6} ",
                Id, FullName, DateofBirth, Native, ClassName, PhoneNo, Mobile);
        }
    }
}
