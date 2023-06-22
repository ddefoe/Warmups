using Xunit;
using Warmups.BLL;

namespace Warmups.Tests
{
    public class LogicTests
    {
        private Logic _logic = new Logic();

        [Theory]
        [InlineData(30, false, false)]
        [InlineData(50, false, true)]
        [InlineData(70, true, true)]
        [InlineData(20, true, false)]
        public void GreatPartyTest(int n, bool b, bool expected)
        {
            var actual = _logic.GreatParty(n, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 10, 2)]
        [InlineData(5, 2, 0)]
        [InlineData(5, 5, 1)]
        public void CanHazTableTest(int x, int y, int expected)
        {
            var actual = _logic.CanHazTable(x, y);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(70, false, true)]
        [InlineData(95, false, false)]
        [InlineData(95, true, true)]
        public void PlayOutsideTest(int n, bool b, bool expected)
        {
            var actual = _logic.PlayOutside(n, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(60, false, 0)]
        [InlineData(65, false, 1)]
        [InlineData(65, true, 0)]
        public void CaughtSpeedingTest(int n, bool b, int expected)
        {
            var actual = _logic.CaughtSpeeding(n, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 4, 7)]
        [InlineData(9, 4, 20)]
        [InlineData(10, 11, 21)]
        public void SkipSumTest(int a, int b, int expected)
        {
            var actual = _logic.SkipSum(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, false, "7:00")]
        [InlineData(5, false, "7:00")]
        [InlineData(0, false, "10:00")]
        public void AlarmClockTest(int n, bool b, string expected)
        {
            var actual = _logic.AlarmClock(n, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, 4, true)]
        [InlineData(4, 5, false)]
        [InlineData(1, 5, true)]
        public void LoveSixTest(int a, int b, bool expected)
        {
            var actual = _logic.LoveSix(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, false, true)]
        [InlineData(11, false, false)]
        [InlineData(11, true, true)]
        public void InRangeTest(int n, bool b, bool expected)
        {
            var actual = _logic.InRange(n, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(22, true)]
        [InlineData(23, true)]
        [InlineData(24, false)]
        public void SpecialElevenTest(int n, bool expected)
        {
            var actual = _logic.SpecialEleven(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20, false)]
        [InlineData(21, true)]
        [InlineData(22, true)]
        public void Mod20Test(int n, bool expected)
        {
            var actual = _logic.Mod20(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, true)]
        [InlineData(10, true)]
        [InlineData(15, false)]
        public void Mod35Test(int n, bool expected)
        {
            var actual = _logic.Mod35(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(false, false, false, true)]
        [InlineData(false, false, true, false)]
        [InlineData(true, false, false, false)]
        public void AnswerCellTest(bool a, bool b, bool c, bool expected)
        {
            var actual = _logic.AnswerCell(a, b, c);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2, 3, true)]
        [InlineData(3, 1, 2, true)]
        [InlineData(3, 2, 2, false)]
        public void TwoIsOneTest(int x, int y, int z, bool expected)
        {
            var actual = _logic.TwoIsOne(x, y, z);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2, 4, false, true)]
        [InlineData(1, 2, 1, false, false)]
        [InlineData(1, 1, 2, true, true)]
        public void AreInOrderTest(int x, int y, int z, bool b, bool expected)
        {
            var actual = _logic.AreInOrder(x, y, z, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 5, 11, false, true)]
        [InlineData(5, 7, 6, false, false)]
        [InlineData(5, 5, 7, true, true)]
        [InlineData(6, 5, 5, true, false)]
        public void InOrderEqualTest(int x, int y, int z, bool b, bool expected)
        {
            var actual = _logic.InOrderEqual(x, y, z, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(23, 19, 13, true)]
        [InlineData(23, 19, 12, false)]
        [InlineData(23, 19, 3, true)]
        public void LastDigitTest(int x, int y, int z, bool expected)
        {
            var actual = _logic.LastDigit(x, y, z);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, true, 5)]
        [InlineData(3, 3, true, 7)]
        [InlineData(3, 3, false, 6)]
        [InlineData(6, 6, true, 7)]
        public void RollDiceTest(int x, int y, bool b, int expected)
        {
            var actual = _logic.RollDice(x, y, b);
            Assert.Equal(expected, actual);
        }

    }
}
