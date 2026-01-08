using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentManagementSystem.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox pictureBoxLogo;
        private GroupBox groupBoxLogin;
        private Label lblSkillsInternational;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnClear;
        private Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBoxLogo = new PictureBox();
            this.groupBoxLogin = new GroupBox();
            this.lblSkillsInternational = new Label();
            this.lblUsername = new Label();
            this.lblPassword = new Label();
            this.txtUsername = new TextBox();
            this.txtPassword = new TextBox();
            this.btnLogin = new Button();
            this.btnClear = new Button();
            this.btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.groupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = Color.Transparent;
            this.pictureBoxLogo.Location = new Point(50, 30);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new Size(300, 150);
            this.pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.lblPassword);
            this.groupBoxLogin.Controls.Add(this.lblUsername);
            this.groupBoxLogin.Controls.Add(this.txtPassword);
            this.groupBoxLogin.Controls.Add(this.txtUsername);
            this.groupBoxLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.groupBoxLogin.ForeColor = Color.FromArgb(41, 128, 185);
            this.groupBoxLogin.Location = new Point(50, 220);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new Size(300, 150);
            this.groupBoxLogin.TabIndex = 1;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Login";
            // 
            // lblSkillsInternational
            // 
            this.lblSkillsInternational.AutoSize = true;
            this.lblSkillsInternational.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblSkillsInternational.ForeColor = Color.FromArgb(41, 128, 185);
            this.lblSkillsInternational.Location = new Point(80, 190);
            this.lblSkillsInternational.Name = "lblSkillsInternational";
            this.lblSkillsInternational.Size = new Size(240, 32);
            this.lblSkillsInternational.TabIndex = 2;
            this.lblSkillsInternational.Text = "Skills International";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new Font("Segoe UI", 9F);
            this.lblUsername.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblUsername.Location = new Point(20, 35);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new Size(63, 15);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new Font("Segoe UI", 9F);
            this.lblPassword.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblPassword.Location = new Point(20, 80);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new Size(59, 15);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new Font("Segoe UI", 9F);
            this.txtUsername.Location = new Point(100, 32);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new Size(180, 23);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new Font("Segoe UI", 9F);
            this.txtPassword.Location = new Point(100, 77);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new Size(180, 23);
            this.txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = Color.FromArgb(46, 204, 113);
            this.btnLogin.FlatStyle = FlatStyle.Flat;
            this.btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnLogin.ForeColor = Color.White;
            this.btnLogin.Location = new Point(50, 390);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new Size(90, 35);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new EventHandler(this.btnLogin_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = Color.FromArgb(241, 196, 15);
            this.btnClear.FlatStyle = FlatStyle.Flat;
            this.btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnClear.ForeColor = Color.White;
            this.btnClear.Location = new Point(155, 390);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new Size(90, 35);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = Color.FromArgb(231, 76, 60);
            this.btnExit.FlatStyle = FlatStyle.Flat;
            this.btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnExit.ForeColor = Color.White;
            this.btnExit.Location = new Point(260, 390);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new Size(90, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new EventHandler(this.btnExit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.ClientSize = new Size(400, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblSkillsInternational);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Student Management System - Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

