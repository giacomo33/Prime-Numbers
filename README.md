# Prime-Numbers
The following repository illustrates the power of using LINQ to List all prime Numbers below a given integer. The first project generates an  IEnumerable<int> with the yield keyword. This process is limited as the 32 bit maximum is 2,147,483,647.
  
The second project named “PrimeNumbersLong” takes the same problem but generates primes based on a 64 bit integer type. This has a maximum of 18,446,744,073,709,551,615. It order to create an efficient mechanism to find the numbers we use the Enumerable.Range static method built into the .NET Framework. As this uses Int32, I created an extension which creates a new Range method based on the "long" integer type. Using LINQ we then have a one line method for generating Prime Numbers.

e.g.

ExtendedEnumerableRange.Int64(2, (long)Math.Sqrt(Number))
                .All(n => Number % n != 0);

