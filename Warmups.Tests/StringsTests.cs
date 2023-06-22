using Xunit;
using Warmups.BLL;

namespace Warmups.Tests
{
    public class StringsTests
    {
        private Strings _strings = new Strings();

        [Theory]
        [InlineData("Bob", "Hello Bob!")]
        [InlineData("Alice", "Hello Alice!")]
        [InlineData("X", "Hello X!")]
        public void SayHiTest(string name, string expected)
        {
            var actual = _strings.SayHi(name);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Hi", "Bye", "HiByeByeHi")]
        [InlineData("Yo", "Alice", "YoAliceAliceYo")]
        [InlineData("What", "Up", "WhatUpUpWhat")]
        public void AbbaTest(string a, string b, string expected)
        {
            var actual = _strings.Abba(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("i", "Yay", "<i>Yay</i>")]
        [InlineData("i", "Hello", "<i>Hello</i>")]
        [InlineData("cite", "Yay", "<cite>Yay</cite>")]
        public void MakeTagsTest(string tag, string content, string expected)
        {
            var actual = _strings.MakeTags(tag, content);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("<<>>", "Yay", "<<Yay>>")]
        [InlineData("<<>>", "WooHoo", "<<WooHoo>>")]
        [InlineData("[[]]", "word", "[[word]]")]
        public void InsertWordTest(string container, string word, string expected)
        {
            var actual = _strings.InsertWord(container, word);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Hello", "lololo")]
        [InlineData("ab", "ababab")]
        [InlineData("Hi", "HiHiHi")]
        public void MultipleEndingsTest(string s, string expected)
        {
            var actual = _strings.MultipleEndings(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("WooHoo", "Woo")]
        [InlineData("HelloThere", "Hello")]
        [InlineData("abcdef", "abc")]
        public void FirstHalfTest(string s, string expected)
        {
            var actual = _strings.FirstHalf(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Hello", "ell")]
        [InlineData("java", "av")]
        [InlineData("coding", "odin")]
        public void TrimOneTest(string s, string expected)
        {
            var actual = _strings.TrimOne(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Hello", "hi", "hiHellohi")]
        [InlineData("hi", "Hello", "hiHellohi")]
        [InlineData("aaa", "b", "baaab")]
        public void LongInMiddleTest(string s1, string s2, string expected)
        {
            var actual = _strings.LongInMiddle(s1, s2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Hello", "lloHe")]
        [InlineData("java", "vaja")]
        [InlineData("Hi", "Hi")]
        public void RotateLeft2Test(string s, string expected)
        {
            var actual = _strings.RotateLeft2(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Hello", "loHel")]
        [InlineData("java", "vaja")]
        [InlineData("Hi", "Hi")]
        public void RotateRight2Test(string s, string expected)
        {
            var actual = _strings.RotateRight2(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Hello", true, "H")]
        [InlineData("Hello", false, "o")]
        [InlineData("oh", true, "o")]
        public void TakeOneTest(string s, bool b, string expected)
        {
            var actual = _strings.TakeOne(s, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("string", "ri")]
        [InlineData("code", "od")]
        [InlineData("Practice", "ct")]
        public void MiddleTwoTest(string s, string expected)
        {
            var actual = _strings.MiddleTwo(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("oddly", true)]
        [InlineData("y", false)]
        [InlineData("oddy", false)]
        public void EndsWithLyTest(string s, bool expected)
        {
            var actual = _strings.EndsWithLy(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Hello", 2, "Helo")]
        [InlineData("Chocolate", 3, "Choate")]
        [InlineData("Chocolate", 1, "Ce")]
        public void FrontAndBackTest(string s, int n, string expected)
        {
            var actual = _strings.FrontAndBack(s, n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("java", 0, "ja")]
        [InlineData("java", 2, "va")]
        [InlineData("java", 3, "ja")]
        public void TakeTwoFromPositionTest(string s, int n, string expected)
        {
            var actual = _strings.TakeTwoFromPosition(s, n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("badxx", true)]
        [InlineData("xbadxx", true)]
        [InlineData("xxbadxx", false)]
        [InlineData("", false)]
        [InlineData("cantaloupe", false)]
        public void HasBadTest(string s, bool expected)
        {
            var actual = _strings.HasBad(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("hello", "he")]
        [InlineData("hi", "hi")]
        [InlineData("h", "h@")]
        [InlineData("", "@@")]
        public void AtFirstTest(string s, string expected)
        {
            var actual = _strings.AtFirst(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("last", "chars", "ls")]
        [InlineData("yo", "mama", "ya")]
        [InlineData("hi", "", "h@")]
        [InlineData("", "", "@@")]
        [InlineData("", "f", "@f")]
        public void LastCharsTest(string s1, string s2, string expected)
        {
            var actual = _strings.LastChars(s1, s2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("abc", "cat", "abcat")]
        [InlineData("dog", "cat", "dogcat")]
        [InlineData("abc", "", "abc")]
        [InlineData("", "abc", "abc")]
        [InlineData("b", "boat", "boat")]
        [InlineData("boat", "t", "boat")]
        public void ConCatTest(string s1, string s2, string expected)
        {
            var actual = _strings.ConCat(s1, s2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("coding", "codign")]
        [InlineData("cat", "cta")]
        [InlineData("ab", "ba")]
        [InlineData("a", "a")]
        public void SwapLastTest(string s, string expected)
        {
            var actual = _strings.SwapLast(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("edited", true)]
        [InlineData("edit", false)]
        [InlineData("ed", true)]
        public void FrontAgainTest(string s, bool expected)
        {
            var actual = _strings.FrontAgain(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Hello", "Hi", "loHi")]
        [InlineData("Hello", "java", "ellojava")]
        [InlineData("java", "Hello", "javaello")]
        [InlineData("", "beep", "")]
        [InlineData("x", "yyyyy", "xy")]
        public void MinCatTest(string s1, string s2, string expected)
        {
            var actual = _strings.MinCat(s1, s2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Hello", "llo")]
        [InlineData("away", "aay")]
        [InlineData("abed", "abed")]
        [InlineData("oboe", "boe")]
        [InlineData("", "")]
        public void TweakFrontTest(string s, string expected)
        {
            var actual = _strings.TweakFront(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("xHix", "Hi")]
        [InlineData("xHi", "Hi")]
        [InlineData("Hxix", "Hxi")]
        [InlineData("x", "")]
        [InlineData("xx", "")]
        [InlineData("xxx", "x")]
        [InlineData("Hi", "Hi")]
        [InlineData("", "")]
        public void StripXTest(string s, string expected)
        {
            var actual = _strings.StripX(s);
            Assert.Equal(expected, actual);
        }
    }
}
