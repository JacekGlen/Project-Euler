using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Problems
{
    public class Problem3
    {
        public ulong CalculateLargestFactor(ulong n)
        {
            for (ulong div = 2; div < n; div++)
            {
                if (n % div == 0)
                {
                    n = n / div;
                    div--;
                }

                if (n >> 1 < div) return n;
            }

            return n;
        }
    }
}
