using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Problems.Problem3().CalculateLargestFactor(12345678901234567890);
            Console.WriteLine(a);

            var b = new Problems.Problem3().CalculateLargestFactor(12345678901234567);
            Console.WriteLine(b);

            Console.ReadLine();
        }
    }
}
