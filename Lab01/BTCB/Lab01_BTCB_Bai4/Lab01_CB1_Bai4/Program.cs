using System;

namespace Lab01NHV
{
    public class Program
    {
        public static string DoiGiay(int giay)
        {
            int gio = giay / 3600;
            int phut = (giay % 3600) / 60;
            int s = giay % 60;

            return gio + ":" + phut + ":" + s;
        }

        static void Main(string[] args)
        {
            Console.Write("Nhap vao tong so giay: ");

            int giay = int.Parse(Console.ReadLine());

            Console.WriteLine(
                giay + " giay co dang "
                + DoiGiay(giay)
            );
        }
    }
}