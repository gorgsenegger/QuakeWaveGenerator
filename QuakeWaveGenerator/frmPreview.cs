using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuakeWaveGenerator
{
    /// <summary>
    /// Preview of the resulting "wave" as a height map.
    /// </summary>
    public partial class frmPreview : Form
    {
        private int[,] m_PreviewArray;
        private int[] m_StepSequence;

        /// <summary>
        /// Height map preview of the generated path_corner entities.
        /// </summary>
        public frmPreview()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Arry and step sequence information.
        /// </summary>
        /// <param name="previewArray"></param>
        /// <param name="stepSequence"></param>
        public void SetArrayAndSequence(int[,] previewArray, int[] stepSequence)
        {
            m_PreviewArray = previewArray;
            m_StepSequence = stepSequence.Distinct().ToArray();
        }

        /// <summary>
        /// TODO: Improve crude preview.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int numElementsWide = m_PreviewArray.GetLength(0);
            int numElementsHigh = m_PreviewArray.GetLength(1);
            int blockWidth = Convert.ToInt32(Math.Floor((double)Size.Width / numElementsWide));
            int blockHeight = Convert.ToInt32(Math.Floor((double)Size.Height / numElementsHigh));
            using (Graphics formGraphics = pnlDraw.CreateGraphics())
            {
                int factor = Convert.ToInt32(Math.Floor(255.0 / m_StepSequence.Max()));
                for (int column = 0; column < m_PreviewArray.GetLength(0); column++)
                {
                    for (int row = 0; row < m_PreviewArray.GetLength(1); row++)
                    {
                        int currentStepHeight = m_PreviewArray[column, row];
                        Color color = Color.FromArgb(currentStepHeight * factor, currentStepHeight * factor, currentStepHeight * factor);
                        using (SolidBrush myBrush = new SolidBrush(color))
                        {
                            formGraphics.FillRectangle(myBrush, new Rectangle(column * blockWidth, row * blockHeight, blockWidth, blockHeight));
                        }
                    }
                }
            }
        }
    }
}
