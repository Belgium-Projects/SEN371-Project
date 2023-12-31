﻿using SEN371_Project.dataHandler;
using SEN371_Project.FunctionalAreas;
using SEN371_Project.userExperience;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN371_Project
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {

            InitializeComponent();
            //    emp = new employee(
            //    "EmployeeName",
            //    "EmployeeID",
            //    "EmployeeSurname",
            //    "EmployeeRole",
            //    "EmployeePhoneNumber",
            //    "sampleUser",
            //    HashPassword("samplePassword", GenerateSalt()) // Hash the password with the salt



            //);
        }

        private string HashPassword(string v1, string v2)
        {
            throw new NotImplementedException();
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
            //employee obj1 = new employee();
            //MessageBox.Show(obj1.HashPassword("123","123"));
            formatUX format = new formatUX();
            format.formattingRules(this);
            //this.txtUsername.AutoSize = false;
            //this.txtPassword.AutoSize = false;
            //this.txtUsername.Size = new System.Drawing.Size(350, 40);
            //this.txtPassword.Size = new System.Drawing.Size(350, 40);
            //txtPassword.PasswordChar = '*';


        }
        int incorrectAttempts = 0;
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            employee emp = new employee();
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool isValid = emp.ValidateCredentials(username, password);

            if (isValid)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmCallCentre a = new frmCallCentre();
                a.Show();
            }
            else
            {
                incorrectAttempts++; // Increment the incorrect attempts counter
                if (incorrectAttempts >= 3) // Check if maximum attempts reached
                {
                    MessageBox.Show("Too many incorrect login attempts. The application will now close.", "Error", MessageBoxButtons.OK);
                    Application.Exit(); // Exit the application
                }
                else
                {
                    MessageBox.Show($"Invalid username or password. You have {3 - incorrectAttempts} attempts left.", "Error", MessageBoxButtons.OK);
                    txtUsername.Clear();
                    txtPassword.Clear();

                }
            }
        }
    }
}
