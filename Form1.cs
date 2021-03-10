using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool PassFileExists = false;
        string PasswordHashFromFile;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("password.lol"))
            {
                PassFileExists = true;
                PasswordHashFromFile = File.ReadAllText("password.lol");

            }
        }


        internal static string GetHash(string text)
        {
            if (String.IsNullOrEmpty(text))
                return text;

            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] Eyup = System.Text.Encoding.UTF8.GetBytes(text);
                byte[] hash = sha.ComputeHash(Eyup);
                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!PassFileExists)
            {
                var PassHash = SavePass(lblPassword.Text);
                lblPassword.Text = "";
                PassFileExists = true;
                PasswordHashFromFile = PassHash;
                lblSetPassword.Text = "Please enter your password";
                btnResetPassword.Visible = true;
            }
            else
            {
                CheckPassword();
            }

        }
		
		private string SavePass(string Password)
		{
			    string PassHash = GetHash(Password);
                File.WriteAllText("password.lol", PassHash);
                return PassHash;
		}

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (PassFileExists)
            {
                lblSetPassword.Text = "Please enter your password";
                btnResetPassword.Visible = true;
            }
            else
            {
                lblSetPassword.Text = "Please set your password";
                btnResetPassword.Visible = false;
            }
        }

        private void cboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxShowPass.Checked)
            {
                lblPassword.UseSystemPasswordChar = false;
            }
            else
            {
                lblPassword.UseSystemPasswordChar = true;
            }
        }

        private void CheckPassword()
        {
            if (PasswordHashFromFile == GetHash(lblPassword.Text))
            {
                Application.Exit();
            }
            else
            {
                lblSetPassword.Text = "Incorrect password!";
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (PassFileExists)
            {
                File.Delete("password.lol");
                lblSetPassword.Text = "Please set your password";
                btnResetPassword.Visible = false;
            }
        }

    }
}
