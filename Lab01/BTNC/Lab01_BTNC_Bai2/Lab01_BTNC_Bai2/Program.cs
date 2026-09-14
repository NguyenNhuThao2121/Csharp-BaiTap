using System;

namespace BTNC_Lab01
{
    public class doiDoSangRadian
    {
        // Hàm đổi độ sang Radian
        public static double DoiDoSangRadian(double d)
        {
            double r = (d * Math.PI) / 180;

            return r;
        }

        public static void Main(string[] args)
        {
            double d;

            Console.Write("Nhap do: ");
            d = double.Parse(Console.ReadLine());

            // Chuyển độ sang Radian
            double r = DoiDoSangRadian(d);

            // Xuất kết quả
            Console.WriteLine("Doi " + d + " do sang radian duoc: " + r);
        }
    }
}