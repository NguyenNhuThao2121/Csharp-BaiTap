using System;

namespace Lab01_NC104_NHV
{
    public class Program
    {
        public static double CanBac(float a, float n)
        {
            return Math.Pow(a, 1 / n);
        }

        static void Main(string[] args)
        {
            Console.Write("Nhap so thuc a: ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("Nhap so can: ");
            float n = float.Parse(Console.ReadLine());

            double squareroot = CanBac(a, n);

            Console.WriteLine("Can bac " + n + " cua " + a + " la: " + squareroot);
        }
    }
}