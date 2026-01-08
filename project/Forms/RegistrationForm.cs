using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using StudentManagementSystem.Helpers;
using StudentManagementSystem.Models;
using StudentManagementSystem.Repositories;

namespace StudentManagementSystem.Forms
{
    public partial class RegistrationForm : Form
    {
        private StudentRepository _studentRepository;

        public RegistrationForm()
        {
            InitializeComponent();
            _studentRepository = new StudentRepository();
            this.StartPosition = FormStartPosition.CenterScreen;
            cmbRegNo.DropDownStyle = ComboBoxStyle.DropDown; // Allow typing new registration numbers
            LoadRegistrationNumbers();
        }

        private void LoadRegistrationNumbers()
        {
            cmbRegNo.Items.Clear();
            var regNumbers = _studentRepository.GetAllRegistrationNumbers();
            foreach (var regNo in regNumbers)
            {
                cmbRegNo.Items.Add(regNo);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                Student student = CreateStudentFromInputs();

                if (_studentRepository.InsertStudent(student))
                {
                    MessageBox.Show("Record Successfully Inserted", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAllFields();
                    LoadRegistrationNumbers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbRegNo.SelectedItem == null)
            {
                MessageBox.Show("Please select a registration number to update.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs())
                return;

            try
            {
                Student student = CreateStudentFromInputs();

                if (_studentRepository.UpdateStudent(student))
                {
                    MessageBox.Show("Record Successfully Updated", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAllFields();
                    LoadRegistrationNumbers();
                }
                else
                {
                    MessageBox.Show("Failed to update record. Record may not exist.", "Update Failed", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbRegNo.SelectedItem == null)
            {
                MessageBox.Show("Please select a registration number to delete.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure, Do you want to Delete this Record?",
                "Delete Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int regNo = Convert.ToInt32(cmbRegNo.SelectedItem);

                    if (_studentRepository.DeleteStudent(regNo))
                    {
                        MessageBox.Show("Record Successfully Deleted", "Success", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAllFields();
                        LoadRegistrationNumbers();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete record.", "Delete Failed", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void cmbRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRegNo.SelectedItem != null)
            {
                try
                {
                    int regNo = Convert.ToInt32(cmbRegNo.SelectedItem);
                    Student? student = _studentRepository.GetStudentByRegNo(regNo);

                    if (student != null)
                    {
                        LoadStudentToForm(student);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading student data: " + ex.Message, "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void lnkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure, Do you really want to Exit...?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private bool ValidateInputs()
        {
            // Validate Registration Number
            if (string.IsNullOrWhiteSpace(cmbRegNo.Text))
            {
                MessageBox.Show("Please enter or select a Registration Number.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRegNo.Focus();
                return false;
            }

            if (!ValidationHelper.ValidateRegistrationNumber(cmbRegNo.Text))
            {
                MessageBox.Show("Please enter a valid Registration Number.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRegNo.Focus();
                return false;
            }

            // Validate Required Fields
            if (!ValidationHelper.ValidateRequiredField(txtFirstName.Text, "First Name"))
            {
                txtFirstName.Focus();
                return false;
            }

            if (!ValidationHelper.ValidateRequiredField(txtLastName.Text, "Last Name"))
            {
                txtLastName.Focus();
                return false;
            }

            // Validate Date of Birth
            if (!ValidationHelper.ValidateDateOfBirth(dtpDateOfBirth.Value))
            {
                dtpDateOfBirth.Focus();
                return false;
            }

            // Validate Gender
            if (!rbMale.Checked && !rbFemale.Checked)
            {
                MessageBox.Show("Please select Gender.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate Email
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !ValidationHelper.ValidateEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid Email address.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            // Validate Phone Numbers
            if (!string.IsNullOrWhiteSpace(txtMobilePhone.Text) && !ValidationHelper.ValidatePhoneNumber(txtMobilePhone.Text))
            {
                MessageBox.Show("Mobile Phone must be 10 digits.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMobilePhone.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtHomePhone.Text) && !ValidationHelper.ValidatePhoneNumber(txtHomePhone.Text))
            {
                MessageBox.Show("Home Phone must be 10 digits.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHomePhone.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtContactNo.Text) && !ValidationHelper.ValidatePhoneNumber(txtContactNo.Text))
            {
                MessageBox.Show("Contact Number must be 10 digits.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContactNo.Focus();
                return false;
            }

            // Validate NIC
            if (!string.IsNullOrWhiteSpace(txtNIC.Text) && !ValidationHelper.ValidateNIC(txtNIC.Text))
            {
                MessageBox.Show("Please enter a valid NIC (9 or 12 digits).", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNIC.Focus();
                return false;
            }

            return true;
        }

        private Student CreateStudentFromInputs()
        {
            return new Student
            {
                RegNo = Convert.ToInt32(cmbRegNo.Text),
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                DateOfBirth = dtpDateOfBirth.Value,
                Gender = rbMale.Checked ? "Male" : "Female",
                Address = txtAddress.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                MobilePhone = string.IsNullOrWhiteSpace(txtMobilePhone.Text) ? 0 : Convert.ToInt32(txtMobilePhone.Text),
                HomePhone = string.IsNullOrWhiteSpace(txtHomePhone.Text) ? 0 : Convert.ToInt32(txtHomePhone.Text),
                ParentName = txtParentName.Text.Trim(),
                NIC = txtNIC.Text.Trim(),
                ContactNo = string.IsNullOrWhiteSpace(txtContactNo.Text) ? 0 : Convert.ToInt32(txtContactNo.Text)
            };
        }

        private void LoadStudentToForm(Student student)
        {
            cmbRegNo.Text = student.RegNo.ToString();
            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            dtpDateOfBirth.Value = student.DateOfBirth;
            rbMale.Checked = student.Gender == "Male";
            rbFemale.Checked = student.Gender == "Female";
            txtAddress.Text = student.Address;
            txtEmail.Text = student.Email;
            txtMobilePhone.Text = student.MobilePhone == 0 ? "" : student.MobilePhone.ToString();
            txtHomePhone.Text = student.HomePhone == 0 ? "" : student.HomePhone.ToString();
            txtParentName.Text = student.ParentName;
            txtNIC.Text = student.NIC;
            txtContactNo.Text = student.ContactNo == 0 ? "" : student.ContactNo.ToString();
        }

        private void ClearAllFields()
        {
            cmbRegNo.Text = "";
            txtFirstName.Clear();
            txtLastName.Clear();
            dtpDateOfBirth.Value = DateTime.Now.AddYears(-18);
            rbMale.Checked = false;
            rbFemale.Checked = false;
            txtAddress.Clear();
            txtEmail.Clear();
            txtMobilePhone.Clear();
            txtHomePhone.Clear();
            txtParentName.Clear();
            txtNIC.Clear();
            txtContactNo.Clear();
            cmbRegNo.Focus();
        }
    }
}

