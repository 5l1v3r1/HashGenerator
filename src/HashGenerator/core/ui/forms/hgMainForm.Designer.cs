namespace HashGenerator.core.ui.forms
{
    partial class hgMainForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.md5HashOption = new System.Windows.Forms.RadioButton();
            this.sha1HashOption = new System.Windows.Forms.RadioButton();
            this.sha512HashOption = new System.Windows.Forms.RadioButton();
            this.computeHash = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.file2ComputeHash = new System.Windows.Forms.TextBox();
            this.pickFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fileHashValue = new System.Windows.Forms.TextBox();
            this.sha256HashOption = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 257);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(547, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(547, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutMenuItem.Text = "About..";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sha256HashOption);
            this.groupBox1.Controls.Add(this.sha512HashOption);
            this.groupBox1.Controls.Add(this.sha1HashOption);
            this.groupBox1.Controls.Add(this.md5HashOption);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 68);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hash Algorithm";
            // 
            // md5HashOption
            // 
            this.md5HashOption.AutoSize = true;
            this.md5HashOption.Location = new System.Drawing.Point(6, 31);
            this.md5HashOption.Name = "md5HashOption";
            this.md5HashOption.Size = new System.Drawing.Size(48, 17);
            this.md5HashOption.TabIndex = 0;
            this.md5HashOption.Text = "MD5";
            this.md5HashOption.UseVisualStyleBackColor = true;
            // 
            // sha1HashOption
            // 
            this.sha1HashOption.AutoSize = true;
            this.sha1HashOption.Checked = true;
            this.sha1HashOption.Location = new System.Drawing.Point(60, 31);
            this.sha1HashOption.Name = "sha1HashOption";
            this.sha1HashOption.Size = new System.Drawing.Size(53, 17);
            this.sha1HashOption.TabIndex = 1;
            this.sha1HashOption.TabStop = true;
            this.sha1HashOption.Text = "SHA1";
            this.sha1HashOption.UseVisualStyleBackColor = true;
            // 
            // sha512HashOption
            // 
            this.sha512HashOption.AutoSize = true;
            this.sha512HashOption.Location = new System.Drawing.Point(190, 31);
            this.sha512HashOption.Name = "sha512HashOption";
            this.sha512HashOption.Size = new System.Drawing.Size(65, 17);
            this.sha512HashOption.TabIndex = 2;
            this.sha512HashOption.Text = "SHA512";
            this.sha512HashOption.UseVisualStyleBackColor = true;
            // 
            // computeHash
            // 
            this.computeHash.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.computeHash.Location = new System.Drawing.Point(226, 208);
            this.computeHash.Name = "computeHash";
            this.computeHash.Size = new System.Drawing.Size(94, 29);
            this.computeHash.TabIndex = 3;
            this.computeHash.Text = "Compute Hash";
            this.computeHash.UseVisualStyleBackColor = true;
            this.computeHash.Click += new System.EventHandler(this.computeHash_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "File:";
            // 
            // file2ComputeHash
            // 
            this.file2ComputeHash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.file2ComputeHash.Location = new System.Drawing.Point(72, 119);
            this.file2ComputeHash.Name = "file2ComputeHash";
            this.file2ComputeHash.Size = new System.Drawing.Size(426, 20);
            this.file2ComputeHash.TabIndex = 5;
            // 
            // pickFile
            // 
            this.pickFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pickFile.Location = new System.Drawing.Point(504, 117);
            this.pickFile.Name = "pickFile";
            this.pickFile.Size = new System.Drawing.Size(31, 23);
            this.pickFile.TabIndex = 6;
            this.pickFile.Text = "...";
            this.pickFile.UseVisualStyleBackColor = true;
            this.pickFile.Click += new System.EventHandler(this.pickFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hash value:";
            // 
            // fileHashValue
            // 
            this.fileHashValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileHashValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fileHashValue.Location = new System.Drawing.Point(72, 156);
            this.fileHashValue.Name = "fileHashValue";
            this.fileHashValue.ReadOnly = true;
            this.fileHashValue.Size = new System.Drawing.Size(426, 20);
            this.fileHashValue.TabIndex = 8;
            this.fileHashValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fileHashValue_KeyDown);
            // 
            // sha256HashOption
            // 
            this.sha256HashOption.AutoSize = true;
            this.sha256HashOption.Location = new System.Drawing.Point(119, 31);
            this.sha256HashOption.Name = "sha256HashOption";
            this.sha256HashOption.Size = new System.Drawing.Size(65, 17);
            this.sha256HashOption.TabIndex = 3;
            this.sha256HashOption.Text = "SHA256";
            this.sha256HashOption.UseVisualStyleBackColor = true;
            // 
            // hgMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 279);
            this.Controls.Add(this.fileHashValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pickFile);
            this.Controls.Add(this.file2ComputeHash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.computeHash);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "hgMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HashGenerator - Compute hash values for files using popular hash algorithms.";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton md5HashOption;
        private System.Windows.Forms.RadioButton sha512HashOption;
        private System.Windows.Forms.RadioButton sha1HashOption;
        private System.Windows.Forms.Button computeHash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox file2ComputeHash;
        private System.Windows.Forms.Button pickFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileHashValue;
        private System.Windows.Forms.RadioButton sha256HashOption;
    }
}

