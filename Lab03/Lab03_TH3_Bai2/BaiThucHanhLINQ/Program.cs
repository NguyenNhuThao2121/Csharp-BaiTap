using System;
using System.Collections.Generic;
using System.Linq;

namespace BaiThucHanhLinq;

class program
{
    static void Main()
    {
        bai22();
    }

    static void Bai21()
    {
        int[] mangso = { 50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };

        var ketqua = mangso.Where(x => x % 4 == 0 && x % 3 == 0);

        Console.WriteLine("Cac so chia het cho 3 va 4 la:");

        foreach (var x in ketqua)
        {
            Console.WriteLine(x);
        }
    }

    static void bai21b()
    {
        int[] mangso = { 50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };

        var ketqua = mangso.Where(x => x <= 3);

        Console.WriteLine("Cac so nho hon hoac bang 3:");

        foreach (var x in ketqua)
        {
            Console.WriteLine(x);
        }
    }

    static void bai21c()
    {
        int[] mangso = { 50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };

        var ketqua = mangso.Select(x => x % 2 == 0 ? x / 2 : x);

        Console.WriteLine("So chan chia doi, so le giu nguyen:");

        foreach (var x in ketqua)
        {
            Console.WriteLine(x);
        }
    }

    static void bai22()
    {
        string[] mangChuoi = { "đầu", "lòng", "hai", "ả", "tố", "nga",
            "Thúy", "Kiều", "là", "chị", "em", "là", "Thúy", "Vân" };

        var kitu = mangChuoi
            .Where(x => x.Length == 4)
            .OrderBy(x => x[0]);

        Console.WriteLine("Cac phan tu co 4 ky tu:");

        foreach (var x in kitu)
        {
            Console.WriteLine(x);
        }
    }

    static void bai22b()
    {
        string[] mangChuoi = { "đầu", "lòng", "hai", "ả", "tố", "nga",
            "Thúy", "Kiều", "là", "chị", "em", "là", "Thúy", "Vân" };

        var ketqua = mangChuoi
            .Select(x => x.ToLower() + " - " + x.ToUpper());

        Console.WriteLine("Chu thuong - CHU HOA:");

        foreach (var x in ketqua)
        {
            Console.WriteLine(x);
        }
    }

    static void bai22c()
    {
        string[] mangChuoi = { "đầu", "lòng", "hai", "ả", "tố", "nga",
            "Thúy", "Kiều", "là", "chị", "em", "là", "Thúy", "Vân" };

        var ketqua = mangChuoi
            .Where(x => x.Contains("u"));

        Console.WriteLine("Cac phan tu co chua ky tu u:");

        foreach (var x in ketqua)
        {
            Console.WriteLine(x);
        }
    }

    static void bai22d()
    {
        string[] mangChuoi = { "đầu", "lòng", "hai", "ả", "tố", "nga",
            "Thúy", "Kiều", "là", "chị", "em", "là", "Thúy", "Vân" };

        var ketqua = mangChuoi
            .Where(x => char.IsUpper(x[0]));

        Console.WriteLine("Cac tu bat dau bang chu in hoa:");

        foreach (var x in ketqua)
        {
            Console.WriteLine(x);
        }
    }
}