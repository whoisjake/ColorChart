namespace DevelopStuff.Examples.ColorChart.View
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this._currentSourceLabel = new System.Windows.Forms.LinkLabel();
            this._headerLabel = new System.Windows.Forms.Label();
            this._authorLabel = new System.Windows.Forms.Label();
            this._currentVersion = new System.Windows.Forms.Label();
            this._emailButton = new System.Windows.Forms.LinkLabel();
            this._licenseLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // _currentSourceLabel
            // 
            this._currentSourceLabel.AutoSize = true;
            this._currentSourceLabel.Location = new System.Drawing.Point(12, 105);
            this._currentSourceLabel.Name = "_currentSourceLabel";
            this._currentSourceLabel.Size = new System.Drawing.Size(235, 13);
            this._currentSourceLabel.TabIndex = 0;
            this._currentSourceLabel.TabStop = true;
            this._currentSourceLabel.Text = "http://source.developstuff.com/colorchart/trunk";
            this._currentSourceLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._currentSourceLabel_LinkClicked);
            // 
            // _headerLabel
            // 
            this._headerLabel.AutoSize = true;
            this._headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._headerLabel.Location = new System.Drawing.Point(12, 15);
            this._headerLabel.Name = "_headerLabel";
            this._headerLabel.Size = new System.Drawing.Size(242, 13);
            this._headerLabel.TabIndex = 1;
            this._headerLabel.Text = "DevelopStuff Examples - Color Chart v1.0";
            // 
            // _authorLabel
            // 
            this._authorLabel.AutoSize = true;
            this._authorLabel.Location = new System.Drawing.Point(12, 28);
            this._authorLabel.Name = "_authorLabel";
            this._authorLabel.Size = new System.Drawing.Size(73, 13);
            this._authorLabel.TabIndex = 2;
            this._authorLabel.Text = "by Jake Good";
            // 
            // _currentVersion
            // 
            this._currentVersion.AutoSize = true;
            this._currentVersion.Location = new System.Drawing.Point(12, 92);
            this._currentVersion.Name = "_currentVersion";
            this._currentVersion.Size = new System.Drawing.Size(74, 13);
            this._currentVersion.TabIndex = 3;
            this._currentVersion.Text = "Latest Version";
            // 
            // _emailButton
            // 
            this._emailButton.AutoSize = true;
            this._emailButton.Location = new System.Drawing.Point(91, 28);
            this._emailButton.Name = "_emailButton";
            this._emailButton.Size = new System.Drawing.Size(108, 13);
            this._emailButton.TabIndex = 4;
            this._emailButton.TabStop = true;
            this._emailButton.Text = "jake@whoisjake.com";
            this._emailButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._emailButton_LinkClicked);
            // 
            // _licenseLabel
            // 
            this._licenseLabel.AutoSize = true;
            this._licenseLabel.Location = new System.Drawing.Point(12, 57);
            this._licenseLabel.Name = "_licenseLabel";
            this._licenseLabel.Size = new System.Drawing.Size(167, 13);
            this._licenseLabel.TabIndex = 5;
            this._licenseLabel.TabStop = true;
            this._licenseLabel.Text = "Distributed under the MIT License";
            this._licenseLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._licenseLabel_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 127);
            this.Controls.Add(this._licenseLabel);
            this.Controls.Add(this._emailButton);
            this.Controls.Add(this._currentVersion);
            this.Controls.Add(this._authorLabel);
            this.Controls.Add(this._headerLabel);
            this.Controls.Add(this._currentSourceLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel _currentSourceLabel;
        private System.Windows.Forms.Label _headerLabel;
        private System.Windows.Forms.Label _authorLabel;
        private System.Windows.Forms.Label _currentVersion;
        private System.Windows.Forms.LinkLabel _emailButton;
        private System.Windows.Forms.LinkLabel _licenseLabel;
    }
}