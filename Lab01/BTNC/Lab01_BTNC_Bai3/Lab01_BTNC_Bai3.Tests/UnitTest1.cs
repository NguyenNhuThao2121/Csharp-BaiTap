using Xunit;
using Lab01_BTNC_Bai3;

namespace Lab01_BTNC_Bai3.Tests
{
    public class TinhY1Tests
    {
        [Theory]
        [InlineData(0, 4)]      // x=0: 4*(0+0+0+1) = 4
        [InlineData(1, 60)]     // x=1: 4*(1+10*1*1+3+1) = 4*15 = 60
        [InlineData(4, 436)]    // x=4: 4*(16+10*2*4+12+1) = 4*(16+80+12+1) = 4*109 = 436
        [InlineData(9, 1516)]   // x=9: 4*(81+10*3*9+27+1) = 4*(81+270+27+1) = 4*379 = 1516
        public void TinhY1_GiaTriHopLe_TraVeDung(double x, double expected)
        {
            double result = Program.TinhY1(x);
            Assert.Equal(expected, result, 2); // độ chính xác 2 chữ số thập phân
        }

        [Fact]
        public void TinhY1_XAm_ThrowException()
        {
            // Math.Sqrt(x) với x < 0 sẽ trả về NaN
            double result = Program.TinhY1(-1);
            Assert.True(double.IsNaN(result));
        }
    }

    public class TinhY2Tests
    {
        [Theory]
        [InlineData(0, 2)]      // x=0: (0+1)/1+1 = 2
        [InlineData(1, 0.898)]  // x=1: tính thủ công gần đúng
        [InlineData(2, 0.041)]  // x=2: tính thủ công gần đúng
        public void TinhY2_GiaTriHopLe_TraVeDung(double x, double expected)
        {
            double result = Program.TinhY2(x);
            Assert.Equal(expected, result, 2);
        }
    }
}
