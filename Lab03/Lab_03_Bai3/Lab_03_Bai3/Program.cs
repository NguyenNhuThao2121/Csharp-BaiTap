using System;
using System.Collections.Generic;
using System.Linq;

namespace BaiThucHanhLinq;

class program
{
    static void Main()
    {
        // Bài 3.1
        bai31a();
        bai31b();
        bai31c();
        bai31d();

        // Bài 3.2
        bai32a();
        bai32b();
        bai32c();
    }


    // =========================================================
    // BÀI 3.1 - THỐNG KÊ MẢNG SỐ
    // =========================================================

    // a. Tổng số phần tử, số chẵn, số lẻ
    static void bai31a()
    {
        int[] mangSo = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };

        int tongSoPhanTu = mangSo.Count();
        int soChan = mangSo.Count(x => x % 2 == 0);
        int soLe = mangSo.Count(x => x % 2 != 0);

        Console.WriteLine("========== BAI 3.1a ==========");
        Console.WriteLine("Tong so phan tu: " + tongSoPhanTu);
        Console.WriteLine("So phan tu chan: " + soChan);
        Console.WriteLine("So phan tu le: " + soLe);

        Console.WriteLine();
    }


    // b. Tính tổng, lớn nhất, nhỏ nhất
    static void bai31b()
    {
        int[] mangSo = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };

        int tong = mangSo.Sum();
        int lonNhat = mangSo.Max();
        int nhoNhat = mangSo.Min();

        Console.WriteLine("========== BAI 3.1b ==========");
        Console.WriteLine("Tong: " + tong);
        Console.WriteLine("Gia tri lon nhat: " + lonNhat);
        Console.WriteLine("Gia tri nho nhat: " + nhoNhat);

        Console.WriteLine();
    }


    // c. Đếm số giá trị khác nhau
    static void bai31c()
    {
        int[] mangSo = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };

        int soGiaTriKhacNhau = mangSo
            .Distinct()
            .Count();

        Console.WriteLine("========== BAI 3.1c ==========");
        Console.WriteLine("So gia tri khac nhau: " + soGiaTriKhacNhau);

        Console.WriteLine();
    }


    // d. Phân nhóm theo số dư khi chia cho 5
    static void bai31d()
    {
        int[] mangSo = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };

        var ketqua = mangSo
            .GroupBy(x => x % 5);

        Console.WriteLine("========== BAI 3.1d ==========");

        foreach (var nhom in ketqua)
        {
            Console.Write("So du " + nhom.Key + ": ");

            foreach (var x in nhom)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }


    // =========================================================
    // BÀI 3.2 - THỐNG KÊ MẢNG CHUỖI
    // =========================================================

    // a. Tìm phần tử có chiều dài ngắn nhất và dài nhất
    static void bai32a()
    {
        string[] monAn =
        {
            "Bún bò Huế",
            "Hủ tiếu heo",
            "Bánh canh",
            "Bánh mì",
            "Nước Cà phê",
            "Mì quảng",
            "Cơm tấm",
            "Nước Chanh dây",
            "Mì xào",
            "Bún riêu",
            "Bánh cuốn",
            "Mì gói",
            "Bún chả",
            "Hủ tiếu Nam vang"
        };

        int doDaiNhoNhat = monAn.Min(x => x.Length);
        int doDaiLonNhat = monAn.Max(x => x.Length);

        var nganNhat = monAn
            .Where(x => x.Length == doDaiNhoNhat);

        var daiNhat = monAn
            .Where(x => x.Length == doDaiLonNhat);

        Console.WriteLine("========== BAI 3.2a ==========");

        Console.WriteLine("Mon an ngan nhat:");

        foreach (var x in nganNhat)
        {
            Console.WriteLine(x);
        }

        Console.WriteLine("Mon an dai nhat:");

        foreach (var x in daiNhat)
        {
            Console.WriteLine(x);
        }

        Console.WriteLine();
    }


    // b. Phân nhóm theo từ đầu tiên
    static void bai32b()
    {
        string[] monAn =
        {
            "Bún bò Huế",
            "Hủ tiếu heo",
            "Bánh canh",
            "Bánh mì",
            "Nước Cà phê",
            "Mì quảng",
            "Cơm tấm",
            "Nước Chanh dây",
            "Mì xào",
            "Bún riêu",
            "Bánh cuốn",
            "Mì gói",
            "Bún chả",
            "Hủ tiếu Nam vang"
        };

        var ketqua = monAn
            .GroupBy(x => x.Split(' ')[0]);

        Console.WriteLine("========== BAI 3.2b ==========");

        foreach (var nhom in ketqua)
        {
            Console.WriteLine("Nhom " + nhom.Key + ":");

            foreach (var mon in nhom)
            {
                Console.WriteLine("  " + mon);
            }
        }

        Console.WriteLine();
    }


    // c. Đếm số phần tử có từ đầu tiên là "Bánh"
    static void bai32c()
    {
        string[] monAn =
        {
            "Bún bò Huế",
            "Hủ tiếu heo",
            "Bánh canh",
            "Bánh mì",
            "Nước Cà phê",
            "Mì quảng",
            "Cơm tấm",
            "Nước Chanh dây",
            "Mì xào",
            "Bún riêu",
            "Bánh cuốn",
            "Mì gói",
            "Bún chả",
            "Hủ tiếu Nam vang"
        };

        int ketqua = monAn
            .Count(x => x.Split(' ')[0] == "Bánh");

        Console.WriteLine("========== BAI 3.2c ==========");
        Console.WriteLine("So mon co tu dau tien la Banh: " + ketqua);

        Console.WriteLine();
    }
}