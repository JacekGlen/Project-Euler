using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using Simple.Problems;

namespace SimpleTests
{
    [TestFixture]
    public class Problem2Test
    {
        [TestCase(2, 2)]
        [TestCase(3, 2)]
        [TestCase(5, 2)]
        [TestCase(8, 10)]
        [TestCase(9, 10)]
        [TestCase(9, 10)]
        [TestCase(10, 10)]
        [TestCase(13, 10)]
        [TestCase(33, 10)]
        [TestCase(34, 44)]
        [TestCase(35, 44)]
        [TestCase(3000, 3382)]
        [TestCase(4000000, 4613732)]
        [Test]
        public void CalculatesSum(long n, long expectedSum)
        {
            var sut = new Problem2();

            var result = sut.Calculate(n);

            Assert.AreEqual(expectedSum, result);
        }

        [TestCase(2, 2)]
        [TestCase(3, 2)]
        [TestCase(5, 2)]
        [TestCase(8, 10)]
        [TestCase(9, 10)]
        [TestCase(9, 10)]
        [TestCase(10, 10)]
        [TestCase(13, 10)]
        [TestCase(33, 10)]
        [TestCase(34, 44)]
        [TestCase(35, 44)]
        [TestCase(3000, 3382)]
        [TestCase(4000000, 4613732)]
        [Test]
        public void CalculatesSkip(long n, long expectedSum)
        {
            var sut = new Problem2();

            var result = sut.CalculateSkip(n);

            Assert.AreEqual(expectedSum, result);
        }

    }
}
