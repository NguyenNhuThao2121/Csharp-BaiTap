using System;

namespace Lab02
{
    class Bai11
    {
        private string s;

        // Constructor nhận chuỗi
        public Bai11(string chuoi)
        {
            s = chuoi;
        }

        // Phương thức thành viên trả về chuỗi đảo
        public string DaoChuoi()
        {
            int n = s.Length;
            string dao = "";

            for (int i = n - 1; i >= 0; i--)
            {
                dao = dao + s[i];
            }

            return dao;
        }

        public static void Main(string[] args)
        {
            Console.Write("Moi ban nhap chuoi: ");
            string chuoi = Console.ReadLine();

            Bai11 x = new Bai11(chuoi);

            Console.WriteLine("Chuoi da dao la: " + x.DaoChuoi());
        }
    }
}