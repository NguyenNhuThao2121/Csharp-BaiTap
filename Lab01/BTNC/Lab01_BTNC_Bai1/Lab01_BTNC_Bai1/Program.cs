using System;

namespace btnc2;

public class TinhKhoangCach
{
    public static double TinhKhoangCachGiuaHaiDiem(double x1, double y1, double x2, double y2)
    {
        double kq;

        kq = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        return kq;
    }

    public static void Main(String[] args)
    {
        double x1, y1, x2, y2, kq;

        Console.WriteLine("Moi ban nhap x1 : ");
        x1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Moi ban nhap y1 : ");
        y1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Moi ban nhap x2 : ");
        x2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Moi ban nhap y2 : ");
        y2 = double.Parse(Console.ReadLine());

        kq = TinhKhoangCachGiuaHaiDiem(x1, y1, x2, y2);

        Console.WriteLine("Ket qua la : " + kq);
    }
}