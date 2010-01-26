namespace DevelopStuff.Examples.ColorChart.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._statusBar = new System.Windows.Forms.StatusStrip();
            this._sortButton = new System.Windows.Forms.ToolStripDropDownButton();
            this._sortByClusterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._sortByGreenValueMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._sortByBlueValueMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._sortByRedValueMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._sortByNameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._colorStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._mainMenu = new System.Windows.Forms.MenuStrip();
            this._fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._separator1 = new System.Windows.Forms.ToolStripSeparator();
            this._exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._aboutColorChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._saveDialog = new System.Windows.Forms.SaveFileDialog();
            this._chart = new DevelopStuff.Examples.ColorChart.Controls.ColorChart();
            this._statusBar.SuspendLayout();
            this._mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _statusBar
            // 
            this._statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._sortButton,
            this._colorStatusLabel});
            this._statusBar.Location = new System.Drawing.Point(0, 527);
            this._statusBar.Name = "_statusBar";
            this._statusBar.Size = new System.Drawing.Size(734, 22);
            this._statusBar.TabIndex = 0;
            this._statusBar.Text = "statusStrip1";
            // 
            // _sortButton
            // 
            this._sortButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._sortButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._sortByClusterMenuItem,
            this._sortByGreenValueMenuItem,
            this._sortByBlueValueMenuItem,
            this._sortByRedValueMenuItem,
            this._sortByNameMenuItem});
            this._sortButton.Image = ((System.Drawing.Image)(resources.GetObject("_sortButton.Image")));
            this._sortButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._sortButton.Name = "_sortButton";
            this._sortButton.Size = new System.Drawing.Size(90, 20);
            this._sortButton.Text = "Sort the colors";
            this._sortButton.ToolTipText = "Sorts the colors by a specific order";
            // 
            // _sortByClusterMenuItem
            // 
            this._sortByClusterMenuItem.Name = "_sortByClusterMenuItem";
            this._sortByClusterMenuItem.Size = new System.Drawing.Size(181, 22);
            this._sortByClusterMenuItem.Text = "Sort By Cluster";
            this._sortByClusterMenuItem.Click += new System.EventHandler(this._sortByClusterMenuItem_Click);
            // 
            // _sortByGreenValueMenuItem
            // 
            this._sortByGreenValueMenuItem.Name = "_sortByGreenValueMenuItem";
            this._sortByGreenValueMenuItem.Size = new System.Drawing.Size(181, 22);
            this._sortByGreenValueMenuItem.Text = "Sort By Green Value";
            this._sortByGreenValueMenuItem.Click += new System.EventHandler(this._sortByGreenValueMenuItem_Click);
            // 
            // _sortByBlueValueMenuItem
            // 
            this._sortByBlueValueMenuItem.Name = "_sortByBlueValueMenuItem";
            this._sortByBlueValueMenuItem.Size = new System.Drawing.Size(181, 22);
            this._sortByBlueValueMenuItem.Text = "Sort By Blue Value";
            this._sortByBlueValueMenuItem.Click += new System.EventHandler(this._sortByBlueValueMenuItem_Click);
            // 
            // _sortByRedValueMenuItem
            // 
            this._sortByRedValueMenuItem.Name = "_sortByRedValueMenuItem";
            this._sortByRedValueMenuItem.Size = new System.Drawing.Size(181, 22);
            this._sortByRedValueMenuItem.Text = "Sort By Red Value";
            this._sortByRedValueMenuItem.Click += new System.EventHandler(this._sortByRedValueMenuItem_Click);
            // 
            // _sortByNameMenuItem
            // 
            this._sortByNameMenuItem.Name = "_sortByNameMenuItem";
            this._sortByNameMenuItem.Size = new System.Drawing.Size(181, 22);
            this._sortByNameMenuItem.Text = "Sort By Name";
            this._sortByNameMenuItem.Click += new System.EventHandler(this._sortByNameMenuItem_Click);
            // 
            // _colorStatusLabel
            // 
            this._colorStatusLabel.Name = "_colorStatusLabel";
            this._colorStatusLabel.Size = new System.Drawing.Size(85, 17);
            this._colorStatusLabel.Text = "32 Colors Found";
            // 
            // _mainMenu
            // 
            this._mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileToolStripMenuItem,
            this._aboutToolStripMenuItem});
            this._mainMenu.Location = new System.Drawing.Point(0, 0);
            this._mainMenu.Name = "_mainMenu";
            this._mainMenu.Size = new System.Drawing.Size(734, 24);
            this._mainMenu.TabIndex = 1;
            // 
            // _fileToolStripMenuItem
            // 
            this._fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._saveAsToolStripMenuItem,
            this._separator1,
            this._exitToolStripMenuItem});
            this._fileToolStripMenuItem.Name = "_fileToolStripMenuItem";
            this._fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this._fileToolStripMenuItem.Text = "&File";
            // 
            // _saveAsToolStripMenuItem
            // 
            this._saveAsToolStripMenuItem.Name = "_saveAsToolStripMenuItem";
            this._saveAsToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this._saveAsToolStripMenuItem.Text = "Save &As";
            this._saveAsToolStripMenuItem.Click += new System.EventHandler(this._saveAsToolStripMenuItem_Click);
            // 
            // _separator1
            // 
            this._separator1.Name = "_separator1";
            this._separator1.Size = new System.Drawing.Size(121, 6);
            // 
            // _exitToolStripMenuItem
            // 
            this._exitToolStripMenuItem.Name = "_exitToolStripMenuItem";
            this._exitToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this._exitToolStripMenuItem.Text = "E&xit";
            this._exitToolStripMenuItem.Click += new System.EventHandler(this._exitToolStripMenuItem_Click);
            // 
            // _aboutToolStripMenuItem
            // 
            this._aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._aboutColorChartToolStripMenuItem});
            this._aboutToolStripMenuItem.Name = "_aboutToolStripMenuItem";
            this._aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this._aboutToolStripMenuItem.Text = "&About";
            // 
            // _aboutColorChartToolStripMenuItem
            // 
            this._aboutColorChartToolStripMenuItem.Name = "_aboutColorChartToolStripMenuItem";
            this._aboutColorChartToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this._aboutColorChartToolStripMenuItem.Text = "About Color Chart";
            this._aboutColorChartToolStripMenuItem.Click += new System.EventHandler(this._aboutColorChartToolStripMenuItem_Click);
            // 
            // _saveDialog
            // 
            this._saveDialog.DefaultExt = "*.jpg";
            this._saveDialog.Filter = "Image files (*.bmp,*.gif,*.jpg, *.png)|*.bmp,*.gif,*.jpg,*.png";
            // 
            // _chart
            // 
            this._chart.AutoScroll = true;
            this._chart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._chart.ColorSortOrder = DevelopStuff.Examples.ColorChart.Core.ColorSort.ByName;
            this._chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this._chart.Location = new System.Drawing.Point(0, 24);
            this._chart.Name = "_chart";
            this._chart.Size = new System.Drawing.Size(734, 503);
            this._chart.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 549);
            this.Controls.Add(this._chart);
            this.Controls.Add(this._statusBar);
            this.Controls.Add(this._mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this._mainMenu;
            this.Name = "MainForm";
            this.Text = "DevelopStuff.Examples.ColorChart";
            this._statusBar.ResumeLayout(false);
            this._statusBar.PerformLayout();
            this._mainMenu.ResumeLayout(false);
            this._mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip _statusBar;
        private System.Windows.Forms.ToolStripStatusLabel _colorStatusLabel;
        private System.Windows.Forms.MenuStrip _mainMenu;
        private System.Windows.Forms.ToolStripMenuItem _fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator _separator1;
        private System.Windows.Forms.ToolStripMenuItem _exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _aboutColorChartToolStripMenuItem;
        private DevelopStuff.Examples.ColorChart.Controls.ColorChart _chart;
        private System.Windows.Forms.SaveFileDialog _saveDialog;
        private System.Windows.Forms.ToolStripDropDownButton _sortButton;
        private System.Windows.Forms.ToolStripMenuItem _sortByGreenValueMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _sortByBlueValueMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _sortByRedValueMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _sortByNameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _sortByClusterMenuItem;
    }
}

