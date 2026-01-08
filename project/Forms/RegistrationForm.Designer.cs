using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentManagementSystem.Forms
{
    partial class RegistrationForm
    {
        private System.ComponentModel.IContainer components = null;
        private GroupBox groupBoxStudentRegistration;
        private GroupBox groupBoxBasicDetails;
        private GroupBox groupBoxContactDetails;
        private GroupBox groupBoxParentDetails;
        private Label lblRegNo;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblDateOfBirth;
        private Label lblGender;
        private Label lblAddress;
        private Label lblEmail;
        private Label lblMobilePhone;
        private Label lblHomePhone;
        private Label lblParentName;
        private Label lblNIC;
        private Label lblContactNo;
        private ComboBox cmbRegNo;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private DateTimePicker dtpDateOfBirth;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtMobilePhone;
        private TextBox txtHomePhone;
        private TextBox txtParentName;
        private TextBox txtNIC;
        private TextBox txtContactNo;
        private Button btnRegister;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private LinkLabel lnkLogout;
        private LinkLabel lnkExit;

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
            this.groupBoxStudentRegistration = new GroupBox();
            this.groupBoxParentDetails = new GroupBox();
            this.lblContactNo = new Label();
            this.txtContactNo = new TextBox();
            this.lblNIC = new Label();
            this.txtNIC = new TextBox();
            this.lblParentName = new Label();
            this.txtParentName = new TextBox();
            this.groupBoxContactDetails = new GroupBox();
            this.lblHomePhone = new Label();
            this.txtHomePhone = new TextBox();
            this.lblMobilePhone = new Label();
            this.txtMobilePhone = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.lblAddress = new Label();
            this.txtAddress = new TextBox();
            this.groupBoxBasicDetails = new GroupBox();
            this.rbFemale = new RadioButton();
            this.rbMale = new RadioButton();
            this.lblGender = new Label();
            this.dtpDateOfBirth = new DateTimePicker();
            this.lblDateOfBirth = new Label();
            this.lblLastName = new Label();
            this.txtLastName = new TextBox();
            this.lblFirstName = new Label();
            this.txtFirstName = new TextBox();
            this.lblRegNo = new Label();
            this.cmbRegNo = new ComboBox();
            this.btnRegister = new Button();
            this.btnUpdate = new Button();
            this.btnDelete = new Button();
            this.btnClear = new Button();
            this.lnkLogout = new LinkLabel();
            this.lnkExit = new LinkLabel();
            this.groupBoxStudentRegistration.SuspendLayout();
            this.groupBoxParentDetails.SuspendLayout();
            this.groupBoxContactDetails.SuspendLayout();
            this.groupBoxBasicDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxStudentRegistration
            // 
            this.groupBoxStudentRegistration.Controls.Add(this.groupBoxParentDetails);
            this.groupBoxStudentRegistration.Controls.Add(this.groupBoxContactDetails);
            this.groupBoxStudentRegistration.Controls.Add(this.groupBoxBasicDetails);
            this.groupBoxStudentRegistration.Controls.Add(this.lblRegNo);
            this.groupBoxStudentRegistration.Controls.Add(this.cmbRegNo);
            this.groupBoxStudentRegistration.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.groupBoxStudentRegistration.ForeColor = Color.FromArgb(41, 128, 185);
            this.groupBoxStudentRegistration.Location = new Point(20, 20);
            this.groupBoxStudentRegistration.Name = "groupBoxStudentRegistration";
            this.groupBoxStudentRegistration.Size = new Size(760, 520);
            this.groupBoxStudentRegistration.TabIndex = 0;
            this.groupBoxStudentRegistration.TabStop = false;
            this.groupBoxStudentRegistration.Text = "Student Registration";
            // 
            // groupBoxParentDetails
            // 
            this.groupBoxParentDetails.Controls.Add(this.lblContactNo);
            this.groupBoxParentDetails.Controls.Add(this.txtContactNo);
            this.groupBoxParentDetails.Controls.Add(this.lblNIC);
            this.groupBoxParentDetails.Controls.Add(this.txtNIC);
            this.groupBoxParentDetails.Controls.Add(this.lblParentName);
            this.groupBoxParentDetails.Controls.Add(this.txtParentName);
            this.groupBoxParentDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.groupBoxParentDetails.ForeColor = Color.FromArgb(52, 73, 94);
            this.groupBoxParentDetails.Location = new Point(400, 280);
            this.groupBoxParentDetails.Name = "groupBoxParentDetails";
            this.groupBoxParentDetails.Size = new Size(340, 220);
            this.groupBoxParentDetails.TabIndex = 4;
            this.groupBoxParentDetails.TabStop = false;
            this.groupBoxParentDetails.Text = "Parent Details";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new Font("Segoe UI", 9F);
            this.lblContactNo.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblContactNo.Location = new Point(20, 160);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new Size(78, 15);
            this.lblContactNo.TabIndex = 5;
            this.lblContactNo.Text = "Contact No:";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new Font("Segoe UI", 9F);
            this.txtContactNo.Location = new Point(120, 157);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new Size(200, 23);
            this.txtContactNo.TabIndex = 6;
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Font = new Font("Segoe UI", 9F);
            this.lblNIC.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblNIC.Location = new Point(20, 110);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new Size(32, 15);
            this.lblNIC.TabIndex = 3;
            this.lblNIC.Text = "NIC:";
            // 
            // txtNIC
            // 
            this.txtNIC.Font = new Font("Segoe UI", 9F);
            this.txtNIC.Location = new Point(120, 107);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new Size(200, 23);
            this.txtNIC.TabIndex = 4;
            // 
            // lblParentName
            // 
            this.lblParentName.AutoSize = true;
            this.lblParentName.Font = new Font("Segoe UI", 9F);
            this.lblParentName.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblParentName.Location = new Point(20, 60);
            this.lblParentName.Name = "lblParentName";
            this.lblParentName.Size = new Size(82, 15);
            this.lblParentName.TabIndex = 1;
            this.lblParentName.Text = "Parent Name:";
            // 
            // txtParentName
            // 
            this.txtParentName.Font = new Font("Segoe UI", 9F);
            this.txtParentName.Location = new Point(120, 57);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new Size(200, 23);
            this.txtParentName.TabIndex = 2;
            // 
            // groupBoxContactDetails
            // 
            this.groupBoxContactDetails.Controls.Add(this.lblHomePhone);
            this.groupBoxContactDetails.Controls.Add(this.txtHomePhone);
            this.groupBoxContactDetails.Controls.Add(this.lblMobilePhone);
            this.groupBoxContactDetails.Controls.Add(this.txtMobilePhone);
            this.groupBoxContactDetails.Controls.Add(this.lblEmail);
            this.groupBoxContactDetails.Controls.Add(this.txtEmail);
            this.groupBoxContactDetails.Controls.Add(this.lblAddress);
            this.groupBoxContactDetails.Controls.Add(this.txtAddress);
            this.groupBoxContactDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.groupBoxContactDetails.ForeColor = Color.FromArgb(52, 73, 94);
            this.groupBoxContactDetails.Location = new Point(20, 280);
            this.groupBoxContactDetails.Name = "groupBoxContactDetails";
            this.groupBoxContactDetails.Size = new Size(360, 220);
            this.groupBoxContactDetails.TabIndex = 3;
            this.groupBoxContactDetails.TabStop = false;
            this.groupBoxContactDetails.Text = "Contact Details";
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Font = new Font("Segoe UI", 9F);
            this.lblHomePhone.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblHomePhone.Location = new Point(20, 160);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new Size(82, 15);
            this.lblHomePhone.TabIndex = 7;
            this.lblHomePhone.Text = "Home Phone:";
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Font = new Font("Segoe UI", 9F);
            this.txtHomePhone.Location = new Point(120, 157);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new Size(220, 23);
            this.txtHomePhone.TabIndex = 8;
            // 
            // lblMobilePhone
            // 
            this.lblMobilePhone.AutoSize = true;
            this.lblMobilePhone.Font = new Font("Segoe UI", 9F);
            this.lblMobilePhone.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblMobilePhone.Location = new Point(20, 110);
            this.lblMobilePhone.Name = "lblMobilePhone";
            this.lblMobilePhone.Size = new Size(87, 15);
            this.lblMobilePhone.TabIndex = 5;
            this.lblMobilePhone.Text = "Mobile Phone:";
            // 
            // txtMobilePhone
            // 
            this.txtMobilePhone.Font = new Font("Segoe UI", 9F);
            this.txtMobilePhone.Location = new Point(120, 107);
            this.txtMobilePhone.Name = "txtMobilePhone";
            this.txtMobilePhone.Size = new Size(220, 23);
            this.txtMobilePhone.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new Font("Segoe UI", 9F);
            this.lblEmail.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblEmail.Location = new Point(20, 60);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new Size(39, 15);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new Font("Segoe UI", 9F);
            this.txtEmail.Location = new Point(120, 57);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(220, 23);
            this.txtEmail.TabIndex = 4;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new Font("Segoe UI", 9F);
            this.lblAddress.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblAddress.Location = new Point(20, 30);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new Size(54, 15);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new Font("Segoe UI", 9F);
            this.txtAddress.Location = new Point(120, 27);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new Size(220, 50);
            this.txtAddress.TabIndex = 2;
            // 
            // groupBoxBasicDetails
            // 
            this.groupBoxBasicDetails.Controls.Add(this.rbFemale);
            this.groupBoxBasicDetails.Controls.Add(this.rbMale);
            this.groupBoxBasicDetails.Controls.Add(this.lblGender);
            this.groupBoxBasicDetails.Controls.Add(this.dtpDateOfBirth);
            this.groupBoxBasicDetails.Controls.Add(this.lblDateOfBirth);
            this.groupBoxBasicDetails.Controls.Add(this.lblLastName);
            this.groupBoxBasicDetails.Controls.Add(this.txtLastName);
            this.groupBoxBasicDetails.Controls.Add(this.lblFirstName);
            this.groupBoxBasicDetails.Controls.Add(this.txtFirstName);
            this.groupBoxBasicDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.groupBoxBasicDetails.ForeColor = Color.FromArgb(52, 73, 94);
            this.groupBoxBasicDetails.Location = new Point(20, 80);
            this.groupBoxBasicDetails.Name = "groupBoxBasicDetails";
            this.groupBoxBasicDetails.Size = new Size(720, 180);
            this.groupBoxBasicDetails.TabIndex = 2;
            this.groupBoxBasicDetails.TabStop = false;
            this.groupBoxBasicDetails.Text = "Basic Details";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new Font("Segoe UI", 9F);
            this.rbFemale.ForeColor = Color.FromArgb(44, 62, 80);
            this.rbFemale.Location = new Point(200, 130);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new Size(63, 19);
            this.rbFemale.TabIndex = 8;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new Font("Segoe UI", 9F);
            this.rbMale.ForeColor = Color.FromArgb(44, 62, 80);
            this.rbMale.Location = new Point(120, 130);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new Size(50, 19);
            this.rbMale.TabIndex = 7;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new Font("Segoe UI", 9F);
            this.lblGender.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblGender.Location = new Point(20, 132);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new Size(51, 15);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender:";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Font = new Font("Segoe UI", 9F);
            this.dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new Point(500, 87);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new Size(200, 23);
            this.dtpDateOfBirth.TabIndex = 5;
            this.dtpDateOfBirth.Value = new DateTime(2006, 1, 1, 0, 0, 0, 0);
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new Font("Segoe UI", 9F);
            this.lblDateOfBirth.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblDateOfBirth.Location = new Point(400, 90);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new Size(81, 15);
            this.lblDateOfBirth.TabIndex = 4;
            this.lblDateOfBirth.Text = "Date of Birth:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new Font("Segoe UI", 9F);
            this.lblLastName.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblLastName.Location = new Point(400, 50);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new Size(67, 15);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new Font("Segoe UI", 9F);
            this.txtLastName.Location = new Point(500, 47);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new Size(200, 23);
            this.txtLastName.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new Font("Segoe UI", 9F);
            this.lblFirstName.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblFirstName.Location = new Point(20, 50);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new Size(69, 15);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new Font("Segoe UI", 9F);
            this.txtFirstName.Location = new Point(120, 47);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new Size(200, 23);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblRegNo.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblRegNo.Location = new Point(20, 40);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new Size(130, 19);
            this.lblRegNo.TabIndex = 1;
            this.lblRegNo.Text = "Registration No:";
            // 
            // cmbRegNo
            // 
            this.cmbRegNo.Font = new Font("Segoe UI", 9F);
            this.cmbRegNo.FormattingEnabled = true;
            this.cmbRegNo.Location = new Point(160, 38);
            this.cmbRegNo.Name = "cmbRegNo";
            this.cmbRegNo.Size = new Size(200, 23);
            this.cmbRegNo.TabIndex = 0;
            this.cmbRegNo.SelectedIndexChanged += new EventHandler(this.cmbRegNo_SelectedIndexChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = Color.FromArgb(46, 204, 113);
            this.btnRegister.FlatStyle = FlatStyle.Flat;
            this.btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnRegister.ForeColor = Color.White;
            this.btnRegister.Location = new Point(20, 560);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new Size(120, 40);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new EventHandler(this.btnRegister_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = Color.FromArgb(52, 152, 219);
            this.btnUpdate.FlatStyle = FlatStyle.Flat;
            this.btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnUpdate.ForeColor = Color.White;
            this.btnUpdate.Location = new Point(160, 560);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new Size(120, 40);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            this.btnDelete.FlatStyle = FlatStyle.Flat;
            this.btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnDelete.ForeColor = Color.White;
            this.btnDelete.Location = new Point(300, 560);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new Size(120, 40);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = Color.FromArgb(241, 196, 15);
            this.btnClear.FlatStyle = FlatStyle.Flat;
            this.btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnClear.ForeColor = Color.White;
            this.btnClear.Location = new Point(440, 560);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new Size(120, 40);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new EventHandler(this.btnClear_Click);
            // 
            // lnkLogout
            // 
            this.lnkLogout.AutoSize = true;
            this.lnkLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lnkLogout.LinkColor = Color.FromArgb(41, 128, 185);
            this.lnkLogout.Location = new Point(600, 570);
            this.lnkLogout.Name = "lnkLogout";
            this.lnkLogout.Size = new Size(50, 15);
            this.lnkLogout.TabIndex = 5;
            this.lnkLogout.TabStop = true;
            this.lnkLogout.Text = "Logout";
            this.lnkLogout.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lnkLogout_LinkClicked);
            // 
            // lnkExit
            // 
            this.lnkExit.AutoSize = true;
            this.lnkExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lnkExit.LinkColor = Color.FromArgb(231, 76, 60);
            this.lnkExit.Location = new Point(680, 570);
            this.lnkExit.Name = "lnkExit";
            this.lnkExit.Size = new Size(30, 15);
            this.lnkExit.TabIndex = 6;
            this.lnkExit.TabStop = true;
            this.lnkExit.Text = "Exit";
            this.lnkExit.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lnkExit_LinkClicked);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.ClientSize = new Size(800, 620);
            this.Controls.Add(this.lnkExit);
            this.Controls.Add(this.lnkLogout);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.groupBoxStudentRegistration);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegistrationForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Student Management System - Registration";
            this.groupBoxStudentRegistration.ResumeLayout(false);
            this.groupBoxStudentRegistration.PerformLayout();
            this.groupBoxParentDetails.ResumeLayout(false);
            this.groupBoxParentDetails.PerformLayout();
            this.groupBoxContactDetails.ResumeLayout(false);
            this.groupBoxContactDetails.PerformLayout();
            this.groupBoxBasicDetails.ResumeLayout(false);
            this.groupBoxBasicDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

