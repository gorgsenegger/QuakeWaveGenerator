namespace QuakeWaveGenerator
{
    partial class frmQuakeWaveGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuakeWaveGenerator));
            this.nudSizeInUnits = new System.Windows.Forms.NumericUpDown();
            this.lblSizeInUnits = new System.Windows.Forms.Label();
            this.lblTextureName = new System.Windows.Forms.Label();
            this.lblOffsetToRight = new System.Windows.Forms.Label();
            this.nudOffsetToRight = new System.Windows.Forms.NumericUpDown();
            this.lblOffsetToFront = new System.Windows.Forms.Label();
            this.nudOffsetToFront = new System.Windows.Forms.NumericUpDown();
            this.lblOffsetToTop = new System.Windows.Forms.Label();
            this.nudOffsetToTop = new System.Windows.Forms.NumericUpDown();
            this.cmbTextureName = new System.Windows.Forms.ComboBox();
            this.lblNumberOfRows = new System.Windows.Forms.Label();
            this.nudNumRows = new System.Windows.Forms.NumericUpDown();
            this.lblNumberOfColumns = new System.Windows.Forms.Label();
            this.nudNumColumns = new System.Windows.Forms.NumericUpDown();
            this.txtSumBlocks = new System.Windows.Forms.TextBox();
            this.lblSumBlocks = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblBlockSpacing = new System.Windows.Forms.Label();
            this.nudSpacing = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeInUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetToRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetToFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetToTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpacing)).BeginInit();
            this.SuspendLayout();
            // 
            // nudSizeInUnits
            // 
            this.nudSizeInUnits.Location = new System.Drawing.Point(105, 7);
            this.nudSizeInUnits.Name = "nudSizeInUnits";
            this.nudSizeInUnits.Size = new System.Drawing.Size(64, 20);
            this.nudSizeInUnits.TabIndex = 0;
            this.nudSizeInUnits.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // lblSizeInUnits
            // 
            this.lblSizeInUnits.AutoSize = true;
            this.lblSizeInUnits.Location = new System.Drawing.Point(12, 9);
            this.lblSizeInUnits.Name = "lblSizeInUnits";
            this.lblSizeInUnits.Size = new System.Drawing.Size(66, 13);
            this.lblSizeInUnits.TabIndex = 1;
            this.lblSizeInUnits.Text = "Size in units:";
            // 
            // lblTextureName
            // 
            this.lblTextureName.AutoSize = true;
            this.lblTextureName.Location = new System.Drawing.Point(352, 9);
            this.lblTextureName.Name = "lblTextureName";
            this.lblTextureName.Size = new System.Drawing.Size(75, 13);
            this.lblTextureName.TabIndex = 2;
            this.lblTextureName.Text = "Texture name:";
            // 
            // lblOffsetToRight
            // 
            this.lblOffsetToRight.AutoSize = true;
            this.lblOffsetToRight.Location = new System.Drawing.Point(12, 35);
            this.lblOffsetToRight.Name = "lblOffsetToRight";
            this.lblOffsetToRight.Size = new System.Drawing.Size(73, 13);
            this.lblOffsetToRight.TabIndex = 4;
            this.lblOffsetToRight.Text = "Offset to right:";
            // 
            // nudOffsetToRight
            // 
            this.nudOffsetToRight.Location = new System.Drawing.Point(105, 33);
            this.nudOffsetToRight.Name = "nudOffsetToRight";
            this.nudOffsetToRight.Size = new System.Drawing.Size(64, 20);
            this.nudOffsetToRight.TabIndex = 5;
            // 
            // lblOffsetToFront
            // 
            this.lblOffsetToFront.AutoSize = true;
            this.lblOffsetToFront.Location = new System.Drawing.Point(175, 35);
            this.lblOffsetToFront.Name = "lblOffsetToFront";
            this.lblOffsetToFront.Size = new System.Drawing.Size(74, 13);
            this.lblOffsetToFront.TabIndex = 6;
            this.lblOffsetToFront.Text = "Offset to front:";
            // 
            // nudOffsetToFront
            // 
            this.nudOffsetToFront.Location = new System.Drawing.Point(282, 33);
            this.nudOffsetToFront.Name = "nudOffsetToFront";
            this.nudOffsetToFront.Size = new System.Drawing.Size(64, 20);
            this.nudOffsetToFront.TabIndex = 7;
            // 
            // lblOffsetToTop
            // 
            this.lblOffsetToTop.AutoSize = true;
            this.lblOffsetToTop.Location = new System.Drawing.Point(352, 35);
            this.lblOffsetToTop.Name = "lblOffsetToTop";
            this.lblOffsetToTop.Size = new System.Drawing.Size(68, 13);
            this.lblOffsetToTop.TabIndex = 8;
            this.lblOffsetToTop.Text = "Offset to top:";
            // 
            // nudOffsetToTop
            // 
            this.nudOffsetToTop.Location = new System.Drawing.Point(435, 33);
            this.nudOffsetToTop.Name = "nudOffsetToTop";
            this.nudOffsetToTop.Size = new System.Drawing.Size(64, 20);
            this.nudOffsetToTop.TabIndex = 9;
            // 
            // cmbTextureName
            // 
            this.cmbTextureName.FormattingEnabled = true;
            this.cmbTextureName.Items.AddRange(new object[] {
            "METAL1_3"});
            this.cmbTextureName.Location = new System.Drawing.Point(433, 6);
            this.cmbTextureName.Name = "cmbTextureName";
            this.cmbTextureName.Size = new System.Drawing.Size(139, 21);
            this.cmbTextureName.TabIndex = 10;
            // 
            // lblNumberOfRows
            // 
            this.lblNumberOfRows.AutoSize = true;
            this.lblNumberOfRows.Location = new System.Drawing.Point(15, 76);
            this.lblNumberOfRows.Name = "lblNumberOfRows";
            this.lblNumberOfRows.Size = new System.Drawing.Size(84, 13);
            this.lblNumberOfRows.TabIndex = 11;
            this.lblNumberOfRows.Text = "Number of rows:";
            // 
            // nudNumRows
            // 
            this.nudNumRows.Location = new System.Drawing.Point(105, 74);
            this.nudNumRows.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudNumRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumRows.Name = "nudNumRows";
            this.nudNumRows.Size = new System.Drawing.Size(64, 20);
            this.nudNumRows.TabIndex = 12;
            this.nudNumRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumRows.ValueChanged += new System.EventHandler(this.nudNumRows_ValueChanged);
            // 
            // lblNumberOfColumns
            // 
            this.lblNumberOfColumns.AutoSize = true;
            this.lblNumberOfColumns.Location = new System.Drawing.Point(175, 76);
            this.lblNumberOfColumns.Name = "lblNumberOfColumns";
            this.lblNumberOfColumns.Size = new System.Drawing.Size(101, 13);
            this.lblNumberOfColumns.TabIndex = 13;
            this.lblNumberOfColumns.Text = "Number of columns:";
            // 
            // nudNumColumns
            // 
            this.nudNumColumns.Location = new System.Drawing.Point(282, 74);
            this.nudNumColumns.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudNumColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumColumns.Name = "nudNumColumns";
            this.nudNumColumns.Size = new System.Drawing.Size(64, 20);
            this.nudNumColumns.TabIndex = 14;
            this.nudNumColumns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumColumns.ValueChanged += new System.EventHandler(this.nudNumColumns_ValueChanged);
            // 
            // txtSumBlocks
            // 
            this.txtSumBlocks.Location = new System.Drawing.Point(435, 73);
            this.txtSumBlocks.Name = "txtSumBlocks";
            this.txtSumBlocks.ReadOnly = true;
            this.txtSumBlocks.Size = new System.Drawing.Size(64, 20);
            this.txtSumBlocks.TabIndex = 15;
            this.txtSumBlocks.Text = "1";
            // 
            // lblSumBlocks
            // 
            this.lblSumBlocks.AutoSize = true;
            this.lblSumBlocks.Location = new System.Drawing.Point(352, 76);
            this.lblSumBlocks.Name = "lblSumBlocks";
            this.lblSumBlocks.Size = new System.Drawing.Size(77, 13);
            this.lblSumBlocks.TabIndex = 16;
            this.lblSumBlocks.Text = "Sum of blocks:";
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(12, 100);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(560, 249);
            this.txtOutput.TabIndex = 17;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(505, 33);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(67, 60);
            this.btnGenerate.TabIndex = 18;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblBlockSpacing
            // 
            this.lblBlockSpacing.AutoSize = true;
            this.lblBlockSpacing.Location = new System.Drawing.Point(175, 9);
            this.lblBlockSpacing.Name = "lblBlockSpacing";
            this.lblBlockSpacing.Size = new System.Drawing.Size(46, 13);
            this.lblBlockSpacing.TabIndex = 20;
            this.lblBlockSpacing.Text = "Spacing";
            // 
            // nudSpacing
            // 
            this.nudSpacing.Location = new System.Drawing.Point(282, 7);
            this.nudSpacing.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudSpacing.Name = "nudSpacing";
            this.nudSpacing.Size = new System.Drawing.Size(66, 20);
            this.nudSpacing.TabIndex = 21;
            this.nudSpacing.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // frmQuakeWaveGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.nudSpacing);
            this.Controls.Add(this.lblBlockSpacing);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblSumBlocks);
            this.Controls.Add(this.txtSumBlocks);
            this.Controls.Add(this.nudNumColumns);
            this.Controls.Add(this.lblNumberOfColumns);
            this.Controls.Add(this.nudNumRows);
            this.Controls.Add(this.lblNumberOfRows);
            this.Controls.Add(this.cmbTextureName);
            this.Controls.Add(this.nudOffsetToTop);
            this.Controls.Add(this.lblOffsetToTop);
            this.Controls.Add(this.nudOffsetToFront);
            this.Controls.Add(this.lblOffsetToFront);
            this.Controls.Add(this.nudOffsetToRight);
            this.Controls.Add(this.lblOffsetToRight);
            this.Controls.Add(this.lblTextureName);
            this.Controls.Add(this.lblSizeInUnits);
            this.Controls.Add(this.nudSizeInUnits);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmQuakeWaveGenerator";
            this.Text = "Quake Wave Generator";
            this.Load += new System.EventHandler(this.frmQuakeWaveGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeInUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetToRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetToFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetToTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpacing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudSizeInUnits;
        private System.Windows.Forms.Label lblSizeInUnits;
        private System.Windows.Forms.Label lblTextureName;
        private System.Windows.Forms.Label lblOffsetToRight;
        private System.Windows.Forms.NumericUpDown nudOffsetToRight;
        private System.Windows.Forms.Label lblOffsetToFront;
        private System.Windows.Forms.NumericUpDown nudOffsetToFront;
        private System.Windows.Forms.Label lblOffsetToTop;
        private System.Windows.Forms.NumericUpDown nudOffsetToTop;
        private System.Windows.Forms.ComboBox cmbTextureName;
        private System.Windows.Forms.Label lblNumberOfRows;
        private System.Windows.Forms.NumericUpDown nudNumRows;
        private System.Windows.Forms.Label lblNumberOfColumns;
        private System.Windows.Forms.NumericUpDown nudNumColumns;
        private System.Windows.Forms.TextBox txtSumBlocks;
        private System.Windows.Forms.Label lblSumBlocks;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblBlockSpacing;
        private System.Windows.Forms.NumericUpDown nudSpacing;
    }
}

