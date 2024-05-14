namespace Fingerprint.Converter.App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gpbWsq = new System.Windows.Forms.GroupBox();
            this.btnChooseWsqFile = new System.Windows.Forms.Button();
            this.txtWsqPath = new System.Windows.Forms.TextBox();
            this.gpbConverted = new System.Windows.Forms.GroupBox();
            this.btnChooseNewFile = new System.Windows.Forms.Button();
            this.txtNewFilePath = new System.Windows.Forms.TextBox();
            this.gpbExtensions = new System.Windows.Forms.GroupBox();
            this.rdbWmf = new System.Windows.Forms.RadioButton();
            this.rdbTiff = new System.Windows.Forms.RadioButton();
            this.rdbBmp = new System.Windows.Forms.RadioButton();
            this.rdbPng = new System.Windows.Forms.RadioButton();
            this.rdbJpg = new System.Windows.Forms.RadioButton();
            this.btnConverter = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.openFileDialogWsq = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.gpbWsq.SuspendLayout();
            this.gpbConverted.SuspendLayout();
            this.gpbExtensions.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbWsq
            // 
            this.gpbWsq.Controls.Add(this.btnChooseWsqFile);
            this.gpbWsq.Controls.Add(this.txtWsqPath);
            this.gpbWsq.Location = new System.Drawing.Point(12, 12);
            this.gpbWsq.Name = "gpbWsq";
            this.gpbWsq.Size = new System.Drawing.Size(630, 90);
            this.gpbWsq.TabIndex = 0;
            this.gpbWsq.TabStop = false;
            this.gpbWsq.Text = "Escolha o arquivo WSQ para conversão";
            // 
            // btnChooseWsqFile
            // 
            this.btnChooseWsqFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChooseWsqFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseWsqFile.Location = new System.Drawing.Point(557, 36);
            this.btnChooseWsqFile.Name = "btnChooseWsqFile";
            this.btnChooseWsqFile.Size = new System.Drawing.Size(42, 23);
            this.btnChooseWsqFile.TabIndex = 1;
            this.btnChooseWsqFile.Text = "...";
            this.btnChooseWsqFile.UseVisualStyleBackColor = true;
            this.btnChooseWsqFile.Click += new System.EventHandler(this.btnChooseWsqFile_Click);
            // 
            // txtWsqPath
            // 
            this.txtWsqPath.BackColor = System.Drawing.Color.White;
            this.txtWsqPath.Location = new System.Drawing.Point(22, 36);
            this.txtWsqPath.Multiline = true;
            this.txtWsqPath.Name = "txtWsqPath";
            this.txtWsqPath.ReadOnly = true;
            this.txtWsqPath.Size = new System.Drawing.Size(542, 23);
            this.txtWsqPath.TabIndex = 0;
            // 
            // gpbConverted
            // 
            this.gpbConverted.Controls.Add(this.btnChooseNewFile);
            this.gpbConverted.Controls.Add(this.txtNewFilePath);
            this.gpbConverted.Location = new System.Drawing.Point(12, 212);
            this.gpbConverted.Name = "gpbConverted";
            this.gpbConverted.Size = new System.Drawing.Size(630, 90);
            this.gpbConverted.TabIndex = 2;
            this.gpbConverted.TabStop = false;
            this.gpbConverted.Text = "Escolha onde salvar o arquivo convertido";
            // 
            // btnChooseNewFile
            // 
            this.btnChooseNewFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChooseNewFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseNewFile.Location = new System.Drawing.Point(557, 36);
            this.btnChooseNewFile.Name = "btnChooseNewFile";
            this.btnChooseNewFile.Size = new System.Drawing.Size(42, 23);
            this.btnChooseNewFile.TabIndex = 1;
            this.btnChooseNewFile.Text = "...";
            this.btnChooseNewFile.UseVisualStyleBackColor = true;
            this.btnChooseNewFile.Click += new System.EventHandler(this.btnChooseNewFile_Click);
            // 
            // txtNewFilePath
            // 
            this.txtNewFilePath.BackColor = System.Drawing.Color.White;
            this.txtNewFilePath.Location = new System.Drawing.Point(22, 36);
            this.txtNewFilePath.Multiline = true;
            this.txtNewFilePath.Name = "txtNewFilePath";
            this.txtNewFilePath.ReadOnly = true;
            this.txtNewFilePath.Size = new System.Drawing.Size(542, 23);
            this.txtNewFilePath.TabIndex = 0;
            // 
            // gpbExtensions
            // 
            this.gpbExtensions.Controls.Add(this.rdbWmf);
            this.gpbExtensions.Controls.Add(this.rdbTiff);
            this.gpbExtensions.Controls.Add(this.rdbBmp);
            this.gpbExtensions.Controls.Add(this.rdbPng);
            this.gpbExtensions.Controls.Add(this.rdbJpg);
            this.gpbExtensions.Enabled = false;
            this.gpbExtensions.Location = new System.Drawing.Point(12, 110);
            this.gpbExtensions.Name = "gpbExtensions";
            this.gpbExtensions.Size = new System.Drawing.Size(630, 90);
            this.gpbExtensions.TabIndex = 3;
            this.gpbExtensions.TabStop = false;
            this.gpbExtensions.Text = "Escolha o tipo de arquivo para conversão";
            // 
            // rdbWmf
            // 
            this.rdbWmf.AutoSize = true;
            this.rdbWmf.Location = new System.Drawing.Point(413, 40);
            this.rdbWmf.Name = "rdbWmf";
            this.rdbWmf.Size = new System.Drawing.Size(51, 17);
            this.rdbWmf.TabIndex = 4;
            this.rdbWmf.TabStop = true;
            this.rdbWmf.Text = "WMF";
            this.rdbWmf.UseVisualStyleBackColor = true;
            // 
            // rdbTiff
            // 
            this.rdbTiff.AutoSize = true;
            this.rdbTiff.Location = new System.Drawing.Point(316, 40);
            this.rdbTiff.Name = "rdbTiff";
            this.rdbTiff.Size = new System.Drawing.Size(47, 17);
            this.rdbTiff.TabIndex = 3;
            this.rdbTiff.TabStop = true;
            this.rdbTiff.Text = "TIFF";
            this.rdbTiff.UseVisualStyleBackColor = true;
            this.rdbTiff.CheckedChanged += new System.EventHandler(this.rdbTiff_CheckedChanged);
            // 
            // rdbBmp
            // 
            this.rdbBmp.AutoSize = true;
            this.rdbBmp.Location = new System.Drawing.Point(228, 40);
            this.rdbBmp.Name = "rdbBmp";
            this.rdbBmp.Size = new System.Drawing.Size(48, 17);
            this.rdbBmp.TabIndex = 2;
            this.rdbBmp.TabStop = true;
            this.rdbBmp.Text = "BMP";
            this.rdbBmp.UseVisualStyleBackColor = true;
            this.rdbBmp.CheckedChanged += new System.EventHandler(this.rdbBmp_CheckedChanged);
            // 
            // rdbPng
            // 
            this.rdbPng.AutoSize = true;
            this.rdbPng.Location = new System.Drawing.Point(130, 40);
            this.rdbPng.Name = "rdbPng";
            this.rdbPng.Size = new System.Drawing.Size(48, 17);
            this.rdbPng.TabIndex = 1;
            this.rdbPng.TabStop = true;
            this.rdbPng.Text = "PNG";
            this.rdbPng.UseVisualStyleBackColor = true;
            this.rdbPng.CheckedChanged += new System.EventHandler(this.rdbPng_CheckedChanged);
            // 
            // rdbJpg
            // 
            this.rdbJpg.AutoSize = true;
            this.rdbJpg.Location = new System.Drawing.Point(43, 40);
            this.rdbJpg.Name = "rdbJpg";
            this.rdbJpg.Size = new System.Drawing.Size(45, 17);
            this.rdbJpg.TabIndex = 0;
            this.rdbJpg.TabStop = true;
            this.rdbJpg.Text = "JPG";
            this.rdbJpg.UseVisualStyleBackColor = true;
            this.rdbJpg.CheckedChanged += new System.EventHandler(this.rdbJpg_CheckedChanged);
            // 
            // btnConverter
            // 
            this.btnConverter.Enabled = false;
            this.btnConverter.Location = new System.Drawing.Point(174, 326);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(125, 23);
            this.btnConverter.TabIndex = 4;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(328, 326);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(117, 23);
            this.btnClean.TabIndex = 5;
            this.btnClean.Text = "Limpar";
            this.btnClean.UseVisualStyleBackColor = true;
            // 
            // openFileDialogWsq
            // 
            this.openFileDialogWsq.FileName = "pfdWsq";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 371);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.gpbExtensions);
            this.Controls.Add(this.gpbConverted);
            this.Controls.Add(this.gpbWsq);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WSQ Converter";
            this.gpbWsq.ResumeLayout(false);
            this.gpbWsq.PerformLayout();
            this.gpbConverted.ResumeLayout(false);
            this.gpbConverted.PerformLayout();
            this.gpbExtensions.ResumeLayout(false);
            this.gpbExtensions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbWsq;
        private System.Windows.Forms.Button btnChooseWsqFile;
        private System.Windows.Forms.TextBox txtWsqPath;
        private System.Windows.Forms.GroupBox gpbConverted;
        private System.Windows.Forms.Button btnChooseNewFile;
        private System.Windows.Forms.TextBox txtNewFilePath;
        private System.Windows.Forms.GroupBox gpbExtensions;
        private System.Windows.Forms.RadioButton rdbTiff;
        private System.Windows.Forms.RadioButton rdbBmp;
        private System.Windows.Forms.RadioButton rdbPng;
        private System.Windows.Forms.RadioButton rdbJpg;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.OpenFileDialog openFileDialogWsq;
        private System.Windows.Forms.RadioButton rdbWmf;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

