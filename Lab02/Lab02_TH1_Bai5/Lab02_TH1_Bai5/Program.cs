using System;

namespace Lab02
{
    class Bai5
    {
        public static void Main(string[] args)
        {
            int chon;
            double x = 0, y = 0;
            double kq;

            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1. Nhap hai gia tri so thuc cho x , y");
                Console.WriteLine("2. Tinh x^y ");
                Console.WriteLine("3. Tinh can bac 2 cua x va y ");
                Console.WriteLine("4. Thoat ");
                Console.WriteLine("Chon chuc nang ");

                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        Console.WriteLine("nhap x :");
                        x = double.Parse(Console.ReadLine());

                        Console.WriteLine("nhap y :");
                        y = double.Parse(Console.ReadLine());

                        break;

                    case 2:
                        kq = Math.Pow(x, y);
                        Console.WriteLine("x^y = " + kq);
                        break;

                    case 3:
                        Console.WriteLine("can bac 2 cua x la " + Math.Sqrt(x));
                        Console.WriteLine("can bac 2 cua y la " + Math.Sqrt(y));
                        break;

                    case 4:
                        Console.WriteLine("thoat chuong trinh");
                        break;

                    default:
                        Console.WriteLine("Moi ban chon lai");
                        break;
                }

            } while (chon != 4);
        }
    }
}