using System;

namespace Lab02
{
    class Bai7
    {
        static bool KiemTra(int a)
        {
            if (a < 2)
            {
                return false;
            }

            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static void Main(string[] args)
        {
            int x;

            Console.WriteLine("Nhap x:");
            x = int.Parse(Console.ReadLine());

            bool kq = KiemTra(x);

            if (kq)
            {
                Console.WriteLine(x + " la so nguyen to");
            }
            else
            {
                Console.WriteLine(x + " khong phai la so nguyen to");
            }
        }
    }
}