using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        //Caluculates Prime Numbers below a specified integer. Breaks down as the process only supports as 32 bit binary integers have an upper limit of 2,147,483,647.
        static void Main(string[] args)
        {
            Console.WriteLine("Application will list all the prime numbers below a given integer");
            CalculatePrimeNumbers();
        }

        static void CalculatePrimeNumbers()
        {
            Console.WriteLine("Enter an Integer: ");
            string textEntered = Console.ReadLine();
            int numberEntered = textEntered.ReadOnlyNumbers();

            IEnumerable<int> numbers
                        = Helper.GetPrimeNumbers(numberEntered);

            foreach (var number in numbers)
            {
                Console.WriteLine("Prime Number is {0}", number);
            }

            Console.WriteLine("Enter another number Y or N");
            ConsoleKeyInfo selection = Console.ReadKey();
            if (selection.Key == ConsoleKey.Y)
            {
                Console.WriteLine();
                CalculatePrimeNumbers();
            }
            else if (selection.Key == ConsoleKey.N)
                return;

        }


    }
}
