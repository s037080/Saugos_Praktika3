using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;


namespace Praktinis3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string password = passwordBox1.Text;

            try
            {
                UnicodeEncoding ByteConverter = new UnicodeEncoding();
                
                byte[] dataToEncrypt = ByteConverter.GetBytes(text);
                byte[] dataToDecrypt = ByteConverter.GetBytes(text);
                byte[] passwordUsage = ByteConverter.GetBytes(password);

                byte[] encryptedData = null;
                byte[] decryptedData = null;

                
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    if (encryptButton.Checked )
                    {                         
                        encryptedData = RSAEncrypt(dataToEncrypt, RSA.ExportParameters(false), false);
                        resultBox.Text = ByteConverter.GetString(encryptedData);
                    }
                    
                    if (decryptButton.Checked)
                    {                        
                        decryptedData = RSADecrypt(encryptedData, RSA.ExportParameters(true), false);
                        resultBox.Text = ByteConverter.GetString(decryptedData);
                    }                    
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Encryption failed.");
            }
        }

        public static byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {

                    
                    RSA.ImportParameters(RSAKeyInfo);

                    
                    encryptedData = RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
                }
                return encryptedData;
            }
            
            catch (CryptographicException e)
            {
                MessageBox.Show(e.Message);

                return null;
            }
        }

        public static byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                   
                    RSA.ImportParameters(RSAKeyInfo);
                    
                    decryptedData = RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
                }
                return decryptedData;
            }
            catch (CryptographicException e)
            {
                MessageBox.Show(e.ToString());

                return null;
            }
        }
        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog folder = new OpenFileDialog();
            folder.InitialDirectory = @"C:\\Users\\Tautvydas\\Desktop\\";
            folder.FilterIndex = 2;
            if (folder.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(folder.FileName);
                textBox1.Text = lines[0];
                passwordBox1.Text = lines[1];
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText("C:\\Users\\Tautvydas\\Desktop\\praktika3.txt", resultBox.Text + Environment.NewLine + passwordBox1.Text);
            MessageBox.Show("Save successful");
        }
    }
}
