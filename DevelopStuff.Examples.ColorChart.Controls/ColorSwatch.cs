using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DevelopStuff.Examples.ColorChart.Controls
{
    public partial class ColorSwatch : UserControl
    {

        #region Constructor

        public ColorSwatch(Color color)
        {
            InitializeComponent();

            this._colorPanel.BackColor = color;
            this._colorLabel.Text = color.Name;

            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        #endregion

    }
}
