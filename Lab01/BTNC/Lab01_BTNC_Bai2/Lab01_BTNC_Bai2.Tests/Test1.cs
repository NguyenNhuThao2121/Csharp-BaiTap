using Microsoft.VisualStudio.TestTools.UnitTesting;
using BTNC_Lab01;
using System;

namespace BTNC_Lab01.Tests
{
    [TestClass]
    public class Test1
    {
        // Test 1: 0 độ
        [TestMethod]
        public void TC01_Doi0Do()
        {
            double ketQua = doiDoSangRadian.DoiDoSangRadian(0);

            Assert.AreEqual(0, ketQua, 0.0001);
        }

        // Test 2: 30 độ
        [TestMethod]
        public void TC02_Doi30Do()
        {
            double ketQua = doiDoSangRadian.DoiDoSangRadian(30);

            Assert.AreEqual(Math.PI / 6, ketQua, 0.0001);
        }

        // Test 3: 45 độ
        [TestMethod]
        public void TC03_Doi45Do()
        {
            double ketQua = doiDoSangRadian.DoiDoSangRadian(45);

            Assert.AreEqual(Math.PI / 4, ketQua, 0.0001);
        }

        // Test 4: 60 độ
        [TestMethod]
        public void TC04_Doi60Do()
        {
            double ketQua = doiDoSangRadian.DoiDoSangRadian(60);

            Assert.AreEqual(Math.PI / 3, ketQua, 0.0001);
        }

        // Test 5: 90 độ
        [TestMethod]
        public void TC05_Doi90Do()
        {
            double ketQua = doiDoSangRadian.DoiDoSangRadian(90);

            Assert.AreEqual(Math.PI / 2, ketQua, 0.0001);
        }

        // Test 6: 120 độ
        [TestMethod]
        public void TC06_Doi120Do()
        {
            double ketQua = doiDoSangRadian.DoiDoSangRadian(120);

            Assert.AreEqual(2 * Math.PI / 3, ketQua, 0.0001);
        }

        // Test 7: 180 độ
        [TestMethod]
        public void TC07_Doi180Do()
        {
            double ketQua = doiDoSangRadian.DoiDoSangRadian(180);

            Assert.AreEqual(Math.PI, ketQua, 0.0001);
        }

        // Test 8: 270 độ
        [TestMethod]
        public void TC08_Doi270Do()
        {
            double ketQua = doiDoSangRadian.DoiDoSangRadian(270);

            Assert.AreEqual(3 * Math.PI / 2, ketQua, 0.0001);
        }

        // Test 9: 360 độ
        [TestMethod]
        public void TC09_Doi360Do()
        {
            double ketQua = doiDoSangRadian.DoiDoSangRadian(360);

            Assert.AreEqual(2 * Math.PI, ketQua, 0.0001);
        }

        // Test 10: -90 độ
        [TestMethod]
        public void TC10_DoiAm90Do()
        {
            double ketQua = doiDoSangRadian.DoiDoSangRadian(-90);

            Assert.AreEqual(-Math.PI / 2, ketQua, 0.0001);
        }
    }
}