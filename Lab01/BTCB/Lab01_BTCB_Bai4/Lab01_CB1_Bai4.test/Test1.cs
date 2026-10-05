using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab01NHV;

namespace Lab01_CB104Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void TestCase1()
        {
            // Arrange
            string expected = "0:0:0";

            // Act
            string actual = Program.DoiGiay(0);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCase2()
        {
            Assert.AreEqual(
                "0:0:1",
                Program.DoiGiay(1)
            );
        }

        [TestMethod]
        public void TestCase3()
        {
            Assert.AreEqual(
                "0:0:59",
                Program.DoiGiay(59)
            );
        }

        [TestMethod]
        public void TestCase4()
        {
            Assert.AreEqual(
                "0:1:0",
                Program.DoiGiay(60)
            );
        }

        [TestMethod]
        public void TestCase5()
        {
            Assert.AreEqual(
                "0:1:1",
                Program.DoiGiay(61)
            );
        }

        [TestMethod]
        public void TestCase6()
        {
            Assert.AreEqual(
                "0:59:59",
                Program.DoiGiay(3599)
            );
        }

        [TestMethod]
        public void TestCase7()
        {
            Assert.AreEqual(
                "1:0:0",
                Program.DoiGiay(3600)
            );
        }

        [TestMethod]
        public void TestCase8()
        {
            Assert.AreEqual(
                "1:0:1",
                Program.DoiGiay(3601)
            );
        }

        [TestMethod]
        public void TestCase9()
        {
            Assert.AreEqual(
                "1:1:1",
                Program.DoiGiay(3661)
            );
        }

        [TestMethod]
        public void TestCase10()
        {
            Assert.AreEqual(
                "2:46:40",
                Program.DoiGiay(10000)
            );
        }
    }
}