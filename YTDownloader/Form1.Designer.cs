namespace YTDownloader
{
    partial class YTDForm
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
            this.UrlBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UrlLabel = new System.Windows.Forms.Label();
            this.PathLabel = new System.Windows.Forms.Label();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.FormatLabel = new System.Windows.Forms.Label();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.MP3RadioButton = new System.Windows.Forms.RadioButton();
            this.MP4RadioButton = new System.Windows.Forms.RadioButton();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.OptionalLabel = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // UrlBox
            // 
            this.UrlBox.Font = new System.Drawing.Font("Gulim", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UrlBox.Location = new System.Drawing.Point(106, 33);
            this.UrlBox.Name = "UrlBox";
            this.UrlBox.Size = new System.Drawing.Size(420, 27);
            this.UrlBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 11;
            // 
            // UrlLabel
            // 
            this.UrlLabel.AutoSize = true;
            this.UrlLabel.Location = new System.Drawing.Point(55, 39);
            this.UrlLabel.Name = "UrlLabel";
            this.UrlLabel.Size = new System.Drawing.Size(45, 15);
            this.UrlLabel.TabIndex = 1;
            this.UrlLabel.Text = "URL :";
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(53, 105);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(47, 15);
            this.PathLabel.TabIndex = 2;
            this.PathLabel.Text = "Path :";
            // 
            // PathBox
            // 
            this.PathBox.Font = new System.Drawing.Font("Gulim", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PathBox.Location = new System.Drawing.Point(106, 99);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(302, 27);
            this.PathBox.TabIndex = 3;
            // 
            // FormatLabel
            // 
            this.FormatLabel.AutoSize = true;
            this.FormatLabel.Font = new System.Drawing.Font("Gulim", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormatLabel.Location = new System.Drawing.Point(31, 226);
            this.FormatLabel.Name = "FormatLabel";
            this.FormatLabel.Size = new System.Drawing.Size(69, 17);
            this.FormatLabel.TabIndex = 7;
            this.FormatLabel.Text = "Format :";
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(374, 219);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(152, 31);
            this.DownloadButton.TabIndex = 8;
            this.DownloadButton.Text = "Download";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // MP3RadioButton
            // 
            this.MP3RadioButton.AutoSize = true;
            this.MP3RadioButton.Font = new System.Drawing.Font("Gulim", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MP3RadioButton.Location = new System.Drawing.Point(138, 224);
            this.MP3RadioButton.Name = "MP3RadioButton";
            this.MP3RadioButton.Size = new System.Drawing.Size(60, 21);
            this.MP3RadioButton.TabIndex = 9;
            this.MP3RadioButton.TabStop = true;
            this.MP3RadioButton.Text = "MP3";
            this.MP3RadioButton.UseVisualStyleBackColor = true;
            // 
            // MP4RadioButton
            // 
            this.MP4RadioButton.AutoSize = true;
            this.MP4RadioButton.Font = new System.Drawing.Font("Gulim", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MP4RadioButton.Location = new System.Drawing.Point(257, 224);
            this.MP4RadioButton.Name = "MP4RadioButton";
            this.MP4RadioButton.Size = new System.Drawing.Size(61, 21);
            this.MP4RadioButton.TabIndex = 10;
            this.MP4RadioButton.TabStop = true;
            this.MP4RadioButton.Text = "MP4";
            this.MP4RadioButton.UseVisualStyleBackColor = true;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(439, 99);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(87, 27);
            this.BrowseButton.TabIndex = 12;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Gulim", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NameLabel.Location = new System.Drawing.Point(40, 165);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(60, 17);
            this.NameLabel.TabIndex = 14;
            this.NameLabel.Text = "Name :";
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Gulim", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NameBox.Location = new System.Drawing.Point(106, 161);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(420, 27);
            this.NameBox.TabIndex = 15;
            // 
            // OptionalLabel
            // 
            this.OptionalLabel.AutoSize = true;
            this.OptionalLabel.Location = new System.Drawing.Point(29, 182);
            this.OptionalLabel.Name = "OptionalLabel";
            this.OptionalLabel.Size = new System.Drawing.Size(71, 15);
            this.OptionalLabel.TabIndex = 16;
            this.OptionalLabel.Text = "(optional)";
            // 
            // ProgressBar
            // 
            this.ProgressBar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ProgressBar.Location = new System.Drawing.Point(34, 270);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(492, 23);
            this.ProgressBar.TabIndex = 17;
            // 
            // YTDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 340);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.OptionalLabel);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.MP4RadioButton);
            this.Controls.Add(this.MP3RadioButton);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.FormatLabel);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.UrlLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UrlBox);
            this.Name = "YTDForm";
            this.Text = "YTDownloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UrlBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UrlLabel;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Label FormatLabel;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.RadioButton MP3RadioButton;
        private System.Windows.Forms.RadioButton MP4RadioButton;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label OptionalLabel;
        private System.Windows.Forms.ProgressBar ProgressBar;
    }
}

