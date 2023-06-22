using Xunit;
using Warmups.BLL;

namespace Warmups.Tests
{
    public class ConditionalsTests
    {
        private Conditionals _conditionals = new Conditionals();

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, true)]
        [InlineData(true, false, false)]
        [InlineData(false, true, false)]
        public void AreWeInTroubleTest(bool a, bool b, bool expected)
        {
            var actual = _conditionals.AreWeInTrouble(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(false, false, true)]
        [InlineData(true, false, false)]
        [InlineData(false, true, true)]
        public void CanSleepInTest(bool a, bool b, bool expected)
        {
            var actual = _conditionals.CanSleepIn(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 2, 5)]
        [InlineData(2, 2, 8)]
        public void SumDoubleTest(int a, int b, int expected)
        {
            var actual = _conditionals.SumDouble(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(23, 4)]
        [InlineData(10, 11)]
        [InlineData(21, 0)]
        public void Diff21Test(int n, int expected)
        {
            var actual = _conditionals.Diff21(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(true, 6, true)]
        [InlineData(true, 7, false)]
        [InlineData(false, 6, false)]
        public void ParrotTroubleTest(bool b, int n, bool expected)
        {
            var actual = _conditionals.ParrotTrouble(b, n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(9, 10, true)]
        [InlineData(9, 9, false)]
        [InlineData(1, 9, true)]
        public void Makes10Test(int x, int y, bool expected)
        {
            var actual = _conditionals.Makes10(x, y);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(103, true)]
        [InlineData(90, true)]
        [InlineData(89, false)]
        public void NearHundredTest(int n, bool expected)
        {
            var actual = _conditionals.NearHundred(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, -1, false, true)]
        [InlineData(-1, 1, false, true)]
        [InlineData(-4, -5, true, true)]
        [InlineData(-4, -5, false, false)]
        [InlineData(1, 1, false, false)]
        public void PosNegTest(int x, int y, bool b, bool expected)
        {
            var actual = _conditionals.PosNeg(x, y, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("candy", "not candy")]
        [InlineData("x", "not x")]
        [InlineData("not bad", "not bad")]
        public void NotStringTest(string s, string expected)
        {
            var actual = _conditionals.NotString(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("kitten", 1, "ktten")]
        [InlineData("kitten", 0, "itten")]
        [InlineData("kitten", 4, "kittn")]
        public void MissingCharTest(string s, int n, string expected)
        {
            var actual = _conditionals.MissingChar(s, n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("code", "eodc")]
        [InlineData("a", "a")]
        [InlineData("ab", "ba")]
        public void FrontBackTest(string s, string expected)
        {
            var actual = _conditionals.FrontBack(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Microsoft", "MicMicMic")]
        [InlineData("Chocolate", "ChoChoCho")]
        [InlineData("at", "atatat")]
        public void Front3Test(string s, string expected)
        {
            var actual = _conditionals.Front3(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("cat", "tcatt")]
        [InlineData("Hello", "oHelloo")]
        [InlineData("a", "aaa")]
        public void BackAroundTest(string s, string expected)
        {
            var actual = _conditionals.BackAround(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, true)]
        [InlineData(10, true)]
        [InlineData(8, false)]
        public void Multiple3or5Test(int n, bool expected)
        {
            var actual = _conditionals.Multiple3or5(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("hi there", true)]
        [InlineData("hi", true)]
        [InlineData("high up", false)]
        [InlineData("g", false)]
        [InlineData("hip", false)]
        [InlineData("hi, how are you?", true)]
        public void StartHiTest(string str, bool expected)
        {
            var actual = _conditionals.StartHi(str);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(120, -1, true)]
        [InlineData(-1, 120, true)]
        [InlineData(2, 120, false)]
        public void IcyHotTest(int x, int y, bool expected)
        {
            var actual = _conditionals.IcyHot(x, y);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(12, 99, true)]
        [InlineData(21, 12, true)]
        [InlineData(8, 99, false)]
        public void Between10and20Test(int x, int y, bool expected)
        {
            var actual = _conditionals.Between10and20(x, y);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(13, 20, 10, true)]
        [InlineData(20, 19, 10, true)]
        [InlineData(20, 10, 12, false)]
        public void HasTeenTest(int x, int y, int z, bool expected)
        {
            var actual = _conditionals.HasTeen(x, y, z);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(13, 99, true)]
        [InlineData(21, 19, true)]
        [InlineData(13, 13, false)]
        [InlineData(44, 5, false)]
        public void SoAloneTest(int x, int y, bool expected)
        {
            var actual = _conditionals.SoAlone(x, y);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("adelbc", "abc")]
        [InlineData("adelHello", "aHello")]
        [InlineData("adedbc", "adedbc")]
        public void RemoveDelTest(string s, string expected)
        {
            var actual = _conditionals.RemoveDel(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("mix snacks", true)]
        [InlineData("pix snacks", true)]
        [InlineData("piz snacks", false)]
        [InlineData("pixel", true)]
        public void IxStartTest(string str, bool expected)
        {
            var actual = _conditionals.IxStart(str);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("ozymandias", "oz")]
        [InlineData("bzoo", "z")]
        [InlineData("oxx", "o")]
        [InlineData("w", "")]
        public void StartOzTest(string s, string expected)
        {
            var actual = _conditionals.StartOz(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2, 3, 3)]
        [InlineData(1, 3, 2, 3)]
        [InlineData(3, 2, 1, 3)]
        public void MaxTest(int a, int b, int c, int expected)
        {
            var actual = _conditionals.Max(a, b, c);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 13, 8)]
        [InlineData(13, 8, 8)]
        [InlineData(13, 7, 0)]
        public void CloserTest(int a, int b, int expected)
        {
            var actual = _conditionals.Closer(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Hello", true)]
        [InlineData("Heelle", true)]
        [InlineData("Heelele", false)]
        [InlineData("344", false)]
        public void GotETest(string str, bool expected)
        {
            var actual = _conditionals.GotE(str);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Hello", "HeLLO")]
        [InlineData("hi there", "hi thERE")]
        [InlineData("hi", "HI")]
        public void EndUpTest(string s, string expected)
        {
            var actual = _conditionals.EndUp(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Miracle", 2, "Mrce")]
        [InlineData("abcdefg", 2, "aceg")]
        [InlineData("abcdefg", 3, "adg")]
        public void EveryNthTest(string s, int n, string expected)
        {
            var actual = _conditionals.EveryNth(s, n);
            Assert.Equal(expected, actual);
        }

    }
}
