#pragma warning disable CS1591
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
            this.lblDamage = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.nudDamage = new System.Windows.Forms.NumericUpDown();
            this.nudSpeed = new System.Windows.Forms.NumericUpDown();
            this.lblSound = new System.Windows.Forms.Label();
            this.chkSound = new System.Windows.Forms.CheckBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblWaveHeightPerStep = new System.Windows.Forms.Label();
            this.nudWaveHeightPerStep = new System.Windows.Forms.NumericUpDown();
            this.lblNumSteps = new System.Windows.Forms.Label();
            this.nudNumSteps = new System.Windows.Forms.NumericUpDown();
            this.lblTotalWaveAmplitude = new System.Windows.Forms.Label();
            this.txtTotalAmplitude = new System.Windows.Forms.TextBox();
            this.tlpTextBoxes = new System.Windows.Forms.TableLayoutPanel();
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.btnClearGeneratedText = new System.Windows.Forms.Button();
            this.btnCopyGeneratedCode = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblStepHeights = new System.Windows.Forms.Label();
            this.txtStepHeights = new System.Windows.Forms.TextBox();
            this.lblDiagonalWave = new System.Windows.Forms.Label();
            this.chkDiagonalWave = new System.Windows.Forms.CheckBox();
            this.btnPreview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeInUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetToRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetToFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetToTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWaveHeightPerStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumSteps)).BeginInit();
            this.tlpTextBoxes.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudSizeInUnits
            // 
            this.nudSizeInUnits.Location = new System.Drawing.Point(232, 7);
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
            this.lblSizeInUnits.Location = new System.Drawing.Point(139, 9);
            this.lblSizeInUnits.Name = "lblSizeInUnits";
            this.lblSizeInUnits.Size = new System.Drawing.Size(66, 13);
            this.lblSizeInUnits.TabIndex = 1;
            this.lblSizeInUnits.Text = "Size in units:";
            // 
            // lblTextureName
            // 
            this.lblTextureName.AutoSize = true;
            this.lblTextureName.Location = new System.Drawing.Point(479, 9);
            this.lblTextureName.Name = "lblTextureName";
            this.lblTextureName.Size = new System.Drawing.Size(75, 13);
            this.lblTextureName.TabIndex = 2;
            this.lblTextureName.Text = "Texture name:";
            // 
            // lblOffsetToRight
            // 
            this.lblOffsetToRight.AutoSize = true;
            this.lblOffsetToRight.Location = new System.Drawing.Point(139, 35);
            this.lblOffsetToRight.Name = "lblOffsetToRight";
            this.lblOffsetToRight.Size = new System.Drawing.Size(73, 13);
            this.lblOffsetToRight.TabIndex = 4;
            this.lblOffsetToRight.Text = "Offset to right:";
            // 
            // nudOffsetToRight
            // 
            this.nudOffsetToRight.Location = new System.Drawing.Point(232, 33);
            this.nudOffsetToRight.Name = "nudOffsetToRight";
            this.nudOffsetToRight.Size = new System.Drawing.Size(64, 20);
            this.nudOffsetToRight.TabIndex = 3;
            // 
            // lblOffsetToFront
            // 
            this.lblOffsetToFront.AutoSize = true;
            this.lblOffsetToFront.Location = new System.Drawing.Point(302, 35);
            this.lblOffsetToFront.Name = "lblOffsetToFront";
            this.lblOffsetToFront.Size = new System.Drawing.Size(74, 13);
            this.lblOffsetToFront.TabIndex = 6;
            this.lblOffsetToFront.Text = "Offset to front:";
            // 
            // nudOffsetToFront
            // 
            this.nudOffsetToFront.Location = new System.Drawing.Point(409, 33);
            this.nudOffsetToFront.Name = "nudOffsetToFront";
            this.nudOffsetToFront.Size = new System.Drawing.Size(64, 20);
            this.nudOffsetToFront.TabIndex = 4;
            // 
            // lblOffsetToTop
            // 
            this.lblOffsetToTop.AutoSize = true;
            this.lblOffsetToTop.Location = new System.Drawing.Point(479, 35);
            this.lblOffsetToTop.Name = "lblOffsetToTop";
            this.lblOffsetToTop.Size = new System.Drawing.Size(68, 13);
            this.lblOffsetToTop.TabIndex = 8;
            this.lblOffsetToTop.Text = "Offset to top:";
            // 
            // nudOffsetToTop
            // 
            this.nudOffsetToTop.Location = new System.Drawing.Point(567, 33);
            this.nudOffsetToTop.Name = "nudOffsetToTop";
            this.nudOffsetToTop.Size = new System.Drawing.Size(64, 20);
            this.nudOffsetToTop.TabIndex = 5;
            // 
            // cmbTextureName
            // 
            this.cmbTextureName.FormattingEnabled = true;
            this.cmbTextureName.Items.AddRange(new object[] {
            "METAL1_3"});
            this.cmbTextureName.Location = new System.Drawing.Point(567, 6);
            this.cmbTextureName.Name = "cmbTextureName";
            this.cmbTextureName.Size = new System.Drawing.Size(139, 21);
            this.cmbTextureName.TabIndex = 2;
            // 
            // lblNumberOfRows
            // 
            this.lblNumberOfRows.AutoSize = true;
            this.lblNumberOfRows.Location = new System.Drawing.Point(139, 87);
            this.lblNumberOfRows.Name = "lblNumberOfRows";
            this.lblNumberOfRows.Size = new System.Drawing.Size(84, 13);
            this.lblNumberOfRows.TabIndex = 11;
            this.lblNumberOfRows.Text = "Number of rows:";
            // 
            // nudNumRows
            // 
            this.nudNumRows.Location = new System.Drawing.Point(232, 85);
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
            this.nudNumRows.TabIndex = 9;
            this.nudNumRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumRows.ValueChanged += new System.EventHandler(this.nudNumRows_ValueChanged);
            this.nudNumRows.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudNumRows_KeyUp);
            // 
            // lblNumberOfColumns
            // 
            this.lblNumberOfColumns.AutoSize = true;
            this.lblNumberOfColumns.Location = new System.Drawing.Point(302, 87);
            this.lblNumberOfColumns.Name = "lblNumberOfColumns";
            this.lblNumberOfColumns.Size = new System.Drawing.Size(101, 13);
            this.lblNumberOfColumns.TabIndex = 13;
            this.lblNumberOfColumns.Text = "Number of columns:";
            // 
            // nudNumColumns
            // 
            this.nudNumColumns.Location = new System.Drawing.Point(409, 85);
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
            this.nudNumColumns.TabIndex = 10;
            this.nudNumColumns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumColumns.ValueChanged += new System.EventHandler(this.nudNumColumns_ValueChanged);
            this.nudNumColumns.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudNumColumns_KeyUp);
            // 
            // txtSumBlocks
            // 
            this.txtSumBlocks.Location = new System.Drawing.Point(567, 85);
            this.txtSumBlocks.Name = "txtSumBlocks";
            this.txtSumBlocks.ReadOnly = true;
            this.txtSumBlocks.Size = new System.Drawing.Size(64, 20);
            this.txtSumBlocks.TabIndex = 15;
            this.txtSumBlocks.Text = "1";
            // 
            // lblSumBlocks
            // 
            this.lblSumBlocks.AutoSize = true;
            this.lblSumBlocks.Location = new System.Drawing.Point(479, 87);
            this.lblSumBlocks.Name = "lblSumBlocks";
            this.lblSumBlocks.Size = new System.Drawing.Size(77, 13);
            this.lblSumBlocks.TabIndex = 16;
            this.lblSumBlocks.Text = "Sum of blocks:";
            // 
            // txtOutput
            // 
            this.tlpTextBoxes.SetColumnSpan(this.txtOutput, 2);
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(3, 3);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(704, 142);
            this.txtOutput.TabIndex = 17;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(482, 159);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(64, 23);
            this.btnGenerate.TabIndex = 18;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblBlockSpacing
            // 
            this.lblBlockSpacing.AutoSize = true;
            this.lblBlockSpacing.Location = new System.Drawing.Point(302, 9);
            this.lblBlockSpacing.Name = "lblBlockSpacing";
            this.lblBlockSpacing.Size = new System.Drawing.Size(46, 13);
            this.lblBlockSpacing.TabIndex = 20;
            this.lblBlockSpacing.Text = "Spacing";
            // 
            // nudSpacing
            // 
            this.nudSpacing.Location = new System.Drawing.Point(409, 7);
            this.nudSpacing.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudSpacing.Name = "nudSpacing";
            this.nudSpacing.Size = new System.Drawing.Size(64, 20);
            this.nudSpacing.TabIndex = 1;
            this.nudSpacing.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // lblDamage
            // 
            this.lblDamage.AutoSize = true;
            this.lblDamage.Location = new System.Drawing.Point(139, 61);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.Size = new System.Drawing.Size(50, 13);
            this.lblDamage.TabIndex = 22;
            this.lblDamage.Text = "Damage:";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(302, 61);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(41, 13);
            this.lblSpeed.TabIndex = 23;
            this.lblSpeed.Text = "Speed:";
            // 
            // nudDamage
            // 
            this.nudDamage.Location = new System.Drawing.Point(232, 59);
            this.nudDamage.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudDamage.Name = "nudDamage";
            this.nudDamage.Size = new System.Drawing.Size(64, 20);
            this.nudDamage.TabIndex = 6;
            // 
            // nudSpeed
            // 
            this.nudSpeed.Location = new System.Drawing.Point(409, 59);
            this.nudSpeed.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nudSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.Size = new System.Drawing.Size(64, 20);
            this.nudSpeed.TabIndex = 7;
            this.nudSpeed.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // lblSound
            // 
            this.lblSound.AutoSize = true;
            this.lblSound.Location = new System.Drawing.Point(479, 61);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(69, 13);
            this.lblSound.TabIndex = 26;
            this.lblSound.Text = "Make sound:";
            // 
            // chkSound
            // 
            this.chkSound.AutoSize = true;
            this.chkSound.Location = new System.Drawing.Point(567, 61);
            this.chkSound.Name = "chkSound";
            this.chkSound.Size = new System.Drawing.Size(15, 14);
            this.chkSound.TabIndex = 8;
            this.chkSound.UseVisualStyleBackColor = true;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 10);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(121, 121);
            this.picLogo.TabIndex = 28;
            this.picLogo.TabStop = false;
            // 
            // lblWaveHeightPerStep
            // 
            this.lblWaveHeightPerStep.AutoSize = true;
            this.lblWaveHeightPerStep.Location = new System.Drawing.Point(139, 113);
            this.lblWaveHeightPerStep.Name = "lblWaveHeightPerStep";
            this.lblWaveHeightPerStep.Size = new System.Drawing.Size(79, 13);
            this.lblWaveHeightPerStep.TabIndex = 30;
            this.lblWaveHeightPerStep.Text = "Height per step";
            // 
            // nudWaveHeightPerStep
            // 
            this.nudWaveHeightPerStep.Location = new System.Drawing.Point(232, 111);
            this.nudWaveHeightPerStep.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudWaveHeightPerStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWaveHeightPerStep.Name = "nudWaveHeightPerStep";
            this.nudWaveHeightPerStep.Size = new System.Drawing.Size(64, 20);
            this.nudWaveHeightPerStep.TabIndex = 11;
            this.nudWaveHeightPerStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWaveHeightPerStep.ValueChanged += new System.EventHandler(this.nudWaveHeightPerStep_ValueChanged);
            this.nudWaveHeightPerStep.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudWaveHeightPerStep_KeyUp);
            // 
            // lblNumSteps
            // 
            this.lblNumSteps.AutoSize = true;
            this.lblNumSteps.Location = new System.Drawing.Point(302, 113);
            this.lblNumSteps.Name = "lblNumSteps";
            this.lblNumSteps.Size = new System.Drawing.Size(87, 13);
            this.lblNumSteps.TabIndex = 32;
            this.lblNumSteps.Text = "Number of steps:";
            // 
            // nudNumSteps
            // 
            this.nudNumSteps.Location = new System.Drawing.Point(409, 111);
            this.nudNumSteps.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudNumSteps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumSteps.Name = "nudNumSteps";
            this.nudNumSteps.Size = new System.Drawing.Size(64, 20);
            this.nudNumSteps.TabIndex = 12;
            this.nudNumSteps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumSteps.ValueChanged += new System.EventHandler(this.nudNumSteps_ValueChanged);
            this.nudNumSteps.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudNumSteps_KeyUp);
            // 
            // lblTotalWaveAmplitude
            // 
            this.lblTotalWaveAmplitude.AutoSize = true;
            this.lblTotalWaveAmplitude.Location = new System.Drawing.Point(479, 113);
            this.lblTotalWaveAmplitude.Name = "lblTotalWaveAmplitude";
            this.lblTotalWaveAmplitude.Size = new System.Drawing.Size(82, 13);
            this.lblTotalWaveAmplitude.TabIndex = 35;
            this.lblTotalWaveAmplitude.Text = "Total amplitude:";
            // 
            // txtTotalAmplitude
            // 
            this.txtTotalAmplitude.Location = new System.Drawing.Point(567, 110);
            this.txtTotalAmplitude.Name = "txtTotalAmplitude";
            this.txtTotalAmplitude.ReadOnly = true;
            this.txtTotalAmplitude.Size = new System.Drawing.Size(64, 20);
            this.txtTotalAmplitude.TabIndex = 34;
            this.txtTotalAmplitude.Text = "1";
            // 
            // tlpTextBoxes
            // 
            this.tlpTextBoxes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTextBoxes.ColumnCount = 2;
            this.tlpTextBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTextBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpTextBoxes.Controls.Add(this.txtMessages, 0, 2);
            this.tlpTextBoxes.Controls.Add(this.txtOutput, 0, 0);
            this.tlpTextBoxes.Controls.Add(this.btnClearGeneratedText, 1, 1);
            this.tlpTextBoxes.Controls.Add(this.btnCopyGeneratedCode, 0, 1);
            this.tlpTextBoxes.Location = new System.Drawing.Point(12, 188);
            this.tlpTextBoxes.Name = "tlpTextBoxes";
            this.tlpTextBoxes.RowCount = 3;
            this.tlpTextBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTextBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpTextBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpTextBoxes.Size = new System.Drawing.Size(710, 261);
            this.tlpTextBoxes.TabIndex = 37;
            // 
            // txtMessages
            // 
            this.tlpTextBoxes.SetColumnSpan(this.txtMessages, 2);
            this.txtMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessages.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessages.Location = new System.Drawing.Point(3, 184);
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessages.Size = new System.Drawing.Size(704, 74);
            this.txtMessages.TabIndex = 37;
            // 
            // btnClearGeneratedText
            // 
            this.btnClearGeneratedText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearGeneratedText.Location = new System.Drawing.Point(613, 155);
            this.btnClearGeneratedText.Name = "btnClearGeneratedText";
            this.btnClearGeneratedText.Size = new System.Drawing.Size(94, 23);
            this.btnClearGeneratedText.TabIndex = 39;
            this.btnClearGeneratedText.Text = "Clear";
            this.btnClearGeneratedText.UseVisualStyleBackColor = true;
            this.btnClearGeneratedText.Click += new System.EventHandler(this.btnClearGeneratedText_Click);
            // 
            // btnCopyGeneratedCode
            // 
            this.btnCopyGeneratedCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyGeneratedCode.Location = new System.Drawing.Point(507, 155);
            this.btnCopyGeneratedCode.Name = "btnCopyGeneratedCode";
            this.btnCopyGeneratedCode.Size = new System.Drawing.Size(100, 23);
            this.btnCopyGeneratedCode.TabIndex = 38;
            this.btnCopyGeneratedCode.Text = "Copy to Clipboard";
            this.btnCopyGeneratedCode.UseVisualStyleBackColor = true;
            this.btnCopyGeneratedCode.Click += new System.EventHandler(this.btnCopyGeneratedCode_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(642, 159);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 23);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblStepHeights
            // 
            this.lblStepHeights.AutoSize = true;
            this.lblStepHeights.Location = new System.Drawing.Point(139, 140);
            this.lblStepHeights.Name = "lblStepHeights";
            this.lblStepHeights.Size = new System.Drawing.Size(82, 13);
            this.lblStepHeights.TabIndex = 39;
            this.lblStepHeights.Text = "Step sequence:";
            // 
            // txtStepHeights
            // 
            this.txtStepHeights.Location = new System.Drawing.Point(232, 137);
            this.txtStepHeights.Name = "txtStepHeights";
            this.txtStepHeights.ReadOnly = true;
            this.txtStepHeights.Size = new System.Drawing.Size(241, 20);
            this.txtStepHeights.TabIndex = 40;
            this.txtStepHeights.Text = "1";
            // 
            // lblDiagonalWave
            // 
            this.lblDiagonalWave.AutoSize = true;
            this.lblDiagonalWave.Location = new System.Drawing.Point(479, 140);
            this.lblDiagonalWave.Name = "lblDiagonalWave";
            this.lblDiagonalWave.Size = new System.Drawing.Size(81, 13);
            this.lblDiagonalWave.TabIndex = 41;
            this.lblDiagonalWave.Text = "Diagonal wave:";
            // 
            // chkDiagonalWave
            // 
            this.chkDiagonalWave.AutoSize = true;
            this.chkDiagonalWave.Location = new System.Drawing.Point(567, 139);
            this.chkDiagonalWave.Name = "chkDiagonalWave";
            this.chkDiagonalWave.Size = new System.Drawing.Size(15, 14);
            this.chkDiagonalWave.TabIndex = 42;
            this.chkDiagonalWave.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(567, 159);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(64, 23);
            this.btnPreview.TabIndex = 43;
            this.btnPreview.Text = "&Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // frmQuakeWaveGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.chkDiagonalWave);
            this.Controls.Add(this.lblDiagonalWave);
            this.Controls.Add(this.txtStepHeights);
            this.Controls.Add(this.lblStepHeights);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tlpTextBoxes);
            this.Controls.Add(this.lblTotalWaveAmplitude);
            this.Controls.Add(this.txtTotalAmplitude);
            this.Controls.Add(this.nudNumSteps);
            this.Controls.Add(this.lblNumSteps);
            this.Controls.Add(this.nudWaveHeightPerStep);
            this.Controls.Add(this.lblWaveHeightPerStep);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.chkSound);
            this.Controls.Add(this.lblSound);
            this.Controls.Add(this.nudSpeed);
            this.Controls.Add(this.nudDamage);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblDamage);
            this.Controls.Add(this.nudSpacing);
            this.Controls.Add(this.lblBlockSpacing);
            this.Controls.Add(this.btnGenerate);
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
            this.MinimumSize = new System.Drawing.Size(750, 500);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWaveHeightPerStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumSteps)).EndInit();
            this.tlpTextBoxes.ResumeLayout(false);
            this.tlpTextBoxes.PerformLayout();
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
        private System.Windows.Forms.Label lblDamage;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.NumericUpDown nudDamage;
        private System.Windows.Forms.NumericUpDown nudSpeed;
        private System.Windows.Forms.Label lblSound;
        private System.Windows.Forms.CheckBox chkSound;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblWaveHeightPerStep;
        private System.Windows.Forms.NumericUpDown nudWaveHeightPerStep;
        private System.Windows.Forms.Label lblNumSteps;
        private System.Windows.Forms.NumericUpDown nudNumSteps;
        private System.Windows.Forms.Label lblTotalWaveAmplitude;
        private System.Windows.Forms.TextBox txtTotalAmplitude;
        private System.Windows.Forms.TableLayoutPanel tlpTextBoxes;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtMessages;
        private System.Windows.Forms.Button btnCopyGeneratedCode;
        private System.Windows.Forms.Button btnClearGeneratedText;
        private System.Windows.Forms.Label lblStepHeights;
        private System.Windows.Forms.TextBox txtStepHeights;
        private System.Windows.Forms.Label lblDiagonalWave;
        private System.Windows.Forms.CheckBox chkDiagonalWave;
        private System.Windows.Forms.Button btnPreview;
    }
}

#pragma warning restore CS1591
