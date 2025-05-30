using System;
using System.Windows.Forms;
using System.Drawing;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Load += new EventHandler(Form1_Load);
        }

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();

            this.txtUsername.Location = new System.Drawing.Point(100, 50);
            this.txtUsername.Size = new System.Drawing.Size(150, 20);

            this.txtPassword.Location = new System.Drawing.Point(100, 90);
            this.txtPassword.Size = new System.Drawing.Size(150, 20);
            this.txtPassword.PasswordChar = '*';

            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            this.ResumeLayout(false);
        }


        #endregion
    }
}
