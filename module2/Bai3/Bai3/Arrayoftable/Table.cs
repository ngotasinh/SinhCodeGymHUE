using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.Arrayoftable
{
    class Table
    {
        private float width, height;

        public Table()
        {
        }
        public Table(float width, float height)
        {
            this.width = width;
            this.height = height;
        }

        public float Width
        {
            set { width = value; }
            get { return width; }
        }
        public float Height
        {
            set { height = value; }
            get { return height; }
        }

        public void ShowData()
        {
            Console.WriteLine("Width: {0}, Heigth: {1}", width, height);
        }
    }

    class TestTables
    {
        static void Main()
        {

            Table[] myTables = new Table[10];
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                myTables[i] = new Table(rnd.Next(50, 201), rnd.Next(50, 201));
                myTables[i].ShowData();
            }         
        }
    }
}
