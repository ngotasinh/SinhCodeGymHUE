using System;
using System.Collections.Generic;
using System.Text;

namespace BTCodeGym.ThuatToanCB
{
    class UCLN
    {
        public static void Main()
        {
            Console.Write("Nhap so thu nhat: ");
            int a = int.Parse(Console.ReadLine());
            a = Math.Abs(a);
            Console.Write("nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine());
            b = Math.Abs(b);
            if (a == 0 || b == 0)
                Console.WriteLine(a + b);
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            Console.WriteLine(a);
        }
    }
}
