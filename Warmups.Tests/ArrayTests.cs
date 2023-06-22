using Xunit;
using Warmups.BLL;
using System;

namespace Warmups.Tests
{
    public class ArrayTests : IDisposable
    {
        private Arrays _arrays = new Arrays();

        [Theory]
        [InlineData(new[] { 1, 2, 6 }, true)]
        [InlineData(new[] { 6, 1, 2, 3 }, true)]
        [InlineData(new[] { 13, 6, 1, 2, 3 }, false)]
        public void FirstLast6Test(int[] nums, bool expected)
        {
            var actual = _arrays.FirstLast6(nums);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3 }, false)]
        [InlineData(new[] { 1, 2, 3, 1 }, true)]
        [InlineData(new[] { 1, 2, 1 }, true)]
        public void SameFirstLastTest(int[] nums, bool expected)
        {
            var actual = _arrays.SameFirstLast(nums);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, new[] { 3, 1, 4 })]
        [InlineData(1, new[] { 3 })]
        [InlineData(5, new[] { 3, 1, 4, 1, 5 })]
        public void MakePiTest(int n, int[] expected)
        {
            var actual = _arrays.MakePi(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3 }, new[] { 7, 3 }, true)]
        [InlineData(new[] { 1, 2, 3 }, new[] { 7, 3, 2 }, false)]
        [InlineData(new[] { 1, 2, 3 }, new[] { 1, 3 }, true)]
        public void CommonEndTest(int[] a, int[] b, bool expected)
        {
            var actual = _arrays.CommonEnd(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3 }, 6)]
        [InlineData(new[] { 5, 11, 2 }, 18)]
        [InlineData(new[] { 7, 0, 0 }, 7)]
        public void SumTest(int[] nums, int expected)
        {
            var actual = _arrays.Sum(nums);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3 }, new[] { 2, 3, 1 })]
        [InlineData(new[] { 5, 11, 9 }, new[] { 11, 9, 5 })]
        [InlineData(new[] { 7, 0, 0 }, new[] { 0, 0, 7 })]
        public void RotateLeftTest(int[] nums, int[] expected)
        {
            var actual = _arrays.RotateLeft(nums);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3 }, new[] { 3, 2, 1 })]
        [InlineData(new[] { 5, 9, 11, 1 }, new[] { 1, 11, 9, 5 })]
        [InlineData(new[] { 7, 0, 0 }, new[] { 0, 0, 7 })]
        [InlineData(new[] { 7 }, new[] { 7 })]
        public void ReverseTest(int[] nums, int[] expected)
        {
            var actual = _arrays.Reverse(nums);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3 }, new[] { 3, 3, 3 })]
        [InlineData(new[] { 11, 5, 9 }, new[] { 11, 11, 11 })]
        [InlineData(new[] { 2, 11, 3 }, new[] { 3, 3, 3 })]
        public void HigherWinsTest(int[] nums, int[] expected)
        {
            var actual = _arrays.HigherWins(nums);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 2, 5 })]
        [InlineData(new[] { 7, 7, 7 }, new[] { 3, 8, 0 }, new[] { 7, 8 })]
        [InlineData(new[] { 5, 2, 9 }, new[] { 1, 4, 5 }, new[] { 2, 4 })]
        public void GetMiddleTest(int[] a, int[] b, int[] expected)
        {
            var actual = _arrays.GetMiddle(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 2, 5 }, true)]
        [InlineData(new[] { 4, 3 }, true)]
        [InlineData(new[] { 7, 5 }, false)]
        public void HasEvenTest(int[] nums, bool expected)
        {
            var actual = _arrays.HasEven(nums);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 4, 5, 6 }, new[] { 0, 0, 0, 0, 0, 6 })]
        [InlineData(new[] { 1, 2 }, new[] { 0, 0, 0, 2 })]
        [InlineData(new[] { 3 }, new[] { 0, 3 })]
        public void KeepLastTest(int[] nums, int[] expected)
        {
            var actual = _arrays.KeepLast(nums);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 2, 2, 3 }, true)]
        [InlineData(new[] { 3, 4, 5, 3 }, true)]
        [InlineData(new[] { 2, 3, 2, 2 }, false)]
        public void Double23Test(int[] nums, bool expected)
        {
            var actual = _arrays.Double23(nums);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 0 })]
        [InlineData(new[] { 2, 3, 5 }, new[] { 2, 0, 5 })]
        [InlineData(new[] { 1, 2, 1 }, new[] { 1, 2, 1 })]
        public void Fix23Test(int[] nums, int[] expected)
        {
            var actual = _arrays.Fix23(nums);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 3, 4, 5 }, true)]
        [InlineData(new[] { 2, 1, 3, 4, 5 }, true)]
        [InlineData(new[] { 1, 1, 1 }, false)]
        public void Unlucky1Test(int[] nums, bool expected)
        {
            var actual = _arrays.Unlucky1(nums);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 4, 5 }, new[] { 1, 2, 3 }, new[] { 4, 5 })]
        [InlineData(new[] { 4 }, new[] { 1, 2, 3 }, new[] { 4, 1 })]
        [InlineData(new int[] { }, new[] { 1, 2 }, new[] { 1, 2 })]
        [InlineData(new[] { 4, 5, 6 }, new[] { 1, 2, 3 }, new[] { 4, 5 })]
        public void Make2Test(int[] a, int[] b, int[] expected)
        {
            var actual = _arrays.Make2(a, b);
            Assert.Equal(expected, actual);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
