using BinomialCalculator.Internal;
using System;
using System.Windows.Forms;

namespace BinomialCalculator.UI
{
    /// <summary>
    /// The primary form of the application.
    /// </summary>
    public partial class MainForm : Form
    {
        #region Constructor
        /// <summary>
        /// Creates a new instance of the <see cref="MainForm" /> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion
        #region Event Handlers
        /// <summary>
        /// Handles the calculate button click event and populates
        /// the <see cref="dataOut" /> table.
        /// </summary>
        /// <param name="sender">The <see cref="Control" /> that raised the event.</param>
        /// <param name="e">The data for the event.</param>
        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Populate the table with the given user input
            PopulateTable(
                new Binomial(
                    (uint)numN.Value,
                    (double)numP.Value
                )
            );
        }
        #endregion
        #region Methods
        /// <summary>
        /// Populates the tables using the specified <see cref="Binomial" /> distribution.
        /// </summary>
        /// <param name="distribution">The distribution to use.</param>
        public void PopulateTable(Binomial distribution)
        {
            // Handle any exceptions - particularly because
            // distribution.GetProbability can cause an overflow exception
            // when given large values.
            try
            {
                // Clear existing data
                dataOut.Rows.Clear();

                // Keep track of cumulative probability
                double cumulative = 0;
                for (uint i = 0; i <= distribution.n; i++)
                {
                    // Get probability for current number of successes
                    double probability = distribution.GetProbability(i);

                    // Increment cumulative probability
                    cumulative += probability;

                    // Add row
                    dataOut.Rows.Add(
                        i,                           // Succeses
                        distribution.n - i,          // Fails
                        probability.DecimalFormat(), // Probability
                        cumulative.DecimalFormat()   // Cumulative probability
                    );
                }
            }
            catch
            {
                // An error occured, so display error message
                MessageBox.Show("An error occured, causing the operation to end early.");
            }
        }
        #endregion
    }
}
