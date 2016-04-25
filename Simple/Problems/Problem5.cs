using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Problems
{
    public class Problem5
    {
        public int CalculateSmallestMultiple(int upper)
        {
            int[] multipliers = new int[upper + 1];

            for (int n = 2; n <= upper; ++n)
            {
                int i = 2;
                int count = 0;
                int current = n;

                while (i <= current)
                {
                    if (current % i == 0)
                    {
                        current = current / i;
                        ++count;
                        multipliers[i] = Math.Max(count, multipliers[i]);
                    }
                    else
                    {
                        ++i;
                        count = 0;
                    }
                }
            }

            var multiple = multipliers.Select((a, idx) => Math.Pow(idx, a)).Aggregate((x,y) => x * y);

            return Convert.ToInt32(multiple);
        }
    }
}
