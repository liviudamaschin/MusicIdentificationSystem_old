﻿namespace CreateFingerprint
{
    partial class CreateNewFingerprint
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtSongsPath = new System.Windows.Forms.TextBox();
            this.btnSelectSongsFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSongsPath
            // 
            this.txtSongsPath.Location = new System.Drawing.Point(66, 13);
            this.txtSongsPath.Name = "txtSongsPath";
            this.txtSongsPath.Size = new System.Drawing.Size(257, 22);
            this.txtSongsPath.TabIndex = 4;
            // 
            // btnSelectSongsFolder
            // 
            this.btnSelectSongsFolder.Location = new System.Drawing.Point(329, 13);
            this.btnSelectSongsFolder.Name = "btnSelectSongsFolder";
            this.btnSelectSongsFolder.Size = new System.Drawing.Size(37, 21);
            this.btnSelectSongsFolder.TabIndex = 3;
            this.btnSelectSongsFolder.Text = "...";
            this.btnSelectSongsFolder.UseVisualStyleBackColor = true;
            this.btnSelectSongsFolder.Click += new System.EventHandler(this.btnSelectSongsFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Folder";
            // 
            // CreateNewFingerprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 186);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSongsPath);
            this.Controls.Add(this.btnSelectSongsFolder);
            this.Name = "CreateNewFingerprint";
            this.Text = "CreateFingerprint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSongsPath;
        private System.Windows.Forms.Button btnSelectSongsFolder;
        private System.Windows.Forms.Label label1;
    }
}