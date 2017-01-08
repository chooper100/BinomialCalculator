namespace BinomialCalculator.Internal
{
    /// <summary>
    /// Represents any distribution.
    /// </summary>
    public interface IDistribution
    {
        #region Properties
        /// <summary>
        /// Gets the mean value of the distribution.
        /// </summary>
        double Mean { get; }

        /// <summary>
        /// Gets the variance of the distribution.
        /// </summary>
        double Variance { get; }

        /// <summary>
        /// Gets the standard deviation of the distribution.
        /// </summary>
        double StandardDeviation { get; }
        #endregion
    }
}
