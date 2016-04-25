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
    public class Problem5Test
    {
        [Test]
        [TestCase(2,2)]
        [TestCase(3, 6)]
        [TestCase(4, 12)]
        [TestCase(10, 2520)]
        [TestCase(20, 0)]
        public void ReturnsCorrectValueForValidParameter(int upper, int expected)
        {
            var sut = new Problem5();

            var result = sut.CalculateSmallestMultiple(upper);

            Assert.AreEqual(expected, result);
        }

    }
}
