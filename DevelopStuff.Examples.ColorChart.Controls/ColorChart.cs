using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using DevelopStuff.Examples.ColorChart.Core;

namespace DevelopStuff.Examples.ColorChart.Controls
{
    public partial class ColorChart : UserControl
    {

        #region Fields

        private int _trueHeight = 0;
        private int _trueWidth = 0;

        private ColorSort _sort;

        #endregion

        #region Constructor

        public ColorChart()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            this._sort = ColorSort.ByName;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the color sort order.
        /// </summary>
        public ColorSort ColorSortOrder
        {
            get
            {
                return this._sort;
            }
            set
            {
                this._sort = value;
            }
        }

        /// <summary>
        /// Gets the true height of the control.
        /// </summary>
        /// <value></value>
        public int TrueHeight
        {
            get
            {
                return this._trueHeight;
            }
        }

        /// <summary>
        /// Gets the true width of the control.
        /// </summary>
        /// <value></value>
        public int TrueWidth
        {
            get
            {
                return this._trueWidth;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Resets the control.
        /// </summary>
        public void Reset()
        {
            this.Controls.Clear();
            this.LoadColorSwatches();
            this.RelocateControls();
        }

        /// <summary>
        /// Loads the color swatches.
        /// </summary>
        private void LoadColorSwatches()
        {
            List<Color> colors = ColorGenerator.Instance.Colors;

            colors.Sort(new ColorComparer(this.ColorSortOrder));

            this.SuspendLayout();

            foreach (Color color in colors)
            {
                ColorSwatch swatch = new ColorSwatch(color);
                this.Controls.Add(swatch);
            }

            this.ResumeLayout();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.UserControl.Load"></see> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs"></see> that contains the event data.</param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Reset();
        }

        /// <summary>
        /// Relocates the controls.
        /// </summary>
        private void RelocateControls()
        {
            int X = 0;
            int Y = 0;
            int totalHeight = 0;
            int totalWidth = 0;

            bool seenFirst = false;

            this.SuspendLayout();

            foreach (ColorSwatch swatch in this.Controls)
            {

                // For the scrollable section, always key off of the "first" control.
                if (!seenFirst)
                {
                    Y = swatch.Location.Y;
                    seenFirst = true;
                }

                swatch.Location = new Point(X, Y);

                if ((X + (2 * swatch.Width) + SystemInformation.VerticalScrollBarWidth) > (this.Width))
                {
                    totalWidth = X + (2 * swatch.Width);
                    totalHeight = Y;

                    X = 0;
                    Y += swatch.Height;
                    
                }
                else
                {
                    X += swatch.Width;
                }
            }

            this._trueHeight = totalHeight;
            this._trueWidth = totalWidth;

            this.ResumeLayout();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.SizeChanged"></see> event.
        /// </summary>
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.RelocateControls();
        }

        #endregion

    }
}
