using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

using DevelopStuff.Examples.ColorChart.Core;

namespace DevelopStuff.Examples.ColorChart.View
{
    public partial class MainForm : Form
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="T:MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Changes the sort order on the control.
        /// </summary>
        /// <param name="colorSort"></param>
        private void ChangeSortOrder(ColorSort colorSort)
        {
            this._chart.ColorSortOrder = colorSort;
            this._chart.Reset();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.Load"></see> event.
        /// </summary>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this._colorStatusLabel.Text = ColorGenerator.Instance.Colors.Count.ToString() + " Colors found.";
        }

        /// <summary>
        /// Shows the <see cref="AboutForm"/>.
        /// </summary>
        private void ShowAboutBox()
        {
            AboutForm form = new AboutForm();
            form.ShowDialog(this);
        }

        /// <summary>
        /// Prompts the user to save the file.
        /// </summary>
        private void SaveFile()
        {
            _saveDialog.Title = "Save color swatches as...";

            DialogResult res = _saveDialog.ShowDialog(this);

			if(res == DialogResult.OK)
			{
                if (Directory.Exists(Path.GetDirectoryName(_saveDialog.FileName)))
                {
                    ImageFormat format = this.ParseImageFormat(_saveDialog.FileName);
                    ColorImage.SaveFile(new Size(this._chart.TrueWidth, this._chart.TrueHeight),format, _saveDialog.FileName);
                }
			}
        }

        /// <summary>
        /// Parses the image format.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <returns></returns>
        private ImageFormat ParseImageFormat(string p)
        {
            string extenstion = Path.GetExtension(p);

            if ((extenstion.ToUpper() == ".JPG") || (extenstion.ToUpper() == ".JPEG"))
            {
                return ImageFormat.Jpeg;
            }

            if (extenstion.ToUpper() == ".PNG")
            {
                return ImageFormat.Png;
            }

            if (extenstion.ToUpper() == ".GIF")
            {
                return ImageFormat.Gif;
            }

            if (extenstion.ToUpper() == ".BMP")
            {
                return ImageFormat.Bmp;
            }

            return ImageFormat.Jpeg;
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Handles the Click event of the _exitToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> instance containing the event data.</param>
        private void _exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the _saveAsToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> instance containing the event data.</param>
        private void _saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveFile();
        }

        /// <summary>
        /// Handles the Click event of the _aboutColorChartToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> instance containing the event data.</param>
        private void _aboutColorChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowAboutBox();
        }

        /// <summary>
        /// Handles the Click event of the _sortByGreenValueMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> instance containing the event data.</param>
        private void _sortByGreenValueMenuItem_Click(object sender, EventArgs e)
        {
            this.ChangeSortOrder(ColorSort.ByGreenValue);
        }

        /// <summary>
        /// Handles the Click event of the _sortByBlueValueMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> instance containing the event data.</param>
        private void _sortByBlueValueMenuItem_Click(object sender, EventArgs e)
        {
            this.ChangeSortOrder(ColorSort.ByBlueValue);
        }

        /// <summary>
        /// Handles the Click event of the _sortByRedValueMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> instance containing the event data.</param>
        private void _sortByRedValueMenuItem_Click(object sender, EventArgs e)
        {
            this.ChangeSortOrder(ColorSort.ByRedValue);
        }

        /// <summary>
        /// Handles the Click event of the _sortByNameMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> instance containing the event data.</param>
        private void _sortByNameMenuItem_Click(object sender, EventArgs e)
        {
            this.ChangeSortOrder(ColorSort.ByName);
        }

        /// <summary>
        /// Handles the Click event of the _sortByClusterMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> instance containing the event data.</param>
        private void _sortByClusterMenuItem_Click(object sender, EventArgs e)
        {
            this.ChangeSortOrder(ColorSort.ByCluster);
        }
        #endregion

    }
}