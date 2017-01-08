using System;

namespace BinomialCalculator.Internal
{
    /// <summary>
    /// Respresents a binomially distributed variable: X~B(n, p)
    /// </summary>
    public struct Binomial : IDistribution
    {
        #region Fields
        /// <summary>
        /// The number of trials.
        /// </summary>
        public uint n;
        /// <summary>
        /// The probability of a success, per trial.
        /// </summary>
        public double p;
        #endregion
        #region Properties
        /// <summary>
        /// Gets the mean value of the distribution.
        /// </summary>
        public double Mean
        {
            get
            {
                return n * p;
            }
        }

        /// <summary>
        /// Gets the variance of the disribution;
        /// </summary>
        public double Variance
        {
            get
            {
                return n * p * (1 - p);
            }
        }

        /// <summary>
        /// Gets the standard deviation of the distribution.
        /// </summary>
        public double StandardDeviation
        {
            get
            {
                return Math.Sqrt(Variance);
            }
        }
        #endregion
        #region Constructor
        /// <summary>
        /// Creates a new instance of the <see cref="Binomial"/> structure. 
        /// </summary>
        /// <param name="n">The number of trials.</param>
        /// <param name="p">The probability of a success, per trial.</param>
        public Binomial(uint n, double p)
        {
            if (p < 0 | p > 1)
                throw new ArgumentOutOfRangeException(
                    "p",
                    p,
                    "The probability must be between 0 and 1, inclusive.");

            this.n = n;
            this.p = p;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Returns the probability for a fixed number of successes:
        /// P(X = x)
        /// </summary>
        /// <param name="successes">The number of successes.</param>
        /// <returns>The probability for a fixed number of successes: P(X = x)</returns>
        public double GetProbability(uint successes)
        {
            if (successes > n)
                throw new ArgumentOutOfRangeException(
                    "successes",
                    successes,
                    "The number of successes must be less than or equal to the number of trials."
                );

            return
                Calculation.Combinatations(n, successes) *
                Math.Pow(p, successes) *
                Math.Pow(1 - p, n - successes);
        }

        /// <summary>
        /// Returns the probability of getting a number of success
        /// between the specified min and max values (inclusive):
        /// P(x &lt;= X &lt;=y)
        /// </summary>
        /// <param name="minSuccesses">The minimum number of successes.</param>
        /// <param name="maxSuccesses">The maximum number of successes.</param>
        /// <returns>The probability of getting a number of success between the specified min and max values (inclusive): P(x &lt;= X &lt;=y)</returns>
        public double GetProbability(uint minSuccesses, uint maxSuccesses)
        {
            double value = 0;
            for (uint i = minSuccesses; i <= maxSuccesses; i++)
            {
                value += GetProbability(i);
            }

            return value;
        }

        /// <summary>
        /// Returns the cumulative probability up to and including
        /// the specified number: P(X &lt;= x)
        /// </summary>
        /// <param name="successes"></param>
        /// <returns></returns>
        public double GetCumulativeProbability(uint successes)
        {
            return GetProbability(0, successes);
        }
        
        /// <summary>
        /// Returns the <see cref="Binomial"/> instance with the inverse
        /// probability. 
        /// </summary>
        /// <returns>The <see cref="Binomial"/> instance with the inverse probability. </returns>
        public Binomial Inverse()
        {
            return new Binomial(n, 1 - p);
        }

        /// <summary>
        /// Converts the object to it's equivalent string representation.
        /// </summary>
        /// <returns>A string version of the object.</returns>
        public override string ToString()
        { 
            return string.Concat("X~B(", n, ", ", p, ")");
        }
        #endregion
    }
}
