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
