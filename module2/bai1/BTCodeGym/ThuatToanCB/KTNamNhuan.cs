using System;
using System.Collections.Generic;
using System.Text;

namespace BTCodeGym.ThuatToanCB
{
    class KTNamNhuan
    {
        public static void Main()
        {
            NamNhuan();
        }
        public static void NamNhuan()
        {
            Console.Write("Nhap nam can kiem tra: ");
            int year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || (year % 100 == 0 && year % 400 == 0))
            {
                Console.WriteLine("Nam: {0} la nam nhuan", year);
            }
            else
            {
                Console.WriteLine("Nam: {0} khong phai la nam nhuan", year);
            }
        }
    }
}
