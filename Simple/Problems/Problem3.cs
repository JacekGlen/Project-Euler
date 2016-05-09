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
            ulong currentFactor = n;
            ulong div = 2;

            while (div <= Math.Sqrt(currentFactor))
            {
                if (currentFactor % div == 0)
                {
                    currentFactor = currentFactor / div;
                }
                else
                {
                    ++div;
                }
            }

            return currentFactor;
        }
    }
}
