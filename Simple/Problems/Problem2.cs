using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Problems
{
    public class Problem2
    {

        public long Calculate(long maxValue)
        {
            var fibs = new List<long>() { 1, 2 };
            long nextFib = 3;

            while (nextFib <= maxValue)
            {
                fibs.Add(nextFib);
                nextFib = fibs.Skip(fibs.Count - 2).Sum();
            }

            return fibs.Where(f => f % 2 == 0).Sum();
        }

        public long CalculateSkip(long maxValue)
        {
            //initial setup
            long fn2 = 0;
            long fn1 = 2;
            long fn = 8;
            long sum = fn1 + fn2;

            //f(n) = 4*f(n-1) + f(n-2)
            while (fn <= maxValue)
            {
                sum += fn;

                fn2 = fn1;
                fn1 = fn;
                fn = 4 * fn1 + fn2;
            }

            return sum;
        }

    }
}
