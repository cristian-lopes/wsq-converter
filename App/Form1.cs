using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Fingerprint.Converter;
using Fingerprint.Converter.Tools;

namespace Fingerprint.Converter.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChooseWsqFile_Click(object sender, EventArgs e)
        {
            // Choose file
            if (openFileDialogWsq.ShowDialog() == DialogResult.OK)
            {
                txtWsqPath.Text = openFileDialogWsq.FileName;
                gpbExtensions.Enabled = true;
            }
        }

        private void rdbJpg_CheckedChanged(object sender, EventArgs e)
        {
            gpbConverted.Enabled = true;
        }

        private void rdbPng_CheckedChanged(object sender, EventArgs e)
        {
            gpbConverted.Enabled = true;
        }

        private void rdbBmp_CheckedChanged(object sender, EventArgs e)
        {
            gpbConverted.Enabled = true;
        }

        private void rdbTiff_CheckedChanged(object sender, EventArgs e)
        {
            gpbConverted.Enabled = true;
        }

        private void btnChooseNewFile_Click(object sender, EventArgs e)
        {
            // Choose destination file
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtNewFilePath.Text = folderBrowserDialog1.SelectedPath;
                btnConverter.Enabled = true;
            }
        }

        private string GetExtension()
        {
            var extension = "jpg";

            if (rdbBmp.Checked)
                extension = "bmp";
            if (rdbPng.Checked)
                extension = "png";
            if (rdbTiff.Checked)
                extension = "tiff";
            if (rdbWmf.Checked)
                extension = "wmf";

            return extension;        }

        private string GetConvertedName()
        {
            var path = System.IO.Path.GetFileNameWithoutExtension(openFileDialogWsq.FileName);
            return path;
        }

        private enumerators.ImageType GetTypeOfFile()
        {
            var extension = enumerators.ImageType.JPG;

            if (rdbBmp.Checked)
                extension = enumerators.ImageType.BMP;
            if (rdbPng.Checked)
                extension = enumerators.ImageType.PNG;
            if (rdbTiff.Checked)
                extension = enumerators.ImageType.TIFF;
            if (rdbWmf.Checked)
                extension = enumerators.ImageType.WMF;

            return extension;
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            try
            {
                var binaryData = System.IO.File.ReadAllBytes(txtWsqPath.Text);
                using (Fingerprint.Converter.LibraryOpen converter = new Fingerprint.Converter.LibraryOpen(binaryData))
                {
                    converter.ConvertAndSave(GetTypeOfFile(), $"{folderBrowserDialog1.SelectedPath}\\{GetConvertedName()}.{GetExtension()}");
                }

                MessageBox.Show("Conversão realizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar converter e salvar o WSQ: " + ex.Message);
            }
        }
    }
}
