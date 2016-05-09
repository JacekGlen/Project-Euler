using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Problems
{
    public class Problem7
    {
        public ulong GetPrime(int i)
        {
            var primeList = new PrimeList().Get();
            return primeList.Skip(i - 1).First();
        }
    }

    public class PrimeList
    {
        public IEnumerable<ulong> Get()
        {
            ulong n = 2;
            var factorizer = new Problem3();

            while (n <= UInt64.MaxValue)
            {
                if (factorizer.CalculateLargestFactor(n) == n)
                {
                    yield return n;
                }

                ++n;
            }
        }
    }
}
