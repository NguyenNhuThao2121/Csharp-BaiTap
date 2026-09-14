using Xunit;
using Lab01_BTCB_Bai3;

namespace Lab01_BTCB_Bai3.Tests
{
    /// <summary>
    /// Test case cho hàm Tinhtong: quy đổi giờ/phút/giây ra tổng số giây
    /// </summary>
    public class TinhtongTests
    {
        [Fact]
        public void Tinhtong_GioPhutGiayBang0_TraVe0()
        {
            // Arrange
            int gio = 0, phut = 0, giay = 0;

            // Act
            int result = Program.tinhtong(gio, phut, giay);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Tinhtong_1Gio_TraVe3600()
        {
            int result = Program.tinhtong(1, 0, 0);
            Assert.Equal(3600, result);
        }

        [Fact]
        public void Tinhtong_1Phut_TraVe60()
        {
            int result = Program.tinhtong(0, 1, 0);
            Assert.Equal(60, result);
        }

        [Fact]
        public void Tinhtong_1Giay_TraVe1()
        {
            int result = Program.tinhtong(0, 0, 1);
            Assert.Equal(1, result);
        }

        [Theory]
        [InlineData(1, 2, 3, 3723)]      // 1h2p3s
        [InlineData(2, 30, 0, 9000)]     // 2h30p
        [InlineData(0, 59, 59, 3599)]    // 59p59s
        [InlineData(23, 59, 59, 86399)]  // 23h59p59s (max trong ngày)
        [InlineData(10, 15, 30, 36930)]  // 10h15p30s
        public void Tinhtong_CacTruongHopHopLe_TinhDungTongGiay(int gio, int phut, int giay, int expected)
        {
            int result = Program.tinhtong(gio, phut, giay);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, 0, 90, 90)]       // giay > 59: 90 giay -> 90 (khong chuan hoa)
        [InlineData(0, 75, 0, 4500)]     // phut > 59
        [InlineData(25, 0, 0, 90000)]    // gio > 23
        public void Tinhtong_GiaTriNgoaiBienVanTinhCongThuc(int gio, int phut, int giay, int expected)
        {
            // Ham chi ap dung cong thuc, khong validate dau vao
            int result = Program.tinhtong(gio, phut, giay);
            Assert.Equal(expected, result);
        }
    }
}
