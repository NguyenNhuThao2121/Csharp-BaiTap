using Microsoft.VisualStudio.TestTools.UnitTesting;
using BTCB.Buoi01;
using System;

namespace Lab01_BTCB_Bai2.Tests
{
    [TestClass]
    public class Test1
    {
        // ===== 5 TEST DIỆN TÍCH =====

        [TestMethod]
        public void TC01_DienTich_R1()
        {
            double ketQua = TinhDienTinh_ChuVi_HinhTron.TinhDienTich(1);
            Assert.AreEqual(Math.PI, ketQua, 0.0001);
        }

        [TestMethod]
        public void TC02_DienTich_R2()
        {
            double ketQua = TinhDienTinh_ChuVi_HinhTron.TinhDienTich(2);
            Assert.AreEqual(4 * Math.PI, ketQua, 0.0001);
        }

        [TestMethod]
        public void TC03_DienTich_R3()
        {
            double ketQua = TinhDienTinh_ChuVi_HinhTron.TinhDienTich(3);
            Assert.AreEqual(9 * Math.PI, ketQua, 0.0001);
        }

        [TestMethod]
        public void TC04_DienTich_R5()
        {
            double ketQua = TinhDienTinh_ChuVi_HinhTron.TinhDienTich(5);
            Assert.AreEqual(25 * Math.PI, ketQua, 0.0001);
        }

        [TestMethod]
        public void TC05_DienTich_R10()
        {
            double ketQua = TinhDienTinh_ChuVi_HinhTron.TinhDienTich(10);
            Assert.AreEqual(100 * Math.PI, ketQua, 0.0001);
        }


        // ===== 5 TEST CHU VI =====

        [TestMethod]
        public void TC06_ChuVi_R1()
        {
            double ketQua = TinhDienTinh_ChuVi_HinhTron.TinhChuVi(1);
            Assert.AreEqual(2 * Math.PI, ketQua, 0.0001);
        }

        [TestMethod]
        public void TC07_ChuVi_R2()
        {
            double ketQua = TinhDienTinh_ChuVi_HinhTron.TinhChuVi(2);
            Assert.AreEqual(4 * Math.PI, ketQua, 0.0001);
        }

        [TestMethod]
        public void TC08_ChuVi_R3()
        {
            double ketQua = TinhDienTinh_ChuVi_HinhTron.TinhChuVi(3);
            Assert.AreEqual(6 * Math.PI, ketQua, 0.0001);
        }

        [TestMethod]
        public void TC09_ChuVi_R5()
        {
            double ketQua = TinhDienTinh_ChuVi_HinhTron.TinhChuVi(5);
            Assert.AreEqual(10 * Math.PI, ketQua, 0.0001);
        }

        [TestMethod]
        public void TC10_ChuVi_R10()
        {
            double ketQua = TinhDienTinh_ChuVi_HinhTron.TinhChuVi(10);
            Assert.AreEqual(20 * Math.PI, ketQua, 0.0001);
        }
    }
}