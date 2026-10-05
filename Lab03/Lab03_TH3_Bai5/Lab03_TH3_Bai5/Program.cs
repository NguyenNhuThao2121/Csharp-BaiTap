using System;
using System.Collections.Generic;
using System.Linq;

namespace BaiThucHanhLinq
{
    // ============================================
    // LỚP MONHOC
    // ============================================
    public class MonHoc
    {
        public string MaMon { get; set; } = "";
        public string TenMon { get; set; } = "";
        public string He { get; set; } = "";
        public byte SoTiet { get; set; }
    }


    // ============================================
    // LỚP DỮ LIỆU
    // ============================================
    public class DuLieu
    {
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
    }


    // ============================================
    // BÀI 5.1
    // ============================================
    class Program
    {
        static void Main()
        {
            bai51a();
            bai51b();
            bai51c();
            bai51d();
        }


        // a. Liệt kê tên các môn học bắt đầu bằng "Lập trình"
        static void bai51a()
        {
            List<MonHoc> dsMon = DuLieu.DS_Mon();

            var ketqua = dsMon
                .Where(x => x.TenMon.StartsWith("Lập trình"))
                .Select(x => x.TenMon);

            Console.WriteLine("========== BAI 5.1a ==========");

            foreach (var x in ketqua)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine();
        }


        // b. Các môn hệ CD,
        //    sắp xếp số tiết giảm dần,
        //    sau đó mã môn tăng dần
        static void bai51b()
        {
            List<MonHoc> dsMon = DuLieu.DS_Mon();

            var ketqua = dsMon
                .Where(x => x.He == "CD")
                .OrderByDescending(x => x.SoTiet)
                .ThenBy(x => x.MaMon);

            Console.WriteLine("========== BAI 5.1b ==========");

            foreach (var x in ketqua)
            {
                Console.WriteLine(
                    x.MaMon + " - " +
                    x.TenMon + " - " +
                    x.He + " - " +
                    x.SoTiet
                );
            }

            Console.WriteLine();
        }


        // c. Tên môn chứa từ "web",
        //    chỉ lấy Tên môn và Hệ
        static void bai51c()
        {
            List<MonHoc> dsMon = DuLieu.DS_Mon();

            var ketqua = dsMon
                .Where(x => x.TenMon.ToLower().Contains("web"))
                .Select(x => new
                {
                    TenMon = x.TenMon,
                    He = x.He
                });

            Console.WriteLine("========== BAI 5.1c ==========");

            foreach (var x in ketqua)
            {
                Console.WriteLine(
                    x.TenMon + " - " + x.He
                );
            }

            Console.WriteLine();
        }


        // d. Các môn hệ KTV,
        //    sắp xếp tăng dần theo Mã môn
        static void bai51d()
        {
            List<MonHoc> dsMon = DuLieu.DS_Mon();

            var ketqua = dsMon
                .Where(x => x.He == "KTV")
                .OrderBy(x => x.MaMon);

            Console.WriteLine("========== BAI 5.1d ==========");

            foreach (var x in ketqua)
            {
                Console.WriteLine(
                    x.MaMon + " - " +
                    x.TenMon
                );
            }

            Console.WriteLine();
        }
    }
}