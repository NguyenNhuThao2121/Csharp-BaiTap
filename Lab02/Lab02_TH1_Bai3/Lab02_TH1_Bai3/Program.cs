//Viết chương trình nhập hai số nguyên x, y. Tính xy và xuất theo định dạng sau:
//Nhap so nguyen x: 7
//Nhap so nguyen y: 3
//Ket qua 7 mu 3 la: 343

using System;
namespace Lab02
{
    class Bai3
    {
        public static void Main(string[] args)
        {
            int x, y ;
            double kqua;
            Console.WriteLine("Nhap so nguyen x: " );
            x = int.Parse( Console.ReadLine() );
            Console.WriteLine("Nhap so nguyen y: ");
            y = int.Parse(Console.ReadLine());
             kqua = Math.Pow( x, y );
            Console.WriteLine("ket qua la: "+kqua);
        }
    }
}