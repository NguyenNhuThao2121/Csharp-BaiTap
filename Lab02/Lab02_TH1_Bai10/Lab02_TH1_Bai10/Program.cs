
using System;

namespace Lab02
{
    class Bai10
    {
        private string s;

        // Constructor nhận chuỗi
        public Bai10(string chuoi)
        {
            s = chuoi;
        }

        // Phương thức thành viên kiểm tra chuỗi đối xứng
        public bool Chuoi()
        {
            int n = s.Length;

            for (int i = 0; i < n / 2; i++)
            {
                if (s[i] != s[n - 1 - i])
                    return false;
            }

            return true;
        }

        public static void Main(string[] args)
        {
            Console.Write("Moi ban nhap chuoi: ");
            string chuoi = Console.ReadLine();

            Bai10 x = new Bai10(chuoi);

            bool kq = x.Chuoi();

            if (kq == true)
                Console.WriteLine("Chuoi ban nhap doi xung: " + kq);
            else
                Console.WriteLine("Chuoi ban nhap khong doi xung: " + kq);
        }
    }
}