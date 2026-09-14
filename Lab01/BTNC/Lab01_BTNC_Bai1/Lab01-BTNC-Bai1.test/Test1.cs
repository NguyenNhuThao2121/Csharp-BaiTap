using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using btnc2;

namespace Lab01_BTNC_Bai1
{
    [TestClass]
    public sealed class Test1
    {
        // Test case 1: Hai điểm trùng nhau
        [TestMethod]
        public void Test01_HaiDiemGiongNhau()
        {
            double ketQua = TinhKhoangCach.TinhKhoangCachGiuaHaiDiem(2, 3, 2, 3);

            Assert.AreEqual(0, ketQua);
        }

        // Test case 2: Khoảng cách theo trục X
        [TestMethod]
        public void Test02_KhoangCachTheoTrucX()
        {
            double ketQua = TinhKhoangCach.TinhKhoangCachGiuaHaiDiem(1, 2, 4, 2);

            Assert.AreEqual(3, ketQua);
        }

        // Test case 3: Khoảng cách theo trục Y
        [TestMethod]
        public void Test03_KhoangCachTheoTrucY()
        {
            double ketQua = TinhKhoangCach.TinhKhoangCachGiuaHaiDiem(2, 1, 2, 5);

            Assert.AreEqual(4, ketQua);
        }

        // Test case 4: Tam giác 3-4-5
        [TestMethod]
        public void Test04_TamGiac345()
        {
            double ketQua = TinhKhoangCach.TinhKhoangCachGiuaHaiDiem(1, 2, 4, 6);

            Assert.AreEqual(5, ketQua);
        }

        // Test case 5: Hai điểm có tọa độ âm
        [TestMethod]
        public void Test05_HaiDiemAm()
        {
            double ketQua = TinhKhoangCach.TinhKhoangCachGiuaHaiDiem(-1, -2, -4, -6);

            Assert.AreEqual(5, ketQua);
        }

        // Test case 6: Một điểm ở gốc tọa độ
        [TestMethod]
        public void Test06_MotDiemLaGocToaDo()
        {
            double ketQua = TinhKhoangCach.TinhKhoangCachGiuaHaiDiem(0, 0, 3, 4);

            Assert.AreEqual(5, ketQua);
        }

        // Test case 7: Hai điểm đối xứng qua gốc
        [TestMethod]
        public void Test07_HaiDiemDoiXung()
        {
            double ketQua = TinhKhoangCach.TinhKhoangCachGiuaHaiDiem(-2, 0, 2, 0);

            Assert.AreEqual(4, ketQua);
        }

        // Test case 8: Kết quả là số thập phân
        [TestMethod]
        public void Test08_KetQuaSoThapPhan()
        {
            double ketQua = TinhKhoangCach.TinhKhoangCachGiuaHaiDiem(0, 0, 1, 1);

            Assert.AreEqual(Math.Sqrt(2), ketQua, 0.0001);
        }

        // Test case 9: Khoảng cách lớn
        [TestMethod]
        public void Test09_KhoangCachLon()
        {
            double ketQua = TinhKhoangCach.TinhKhoangCachGiuaHaiDiem(0, 0, 300, 400);

            Assert.AreEqual(500, ketQua);
        }

        // Test case 10: Tọa độ âm và dương
        [TestMethod]
        public void Test10_ToaDoAmVaDuong()
        {
            double ketQua = TinhKhoangCach.TinhKhoangCachGiuaHaiDiem(-3, -4, 0, 0);

            Assert.AreEqual(5, ketQua);
        }
    }
}