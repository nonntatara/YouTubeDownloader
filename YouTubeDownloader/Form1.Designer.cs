﻿//namespace YouTubeDownloader
//{
//    partial class Form1
//    {
//        /// <summary>
//        ///  Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        ///  Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        ///  Required method for Designer support - do not modify
//        ///  the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.components = new System.ComponentModel.Container();
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(800, 450);
//            this.Text = "Form1";
//        }

//        #endregion
//    }
//}


//namespace YouTubeDownloader
//{
//    partial class Form1
//    {
//        private System.ComponentModel.IContainer components = null;
//        private System.Windows.Forms.Button btnBrowseFile;
//        private System.Windows.Forms.TextBox txtThread;
//        private System.Windows.Forms.Button btnBrowseYtdlp;
//        private System.Windows.Forms.TextBox txtYtdlpExe;
//        private System.Windows.Forms.Button btnBrowseFfmpeg;
//        private System.Windows.Forms.TextBox txtFfmpegExe;
//        private System.Windows.Forms.Button btnSaveTo;
//        private System.Windows.Forms.TextBox txtSaveTo;
//        private System.Windows.Forms.Button btnStartDownload;
//        private System.Windows.Forms.Label lblStatus;
//        private System.Windows.Forms.Label lblCount;
//        private System.Windows.Forms.TextBox txtCmd;
//        private System.Windows.Forms.Button btnCancel;

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        private void InitializeComponent()
//        {
//            this.btnBrowseFile = new System.Windows.Forms.Button();
//            this.txtThread = new System.Windows.Forms.TextBox();
//            this.btnBrowseYtdlp = new System.Windows.Forms.Button();
//            this.txtYtdlpExe = new System.Windows.Forms.TextBox();
//            this.btnBrowseFfmpeg = new System.Windows.Forms.Button();
//            this.txtFfmpegExe = new System.Windows.Forms.TextBox();
//            this.btnSaveTo = new System.Windows.Forms.Button();
//            this.txtSaveTo = new System.Windows.Forms.TextBox();
//            this.btnStartDownload = new System.Windows.Forms.Button();
//            this.lblStatus = new System.Windows.Forms.Label();
//            this.lblCount = new System.Windows.Forms.Label();
//            this.txtCmd = new System.Windows.Forms.TextBox();
//            this.btnCancel = new System.Windows.Forms.Button();
//            this.SuspendLayout();
//            // 
//            // btnBrowseFile
//            // 
//            this.btnBrowseFile.Location = new System.Drawing.Point(12, 12);
//            this.btnBrowseFile.Name = "btnBrowseFile";
//            this.btnBrowseFile.Size = new System.Drawing.Size(75, 23);
//            this.btnBrowseFile.TabIndex = 0;
//            this.btnBrowseFile.Text = "Browse File";
//            this.btnBrowseFile.UseVisualStyleBackColor = true;
//            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
//            // 
//            // txtThread
//            // 
//            this.txtThread.Location = new System.Drawing.Point(93, 41);
//            this.txtThread.Name = "txtThread";
//            this.txtThread.Size = new System.Drawing.Size(100, 20);
//            this.txtThread.TabIndex = 1;
//            // 
//            // btnBrowseYtdlp
//            // 
//            this.btnBrowseYtdlp.Location = new System.Drawing.Point(12, 67);
//            this.btnBrowseYtdlp.Name = "btnBrowseYtdlp";
//            this.btnBrowseYtdlp.Size = new System.Drawing.Size(75, 23);
//            this.btnBrowseYtdlp.TabIndex = 2;
//            this.btnBrowseYtdlp.Text = "Browse yt-dlp";
//            this.btnBrowseYtdlp.UseVisualStyleBackColor = true;
//            this.btnBrowseYtdlp.Click += new System.EventHandler(this.btnBrowseYtdlp_Click);
//            // 
//            // txtYtdlpExe
//            // 
//            this.txtYtdlpExe.Location = new System.Drawing.Point(93, 69);
//            this.txtYtdlpExe.Name = "txtYtdlpExe";
//            this.txtYtdlpExe.Size = new System.Drawing.Size(100, 20);
//            this.txtYtdlpExe.TabIndex = 3;
//            // 
//            // btnBrowseFfmpeg
//            // 
//            this.btnBrowseFfmpeg.Location = new System.Drawing.Point(12, 96);
//            this.btnBrowseFfmpeg.Name = "btnBrowseFfmpeg";
//            this.btnBrowseFfmpeg.Size = new System.Drawing.Size(75, 23);
//            this.btnBrowseFfmpeg.TabIndex = 4;
//            this.btnBrowseFfmpeg.Text = "Browse ffmpeg";
//            this.btnBrowseFfmpeg.UseVisualStyleBackColor = true;
//            this.btnBrowseFfmpeg.Click += new System.EventHandler(this.btnBrowseFfmpeg_Click);
//            // 
//            // txtFfmpegExe
//            // 
//            this.txtFfmpegExe.Location = new System.Drawing.Point(93, 98);
//            this.txtFfmpegExe.Name = "txtFfmpegExe";
//            this.txtFfmpegExe.Size = new System.Drawing.Size(100, 20);
//            this.txtFfmpegExe.TabIndex = 5;
//            // 
//            // btnSaveTo
//            // 
//            this.btnSaveTo.Location = new System.Drawing.Point(12, 125);
//            this.btnSaveTo.Name = "btnSaveTo";
//            this.btnSaveTo.Size = new System.Drawing.Size(75, 23);
//            this.btnSaveTo.TabIndex = 6;
//            this.btnSaveTo.Text = "Save To";
//            this.btnSaveTo.UseVisualStyleBackColor = true;
//            this.btnSaveTo.Click += new System.EventHandler(this.btnSaveTo_Click);
//            // 
//            // txtSaveTo
//            // 
//            this.txtSaveTo.Location = new System.Drawing.Point(93, 127);
//            this.txtSaveTo.Name = "txtSaveTo";
//            this.txtSaveTo.Size = new System.Drawing.Size(100, 20);
//            this.txtSaveTo.TabIndex = 7;
//            // 
//            // btnStartDownload
//            // 
//            this.btnStartDownload.Location = new System.Drawing.Point(12, 154);
//            this.btnStartDownload.Name = "btnStartDownload";
//            this.btnStartDownload.Size = new System.Drawing.Size(75, 23);
//            this.btnStartDownload.TabIndex = 8;
//            this.btnStartDownload.Text = "Start Download";
//            this.btnStartDownload.UseVisualStyleBackColor = true;
//            this.btnStartDownload.Click += new System.EventHandler(this.btnStartDownload_Click);
//            // 
//            // lblStatus
//            // 
//            this.lblStatus.AutoSize = true;
//            this.lblStatus.Location = new System.Drawing.Point(93, 159);
//            this.lblStatus.Name = "lblStatus";
//            this.lblStatus.Size = new System.Drawing.Size(37, 13);
//            this.lblStatus.TabIndex = 9;
//            this.lblStatus.Text = "Status";
//            // 
//            // lblCount
//            // 
//            this.lblCount.AutoSize = true;
//            this.lblCount.Location = new System.Drawing.Point(93, 172);
//            this.lblCount.Name = "lblCount";
//            this.lblCount.Size = new System.Drawing.Size(35, 13);
//            this.lblCount.TabIndex = 10;
//            this.lblCount.Text = "Count";
//            // 
//            // txtCmd
//            // 
//            this.txtCmd.Location = new System.Drawing.Point(12, 183);
//            this.txtCmd.Multiline = true;
//            this.txtCmd.Name = "txtCmd";
//            this.txtCmd.Size = new System.Drawing.Size(200, 100);
//            this.txtCmd.TabIndex = 11;
//            // 
//            // btnCancel
//            // 
//            this.btnCancel.Location = new System.Drawing.Point(12, 289);
//            this.btnCancel.Name = "btnCancel";
//            this.btnCancel.Size = new System.Drawing.Size(75, 23);
//            this.btnCancel.TabIndex = 12;
//            this.btnCancel.Text = "Cancel";
//            this.btnCancel.UseVisualStyleBackColor = true;
//            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
//            // 
//            // Form1
//            // 
//            this.ClientSize = new System.Drawing.Size(284, 324);
//            this.Controls.Add(this.btnCancel);
//            this.Controls.Add(this.txtCmd);
//            this.Controls.Add(this.lblCount);
//            this.Controls.Add(this.lblStatus);
//            this.Controls.Add(this.btnStartDownload);
//            this.Controls.Add(this.txtSaveTo);
//            this.Controls.Add(this.btnSaveTo);
//            this.Controls.Add(this.txtFfmpegExe);
//            this.Controls.Add(this.btnBrowseFfmpeg);
//            this.Controls.Add(this.txtYtdlpExe);
//            this.Controls.Add(this.btnBrowseYtdlp);
//            this.Controls.Add(this.txtThread);
//            this.Controls.Add(this.btnBrowseFile);
//            this.Name = "Form1";
//            this.Text = "YouTube Downloader";
//            this.ResumeLayout(false);
//            this.PerformLayout();
//        }
//    }
//}


namespace YouTubeDownloader
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnBrowseFile;
        private TextBox txtFilePath;
        private Button btnBrowseYtdlp;
        private TextBox txtYtdlpExe;
        private Button btnBrowseFfmpeg;
        private TextBox txtFfmpegExe;
        private Button btnSaveTo;
        private TextBox txtSaveTo;
        private Button btnStartDownload;
        private Label lblStatus;
        private Label lblCount;
        private TextBox txtCmd;
        private Button btnCancel;

        private void InitializeComponent()
        {
            btnBrowseFile = new Button();
            txtFilePath = new TextBox();
            btnBrowseYtdlp = new Button();
            txtYtdlpExe = new TextBox();
            btnBrowseFfmpeg = new Button();
            txtFfmpegExe = new TextBox();
            btnSaveTo = new Button();
            txtSaveTo = new TextBox();
            btnStartDownload = new Button();
            lblStatus = new Label();
            lblCount = new Label();
            txtCmd = new TextBox();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // btnBrowseFile
            // 
            btnBrowseFile.Location = new Point(12, 12);
            btnBrowseFile.Name = "btnBrowseFile";
            btnBrowseFile.Size = new Size(110, 23);
            btnBrowseFile.TabIndex = 0;
            btnBrowseFile.Text = "Browse File";
            btnBrowseFile.UseVisualStyleBackColor = true;
            btnBrowseFile.Click += btnBrowseFile_Click;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(128, 13);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(270, 23);
            txtFilePath.TabIndex = 1;
            // 
            // btnBrowseYtdlp
            // 
            btnBrowseYtdlp.Location = new Point(12, 50);
            btnBrowseYtdlp.Name = "btnBrowseYtdlp";
            btnBrowseYtdlp.Size = new Size(110, 23);
            btnBrowseYtdlp.TabIndex = 2;
            btnBrowseYtdlp.Text = "yt-dlp.exe";
            btnBrowseYtdlp.UseVisualStyleBackColor = true;
            btnBrowseYtdlp.Click += btnBrowseYtdlp_Click;
            // 
            // txtYtdlpExe
            // 
            txtYtdlpExe.Location = new Point(128, 51);
            txtYtdlpExe.Name = "txtYtdlpExe";
            txtYtdlpExe.Size = new Size(270, 23);
            txtYtdlpExe.TabIndex = 3;
            // 
            // btnBrowseFfmpeg
            // 
            btnBrowseFfmpeg.Location = new Point(12, 90);
            btnBrowseFfmpeg.Name = "btnBrowseFfmpeg";
            btnBrowseFfmpeg.Size = new Size(110, 23);
            btnBrowseFfmpeg.TabIndex = 4;
            btnBrowseFfmpeg.Text = "ffmpeg.exe";
            btnBrowseFfmpeg.UseVisualStyleBackColor = true;
            btnBrowseFfmpeg.Click += btnBrowseFfmpeg_Click;
            // 
            // txtFfmpegExe
            // 
            txtFfmpegExe.Location = new Point(128, 91);
            txtFfmpegExe.Name = "txtFfmpegExe";
            txtFfmpegExe.Size = new Size(270, 23);
            txtFfmpegExe.TabIndex = 5;
            // 
            // btnSaveTo
            // 
            btnSaveTo.Location = new Point(12, 130);
            btnSaveTo.Name = "btnSaveTo";
            btnSaveTo.Size = new Size(110, 23);
            btnSaveTo.TabIndex = 6;
            btnSaveTo.Text = "Save To";
            btnSaveTo.UseVisualStyleBackColor = true;
            btnSaveTo.Click += btnSaveTo_Click;
            // 
            // txtSaveTo
            // 
            txtSaveTo.Location = new Point(128, 131);
            txtSaveTo.Name = "txtSaveTo";
            txtSaveTo.Size = new Size(270, 23);
            txtSaveTo.TabIndex = 7;
            // 
            // btnStartDownload
            // 
            btnStartDownload.Location = new Point(12, 170);
            btnStartDownload.Name = "btnStartDownload";
            btnStartDownload.Size = new Size(110, 23);
            btnStartDownload.TabIndex = 8;
            btnStartDownload.Text = "Start Download";
            btnStartDownload.UseVisualStyleBackColor = true;
            btnStartDownload.Click += btnStartDownload_Click;
            // 
            // lblStatus
            // 
            lblStatus.Location = new Point(12, 210);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(360, 23);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Status: Waiting...";
            // 
            // lblCount
            // 
            lblCount.Location = new Point(12, 240);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(360, 23);
            lblCount.TabIndex = 10;
            lblCount.Text = "Downloaded: 0";
            // 
            // txtCmd
            // 
            txtCmd.Location = new Point(12, 270);
            txtCmd.Multiline = true;
            txtCmd.Name = "txtCmd";
            txtCmd.Size = new Size(386, 150);
            txtCmd.TabIndex = 11;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 430);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(416, 461);
            Controls.Add(btnCancel);
            Controls.Add(txtCmd);
            Controls.Add(lblCount);
            Controls.Add(lblStatus);
            Controls.Add(btnStartDownload);
            Controls.Add(txtSaveTo);
            Controls.Add(btnSaveTo);
            Controls.Add(txtFfmpegExe);
            Controls.Add(btnBrowseFfmpeg);
            Controls.Add(txtYtdlpExe);
            Controls.Add(btnBrowseYtdlp);
            Controls.Add(txtFilePath);
            Controls.Add(btnBrowseFile);
            Name = "Form1";
            Text = "YouTube Downloader";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
