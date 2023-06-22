using Xunit;
using Warmups.BLL;

namespace Warmups.Tests
{
    public class LoopsTests
    {
        private Loops _loops = new Loops();

        [Theory]
        [InlineData("Hi", 2, "HiHi")]
        [InlineData("Hi", 3, "HiHiHi")]
        [InlineData("Hi", 1, "Hi")]
        public void StringTimesTest(string str, int n, string expected)
        {
            var actual = _loops.StringTimes(str, n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Chocolate", 2, "ChoCho")]
        [InlineData("Chocolate", 3, "ChoChoCho")]
        [InlineData("Abc", 3, "AbcAbcAbc")]
        public void FrontTimesTest(string str, int n, string expected)
        {
            var actual = _loops.FrontTimes(str, n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("abcxx", 1)]
        [InlineData("xxx", 2)]
        [InlineData("xxxx", 3)]
        public void CountXXTest(string str, int expected)
        {
            var actual = _loops.CountXX(str);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("axxbb", true)]
        [InlineData("axaxxax", false)]
        [InlineData("xxxxx", true)]
        [InlineData("dffa", false)]
        [InlineData("tx", false)]
        [InlineData("txx", true)]
        [InlineData("x", false)]
        public void DoubleXTest(string str, bool expected)
        {
            var actual = _loops.DoubleX(str);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Hello", "Hlo")]
        [InlineData("Hi", "H")]
        [InlineData("Heeololeo", "Hello")]
        public void EveryOtherTest(string str, string expected)
        {
            var actual = _loops.EveryOther(str);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Code", "CCoCodCode")]
        [InlineData("abc", "aababc")]
        [InlineData("ab", "aab")]
        public void StringSplosionTest(string str, string expected)
        {
            var actual = _loops.StringSplosion(str);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("hixxhi", 1)]
        [InlineData("xaxxaxaxx", 1)]
        [InlineData("axxxaaxx", 2)]
        public void CountLast2Test(string str, int expected)
        {
            var actual = _loops.CountLast2(str);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 9 }, 1)]
        [InlineData(new[] { 1, 9, 9 }, 2)]
        [InlineData(new[] { 1, 9, 9, 3, 9 }, 3)]
        public void Count9Test(int[] nums, int expected)
        {
            var actual = _loops.Count9(nums);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 9, 3, 4 }, true)]
        [InlineData(new[] { 1, 2, 3, 4, 9 }, false)]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, false)]
        public void ArrayFront9Test(int[] nums, bool expected)
        {
            var actual = _loops.ArrayFront9(nums);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 1, 2, 3, 1 }, true)]
        [InlineData(new[] { 1, 1, 2, 4, 1 }, false)]
        [InlineData(new[] { 1, 1, 2, 1, 2, 3 }, true)]
        [InlineData(new[] { 1, 2, 3 }, true)]
        [InlineData(new[] { 3 }, false)]
        [InlineData(new[] { 3, 2 }, false)]
        public void Array123Test(int[] nums, bool expected)
        {
            var actual = _loops.Array123(nums);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("xxcaazz", "xxbaaz", 3)]
        [InlineData("abc", "abc", 2)]
        [InlineData("abc", "axc", 0)]
        public void SubStringMatchTest(string s1, string s2, int expected)
        {
            var actual = _loops.SubStringMatch(s1, s2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("xxHxix", "xHix")]
        [InlineData("abxxxcd", "abcd")]
        [InlineData("xabxxxcdx", "xabcdx")]
        public void StringXTest(string str, string expected)
        {
            var actual = _loops.StringX(str);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("kitten", "kien")]
        [InlineData("Chocolate", "Chole")]
        [InlineData("CodingHorror", "Congrr")]
        public void AltPairsTest(string str, string expected)
        {
            var actual = _loops.AltPairs(str);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("yakpak", "pak")]
        [InlineData("pakyak", "pak")]
        [InlineData("yak123ya", "123ya")]
        [InlineData("ybkpbk", "pbk")]
        public void DoNotYakTest(string str, string expected)
        {
            var actual = _loops.DoNotYak(str);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 6, 6, 2 }, 1)]
        [InlineData(new[] { 6, 6, 2, 6 }, 1)]
        [InlineData(new[] { 6, 7, 2, 6 }, 1)]
        [InlineData(new[] { 6, 7, 6, 6 }, 2)]
        [InlineData(new[] { 1, 2, 6 }, 0)]
        public void Array667Test(int[] nums, int expected)
        {
            var actual = _loops.Array667(nums);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 1, 2, 2, 1 }, true)]
        [InlineData(new[] { 1, 1, 2, 2, 2, 1 }, false)]
        [InlineData(new[] { 1, 1, 1, 2, 2, 2, 1 }, false)]
        [InlineData(new[] { 3, 1, 1 }, true)]
        [InlineData(new[] { 2, 1 }, true)]
        public void NoTriplesTest(int[] nums, bool expected)
        {
            var actual = _loops.NoTriples(nums);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 7, 1 }, true)]
        [InlineData(new[] { 1, 2, 8, 1 }, false)]
        [InlineData(new[] { 2, 7, 1 }, true)]
        [InlineData(new[] { 6, 4, 9, 3, 2 }, true)]
        [InlineData(new[] { 2, 7 }, false)]
        public void Pattern51Test(int[] nums, bool expected)
        {
            var actual = _loops.Pattern51(nums);
            Assert.Equal(expected, actual);
        }

    }
}
