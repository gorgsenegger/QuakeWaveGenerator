using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuakeWaveGenerator
{
    public partial class frmQuakeWaveGenerator : Form
    {
        private MapFileTool m_MapFileTool = new MapFileTool();

        public frmQuakeWaveGenerator()
        {
            InitializeComponent();
            SetupNumericUpDownControls();
        }

        private void SetupNumericUpDownControls()
        {
            foreach (Control control in Controls)
            {
                NumericUpDown numericUpDown = control as NumericUpDown;
                if (numericUpDown != null)
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

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            decimal percentagePerBlock = Convert.ToDecimal(100) / Convert.ToDecimal(nudNumRows.Value * nudNumColumns.Value);
            for (int row = 1; row <= nudNumRows.Value; row++)
            {
                for (int column = 1; column <= nudNumColumns.Value; column++)
                {
                    int percentage = Convert.ToInt32(percentagePerBlock * ((row - 1) * nudNumColumns.Value + column));
                    await Task.Run(() => UpdateProgressBar(percentage));
                    await Task.Run(() => generateBlock(row, column));
                }
            }
        }

        public void UpdateProgressBar(int percentage)
        {
            prgGeneration.Invoke(new MethodInvoker(delegate { prgGeneration.Value = percentage; }));
        }

        private void generateBlock(int row, int column)
        {
            int length = Convert.ToInt32(nudSizeInUnits.Value);
            int start_x = Convert.ToInt32(nudOffsetToRight.Value);
            int start_y = Convert.ToInt32(nudOffsetToFront.Value);
            int start_z = Convert.ToInt32(nudOffsetToTop.Value);
            int spacing = Convert.ToInt32(nudSpacing.Value);

            // LEFT_FRONT_BOTTOM
            int left_front_bottom_x = ((column - 1) * length) + ((column - 1) * spacing) + start_x;
            int left_front_bottom_y = ((row - 1) * length) + ((row - 1) * spacing) + start_y;
            int left_front_bottom_z = start_z;

            // RIGHT_FRONT_BOTTOM
            int right_front_bottom_x = (column * length) + ((column - 1) * spacing) + start_x;
            int right_front_bottom_y = ((row - 1) * length) + ((row - 1) * spacing) + start_y;
            int right_front_bottom_z = start_z;

            // LEFT_BACK_BOTTOM
            int left_back_bottom_x = ((column - 1) * length) + ((column - 1) * spacing) + start_x;
            int left_back_bottom_y = (row * length) + ((row - 1) * spacing) + start_y;
            int left_back_bottom_z = start_z;

            // RIGHT_BACK_BOTTOM
            int right_back_bottom_x = (column * length) + ((column - 1) * spacing) + start_x;
            int right_back_bottom_y = (row * length) + ((row - 1) * spacing) + start_y;
            int right_back_bottom_z = start_z;

            // LEFT_FRONT_TOP
            int left_front_top_x = ((column - 1) * length) + ((column - 1) * spacing) + start_x;
            int left_front_top_y = ((row - 1) * length) + ((row - 1) * spacing) + start_y;
            int left_front_top_z = start_z + length;

            // RIGHT_FRONT_TOP
            int right_front_top_x = (column * length) + ((column - 1) * spacing) + start_x;
            int right_front_top_y = ((row - 1) * length) + ((row - 1) * spacing) + start_y;
            int right_front_top_z = start_z + length;

            // LEFT_BACK_TOP
            int left_back_top_x = ((column - 1) * length) + ((column - 1) * spacing) + start_x;
            int left_back_top_y = (row * length) + ((row - 1) * spacing) + start_y;
            int left_back_top_z = start_z + length;

            // RIGHT_BACK_TOP
            int right_back_top_x = (column * length) + ((column - 1) * spacing) + start_x;
            int right_back_top_y = (row * length) + ((row - 1) * spacing) + start_y;
            int right_back_top_z = start_z + length;

            txtOutput.Invoke(new MethodInvoker(delegate
            {
                txtOutput.AppendText("{" + Environment.NewLine);
                string baseTargetName = m_MapFileTool.GenerateBaseTargetName(row, column);
                txtOutput.AppendText(m_MapFileTool.GenerateFuncTrainSettings(row, column, baseTargetName, chkSound.Checked));

                // Left face
                txtOutput.AppendText(
                 m_MapFileTool.GenerateFace(
                        left_front_top_x, left_front_top_y, left_front_top_z,
                        left_front_bottom_x, left_front_bottom_y, left_front_bottom_z,
                        left_back_top_x, left_back_top_y, left_back_top_z,
                        cmbTextureName.SelectedItem.ToString()));

                // Right face
                txtOutput.AppendText(
                    m_MapFileTool.GenerateFace(
                        right_back_top_x, right_back_top_y, right_back_top_z,
                        right_back_bottom_x, right_back_bottom_y, right_back_bottom_z,
                        right_front_top_x, right_front_top_y, right_front_top_z,
                        cmbTextureName.SelectedItem.ToString()));

                // Front face
                txtOutput.AppendText(
                    m_MapFileTool.GenerateFace(
                        right_front_top_x, right_front_top_y, right_front_top_z,
                        right_front_bottom_x, right_front_bottom_y, right_front_bottom_z,
                        left_front_top_x, left_front_top_y, left_front_top_z,
                        cmbTextureName.SelectedItem.ToString()));

                // Back face
                txtOutput.AppendText(
                    m_MapFileTool.GenerateFace(
                        left_back_top_x, left_back_top_y, left_back_top_z,
                        left_back_bottom_x, left_back_bottom_y, left_back_bottom_z,
                        right_back_top_x, right_back_top_y, right_back_top_z,
                        cmbTextureName.SelectedItem.ToString()));

                // Bottom face
                txtOutput.AppendText(
                    m_MapFileTool.GenerateFace(
                        left_back_bottom_x, left_back_bottom_y, left_back_bottom_z,
                        left_front_bottom_x, left_front_bottom_y, left_front_bottom_z,
                        right_back_bottom_x, right_back_bottom_y, right_back_bottom_z,
                        cmbTextureName.SelectedItem.ToString()));

                // Top face
                txtOutput.AppendText(
                    m_MapFileTool.GenerateFace(
                        right_front_top_x, right_front_top_y, right_front_top_z,
                        left_front_top_x, left_front_top_y, left_front_top_z,
                        right_back_top_x, right_back_top_y, right_back_top_z,
                        cmbTextureName.SelectedItem.ToString()));
                txtOutput.AppendText("}" + Environment.NewLine);

                // TODO Generate path_corners: init, top, bottom
                // TODO: We need to vary the z coordinates for each init path_corner (based on direction of wave and number of steps)
                txtOutput.AppendText(
                  m_MapFileTool.GeneratePathCorner(
                        baseTargetName, PathCornerType.Init, left_front_bottom_x, left_front_bottom_y, left_front_bottom_z));
                txtOutput.AppendText(
                    m_MapFileTool.GeneratePathCorner(
                        baseTargetName, PathCornerType.Bottom, left_front_bottom_x, left_front_bottom_y, left_front_bottom_z));
                txtOutput.AppendText(
                    m_MapFileTool.GeneratePathCorner(
                        baseTargetName, PathCornerType.Top, left_front_bottom_x, left_front_bottom_y, left_front_bottom_z));
            }));
        }

        private void SelectAllText(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            if (numericUpDown != null)
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
            UpdateTotalAmplitude();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalAmplitude();
        }

        private void UpdateTotalAmplitude()
        {
            if (nudNumSteps.Value > Math.Max(nudNumRows.Value, nudNumColumns.Value))
            {
                txtMessages.AppendText("Num steps for wave must not be greater than the number of rows or columns!");
                return;
            }

            txtTotalAmplitude.Text = Convert.ToString(nudWaveHeightPerStep.Value * nudNumSteps.Value);
        }
    }
}
