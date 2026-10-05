//Bài 4: Làm lại bài 3, nhưng thông báo lỗi khi x hay y
//không phải là số nguyên
using System;
using System.Transactions;

namespace Lab02
{
    class Bai4
    {
        public static void Main(string[] args)
        {
            int x,y ;
            double kq;

            Console.WriteLine("nhap so nguyen x ");
            
            if(int.TryParse(Console.ReadLine(),out x) == false)
            {
                Console.WriteLine("x khong phai la so nguyen");
                return;
            }

            Console.WriteLine("nhap so nguyen y ");

            if(int.TryParse(Console.ReadLine() , out y )== false)
            {
                Console.WriteLine("y khong phai la so nguyen");
                return;
            }

             kq = Math.Pow(x, y);

            Console.WriteLine("Ket qua la " + kq);
        }
    }
}