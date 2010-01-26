namespace DevelopStuff.Examples.ColorChart.Controls
{
    partial class ColorSwatch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._colorPanel = new System.Windows.Forms.Panel();
            this._colorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _colorPanel
            // 
            this._colorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._colorPanel.Location = new System.Drawing.Point(25, 10);
            this._colorPanel.Name = "_colorPanel";
            this._colorPanel.Size = new System.Drawing.Size(50, 50);
            this._colorPanel.TabIndex = 0;
            // 
            // _colorLabel
            // 
            this._colorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._colorLabel.AutoEllipsis = true;
            this._colorLabel.Location = new System.Drawing.Point(3, 67);
            this._colorLabel.Name = "_colorLabel";
            this._colorLabel.Size = new System.Drawing.Size(94, 23);
            this._colorLabel.TabIndex = 1;
            this._colorLabel.Text = "Color";
            this._colorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorSwatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._colorLabel);
            this.Controls.Add(this._colorPanel);
            this.Name = "ColorSwatch";
            this.Size = new System.Drawing.Size(100, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _colorPanel;
        private System.Windows.Forms.Label _colorLabel;
    }
}
