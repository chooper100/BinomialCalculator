namespace BinomialCalculator.Internal
{
    /// <summary>
    /// Provides extension methods for various classses.
    /// </summary>
    public static class ExtensionMethods
    {
        #region Methods
        /// <summary>
        /// Formats the <see cref="double"/> value to have 4 decimal places.
        /// </summary>
        /// <param name="value">The <see cref="double" /> value to format.</param>
        /// <returns>The formatted value.</returns>
        public static string DecimalFormat(this double value)
        {
            return string.Format("{0:0.0000}", value);
        }
        #endregion
    }
}
