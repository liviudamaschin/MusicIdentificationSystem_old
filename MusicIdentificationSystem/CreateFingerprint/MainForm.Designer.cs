namespace CreateFingerprint
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnCreateFingerprint = new System.Windows.Forms.Button();
            this.pictureBoxWait = new System.Windows.Forms.PictureBox();
            this.btnMatchFingerprint = new System.Windows.Forms.Button();
            this.listBoxTracks = new System.Windows.Forms.ListBox();
            this.bindingSourceTracks = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTracks)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "\"All Supported Audio | *.mp3; *.wma; *.wav; | MP3s | *.mp3 | WMAs | *.wma | WAVs " +
    "| *.wav\";";
            this.openFileDialog.InitialDirectory = "T:\\WORK\\Music";
            // 
            // btnCreateFingerprint
            // 
            this.btnCreateFingerprint.Location = new System.Drawing.Point(23, 21);
            this.btnCreateFingerprint.Name = "btnCreateFingerprint";
            this.btnCreateFingerprint.Size = new System.Drawing.Size(156, 23);
            this.btnCreateFingerprint.TabIndex = 0;
            this.btnCreateFingerprint.Text = "Create Fingerprint";
            this.btnCreateFingerprint.UseVisualStyleBackColor = true;
            this.btnCreateFingerprint.Click += new System.EventHandler(this.btnCreateFingerprint_Click);
            // 
            // pictureBoxWait
            // 
            this.pictureBoxWait.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWait.Image")));
            this.pictureBoxWait.Location = new System.Drawing.Point(691, 215);
            this.pictureBoxWait.Name = "pictureBoxWait";
            this.pictureBoxWait.Size = new System.Drawing.Size(180, 117);
            this.pictureBoxWait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxWait.TabIndex = 1;
            this.pictureBoxWait.TabStop = false;
            this.pictureBoxWait.Visible = false;
            // 
            // btnMatchFingerprint
            // 
            this.btnMatchFingerprint.Location = new System.Drawing.Point(23, 68);
            this.btnMatchFingerprint.Name = "btnMatchFingerprint";
            this.btnMatchFingerprint.Size = new System.Drawing.Size(156, 23);
            this.btnMatchFingerprint.TabIndex = 2;
            this.btnMatchFingerprint.Text = "Match Song";
            this.btnMatchFingerprint.UseVisualStyleBackColor = true;
            this.btnMatchFingerprint.Click += new System.EventHandler(this.btnMatchFingerprint_Click);
            // 
            // listBoxTracks
            // 
            this.listBoxTracks.DataSource = this.bindingSourceTracks;
            this.listBoxTracks.DisplayMember = "Display";
            this.listBoxTracks.FormattingEnabled = true;
            this.listBoxTracks.Location = new System.Drawing.Point(23, 117);
            this.listBoxTracks.Name = "listBoxTracks";
            this.listBoxTracks.ScrollAlwaysVisible = true;
            this.listBoxTracks.Size = new System.Drawing.Size(641, 186);
            this.listBoxTracks.TabIndex = 3;
            this.listBoxTracks.ValueMember = "Value";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 332);
            this.Controls.Add(this.listBoxTracks);
            this.Controls.Add(this.btnMatchFingerprint);
            this.Controls.Add(this.pictureBoxWait);
            this.Controls.Add(this.btnCreateFingerprint);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Music Fingerprint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTracks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnCreateFingerprint;
        private System.Windows.Forms.PictureBox pictureBoxWait;
        private System.Windows.Forms.Button btnMatchFingerprint;
        private System.Windows.Forms.ListBox listBoxTracks;
        private System.Windows.Forms.BindingSource bindingSourceTracks;
    }
}

