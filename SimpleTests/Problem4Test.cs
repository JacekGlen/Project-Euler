using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Simple.Problems;

namespace SimpleTests
{
    [TestFixture]
    public class Problem4Test
    {
        [Test]
        public void FindsPalindromeAsProductOfTwoDigits()
        {
            var sut = new PalindromeFinder(10, 99);

            var result = sut.Execute(99 * 99);

            Assert.AreEqual(9009, result);
        }

        [Test]
        public void FindsPalindromeAsProductOfThreeDigits()
        {
            var sut = new PalindromeFinder(100, 999);

            var result = sut.Execute(999 * 999);

            Assert.AreEqual(906609, result);
        }

        [Test]
        public void CompactFindsPalindrome()
        {
            var sut = new Problem4();

            var result = sut.FindPalindrom();

            Assert.AreEqual(906609, result);
        }

    }
}
