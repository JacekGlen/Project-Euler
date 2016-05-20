using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Problems
{
    public class Problem6
    {
        public long GetDifference(int n)
        {
            var sumSquares = GetSumOfSquares(n);
            var squareSum = GetSquareOfSum(n);

            return squareSum - sumSquares;
        }

        private long GetSquareOfSum(int n)
        {
            var sum = (n * (n + 1)) / 2;

            return Convert.ToInt64( Math.Pow(sum, 2));
        }

        private long GetSumOfSquares(int n)
        {
            var sum = (n * (n + 1) * (2 * n + 1)) / 6;

            return sum;
        }
    }
}
