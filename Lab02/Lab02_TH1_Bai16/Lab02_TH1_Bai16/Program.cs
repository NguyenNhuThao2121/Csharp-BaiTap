using System;
using System.Collections.Generic;

namespace Lab02
{
    class MangSoNguyen
    {
        int[] a;
        int n;

        // Nhap mang
        public void Nhap()
        {
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());

            a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        // In mang
        public void Xuat()
        {
            Console.Write("Mang: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }

            Console.WriteLine();
        }

        // Tim lon nhat
        public int TimLonNhat()
        {
            int max = a[0];

            for (int i = 1; i < n; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }

            return max;
        }

        // Tim nho nhat
        public int TimNhoNhat()
        {
            int min = a[0];

            for (int i = 1; i < n; i++)
            {
                if (a[i] < min)
                    min = a[i];
            }

            return min;
        }

        // Kiem tra so nguyen to
        public bool LaSoNguyenTo(int x)
        {
            if (x < 2)
                return false;

            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                    return false;
            }

            return true;
        }

        // Tra ve mang cac so nguyen to
        public List<int> LaySoNguyenTo()
        {
            List<int> ds = new List<int>();

            for (int i = 0; i < n; i++)
            {
                if (LaSoNguyenTo(a[i]))
                    ds.Add(a[i]);
            }

            return ds;
        }
    }

    class Bai15
    {
        static void Main(string[] args)
        {
            MangSoNguyen m = new MangSoNguyen();

            m.Nhap();
            m.Xuat();

            Console.WriteLine("Phan tu lon nhat: " + m.TimLonNhat());
            Console.WriteLine("Phan tu nho nhat: " + m.TimNhoNhat());

            List<int> ds = m.LaySoNguyenTo();

            Console.Write("Cac so nguyen to: ");

            for (int i = 0; i < ds.Count; i++)
            {
                Console.Write(ds[i] + " ");
            }
        }
    }
}