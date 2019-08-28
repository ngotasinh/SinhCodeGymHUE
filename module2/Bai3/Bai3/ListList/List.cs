using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.ListList
{
    public class List
    {
        public static void Main()
        {
            List<Dictionary<int, string>> C6 = new List<Dictionary<int, string>>();
            var to1 = new Dictionary<int, string>();
            to1.Add(1, "khoa");
            to1.Add(2, "Bao");
            C6.Add(to1);

            var to2 = new Dictionary<int, string>();
            to2.Add(1, "Ha");
            to2.Add(2, "Huy");
            C6.Add(to2);

            foreach (var to in C6)
            {
                foreach (var number in to)
                {
                    Console.WriteLine("Id : {0}\tName : {1}\t", number.Key, number.Value);
                }
            }
        }
    }
}
