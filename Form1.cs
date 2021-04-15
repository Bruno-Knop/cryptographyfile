using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using cryptographyfile;

namespace cryptographyfile {
    public partial class From1 : Form {
        public From1() {
            InitializeComponent();

            Cryptography.cspp = new CspParameters();
            Cryptography.EncrFloder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Encrypt\";
            Cryptography.DecrFloder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Decrypt\";
            Cryptography.SrcFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        #region Buttons

        private void ButtonEncryptFile_Click(object sender, EventArgs e) {
            if (Cryptography.rsa == null) {
                label1.ForeColor = Color.Red;
                label1.Text = "Key not defined";
            }
            else {
                //Select file
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.InitialDirectory = Cryptography.SrcFolder;
                if (dialog.ShowDialog() == DialogResult.OK) {
                    string fName = dialog.FileName;
                    FileInfo fInfo = new FileInfo(fName);
                    string name = fInfo.FullName;
                    label1.Text = Cryptography.EncryptFile(name);
                }
            }
        }

        private void ButtonDecryptFile_Click(object sender, EventArgs e) {
            if (Cryptography.rsa == null) {
                label1.ForeColor = Color.Red;
                label1.Text = "Key not defined";
            }
            else {
                //Select file
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.InitialDirectory = Cryptography.EncrFloder;
                if (dialog.ShowDialog() == DialogResult.OK) {
                    string fName = dialog.FileName;
                    FileInfo fInfo = new FileInfo(fName);
                    string name = fInfo.Name;
                    label1.Text = Cryptography.DecryptFile(name);
                }
            }
        }

        private void ButtonCreateKey_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtKey.Text)) {
                label1.ForeColor = Color.Red;
                label1.Text = "Insert value to define public key.";
                txtKey.Focus();
                return;
            }

            Cryptography.KeyName = txtKey.Text;
            label1.ForeColor = Color.DarkBlue;
            label1.Text = Cryptography.CreateKey();
        }

        private void ButtonGetPrivateKey_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtKey.Text)) {
                label1.ForeColor = Color.Red;
                label1.Text = "Insert value to define key private.";
                txtKey.Focus();
                return;
            }

            Cryptography.KeyName = txtKey.Text;
            label1.ForeColor = Color.DarkBlue;
            label1.Text = Cryptography.GetPrivateKey();
        }

        private void ButtonExportPublic_Click(object sender, EventArgs e) {
            if (Cryptography.ExportPublicKey()) {
                label1.ForeColor = Color.DarkBlue;
                label1.Text = "Public key exported.";
            }
            else {
                label1.ForeColor = Color.Red;
                label1.Text = "Public key not exported.";
            }
        }

        private void ButtonImportPublic_Click(object sender, EventArgs e) {
            Cryptography.KeyName = "Public";
            label1.ForeColor = Color.DarkBlue;
            label1.Text = Cryptography.ImportPublicKey();
        }

        #endregion

    }
}
