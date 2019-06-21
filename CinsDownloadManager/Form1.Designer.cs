namespace CinsDownloadManager
{
    partial class Form1
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
            this.prgsDownloading = new System.Windows.Forms.ProgressBar();
            this.lstMusics = new System.Windows.Forms.ListBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.lstIndirilmisler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstVideos = new System.Windows.Forms.ListBox();
            this.btnVideoDownload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prgsDownloading
            // 
            this.prgsDownloading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgsDownloading.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.prgsDownloading.Location = new System.Drawing.Point(9, 212);
            this.prgsDownloading.Margin = new System.Windows.Forms.Padding(2);
            this.prgsDownloading.Name = "prgsDownloading";
            this.prgsDownloading.Size = new System.Drawing.Size(351, 19);
            this.prgsDownloading.TabIndex = 0;
            // 
            // lstMusics
            // 
            this.lstMusics.FormattingEnabled = true;
            this.lstMusics.Items.AddRange(new object[] {
            "m.mp3",
            "m2.mp3",
            "banana.mp3"});
            this.lstMusics.Location = new System.Drawing.Point(9, 28);
            this.lstMusics.Margin = new System.Windows.Forms.Padding(2);
            this.lstMusics.Name = "lstMusics";
            this.lstMusics.Size = new System.Drawing.Size(122, 56);
            this.lstMusics.TabIndex = 1;
            this.lstMusics.SelectedIndexChanged += new System.EventHandler(this.LstMusics_SelectedIndexChanged);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(142, 28);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(2);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(68, 55);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Music Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            // 
            // lstIndirilmisler
            // 
            this.lstIndirilmisler.FormattingEnabled = true;
            this.lstIndirilmisler.Location = new System.Drawing.Point(234, 27);
            this.lstIndirilmisler.Margin = new System.Windows.Forms.Padding(2);
            this.lstIndirilmisler.Name = "lstIndirilmisler";
            this.lstIndirilmisler.Size = new System.Drawing.Size(122, 173);
            this.lstIndirilmisler.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Musics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Downloaded";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Movies";
            // 
            // lstVideos
            // 
            this.lstVideos.FormattingEnabled = true;
            this.lstVideos.Items.AddRange(new object[] {
            "v.mp4"});
            this.lstVideos.Location = new System.Drawing.Point(9, 115);
            this.lstVideos.Margin = new System.Windows.Forms.Padding(2);
            this.lstVideos.Name = "lstVideos";
            this.lstVideos.Size = new System.Drawing.Size(122, 69);
            this.lstVideos.TabIndex = 6;
            // 
            // btnVideoDownload
            // 
            this.btnVideoDownload.Location = new System.Drawing.Point(142, 115);
            this.btnVideoDownload.Margin = new System.Windows.Forms.Padding(2);
            this.btnVideoDownload.Name = "btnVideoDownload";
            this.btnVideoDownload.Size = new System.Drawing.Size(68, 68);
            this.btnVideoDownload.TabIndex = 2;
            this.btnVideoDownload.Text = "Video Download";
            this.btnVideoDownload.UseVisualStyleBackColor = true;
            this.btnVideoDownload.Click += new System.EventHandler(this.BtnVideoDownload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 240);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstVideos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstIndirilmisler);
            this.Controls.Add(this.btnVideoDownload);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.lstMusics);
            this.Controls.Add(this.prgsDownloading);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "-";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgsDownloading;
        private System.Windows.Forms.ListBox lstMusics;
        private System.Windows.Forms.Button btnDownload;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ListBox lstIndirilmisler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstVideos;
        private System.Windows.Forms.Button btnVideoDownload;
    }
}

