using System;

namespace Lab02
{
    class SinhVien
    {
        string maSV;
        string hoTen;
        string diaChi;
        int namHoc;

        public void Nhap()
        {
            Console.Write("Nhap ma sinh vien: ");
            maSV = Console.ReadLine();

            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhap dia chi: ");
            diaChi = Console.ReadLine();

            Console.Write("Nhap nam hoc: ");
            namHoc = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Ma sinh vien: " + maSV);
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("Dia chi: " + diaChi);
            Console.WriteLine("Nam hoc: " + namHoc);
        }
    }

    class Bai13
    {
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien();

            sv.Nhap();
            sv.Xuat();
        }
    }
}