
namespace RemoveBgTool
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
            this.txtSelectedFile = new System.Windows.Forms.TextBox();
            this.btnFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.localPhoto = new System.Windows.Forms.PictureBox();
            this.streamPhoto = new System.Windows.Forms.PictureBox();
            this.txtSelectedFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFolder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.localPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streamPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSelectedFile
            // 
            this.txtSelectedFile.Location = new System.Drawing.Point(12, 25);
            this.txtSelectedFile.Name = "txtSelectedFile";
            this.txtSelectedFile.Size = new System.Drawing.Size(503, 20);
            this.txtSelectedFile.TabIndex = 0;
            this.txtSelectedFile.TextChanged += new System.EventHandler(this.txtSelectedFile_TextChanged);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(521, 24);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(75, 20);
            this.btnFile.TabIndex = 1;
            this.btnFile.Text = "...";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path to file :";
            // 
            // localPhoto
            // 
            this.localPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.localPhoto.Location = new System.Drawing.Point(13, 107);
            this.localPhoto.Name = "localPhoto";
            this.localPhoto.Size = new System.Drawing.Size(244, 164);
            this.localPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.localPhoto.TabIndex = 3;
            this.localPhoto.TabStop = false;
            this.localPhoto.Click += new System.EventHandler(this.localPhoto_Click);
            // 
            // streamPhoto
            // 
            this.streamPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.streamPhoto.Location = new System.Drawing.Point(352, 107);
            this.streamPhoto.Name = "streamPhoto";
            this.streamPhoto.Size = new System.Drawing.Size(244, 164);
            this.streamPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.streamPhoto.TabIndex = 4;
            this.streamPhoto.TabStop = false;
            this.streamPhoto.Click += new System.EventHandler(this.streamPhoto_Click);
            // 
            // txtSelectedFolder
            // 
            this.txtSelectedFolder.Location = new System.Drawing.Point(12, 80);
            this.txtSelectedFolder.Name = "txtSelectedFolder";
            this.txtSelectedFolder.Size = new System.Drawing.Size(503, 20);
            this.txtSelectedFolder.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select where you want to save file :";
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(520, 79);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(75, 20);
            this.btnFolder.TabIndex = 7;
            this.btnFolder.Text = "...";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(266, 106);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 9;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(266, 136);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 10;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 307);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSelectedFolder);
            this.Controls.Add(this.streamPhoto);
            this.Controls.Add(this.localPhoto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.txtSelectedFile);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(623, 346);
            this.MinimumSize = new System.Drawing.Size(623, 346);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove-BG-Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.localPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streamPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSelectedFile;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox localPhoto;
        private System.Windows.Forms.PictureBox streamPhoto;
        private System.Windows.Forms.TextBox txtSelectedFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnSettings;
    }
}

