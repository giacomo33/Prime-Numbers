using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    public static class Helper
    {

        static IEnumerable<int> CalculatePrimeNumbers(int number)
        {
            return number.GetPrimeNumbers();
        }

        public static IEnumerable<int> GetPrimeNumbers(this int number)
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

        static bool IsPrime(int n)
        {
            if (n > 1)
            {
                return Enumerable.Range(1, n).Where(x => n % x == 0)
                                 .SequenceEqual(new[] { 1, n });
            }

            return false;
        }
        public static IEnumerable<int> GetNonModuloDigits(int number, int modulo)
        {

            do
            {
                if (number == 2 || number == 3 || number == 5 || number == 7)
                    yield return number;

                if ((int)(number % modulo) != 0)
                    yield return number;

                number--;
            }
            while (number > 1);
        }

        public static int ReadOnlyNumbers(this string line) =>
            Regex.Split(line, @"\D+")
              .Aggregate(0, (x, y) =>
              Int32.Parse($"{x}{y}"));
    }
}
