using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Problems
{
    public class Problem4
    {
        public int FindPalindrom()
        {
            for (int n = 999 * 999; n > 0; --n)
            {
                // is palindrome?
                var s = n.ToString();
                if (s != String.Join("", s.Reverse()))
                    continue;

                // is n product of two integers?
                var lowerLimit = (((n / 999) + 999) / 2);
                for (int number = 999; number > lowerLimit; --number)
                {
                    if (n % number == 0)
                        return n;
                }
            }

            return 0;
        }
    }

    public class PalindromeFinder
    {
        int numberMin;
        int numberMax;

        public PalindromeFinder(int numberMin, int numberMax)
        {
            this.numberMin = numberMin;
            this.numberMax = numberMax;
        }

        public int Execute(int maxValue)
        {
            for (int n = maxValue; n > 0; --n)
            {
                if (IsPalindrome(n) && IsProductOfIntegers(n))
                {
                    return n;
                }
            }

            throw new Exception("Could not find palindrome");
        }

        private bool IsProductOfIntegers(int n)
        {
            var lowerLimit = Math.Max((((n / numberMax) + numberMax) / 2), numberMin);

            for (int number = numberMax; number > lowerLimit; --number)
            {
                if (n % number == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsPalindrome(int n)
        {
            var s = n.ToString();

            return s == String.Join("", s.Reverse());
        }
    }

}
