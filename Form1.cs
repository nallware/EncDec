using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EncDec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                      

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string text = tbDecryptedText.Text;
            string salt = tbSalt.Text;
            tbEncryptedText.Text = babelFish.EncryptText(text, salt);
            }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string salt = tbSalt.Text;
            string text = tbEncryptedText.Text;
            tbDecryptedText.Text = babelFish.DecryptText(text, salt);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbDecryptedText.Clear();
            tbEncryptedText.Clear();
            tbSalt.Clear();
        }
        
    }
}
