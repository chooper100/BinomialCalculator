using System;

namespace BinomialCalculator.Internal
{
    /// <summary>
    /// Provides methods to compute the values of various
    /// mathematical functions.
    /// </summary>
    public static class Calculation
    {
        #region Methods
        /// <summary>
        /// Returns the number of possible combinations of r values
        /// in a group of size n: nCr
        /// </summary>
        /// <param name="n">The group size.</param>
        /// <param name="r">The number of objects to arrange.</param>
        /// <returns>The number of possible combinations of r values in a group of size n: nCr</returns>
        public static uint Combinatations(uint n, uint r)
        {
            // Naive implementation:
            // return Factorial(n) / Factorial(r) * Factorial(n - r);
            //
            // We do not use this as, not only are there redundant
            // calculations, but also we will get overflow exceptions
            // very frequently (due to the nature of factorial)

            // Check input is valid
            if (r > n)
                throw new ArgumentOutOfRangeException(
                    "r",
                    r,
                    "r must be between 0 and n, inclusive");

            // Optimise for best case
            if (r == 0 || r == n)
                return 1;

            // Combinations are symmetric, so take advantage of this in
            // order to reduce the number of calculations (as well as
            // the likelihood of an overflow exception) 
            if (r > (n + 1) / 2)
                return Combinatations(n, n - r);

            // Optimised implementation:
            // We can optimise the nCr formula to get the following formula:
            // nCr = n(n - 1)(n - 2)...(n - (r - 1)) / r!

            ulong nominator = 1;
            for (ulong i = 0; i < r; i++)
            {
                // Perform overflow checking (as it is possible to get an
                // overflow exception here with large n values)
                nominator = checked(nominator * (n - i));
            }

            return (uint)(nominator / Factorial(r));
        }

        /// <summary>
        /// Returns the factorial of the specified number: n!
        /// </summary>
        /// <param name="n">The number to return the factorial of.</param>
        /// <returns>The factorial of the specified number: n!</returns>
        public static ulong Factorial(uint n)
        {
            // Base case: 1! = 1
            if (n <= 1)
                return 1;

            // Use recursion to find factorial
            // Also perform overflow checking, as factorial operations
            // can quickly produce large numbers
            return checked(n * Factorial(n - 1));
        }
        #endregion
    }
}
