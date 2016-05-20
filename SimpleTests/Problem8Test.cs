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
    public class Problem8Test
    {
        [Test]
        [TestCase(4, 5832)]
        [TestCase(13, 23514624000)]
        public void GetsGreatestProduct(int windowSize, long expectedResult)
        {
            var sut = new Problem8();

            var result = sut.GetGreatestProduct(windowSize);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
