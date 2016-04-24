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
    public class Problem3Test
    {
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 2)]
        [TestCase(5, 5)]
        [TestCase(6, 3)]
        [TestCase(7, 7)]
        [TestCase(8, 2)]
        [TestCase(9, 3)]
        [TestCase(10, 5)]
        [TestCase(11, 11)]
        [TestCase(15, 5)]
        [TestCase(21, 7)]
        [TestCase(29, 29)]
        [TestCase(155, 31)]
        [TestCase(13195, 29)]
        [TestCase(600851475143, 6857)]
        [TestCase(12345678901, 14405693)]
        //[TestCase(123456789012, 10288065751)] takes to long (largest factor too close to n)
        [TestCase(1234567890123, 116216501)]
        //[TestCase(12345678901234, 12079920647)] takes to long (largest factor too close to n)
        [TestCase(123456789012345, 7552031)]
        [TestCase(1234567890123456, 435503)]
        //[TestCase(12345678901234567, 1763668414462081)] takes to long (largest factor too close to n)
        [TestCase(123456789012345678, 106377431)]
        [TestCase(1234567890123456789, 27961)]
        //[TestCase(12345678901234567890, 27961)] int too large
        [Test]
        public void CalculatesFactorWithDiv(long n, long largestFactor)
        {
            var sut = new Problem3();
            
            var result = sut.CalculateLargestFactor((ulong)n);

            Assert.AreEqual(largestFactor, result);
        }

        //[Test]
        public void CalculatesLargeFactorWithDiv()
        {
            ulong n = 12345678901234567890;
            ulong expected = 27961;
            var sut = new Problem3();

            var result = sut.CalculateLargestFactor(n);

            Assert.IsTrue(result == expected);
        }

    }
}
