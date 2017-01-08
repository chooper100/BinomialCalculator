namespace BinomialCalculator.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataOut = new System.Windows.Forms.DataGridView();
            this.colSuccesses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFailures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProbability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCumulative = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numN = new System.Windows.Forms.NumericUpDown();
            this.lblN = new System.Windows.Forms.Label();
            this.lblNotation = new System.Windows.Forms.Label();
            this.numP = new System.Windows.Forms.NumericUpDown();
            this.lblP = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numP)).BeginInit();
            this.SuspendLayout();
            // 
            // dataOut
            // 
            this.dataOut.AllowUserToAddRows = false;
            this.dataOut.AllowUserToDeleteRows = false;
            this.dataOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataOut.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSuccesses,
            this.colFailures,
            this.colProbability,
            this.colCumulative});
            this.dataOut.Location = new System.Drawing.Point(17, 135);
            this.dataOut.Name = "dataOut";
            this.dataOut.RowHeadersVisible = false;
            this.dataOut.Size = new System.Drawing.Size(378, 168);
            this.dataOut.TabIndex = 0;
            // 
            // colSuccesses
            // 
            this.colSuccesses.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSuccesses.HeaderText = "Successes";
            this.colSuccesses.Name = "colSuccesses";
            this.colSuccesses.ReadOnly = true;
            // 
            // colFailures
            // 
            this.colFailures.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFailures.HeaderText = "Failures";
            this.colFailures.Name = "colFailures";
            this.colFailures.ReadOnly = true;
            // 
            // colProbability
            // 
            this.colProbability.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProbability.HeaderText = "Probability";
            this.colProbability.Name = "colProbability";
            this.colProbability.ReadOnly = true;
            // 
            // colCumulative
            // 
            this.colCumulative.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCumulative.HeaderText = "Cumulative Probability";
            this.colCumulative.Name = "colCumulative";
            this.colCumulative.ReadOnly = true;
            // 
            // numN
            // 
            this.numN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numN.Location = new System.Drawing.Point(45, 42);
            this.numN.Maximum = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.numN.Name = "numN";
            this.numN.Size = new System.Drawing.Size(120, 23);
            this.numN.TabIndex = 1;
            this.toolTip.SetToolTip(this.numN, "The number of trials");
            this.numN.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.Location = new System.Drawing.Point(14, 44);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(25, 15);
            this.lblN.TabIndex = 2;
            this.lblN.Text = "n =";
            this.toolTip.SetToolTip(this.lblN, "The number of trials");
            // 
            // lblNotation
            // 
            this.lblNotation.AutoSize = true;
            this.lblNotation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotation.Location = new System.Drawing.Point(12, 9);
            this.lblNotation.Name = "lblNotation";
            this.lblNotation.Size = new System.Drawing.Size(107, 25);
            this.lblNotation.TabIndex = 3;
            this.lblNotation.Text = "X ~ B(n, p)";
            // 
            // numP
            // 
            this.numP.DecimalPlaces = 3;
            this.numP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numP.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numP.Location = new System.Drawing.Point(45, 71);
            this.numP.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numP.Name = "numP";
            this.numP.Size = new System.Drawing.Size(120, 23);
            this.numP.TabIndex = 4;
            this.toolTip.SetToolTip(this.numP, "The probability of a success per trial (0 - 1)");
            this.numP.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.Location = new System.Drawing.Point(14, 73);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(25, 15);
            this.lblP.TabIndex = 5;
            this.lblP.Text = "p =";
            this.toolTip.SetToolTip(this.lblP, "The probability of a success per trial (0 - 1)");
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(17, 100);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 321);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.numP);
            this.Controls.Add(this.lblNotation);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.numN);
            this.Controls.Add(this.dataOut);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.Text = "Binomial Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.dataOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataOut;
        private System.Windows.Forms.NumericUpDown numN;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblNotation;
        private System.Windows.Forms.NumericUpDown numP;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSuccesses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFailures;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProbability;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCumulative;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

