using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Problems
{
    public class Problem9
    {
        public int FindTripletProduct(int tripletSum)
        {
            int a = 1, b = 1, c = 1;

            for (a = 1; a < tripletSum / 3; ++a)
            {
                int aSquare = a * a;
                b = a + 1;
                c = tripletSum - a - b;

                while (b < c)
                {

                    if (aSquare + b * b == c * c)
                    {
                        return a * b * c;
                    }

                    ++b;
                    c = tripletSum - a - b;
                }
            }

            throw new Exception("Triplet not found");
        }

    }
}
