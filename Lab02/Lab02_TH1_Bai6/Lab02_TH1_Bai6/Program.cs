using System;

namespace Lab02
{
    class bai6
    {
        static int TimMax(int a , int b , int c)
        {
            if(a>b && a > c)
            {
                return a; 
            }else if (b>c && b > a)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        public static void Main(string [] args)
        {
            int a, b, c;
            Console.WriteLine("Nhap x : ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap y : ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap z : ");
            c = int.Parse(Console.ReadLine());

            int kq = TimMax(a, b, c);

            Console.WriteLine("so nguyen lon nhat " + kq);
            
        }
    }
    
}