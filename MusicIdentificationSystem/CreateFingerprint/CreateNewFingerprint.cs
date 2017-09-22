﻿using MusicIdentification.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateFingerprint
{
    public partial class CreateNewFingerprint : Form
    {
        public CreateNewFingerprint()
        {
            InitializeComponent();
        }

        private void btnSelectSongsFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {

                    txtSongsPath.Text = fbd.SelectedPath;
                    //string[] files = Directory.GetFiles(fbd.SelectedPath);

                   //MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtSongsPath.Text))
                MessageBox.Show("Please select a folder:");

            string[] files = Directory.GetFiles(txtSongsPath.Text);
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                if (fileInfo.Extension.ToLower() == "mp3")
                {
                    Fingerprint fingerprint = new Fingerprint();
                    fingerprint.StoreAudioFileFingerprintsInStorageForLaterRetrieval(file);
                }

            }
            //MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
        }
    }
}
