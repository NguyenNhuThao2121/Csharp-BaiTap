using System;
using System.Collections.Generic;
namespace Lab02
{
    class MangHaiChieu
    {
        int[,] a;
        int n, m;
        // Sinh mang ngau nhien
        public void SinhMang()
        {
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Nhap m: ");
            m = int.Parse(Console.ReadLine());
            a = new int[n, m];
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = rd.Next(10, 101);
                }
            }
        }
        // In mang
        public void Xuat()
        {
            Console.WriteLine("Mang A:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        // Lay mang so chan
        public List<int> LaySoChan()
        {
            List<int> chan = new List<int>();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] % 2 == 0)
                        chan.Add(a[i, j]);
                }
            }
            return chan;
        }
        // Lay mang so le
        public List<int> LaySoLe()
        {
            List<int> le = new List<int>();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] % 2 != 0)
                        le.Add(a[i, j]);
                }
            }
            return le;
        }
    }
    class Bai17
    {
        static void Main(string[] args)
        {
            MangHaiChieu m = new MangHaiChieu();
            m.SinhMang();
            m.Xuat();
            List<int> chan = m.LaySoChan();
            List<int> le = m.LaySoLe();
            Console.WriteLine("Mang cac so chan:");
            for (int i = 0; i < chan.Count; i++)
            {
                Console.Write(chan[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Mang cac so le:");
            for (int i = 0; i < le.Count; i++)
            {
                Console.Write(le[i] + " ");
            }
        }
    }
}