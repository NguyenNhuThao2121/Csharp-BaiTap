using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab01_NC104_NHV;

namespace Lab01_NC104_NHVTest
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void TestCase1()
        {
            double expected = 2;
            double actual = Program.CanBac(4, 2);

            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void TestCase2()
        {
            double expected = 3;
            double actual = Program.CanBac(9, 2);

            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void TestCase3()
        {
            double expected = 2;
            double actual = Program.CanBac(8, 3);

            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void TestCase4()
        {
            double expected = 3;
            double actual = Program.CanBac(27, 3);

            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void TestCase5()
        {
            double expected = 2;
            double actual = Program.CanBac(16, 4);

            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void TestCase6()
        {
            double expected = 2;
            double actual = Program.CanBac(32, 5);

            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void TestCase7()
        {
            double expected = 10;
            double actual = Program.CanBac(100, 2);

            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void TestCase8()
        {
            double expected = 1;
            double actual = Program.CanBac(1, 2);

            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void TestCase9()
        {
            double expected = 0;
            double actual = Program.CanBac(0, 2);

            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void TestCase10()
        {
            double expected = 4;
            double actual = Program.CanBac(64, 3);

            Assert.AreEqual(expected, actual, 0.0001);
        }
    }
}