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
    public class Problem9Test
    {
        [Test]
        [TestCase(3 + 4 + 5, 3 * 4 * 5)]
        [TestCase(1000, 31875000)]
        public void CalculatesCorrectProduct(int tripletSum, int expectedProduct)
        {
            var sut = new Problem9();

            var product = sut.FindTripletProduct(tripletSum);

            Assert.AreEqual(expectedProduct, product);
        }

    }
}
