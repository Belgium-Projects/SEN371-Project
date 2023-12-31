﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN371_Project.dataHandler
{
    internal class Validation
    {
        public void ApplicationForm(TextBox txtFirstName,TextBox txtEmail,TextBox txtLastName , TextBox txtPhoneNumber ,TextBox txtAddress,TextBox txtZipCode ,TextBox txtBusinessName,DateTimePicker dateDateOfBirth)
        {
            string firstName = txtFirstName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string lastName = txtLastName.Text;
            string phoneNumber = txtPhoneNumber.Text.Trim();
            string address = txtAddress.Text.Trim();
            string zipCode = txtZipCode.Text.Trim();
            string bussinessName = txtBusinessName.Text.Trim();
            DateTime dateOfBirth = dateDateOfBirth.Value;
            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("First Name is required.", "Validation Error");
                return;
            }
            else if (!isValidFirstName(firstName))
            {
                MessageBox.Show("First Name can only contain valid characters", "Validation Error");
                return;
            }
            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Last Name is required.", "Validation Error");
                return;
            }
            else if (!isValidLastName(lastName))
            {
                MessageBox.Show("Last Name can only contain valid characters.", "Validation Error");
                return;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("A phone number is required.", "Validation Error");
                return;
            }

            else if (!isValidPhoneNumber(phoneNumber))
            {
                MessageBox.Show("Invalid phone number.", "Validation Error");
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("An email is required.", "Validation Error");
                return;
            }

            else if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email address.", "Validation Error");
                return;
            }

            if (!isValidDateOfBirth(dateOfBirth))
            {
                MessageBox.Show("Invalid Date Of Birth.", "Validation Error");
                return;
            }

            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Invalid  address.", "Validation Error");
                return;
            }

            else if (!isValidAddress())
            {
                MessageBox.Show("Invalid  address.", "Validation Error");
                return;
            }

            if (string.IsNullOrEmpty(zipCode))
            {
                MessageBox.Show("Zip Code is required.", "Validation Error");
                return;
            }

            else if (!isValidZipCode(zipCode))
            {
                MessageBox.Show("Invalid  zip code.", "Validation Error");
                return;
            }

            if (string.IsNullOrEmpty(bussinessName))
            {
                MessageBox.Show("A business name is required.", "Validation Error");
                return;
            }
            else if (!isValidBusinessName())
            {
                MessageBox.Show("Invalid  business name.", "Validation Error");
                return;
            }
        }
        private bool IsValidEmail(string email)
        {

            string regexPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, regexPattern);
        }

        private bool isValidFirstName(string firstName)
        {
            string firstNameRegex = @"^[A-Za-zÀ-ÿ-]{2,}$";
            return Regex.IsMatch(firstName, firstNameRegex);
        }

        private bool isValidLastName(string lastName)
        {
            string lastNameRegex = @"^[A-Za-zÀ-ÿ- ]{2,}$";
            return Regex.IsMatch(lastName, lastNameRegex);
        }
        private bool isValidPhoneNumber(string phoneNumber)
        {
            string phoneNumberRegex = @"^(\+27|0)[6-8][0-9]{8}$";
            return Regex.IsMatch(phoneNumber, phoneNumberRegex);
        }
        private bool isValidDateOfBirth(DateTime dobInput)
        {
            DateTime currentDate = DateTime.Now;
            DateTime minimumDate = currentDate.AddYears(-100);
            DateTime maximumDate = currentDate.AddYears(-5);

            return dobInput >= minimumDate && dobInput <= maximumDate;
        }

        private bool isValidZipCode(string zipCode)
        {
            string zaZipRegex = @"^\d{4,5}$";
            return Regex.IsMatch(zipCode, zaZipRegex);
        }
        public bool isNumber(string number)
        {
            string numbercheck = @"^[0-9]+$";
            return Regex.IsMatch(number, numbercheck);
        }

        private bool isValidAddress()
        {
            return true;
        }

        private bool isValidBusinessName()
        {
            return true;
        }
    }
}
