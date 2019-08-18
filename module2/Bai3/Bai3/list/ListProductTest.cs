using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.list
{
    public class ListProductTest
    {
        public static void Main()
        {
            LisProduct list = new LisProduct();
            list.ProductList = new Product[5];

            for (int i = 0; i <list.ProductList.Length; i++)
            {
                list[i] = new Product();
                list[i].Pid = i;
                list[i].PName = string.Format("P{0}", i);
            }
            for (int i = 0; i < list.ProductList.Length; i++)
            { 
                Console.WriteLine("Product ID: {0}", list[i].Pid);
                Console.WriteLine("Prodoct Name: {0}", list[i].PName);
                Console.WriteLine("*********************************");
            }
            Console.WriteLine("Nhap vao san pham: ");
            string name = Console.ReadLine();
            Product p = list[name];
            if(p != null)
            {
                Console.WriteLine("Tim thay san pham");
            }
            else Console.WriteLine("Khong tim thay san pham");
        }
    }
}
