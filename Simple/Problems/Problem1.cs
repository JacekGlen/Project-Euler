using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Problems
{
    public class Problem1
    {

        public long Calculate(long n)
        {
            if (n <= 0)
            {
                return 0;
            }

            long max = n - 1;
            var max3 = Math.Floor((double)max / 3);
            var max5 = Math.Floor((double)max / 5);
            var max15 = Math.Floor((double)max / 15);

            long i = 1;
            long multiplier3 = 0;
            long multiplier5 = 0;
            long multiplier15 = 0;

            while (i <= max15)
            {
                multiplier15 += i;
                ++i;
            }

            multiplier5 = multiplier15;
            while (i <= max5)
            {
                multiplier5 += i;
                ++i;
            }

            multiplier3 = multiplier5;

            while (i <= max3)
            {
                multiplier3 += i;
                ++i;
            }

            var sum = multiplier3 * 3 + multiplier5 * 5 - multiplier15 * 15;

            return sum;
        }

        public long CalculateLinq(int n)
        {
            if (n < 1) { return 0; }
            return Enumerable.Range(1, n - 1).Where(i => i % 3 == 0 || i % 5 == 0).Sum();
        }

public long CalculateEquation(int n)
{
    n = n - 1;
    int c3 = n / 3;
    int c5 = n / 5;

    return (3 * (c3 * c3 + c3) + 5 * (c5 * c5 + c5) - 15 * ((c3 / 5) * (c3 / 5) + (c3 / 5))) / 2;
}

    }
}
