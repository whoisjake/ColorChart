using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DevelopStuff.Examples.ColorChart.View
{
    public partial class AboutForm : Form
    {

        #region Constructor

        public AboutForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Shells out to a process.
        /// </summary>
        /// <param name="path"></param>
        private void ShellOut(string path)
        {
            try
            {
                System.Diagnostics.Process.Start(path);
            }
            catch { }
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Handles the LinkClicked event of the _licenseLabel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="T:System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void _licenseLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ShellOut("http://thoughtstoblog.com/pages/license");
        }


        /// <summary>
        /// Handles the LinkClicked event of the _emailButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="T:System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void _emailButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ShellOut("mailto:" + this._emailButton.Text);
        }

        /// <summary>
        /// Handles the LinkClicked event of the _currentSourceLabel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="T:System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void _currentSourceLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ShellOut(this._currentSourceLabel.Text);
        }

        #endregion


    }
}