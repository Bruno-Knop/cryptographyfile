
namespace cryptographyfile {
    partial class From1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.ButtonEncryptFile = new System.Windows.Forms.Button();
            this.ButtonDecryptFile = new System.Windows.Forms.Button();
            this.ButtonCreateKey = new System.Windows.Forms.Button();
            this.ButtonExportPublic = new System.Windows.Forms.Button();
            this.ButtonImportPublic = new System.Windows.Forms.Button();
            this.ButtonGetPrivateKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unidentified Key";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtKey
            // 
            this.txtKey.BackColor = System.Drawing.Color.White;
            this.txtKey.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(13, 193);
            this.txtKey.MaxLength = 8;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(324, 26);
            this.txtKey.TabIndex = 1;
            this.txtKey.Text = "Insert Key";
            this.txtKey.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ButtonEncryptFile
            // 
            this.ButtonEncryptFile.BackColor = System.Drawing.Color.Transparent;
            this.ButtonEncryptFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEncryptFile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonEncryptFile.FlatAppearance.BorderSize = 0;
            this.ButtonEncryptFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonEncryptFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonEncryptFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEncryptFile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEncryptFile.ForeColor = System.Drawing.Color.Gold;
            this.ButtonEncryptFile.Location = new System.Drawing.Point(365, 12);
            this.ButtonEncryptFile.Name = "ButtonEncryptFile";
            this.ButtonEncryptFile.Size = new System.Drawing.Size(100, 60);
            this.ButtonEncryptFile.TabIndex = 2;
            this.ButtonEncryptFile.Text = "File Encryption";
            this.ButtonEncryptFile.UseVisualStyleBackColor = false;
            this.ButtonEncryptFile.Click += new System.EventHandler(this.ButtonEncryptFile_Click);
            // 
            // ButtonDecryptFile
            // 
            this.ButtonDecryptFile.BackColor = System.Drawing.Color.Transparent;
            this.ButtonDecryptFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDecryptFile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonDecryptFile.FlatAppearance.BorderSize = 0;
            this.ButtonDecryptFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDecryptFile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDecryptFile.ForeColor = System.Drawing.Color.Gold;
            this.ButtonDecryptFile.Location = new System.Drawing.Point(501, 12);
            this.ButtonDecryptFile.Name = "ButtonDecryptFile";
            this.ButtonDecryptFile.Size = new System.Drawing.Size(98, 59);
            this.ButtonDecryptFile.TabIndex = 3;
            this.ButtonDecryptFile.Text = "File Decryption";
            this.ButtonDecryptFile.UseMnemonic = false;
            this.ButtonDecryptFile.UseVisualStyleBackColor = false;
            this.ButtonDecryptFile.Click += new System.EventHandler(this.ButtonDecryptFile_Click);
            // 
            // ButtonCreateKey
            // 
            this.ButtonCreateKey.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCreateKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCreateKey.FlatAppearance.BorderSize = 0;
            this.ButtonCreateKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCreateKey.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCreateKey.ForeColor = System.Drawing.Color.Gold;
            this.ButtonCreateKey.Location = new System.Drawing.Point(501, 108);
            this.ButtonCreateKey.Name = "ButtonCreateKey";
            this.ButtonCreateKey.Size = new System.Drawing.Size(98, 59);
            this.ButtonCreateKey.TabIndex = 4;
            this.ButtonCreateKey.Text = "Create Key";
            this.ButtonCreateKey.UseVisualStyleBackColor = false;
            this.ButtonCreateKey.Click += new System.EventHandler(this.ButtonCreateKey_Click);
            // 
            // ButtonExportPublic
            // 
            this.ButtonExportPublic.BackColor = System.Drawing.Color.Transparent;
            this.ButtonExportPublic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonExportPublic.FlatAppearance.BorderSize = 0;
            this.ButtonExportPublic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExportPublic.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExportPublic.ForeColor = System.Drawing.Color.Gold;
            this.ButtonExportPublic.Location = new System.Drawing.Point(365, 207);
            this.ButtonExportPublic.Name = "ButtonExportPublic";
            this.ButtonExportPublic.Size = new System.Drawing.Size(98, 59);
            this.ButtonExportPublic.TabIndex = 5;
            this.ButtonExportPublic.Text = "Export Public Key";
            this.ButtonExportPublic.UseVisualStyleBackColor = false;
            this.ButtonExportPublic.Click += new System.EventHandler(this.ButtonExportPublic_Click);
            // 
            // ButtonImportPublic
            // 
            this.ButtonImportPublic.BackColor = System.Drawing.Color.Transparent;
            this.ButtonImportPublic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonImportPublic.FlatAppearance.BorderSize = 0;
            this.ButtonImportPublic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonImportPublic.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonImportPublic.ForeColor = System.Drawing.Color.Gold;
            this.ButtonImportPublic.Location = new System.Drawing.Point(365, 108);
            this.ButtonImportPublic.Name = "ButtonImportPublic";
            this.ButtonImportPublic.Size = new System.Drawing.Size(98, 59);
            this.ButtonImportPublic.TabIndex = 6;
            this.ButtonImportPublic.Text = "Import Public Key";
            this.ButtonImportPublic.UseVisualStyleBackColor = false;
            this.ButtonImportPublic.Click += new System.EventHandler(this.ButtonImportPublic_Click);
            // 
            // ButtonGetPrivateKey
            // 
            this.ButtonGetPrivateKey.BackColor = System.Drawing.Color.Transparent;
            this.ButtonGetPrivateKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonGetPrivateKey.FlatAppearance.BorderSize = 0;
            this.ButtonGetPrivateKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGetPrivateKey.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGetPrivateKey.ForeColor = System.Drawing.Color.Gold;
            this.ButtonGetPrivateKey.Location = new System.Drawing.Point(501, 207);
            this.ButtonGetPrivateKey.Name = "ButtonGetPrivateKey";
            this.ButtonGetPrivateKey.Size = new System.Drawing.Size(98, 59);
            this.ButtonGetPrivateKey.TabIndex = 7;
            this.ButtonGetPrivateKey.Text = "Get Private Key";
            this.ButtonGetPrivateKey.UseVisualStyleBackColor = false;
            this.ButtonGetPrivateKey.Click += new System.EventHandler(this.ButtonGetPrivateKey_Click);
            // 
            // From1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::cryptographyfile.Properties.Resources.Descrypt;
            this.ClientSize = new System.Drawing.Size(611, 278);
            this.Controls.Add(this.ButtonGetPrivateKey);
            this.Controls.Add(this.ButtonImportPublic);
            this.Controls.Add(this.ButtonExportPublic);
            this.Controls.Add(this.ButtonCreateKey);
            this.Controls.Add(this.ButtonDecryptFile);
            this.Controls.Add(this.ButtonEncryptFile);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "From1";
            this.Text = "Encrypt & Decrypt Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button ButtonEncryptFile;
        private System.Windows.Forms.Button ButtonDecryptFile;
        private System.Windows.Forms.Button ButtonCreateKey;
        private System.Windows.Forms.Button ButtonExportPublic;
        private System.Windows.Forms.Button ButtonImportPublic;
        private System.Windows.Forms.Button ButtonGetPrivateKey;
    }
}

