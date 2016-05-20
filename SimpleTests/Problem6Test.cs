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
    public class Problem6Test
    {
        [TestCase(10, 2640)]
        [TestCase(100, 2640)]
        public void CalculatesDifference(int n, long expectedResult)
        {
            var sut = new Problem6();

            var result = sut.GetDifference(n);

            Assert.AreEqual(expectedResult, result);
        }

    }
}
