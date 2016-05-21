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
    public class Problem10Test
    {
        [Test]
        [TestCase(10UL, 17UL)]
        [TestCase(2000000UL, 0UL)]
        public void CalculatesSum(ulong maxValue, ulong expectedSum)
        {
            var sut = new Problem10();

            var sum = sut.SumPrimes(maxValue);

            Assert.AreEqual(expectedSum, sum);
        }
    }
}
