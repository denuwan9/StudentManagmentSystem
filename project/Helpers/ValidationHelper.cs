using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace StudentManagementSystem.Helpers
{
    public static class ValidationHelper
    {
        public static bool ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        public static bool ValidatePhoneNumber(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return false;

            // Check if it's exactly 10 digits
            string pattern = @"^\d{10}$";
            return Regex.IsMatch(phone, pattern);
        }

        public static bool ValidateNIC(string nic)
        {
            if (string.IsNullOrWhiteSpace(nic))
                return false;

            // Sri Lankan NIC format: 9 digits or 12 digits (old or new format)
            string pattern = @"^(\d{9}|\d{12})$";
            return Regex.IsMatch(nic, pattern);
        }

        public static bool ValidateRequiredField(string value, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                MessageBox.Show($"{fieldName} is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public static bool ValidateDateOfBirth(DateTime dateOfBirth)
        {
            // Check if date is not in the future
            if (dateOfBirth > DateTime.Now)
            {
                MessageBox.Show("Date of Birth cannot be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check if age is reasonable (between 5 and 100 years)
            int age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age--;

            if (age < 5 || age > 100)
            {
                MessageBox.Show("Date of Birth must result in an age between 5 and 100 years.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public static bool ValidateRegistrationNumber(string regNo)
        {
            if (string.IsNullOrWhiteSpace(regNo))
                return false;

            return int.TryParse(regNo, out int result) && result > 0;
        }
    }
}


