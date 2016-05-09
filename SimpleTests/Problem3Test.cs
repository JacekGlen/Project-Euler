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
        [TestCase(2UL, 2)]
        [TestCase(3UL, 3)]
        [TestCase(4UL, 2)]
        [TestCase(5UL, 5)]
        [TestCase(6UL, 3)]
        [TestCase(7UL, 7)]
        [TestCase(8UL, 2)]
        [TestCase(9UL, 3)]
        [TestCase(10UL, 5)]
        [TestCase(11UL, 11)]
        [TestCase(15UL, 5)]
        [TestCase(21UL, 7)]
        [TestCase(29UL, 29)]
        [TestCase(155UL, 31)]
        [TestCase(13195UL, 29)]
        [TestCase(600851475143UL, 6857)]
        [TestCase(12345678901UL, 14405693)]
        [TestCase(123456789012UL, 10288065751)] //takes to long (largest factor too close to n)
        [TestCase(1234567890123UL, 116216501)]
        [TestCase(12345678901234UL, 12079920647)]
        [TestCase(123456789012345UL, 7552031)]
        [TestCase(1234567890123456UL, 435503)]
        [TestCase(12345678901234567UL, 1763668414462081)]
        [TestCase(123456789012345678UL, 106377431)]
        [TestCase(1234567890123456789UL, 27961)]
        [TestCase(12345678901234567890UL, 27961)] 
        [Test]
        public void CalculatesFactorWithDiv(ulong n, long largestFactor)
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
