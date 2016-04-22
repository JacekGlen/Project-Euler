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
    public class Problem1Test
    {
        [TestCase(0, 0)]
        [TestCase(3, 0)]
        [TestCase(7, 14)]
        [TestCase(10, 23)]
        [TestCase(11, 33)]
        [TestCase(1000, 233168)]
        [Test]
        public void CalculatesSum(long n, long expectedSum)
        {
            var sut = new Problem1();

            var result = sut.Calculate(n);

            Assert.AreEqual(expectedSum, result);
        }

        [TestCase(0, 0)]
        [TestCase(3, 0)]
        [TestCase(7, 14)]
        [TestCase(10, 23)]
        [TestCase(11, 33)]
        [TestCase(1000, 233168)]
        [Test]
        public void CalculatesLinqSum(int n, long expectedSum)
        {
            var sut = new Problem1();

            var result = sut.CalculateLinq(n);

            Assert.AreEqual(expectedSum, result);
        }

        [TestCase(0, 0)]
        [TestCase(3, 0)]
        [TestCase(7, 14)]
        [TestCase(10, 23)]
        [TestCase(11, 33)]
        [TestCase(1000, 233168)]
        [Test]
        public void CalculatesEquationSum(int n, long expectedSum)
        {
            var sut = new Problem1();

            var result = sut.CalculateEquation(n);

            Assert.AreEqual(expectedSum, result);
        }


        [Test]
        public void Solution()
        {
            var sut = new Problem1();

            var result = sut.Calculate(1000);

            Console.WriteLine(result);
        }

    }
}
