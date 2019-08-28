using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.SortList
{
    public class SortList
    {
        public static void Main()
        {
            //SortedList<string, string> EmployeeList = new SortedList<string, string>();
            Dictionary<string, string> EmployeeList = new Dictionary<string, string>();

            EmployeeList.Add("khoa", "co tuong");
            EmployeeList.Add("sinh", "game");
            EmployeeList.Add("huy", "phim");

            //duyệt qua key.
            foreach (var item in EmployeeList.Keys)
            {
                Console.WriteLine("******************************************");
                Console.WriteLine(item);
            }
            //duyệt qua value.

            foreach (var item in EmployeeList.Values)
            {
                Console.WriteLine("******************************************");
                Console.WriteLine(item);
            }
            // duyệt qua key in ra cả key và value

            Console.WriteLine("******************************************");
            foreach (var item in EmployeeList.Keys)
            {
                Console.WriteLine("key: {0}\t Value: {1}", item, EmployeeList[item]);
            }


            // Xóa bằng key
            Console.WriteLine("******************************************");
            EmployeeList.Remove("khoa");


            Console.WriteLine("******************************************");
            foreach (var item in EmployeeList.Keys)
            {
                Console.WriteLine("key: {0}\t Value: {1}", item, EmployeeList[item]);
            }

            // Xóa bằng key trả về giá trị value
            string sinhValue;
            Console.WriteLine("******************************************");
            EmployeeList.Remove("sinh", out sinhValue);

            Console.WriteLine(sinhValue);
            Console.WriteLine("******************************************");
            foreach (var item in EmployeeList.Keys)
            {
                Console.WriteLine("key: {0}\t Value: {1}", item, EmployeeList[item]);
            }

            // Xóa phần tử theo index
           /* Console.WriteLine("******************************************");
            EmployeeList.RemoveAt(0);
*/
            /*Console.WriteLine("******************************************");
            foreach (var item in EmployeeList.Keys)
            {
                Console.WriteLine("key: {0}\t Value: {1}", item, EmployeeList[item]);
            }

            // hiển thị tất cả các value sử dụng enumrator
            var enumrator = EmployeeList.GetEnumerator();
            while (enumrator.MoveNext())
            {
                Console.WriteLine("Key : {0}\t Value : {1}", enumrator.Current.Key,enumrator.Current.Value);
            }*/
        }
    }
}
