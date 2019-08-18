using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    class Person
    {
      
        protected int age;
        
        public void Greet()
        {
            Console.WriteLine("hello");
        }
        public void SetAge(int num)
        {
            age = num;
        }
    }
    class Student : Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("I’m going to class");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is: {0} year old", age);
        }
    }
    class Teacher : Person
    {
        private string subject;
        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }
    }
    class StudentAndTeacherTest
    {
        static void Main()
        {
            Person myPerson = new Person();
            myPerson.Greet();

            Student myStudent = new Student();
            myStudent.SetAge(21);
            myStudent.Greet();
            myStudent.ShowAge();

            Teacher myTeacher = new Teacher();
            myTeacher.SetAge(30);
            myTeacher.Greet();
            myTeacher.Explain();

            Console.ReadKey();
        }
    }
}
