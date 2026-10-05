using System;
using System.Collections.Generic;
using System.Linq;

namespace BaiThucHanhLinq
{
    // =====================================================
    // LỚP MONHOC
    // =====================================================

    public class MonHoc
    {
        public string MaMon { get; set; } = "";
        public string TenMon { get; set; } = "";
        public string He { get; set; } = "";
        public byte SoTiet { get; set; }
    }


    // =====================================================
    // LỚP DỮ LIỆU
    // =====================================================

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


    // =====================================================
    // BÀI 5.2
    // =====================================================

    class Program
    {
        static void Main()
        {
            bai52a();
            bai52b();
            bai52c();
            bai52d();
            bai52e();
            bai52f();
            bai52g();
            bai52h();
            bai52i();
            bai52j();
            bai52k();
        }


        // -------------------------------------------------
        // a. Tổng số môn hiện có
        // -------------------------------------------------

        static void bai52a()
        {
            List<MonHoc> dsMon = DuLieu.DS_Mon();

            int ketqua = dsMon.Count();

            Console.WriteLine("========== BAI 5.2a ==========");
            Console.WriteLine("Tong so mon: " + ketqua);
            Console.WriteLine();
        }


        // -------------------------------------------------
        // b. Đếm số môn bắt đầu bằng "Lập trình"
        // -------------------------------------------------

        static void bai52b()
        {
            List<MonHoc> dsMon = DuLieu.DS_Mon();

            int ketqua = dsMon
                .Count(x => x.TenMon.StartsWith("Lập trình"));

            Console.WriteLine("========== BAI 5.2b ==========");
            Console.WriteLine(
                "So mon bat dau bang 'Lap trinh': " + ketqua
            );

            Console.WriteLine();
        }


        // -------------------------------------------------
        // c. Tổng số tiết của hệ KTV
        // -------------------------------------------------

        static void bai52c()
        {
            List<MonHoc> dsMon = DuLieu.DS_Mon();

            int ketqua = dsMon
                .Where(x => x.He == "KTV")
                .Sum(x => x.SoTiet);

            Console.WriteLine("========== BAI 5.2c ==========");
            Console.WriteLine("Tong so tiet cua he KTV: " + ketqua);

            Console.WriteLine();
        }


        // -------------------------------------------------
        // d. Tổng số môn của mỗi hệ
        // -------------------------------------------------

        static void bai52d()
        {
            List<MonHoc> dsMon = DuLieu.DS_Mon();

            var ketqua = dsMon
                .GroupBy(x => x.He);

            Console.WriteLine("========== BAI 5.2d ==========");

            foreach (var nhom in ketqua)
            {
                Console.WriteLine(
                    "He: " + nhom.Key +
                    " - Tong so mon: " + nhom.Count()
                );
            }

            Console.WriteLine();
        }


        // -------------------------------------------------
        // e. Nhóm theo Số tiết
        //    In Số tiết và Tổng số môn
        //    Sắp xếp giảm dần theo Số tiết
        // -------------------------------------------------

        static void bai52e()
        {
            List<MonHoc> dsMon = DuLieu.DS_Mon();

            var ketqua = dsMon
                .GroupBy(x => x.SoTiet)
                .OrderByDescending(nhom => nhom.Key);

            Console.WriteLine("========== BAI 5.2e ==========");

            foreach (var nhom in ketqua)
            {
                Console.WriteLine(
                    "So tiet: " + nhom.Key +
                    " - Tong so mon: " + nhom.Count()
                );
            }

            Console.WriteLine();
        }


        // -------------------------------------------------
        // f. Thông tin môn có số tiết cao nhất
        // -------------------------------------------------

        static void bai52f()
        {
            List<MonHoc> dsMon = DuLieu.DS_Mon();

            byte soTietCaoNhat = dsMon.Max(x => x.SoTiet);

            var ketqua = dsMon
                .Where(x => x.SoTiet == soTietCaoNhat);

            Console.WriteLine("========== BAI 5.2f ==========");

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


        // -------------------------------------------------
        // g. Thống kê theo Hệ:
        //    Tổng số môn
        //    Tổng số tiết
        //    Số tiết cao nhất
        //    Số tiết thấp nhất
        // -------------------------------------------------

        static void bai52g()
        {
            List<MonHoc> dsMon = DuLieu.DS_Mon();

            var ketqua = dsMon
                .GroupBy(x => x.He);

            Console.WriteLine("========== BAI 5.2g ==========");

            foreach (var nhom in ketqua)
            {
                Console.WriteLine("He: " + nhom.Key);
                Console.WriteLine("  Tong so mon: " + nhom.Count());
                Console.WriteLine("  Tong so tiet: " + nhom.Sum(x => x.SoTiet));
                Console.WriteLine("  So tiet cao nhat: " + nhom.Max(x => x.SoTiet));
                Console.WriteLine("  So tiet thap nhat: " + nhom.Min(x => x.SoTiet));
            }

            Console.WriteLine();
        }


        // -------------------------------------------------
        // h. Phân nhóm môn học theo Hệ
        // -------------------------------------------------

        static void bai52h()
        {
            List<MonHoc> dsMon = DuLieu.DS_Mon();

            var ketqua = dsMon
                .GroupBy(x => x.He);

            Console.WriteLine("========== BAI 5.2h ==========");

            foreach (var nhom in ketqua)
            {
                Console.WriteLine("===== He: " + nhom.Key + " =====");

                foreach (var mon in nhom)
                {
                    Console.WriteLine(
                        mon.MaMon + " - " + mon.TenMon
                    );
                }
            }

            Console.WriteLine();
        }


        // -------------------------------------------------
        // i. Phân nhóm theo Số tiết
        //    và tăng dần theo Số tiết
        // -------------------------------------------------

        static void bai52i()
        {
            List<MonHoc> dsMon = DuLieu.DS_Mon();

            var ketqua = dsMon
                .GroupBy(x => x.SoTiet)
                .OrderBy(nhom => nhom.Key);

            Console.WriteLine("========== BAI 5.2i ==========");

            foreach (var nhom in ketqua)
            {
                Console.WriteLine("===== " + nhom.Key + " tiet =====");

                foreach (var mon in nhom)
                {
                    Console.WriteLine(
                        mon.MaMon + " - " + mon.TenMon
                    );
                }
            }

            Console.WriteLine();
        }


        // -------------------------------------------------
        // j. Với hệ KTV:
        //    Phân nhóm theo HP2, HP3, HP4, HP5
        //    Sắp xếp theo Mã môn
        // -------------------------------------------------

        static void bai52j()
        {
            List<MonHoc> dsMon = DuLieu.DS_Mon();

            var ketqua = dsMon
                .Where(x => x.He == "KTV")
                .GroupBy(x => x.MaMon.Substring(0, 3))
                .OrderBy(nhom => nhom.Key);

            Console.WriteLine("========== BAI 5.2j ==========");

            foreach (var nhom in ketqua)
            {
                Console.WriteLine("===== " + nhom.Key + " =====");

                foreach (var mon in nhom.OrderBy(x => x.MaMon))
                {
                    Console.WriteLine(
                        mon.MaMon + " - " + mon.TenMon
                    );
                }
            }

            Console.WriteLine();
        }


        // -------------------------------------------------
        // k. Phân nhóm theo Hệ
        //    Chỉ lấy môn có Số tiết > 40
        //    Trong mỗi nhóm sắp xếp theo Mã môn
        // -------------------------------------------------

        static void bai52k()
        {
            List<MonHoc> dsMon = DuLieu.DS_Mon();

            var ketqua = dsMon
                .Where(x => x.SoTiet > 40)
                .GroupBy(x => x.He);

            Console.WriteLine("========== BAI 5.2k ==========");

            foreach (var nhom in ketqua)
            {
                Console.WriteLine("===== He: " + nhom.Key + " =====");

                foreach (var mon in nhom.OrderBy(x => x.MaMon))
                {
                    Console.WriteLine(
                        mon.MaMon + " - " +
                        mon.TenMon + " - " +
                        mon.SoTiet
                    );
                }
            }

            Console.WriteLine();
        }
    }
}