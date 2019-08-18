using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.hoadon
{
    public class HoaDon
    {
        private string tenKhachHang;
        private int tongTien;

        private static int tongHoaDon;
        private static int tongTienHoaDon;

        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public HoaDon(string ten, int tien)
        {
            tenKhachHang = ten;
            tongTien = tien;
            tongHoaDon++;
            tongTienHoaDon += tongTien; 
        }
        static HoaDon()
        {
            tongTienHoaDon = 0;
            tongHoaDon = 0;
        }

        public void ThongKe()
        {
            Console.WriteLine("Tong hoa Don: {0}", tongHoaDon);
            Console.WriteLine("Tong doanh thu: {0}", tongTienHoaDon);
        }

    }
}
