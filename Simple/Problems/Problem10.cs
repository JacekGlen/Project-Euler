using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Problems
{
    public class Problem10
    {
        public ulong SumPrimes(ulong maxValue)
        {
            var primeList = new PrimeList().Get();
            ulong sum = 0;

            foreach (var prime in primeList)
            {
                if (prime >= maxValue)
                {
                    break;
                }

                sum += prime;
            }

            return sum;
        }
    }
}
