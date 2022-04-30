using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuakeWaveGenerator
{
    /// <summary>
    /// Main form of the application.
    /// </summary>
    public partial class frmQuakeWaveGenerator : Form
    {
        private readonly MapFileTool m_MapFileTool = new MapFileTool();
        private bool m_Cancelled = false;

        /// <summary>
        /// Initialises a new instance of the <see cref="frmQuakeWaveGenerator"/> form.
        /// </summary>
        public frmQuakeWaveGenerator()
        {
            InitializeComponent();
            SetupNumericUpDownControls();
        }

        /// <summary>
        /// Attach event handlers that are the same for each instance of the NumericUpDownControl.
        /// </summary>
        private void SetupNumericUpDownControls()
        {
            foreach (Control control in Controls)
            {
                if (control is NumericUpDown numericUpDown)
                {
                    numericUpDown.Click += SelectAllText;
                    numericUpDown.GotFocus += SelectAllText;
                    numericUpDown.LostFocus += HandleLostFocus;
                }
            }
        }

        private void nudNumRows_ValueChanged(object sender, EventArgs e)
        {
            UpdateSumBlocks();
        }

        private void nudNumColumns_ValueChanged(object sender, EventArgs e)
        {
            UpdateSumBlocks();
        }

        private void UpdateSumBlocks()
        {
            txtSumBlocks.Text = (nudNumRows.Value * nudNumColumns.Value).ToString();
        }

        private void frmQuakeWaveGenerator_Load(object sender, EventArgs e)
        {
            cmbTextureName.SelectedIndex = 0;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            btnCancel.Enabled = true;
            decimal percentagePerBlock = Convert.ToDecimal(100) / Convert.ToDecimal(nudNumRows.Value * nudNumColumns.Value);
            int[] stepSequence = m_MapFileTool.StepSequence(Convert.ToInt32(nudNumSteps.Value), Convert.ToInt32(nudWaveHeightPerStep.Value));
            StringBuilder stringBuilder = new StringBuilder();
            for (int row = 1; row <= nudNumRows.Value; row++)
            {
                for (int column = 1; column <= nudNumColumns.Value; column++)
                {
                    if (m_Cancelled)
                    {
                        LogMessage("Generation cancelled.", Severity.Info);
                        m_Cancelled = false;
                        btnCancel.Enabled = false;
                        return;
                    }

                    int offsetPerRow = 0;
                    if (chkDiagonalWave.Checked)
                    {
                        offsetPerRow = (row - 1) + column;
                    }

                    int stepHeight = stepSequence[(offsetPerRow + column) % stepSequence.Length];
                    int percentage = Convert.ToInt32(percentagePerBlock * ((row - 1) * nudNumColumns.Value + column));
                    stringBuilder.Append(generateBlock(row, column, stepHeight, stepSequence.Max()));
                }
            }

            txtOutput.Invoke(new MethodInvoker(delegate
            {
                txtOutput.AppendText(stringBuilder.ToString());
            }));
            btnCancel.Enabled = false;
        }

        private string generateBlock(int row, int column, int stepHeight, int amplitude)
        {
            int length = Convert.ToInt32(nudSizeInUnits.Value);
            int start_x = Convert.ToInt32(nudOffsetToRight.Value);
            int start_y = Convert.ToInt32(nudOffsetToFront.Value);
            int start_z = Convert.ToInt32(nudOffsetToTop.Value);
            int spacing = Convert.ToInt32(nudSpacing.Value);

            return m_MapFileTool.ConcatBlockParts(
                row, column, length, start_x, start_y, start_z, spacing, chkSound.Checked, cmbTextureName.SelectedItem.ToString(), amplitude, stepHeight);
        }

        private void SelectAllText(object sender, EventArgs e)
        {
            if (sender is NumericUpDown numericUpDown)
            {
                numericUpDown.Select(0, numericUpDown.Value.ToString().Length);
            }
        }

        private void HandleLostFocus(object sender, EventArgs e)
        {
            UpdateSumBlocks();
        }

        private void nudWaveHeightPerStep_ValueChanged(object sender, EventArgs e)
        {
            UpdateAmplitude();
        }

        private void nudNumSteps_ValueChanged(object sender, EventArgs e)
        {
            UpdateAmplitude();
        }

        private void UpdateAmplitude()
        {
            int[] stepSequence = m_MapFileTool.StepSequence(Convert.ToInt32(nudNumSteps.Value), Convert.ToInt32(nudWaveHeightPerStep.Value));
            if (stepSequence.Length > nudNumColumns.Value)
            {
                LogMessage("Number of steps in step sequence must not be greater than the number of rows or columns!", Severity.Warning);
                nudNumSteps.Value = Math.Min(nudNumRows.Value, nudNumColumns.Value);
                return;
            }

            txtTotalAmplitude.Text = Convert.ToString(nudWaveHeightPerStep.Value * nudNumSteps.Value);
            txtStepHeights.Text = string.Join(", ", stepSequence);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            m_Cancelled = true;
        }

        private void LogMessage(string message, Severity severity)
        {
            string outputMessage =
                string.Format("{0} {1} - {2} - {3}", DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString(), severity, message);
            txtMessages.AppendText(outputMessage + Environment.NewLine);
        }

        private void btnCopyGeneratedCode_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOutput.Text))
            {
                Clipboard.SetText(txtOutput.Text);
            }
        }

        private void btnClearGeneratedText_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
        }

        private void nudNumRows_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateSumBlocks();
        }

        private void nudNumColumns_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateSumBlocks();
        }

        private void nudWaveHeightPerStep_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateAmplitude();
        }

        private void nudNumSteps_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateAmplitude();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            int[,] previewArray = new int[Convert.ToInt32(nudNumRows.Value), Convert.ToInt32(nudNumColumns.Value)];
            int[] stepSequence = m_MapFileTool.StepSequence(Convert.ToInt32(nudNumSteps.Value), Convert.ToInt32(nudWaveHeightPerStep.Value));
            for (int column = 1; column <= nudNumColumns.Value; column++)
            {
                for (int row = 1; row <= nudNumRows.Value; row++)
                {
                    int offsetPerRow = 0;
                    if (chkDiagonalWave.Checked)
                    {
                        offsetPerRow = (row - 1) + column;
                    }

                    int stepHeight = stepSequence[(offsetPerRow + column) % stepSequence.Length];
                    previewArray[row - 1, column - 1] = stepHeight;
                }
            }

            frmPreview frmPreview = new frmPreview();
            frmPreview.SetArrayAndSequence(previewArray, stepSequence);
            frmPreview.ShowDialog();
        }
    }
}
