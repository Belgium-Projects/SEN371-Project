using SEN371_Project.dataHandler;
using SEN371_Project.FunctionalAreas;
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
        private employee emp;
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

        // Helper method to generate a random salt
        //private static string GenerateSalt()
        //{
        //    byte[] saltBytes = new byte[32];
        //    using (var rng = new RNGCryptoServiceProvider())
        //    {
        //        rng.GetBytes(saltBytes);
        //    }
        //    return Convert.ToBase64String(saltBytes);
        //}
        private void frmLogin_Load(object sender, EventArgs e)
        {
            //employee obj1 = new employee();
            //MessageBox.Show(obj1.HashPassword("123","123"));
            txtPassword.PasswordChar = '*';
           
        }

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
                MessageBox.Show("Invalid username or password. Login failed.", "Error", MessageBoxButtons.OK);
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }
    }
  }
