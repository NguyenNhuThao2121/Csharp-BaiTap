using System;

namespace Lab02
{
    class NhanVien
    {
        string hoTen;
        double luong;
        int soNgayVang;

        public void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhap luong: ");
            luong = double.Parse(Console.ReadLine());

            Console.Write("Nhap so ngay vang: ");
            soNgayVang = int.Parse(Console.ReadLine());
        }

        public double TinhLuong()
        {
            return luong - soNgayVang * 100000;
        }

        public void Xuat()
        {
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("Luong thuc nhan: " + TinhLuong());
        }
    }

    class Bai14
    {
        static void Main(string[] args)
        {
            NhanVien nv = new NhanVien();

            nv.Nhap();
            nv.Xuat();
        }
    }
}