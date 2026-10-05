using System;

namespace BTCB.Buoi01
{
    public class TinhDienTinh_ChuVi_HinhTron
    {
        public static double TinhDienTich(double r)
        {
            double pi = Math.PI;
            double s = pi * Math.Pow(r, 2);

            return s;
        }

        public static double TinhChuVi(double r)
        {
            double pi = Math.PI;
            double c = 2 * pi * r;

            return c;
        }

        public static void Main(string[] args)
        {
            double r;

            Console.Write("Ban Kinh : r = ");
            r = double.Parse(Console.ReadLine());

            double s = TinhDienTich(r);
            double c = TinhChuVi(r);

            Console.WriteLine("Dien tich hinh tron : s = " + s);
            Console.WriteLine("Chu vi hinh tron : c = " + c);
        }
    }
}