using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.LinkList
{
    public class LinkedList
    {
        public static void Main()
        {
            LinkedList<string> Relationship = new LinkedList<string>();
            Relationship.AddFirst("khoa");

            var phong = Relationship.First;
            Relationship.AddAfter(phong, "Phong");

            var tu = Relationship.Find("Phong");
            Relationship.AddAfter(tu, "Tu");

            foreach (var item in Relationship)
            {
                Console.WriteLine("item : {0}", item);
            }
        }
    }
}
