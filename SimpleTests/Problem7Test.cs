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
    public class Problem7Test
    {
        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(3, 5)]
        [TestCase(6, 13)]
        [TestCase(10001, 104743)]
        public void CalculatesNPrime(int primeNumber, int expectedPrime)
        {
            var sut = new Problem7();

            var result = sut.GetPrime(primeNumber);

            Assert.AreEqual(expectedPrime, result);
        }
    }
}
