using System;

namespace Lab02
{
    class Bai8
    {
        static void HoanVi ( ref double a , ref double b)
        {
            double tam;
            tam = a;
            a = b;
            b = tam;
      }
        public static void Main (string[] args)
        {
            double x, y;
            Console.WriteLine("Nhap a : ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b : ");
            y = double.Parse(Console.ReadLine());

            HoanVi(ref x, ref y);
            Console.WriteLine("sau khi doi cho la a = : "+x);
            Console.WriteLine("sau khi doi cho la b = : "+y);
        }
    }
}