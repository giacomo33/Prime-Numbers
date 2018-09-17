using PrimeNumbersLong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PrimeNumbersLong
{
    public static class Helper
    {
        static IEnumerable<long> CalculatePrimeNumbers(long number)
        {
            return number.GetPrimeNumbers();
        }

        public static IEnumerable<long> GetPrimeNumbers(this long number)
        {
            long originalNumber = number;
            do
            {
                if (IsPrime(number))
                    yield return number;

                number--;
            }
            while (number > 1);
        }

        static bool IsPrime(long n)
        {
            if (n > 1)
            {
                return Range.Int64(1, n).Where(x => n % x == 0)
                                 .SequenceEqual(new[] { 1, n });
            }

            return false;
        }

        public static long ReadOnlyNumbers(this string line) =>
            Regex.Split(line, @"\D+")
              .Aggregate(0L, (x, y) =>
              long.Parse($"{x}{y}"));
    }
}
