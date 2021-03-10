namespace WindowsFormsApplication1
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.TextBox();
            this.lblSetPassword = new System.Windows.Forms.Label();
            this.cboxShowPass = new System.Windows.Forms.CheckBox();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(31, 67);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(31, 41);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 20);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.UseSystemPasswordChar = true;
            // 
            // lblSetPassword
            // 
            this.lblSetPassword.AutoSize = true;
            this.lblSetPassword.Location = new System.Drawing.Point(28, 25);
            this.lblSetPassword.Name = "lblSetPassword";
            this.lblSetPassword.Size = new System.Drawing.Size(127, 13);
            this.lblSetPassword.TabIndex = 2;
            this.lblSetPassword.Text = "Please set your password";
            // 
            // cboxShowPass
            // 
            this.cboxShowPass.AutoSize = true;
            this.cboxShowPass.Location = new System.Drawing.Point(150, 43);
            this.cboxShowPass.Name = "cboxShowPass";
            this.cboxShowPass.Size = new System.Drawing.Size(102, 17);
            this.cboxShowPass.TabIndex = 3;
            this.cboxShowPass.Text = "Show Password";
            this.cboxShowPass.UseVisualStyleBackColor = true;
            this.cboxShowPass.CheckedChanged += new System.EventHandler(this.cboxShowPass_CheckedChanged);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(174, 227);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(90, 23);
            this.btnResetPassword.TabIndex = 4;
            this.btnResetPassword.Text = "ResetPassword";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.cboxShowPass);
            this.Controls.Add(this.lblSetPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnSubmit);
            this.Name = "Form1";
            this.Text = "TestHashing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox lblPassword;
        private System.Windows.Forms.Label lblSetPassword;
        private System.Windows.Forms.CheckBox cboxShowPass;
        private System.Windows.Forms.Button btnResetPassword;
    }
}

