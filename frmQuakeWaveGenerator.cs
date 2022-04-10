﻿using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuakeWaveGenerator
{
    public partial class frmQuakeWaveGenerator : Form
    {
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
            // progress, Convert.ToInt32(percentagePerBlock * ((row - 1) * nudNumColumns.Value + column)))
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

            //prgGeneration.Invoke(new MethodInvoker(delegate { prgGeneration.Value = percentage; }));
            txtOutput.Invoke(new MethodInvoker(delegate
            {
                txtOutput.AppendText("{" + Environment.NewLine);
                txtOutput.AppendText(generateBlockSettings(row, column));

                // Left face
                generateFace(
                    left_front_top_x, left_front_top_y, left_front_top_z,
                    left_front_bottom_x, left_front_bottom_y, left_front_bottom_z,
                    left_back_top_x, left_back_top_y, left_back_top_z);

                // Right face
                generateFace(
                    right_back_top_x, right_back_top_y, right_back_top_z,
                    right_back_bottom_x, right_back_bottom_y, right_back_bottom_z,
                    right_front_top_x, right_front_top_y, right_front_top_z);

                // Front face
                generateFace(
                    right_front_top_x, right_front_top_y, right_front_top_z,
                    right_front_bottom_x, right_front_bottom_y, right_front_bottom_z,
                    left_front_top_x, left_front_top_y, left_front_top_z);

                // Back face
                generateFace(
                    left_back_top_x, left_back_top_y, left_back_top_z,
                    left_back_bottom_x, left_back_bottom_y, left_back_bottom_z,
                    right_back_top_x, right_back_top_y, right_back_top_z);

                // Bottom face
                generateFace(
                    left_back_bottom_x, left_back_bottom_y, left_back_bottom_z,
                    left_front_bottom_x, left_front_bottom_y, left_front_bottom_z,
                    right_back_bottom_x, right_back_bottom_y, right_back_bottom_z);

                // Top face
                generateFace(
                    right_front_top_x, right_front_top_y, right_front_top_z,
                    left_front_top_x, left_front_top_y, left_front_top_z,
                    right_back_top_x, right_back_top_y, right_back_top_z);
                txtOutput.AppendText("}" + Environment.NewLine);
            }));
        }

        private string generateBlockSettings(int row, int column)
        {
            int makeSound = chkSound.Checked ? 1 : 0;
            return string.Format(
                @"  ""classname"" ""func_train""" + Environment.NewLine +
                @"  ""dmg"" ""0""" + Environment.NewLine +
                @"  ""speed"" ""32""" + Environment.NewLine +
                @"  ""sounds"" ""{0}""" + Environment.NewLine +
                @"  ""target"" ""{1}""" + Environment.NewLine +
                @"  {{" + Environment.NewLine, makeSound, "train_row-" + row.ToString("D3") + "_column-" + column.ToString("D3"));
        }

        private void generateFace(int x1, int y1, int z1, int x2, int y2, int z2, int x3, int y3, int z3)
        {
            string texture = cmbTextureName.SelectedItem + " 0 0 0 1 1";

            txtOutput.AppendText(
                string.Format("    ({0} {1} {2}) ({3} {4} {5}) ({6} {7} {8}) {9}", x1, y1, z1, x2, y2, z2, x3, y3, z3, texture) +
                Environment.NewLine);
        }

        private void SelectAllText(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            if (numericUpDown != null)
            {
                numericUpDown.Select(0, numericUpDown.Value.ToString().Length);
            }
        }
    }
}
