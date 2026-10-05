using System;

namespace Lab02
{
    class Bai9
    {
        static void TimMaxMin(double a, double b, double c, out double max, out double min)
        {
            max = a;
            min = a;

            if (b > max)
                max = b;

            if (b < min)
                min = b;

            if (c > max)
                max = c;

            if (c < min)
                min = c;
        }

        public static void Main(string[] args)
        {
            double x, y, z;
            double max, min;

            Console.WriteLine("Nhap x: ");
            x = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap y: ");
            y = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap z: ");
            z = double.Parse(Console.ReadLine());

            TimMaxMin(x, y, z, out max, out min);

            Console.WriteLine("So lon nhat la: " + max);
            Console.WriteLine("So be nhat la: " + min);
        }
    }
}