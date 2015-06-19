using HashGenerator.core.hashing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashGenerator.core.ui.forms
{
    public partial class hgMainForm : Form
    {
        public hgMainForm()
        {
            InitializeComponent();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            using (hgAboutForm aboutForm = new hgAboutForm())
            {
                aboutForm.ShowDialog(this);
            }
        }

        private void pickFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.Title = "Select a file to compute Hash value.";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    file2ComputeHash.Text = openFileDialog.FileName;
                    fileHashValue.Text = "";
                }
            }
        }

        private void computeHash_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(file2ComputeHash.Text)) return;
            if (!System.IO.File.Exists(file2ComputeHash.Text)) return;

            if (md5HashOption.Checked)
            {
                hgMD5 md5Algo = new hgMD5();
                fileHashValue.Text = md5Algo.ComputeHash(file2ComputeHash.Text);
            }
            else if (sha1HashOption.Checked)
            {
                hgSHA1 sha1Algo = new hgSHA1();
                fileHashValue.Text = sha1Algo.ComputeHash(file2ComputeHash.Text);
            }
            else if (sha256HashOption.Checked)
            {
                hgSHA256 sha256Algo = new hgSHA256();
                fileHashValue.Text = sha256Algo.ComputeHash(file2ComputeHash.Text);
            }
            else if (sha512HashOption.Checked)
            {
                hgSHA512 sha512Algo = new hgSHA512();
                fileHashValue.Text = sha512Algo.ComputeHash(file2ComputeHash.Text);
            }
        }

        private void fileHashValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control & e.KeyCode == Keys.A)
                fileHashValue.SelectAll();
        }
    }
}
