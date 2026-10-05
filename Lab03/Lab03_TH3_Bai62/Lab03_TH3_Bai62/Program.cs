using System;
using System.Collections.Generic;
using System.Linq;

public class He
{
    public string MaHe { get; set; } = "";
    public string TenHe { get; set; } = "";
}

public class MonHoc
{
    public string MaMon { get; set; } = "";
    public string TenMon { get; set; } = "";
    public string He { get; set; } = "";
    public byte SoTiet { get; set; }
}

public class DuLieu
{
    // Danh sách hệ
    public static List<He> DS_He()
    {
        List<He> ds = new List<He>();

        ds.Add(new He
        {
            MaHe = "KTV",
            TenHe = "Kỹ thuật viên"
        });

        ds.Add(new He
        {
            MaHe = "CD",
            TenHe = "Chuyên đề"
        });

        ds.Add(new He
        {
            MaHe = "QT",
            TenHe = "Chứng chỉ quốc tế"
        });

        return ds;
    }

    // Danh sách môn học
    public static List<MonHoc> DS_Mon()
    {
        List<MonHoc> ds = new List<MonHoc>();

        ds.Add(new MonHoc
        {
            MaMon = "HP2_1",
            TenMon = "Nền tảng C#",
            He = "KTV",
            SoTiet = 64
        });

        ds.Add(new MonHoc
        {
            MaMon = "HP2_2",
            TenMon = "Công nghệ ADO.NET",
            He = "KTV",
            SoTiet = 64
        });

        ds.Add(new MonHoc
        {
            MaMon = "HP3_1",
            TenMon = "Lập trình Windows Forms",
            He = "KTV",
            SoTiet = 64
        });

        ds.Add(new MonHoc
        {
            MaMon = "HP3_2",
            TenMon = "Xây dựng ứng dụng Windows Forms",
            He = "KTV",
            SoTiet = 64
        });

        ds.Add(new MonHoc
        {
            MaMon = "HP4_1",
            TenMon = "Lập trình Web với HTML, CSS và JavaScript",
            He = "KTV",
            SoTiet = 64
        });

        ds.Add(new MonHoc
        {
            MaMon = "HP4_2",
            TenMon = "Xây dựng ứng dụng Web với ASP.NET",
            He = "KTV",
            SoTiet = 64
        });

        ds.Add(new MonHoc
        {
            MaMon = "HP5_1",
            TenMon = "Lập trình CSDL SQL Server căn bản",
            He = "KTV",
            SoTiet = 64
        });

        ds.Add(new MonHoc
        {
            MaMon = "HP5_2",
            TenMon = "Lập trình CSDL SQL Server nâng cao",
            He = "KTV",
            SoTiet = 64
        });

        ds.Add(new MonHoc
        {
            MaMon = "JLCB",
            TenMon = "Joomla cơ bản",
            He = "CD",
            SoTiet = 72
        });

        ds.Add(new MonHoc
        {
            MaMon = "LINQ",
            TenMon = "Language-Integrated Query",
            He = "CD",
            SoTiet = 64
        });

        ds.Add(new MonHoc
        {
            MaMon = "DAWEB",
            TenMon = "Đồ án thực tế Web với ASP.NET",
            He = "CD",
            SoTiet = 40
        });

        ds.Add(new MonHoc
        {
            MaMon = "DAWIN",
            TenMon = "Đồ án thực tế Windows Forms",
            He = "CD",
            SoTiet = 40
        });

        ds.Add(new MonHoc
        {
            MaMon = "CC++",
            TenMon = "Lập trình hướng đối tượng với C/C++",
            He = "CD",
            SoTiet = 128
        });

        ds.Add(new MonHoc
        {
            MaMon = "JQUE",
            TenMon = "JQuery",
            He = "CD",
            SoTiet = 22
        });

        ds.Add(new MonHoc
        {
            MaMon = "XML",
            TenMon = "Công nghệ XML",
            He = "CD",
            SoTiet = 32
        });

        ds.Add(new MonHoc
        {
            MaMon = "CRYS",
            TenMon = "Crystal Report trong Visual Studio",
            He = "CD",
            SoTiet = 32
        });

        ds.Add(new MonHoc
        {
            MaMon = "BWEB",
            TenMon = "HTML, CSS và JavaScript",
            He = "CD",
            SoTiet = 32
        });

        ds.Add(new MonHoc
        {
            MaMon = "XYZ",
            TenMon = "Chưa đặt tên môn",
            He = "",
            SoTiet = 0
        });

        return ds;
    }

    // =========================================================
    // a. Dùng JOIN để liệt kê: Tên hệ, Mã môn, Tên môn
    // =========================================================
    public static void Bai62a()
    {
        Console.WriteLine("\n========== BÀI 6.2a ==========");

        List<He> dsHe = DS_He();
        List<MonHoc> dsMon = DS_Mon();

        var ketqua = from h in dsHe
                     join m in dsMon
                     on h.MaHe equals m.He
                     select new
                     {
                         TenHe = h.TenHe,
                         MaMon = m.MaMon,
                         TenMon = m.TenMon
                     };

        foreach (var x in ketqua)
        {
            Console.WriteLine(
                x.TenHe + " - " +
                x.MaMon + " - " +
                x.TenMon);
        }
    }

    // =========================================================
    // b. LEFT OUTER JOIN
    // Liệt kê cả những hệ chưa có môn học
    // =========================================================
    public static void Bai62b()
    {
        Console.WriteLine("\n========== BÀI 6.2b ==========");

        List<He> dsHe = DS_He();
        List<MonHoc> dsMon = DS_Mon();

        var ketqua = dsHe
            .GroupJoin(
                dsMon,
                h => h.MaHe,
                m => m.He,
                (h, mon) => new
                {
                    He = h,
                    Mon = mon
                })
            .SelectMany(
                x => x.Mon.DefaultIfEmpty(),
                (x, m) => new
                {
                    TenHe = x.He.TenHe,
                    MaMon = m == null ? "" : m.MaMon,
                    TenMon = m == null ? "Chưa có môn học" : m.TenMon
                });

        foreach (var x in ketqua)
        {
            Console.WriteLine(
                x.TenHe + " - " +
                x.MaMon + " - " +
                x.TenMon);
        }
    }

    // =========================================================
    // c. Liệt kê cả:
    // - Hệ chưa có môn học
    // - Môn học chưa khai báo hệ
    // FULL OUTER JOIN mô phỏng bằng UNION
    // =========================================================
    public static void Bai62c()
    {
        Console.WriteLine("\n========== BÀI 6.2c ==========");

        List<He> dsHe = DS_He();
        List<MonHoc> dsMon = DS_Mon();

        // Phần 1: tất cả hệ + môn nếu có
        var phan1 = dsHe
            .GroupJoin(
                dsMon,
                h => h.MaHe,
                m => m.He,
                (h, mon) => new
                {
                    TenHe = h.TenHe,
                    MaMon = mon.Select(x => x.MaMon).FirstOrDefault() ?? "",
                    TenMon = mon.Select(x => x.TenMon).FirstOrDefault()
                              ?? "Chưa có môn học"
                });

        // Phần 2: môn học chưa khai báo hệ
        var phan2 = dsMon
            .Where(m => !dsHe.Any(h => h.MaHe == m.He))
            .Select(m => new
            {
                TenHe = "Chưa khai báo hệ",
                MaMon = m.MaMon,
                TenMon = m.TenMon
            });

        foreach (var x in phan1)
        {
            Console.WriteLine(
                x.TenHe + " - " +
                x.MaMon + " - " +
                x.TenMon);
        }

        foreach (var x in phan2)
        {
            Console.WriteLine(
                x.TenHe + " - " +
                x.MaMon + " - " +
                x.TenMon);
        }
    }

    // =========================================================
    // d. Chỉ liệt kê:
    // - Hệ chưa có môn học
    // - Môn học chưa khai báo hệ
    // =========================================================
    public static void Bai62d()
    {
        Console.WriteLine("\n========== BÀI 6.2d ==========");

        List<He> dsHe = DS_He();
        List<MonHoc> dsMon = DS_Mon();

        // Hệ chưa có môn
        var heChuaCoMon = dsHe
            .Where(h => !dsMon.Any(m => m.He == h.MaHe))
            .Select(h => new
            {
                TenHe = h.TenHe,
                MaMon = "",
                TenMon = "Chưa có môn học"
            });

        // Môn chưa khai báo hệ
        var monChuaCoHe = dsMon
            .Where(m => !dsHe.Any(h => h.MaHe == m.He))
            .Select(m => new
            {
                TenHe = "Chưa khai báo hệ",
                MaMon = m.MaMon,
                TenMon = m.TenMon
            });

        foreach (var x in heChuaCoMon)
        {
            Console.WriteLine(
                x.TenHe + " - " +
                x.MaMon + " - " +
                x.TenMon);
        }

        foreach (var x in monChuaCoHe)
        {
            Console.WriteLine(
                x.TenHe + " - " +
                x.MaMon + " - " +
                x.TenMon);
        }
    }

    // =========================================================
    // e. Lấy 5 môn học đầu tiên có số tiết giảm dần
    // =========================================================
    public static void Bai62e()
    {
        Console.WriteLine("\n========== BÀI 6.2e ==========");

        List<He> dsHe = DS_He();
        List<MonHoc> dsMon = DS_Mon();

        var ketqua = dsMon
            .OrderByDescending(m => m.SoTiet)
            .Take(5)
            .Join(
                dsHe,
                m => m.He,
                h => h.MaHe,
                (m, h) => new
                {
                    TenHe = h.TenHe,
                    MaMon = m.MaMon,
                    TenMon = m.TenMon,
                    SoTiet = m.SoTiet
                });

        foreach (var x in ketqua)
        {
            Console.WriteLine(
                x.TenHe + " - " +
                x.MaMon + " - " +
                x.TenMon + " - " +
                x.SoTiet + " tiết");
        }
    }

    // =========================================================
    // f. Tổng số môn học của mỗi hệ
    // =========================================================
    public static void Bai62f()
    {
        Console.WriteLine("\n========== BÀI 6.2f ==========");

        List<He> dsHe = DS_He();
        List<MonHoc> dsMon = DS_Mon();

        var ketqua = dsHe
            .GroupJoin(
                dsMon,
                h => h.MaHe,
                m => m.He,
                (h, mon) => new
                {
                    MaHe = h.MaHe,
                    TenHe = h.TenHe,
                    TongSoMon = mon.Count()
                });

        foreach (var x in ketqua)
        {
            Console.WriteLine(
                x.MaHe + " - " +
                x.TenHe + " - " +
                x.TongSoMon);
        }
    }

    // =========================================================
    // g. Có bao nhiêu loại Số tiết khác nhau
    // =========================================================
    public static void Bai62g()
    {
        Console.WriteLine("\n========== BÀI 6.2g ==========");

        List<MonHoc> dsMon = DS_Mon();

        int ketqua = dsMon
            .Select(x => x.SoTiet)
            .Distinct()
            .Count();

        Console.WriteLine("Có " + ketqua + " loại số tiết khác nhau.");
    }

    // =========================================================
    // h. Tìm môn học đầu tiên có tên bắt đầu bằng "Lập trình"
    // =========================================================
    public static void Bai62h()
    {
        Console.WriteLine("\n========== BÀI 6.2h ==========");

        List<MonHoc> dsMon = DS_Mon();

        var ketqua = dsMon
            .FirstOrDefault(x => x.TenMon.StartsWith("Lập trình"));

        if (ketqua != null)
        {
            Console.WriteLine("Mã môn: " + ketqua.MaMon);
            Console.WriteLine("Tên môn: " + ketqua.TenMon);
            Console.WriteLine("Hệ: " + ketqua.He);
            Console.WriteLine("Số tiết: " + ketqua.SoTiet);
        }
        else
        {
            Console.WriteLine("Không tìm thấy môn học.");
        }
    }

    // =========================================================
    // i. Liệt kê các môn theo từng hệ,
    //    đánh số thứ tự trong mỗi nhóm
    // =========================================================
    public static void Bai62i()
    {
        Console.WriteLine("\n========== BÀI 6.2i ==========");

        List<He> dsHe = DS_He();
        List<MonHoc> dsMon = DS_Mon();

        var ketqua = dsHe
            .GroupJoin(
                dsMon,
                h => h.MaHe,
                m => m.He,
                (h, mon) => new
                {
                    He = h,
                    Mon = mon
                });

        foreach (var nhom in ketqua)
        {
            Console.WriteLine("\n===== " + nhom.He.TenHe + " =====");

            int stt = 1;

            foreach (var mon in nhom.Mon)
            {
                Console.WriteLine(
                    stt + ". " +
                    mon.MaMon + " - " +
                    mon.TenMon);

                stt++;
            }
        }
    }

    // =========================================================
    // MAIN
    // =========================================================
    static void Main()
    {
        Bai62a();
        Bai62b();
        Bai62c();
        Bai62d();
        Bai62e();
        Bai62f();
        Bai62g();
        Bai62h();
        Bai62i();
    }
}