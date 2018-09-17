using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbersLong
{
    //Caluculates Prime Numbers below a specified long. Supports long, or 64 bit numbers
    class Program
    {
        //Caluculates Prime Numbers below a specified integer. Breaks down as the process only supports as 32 bit binary integers have an upper limit of 18,446,744,073,709,551,615.
        static void Main(string[] args)
        {
            Console.WriteLine("Application will list all the prime numbers below a given 64 bit integer. Max is 18,446,744,073,709,551,615.");
            CalculatePrimeNumbers();
        }

        static void CalculatePrimeNumbers()
        {
            Console.WriteLine("Enter a Natural Number: ");
            string textEntered = Console.ReadLine();
            long numberEntered = textEntered.ReadOnlyNumbers();

            IEnumerable<long> numbers
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
