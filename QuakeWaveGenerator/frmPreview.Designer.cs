#pragma warning disable CS1591
namespace QuakeWaveGenerator
{
    partial class frmPreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPreview));
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlDraw
            // 
            this.pnlDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDraw.Location = new System.Drawing.Point(0, 0);
            this.pnlDraw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(1200, 692);
            this.pnlDraw.TabIndex = 0;
            // 
            // frmPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.pnlDraw);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "frmPreview";
            this.Text = "Preview";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDraw;
    }
}
#pragma warning restore CS1591
