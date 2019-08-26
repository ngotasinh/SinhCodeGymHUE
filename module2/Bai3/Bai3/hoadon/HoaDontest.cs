using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.hoadon
{
    public class HoaDontest
    {
        public static void Main()
        {
            Console.WriteLine("*******************************************");
            var hoadon1 = new HoaDon("Nguyen Van A", 20);
            Console.WriteLine(hoadon1.TenKhachHang);
            Console.WriteLine(hoadon1.TongTien);
            hoadon1.ThongKe();
            Console.WriteLine("*******************************************");
            hoadon1.TenKhachHang = "Nguyen Van B";
            Console.WriteLine(hoadon1.TenKhachHang);
            Console.WriteLine(hoadon1.TongTien);
            hoadon1.ThongKe();

        }
    }
}
