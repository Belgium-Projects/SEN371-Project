using SEN371_Project.dataHandler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN371_Project
{
    public partial class frmApplication : Form
    {
        public frmApplication()
        {
            InitializeComponent();
        }
        private void frmManagement_Load(object sender, EventArgs e)
        {
            //add management function here
             employee obj = new employee();
            lblEmpName.Text = obj.EmpName;

        }
        private void btnWork_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCallCentre a = new frmCallCentre();
            a.Show();

        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
           

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            this.Close();
            frmClient a = new frmClient();
            a.Show();

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //add log out function here
            this.Close();
            frmClose a = new frmClose();
            a.Show();
           
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            

        }


        private void pnlWork_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool isValidEmail(string email)
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
            string lastNameRegex = @"^[A-Za-zÀ-ÿ-]{2,}$";
            return Regex.IsMatch(lastName, lastNameRegex);
        }
        private bool isValidPhoneNumber(string phoneNumber)
        {
            string phoneNumberRegex = @"^(\+27 | 0)[6 - 8][0 - 9]{ 8}$";
            return Regex.IsMatch(phoneNumber, phoneNumberRegex);
        }
        private bool isValidDateOfBirth()
        {
            return true;
        }

        private bool isValidAddress()
        {
            return true;
        }
        private bool isValidZipCode()
        {
            return true;
        }

        private bool isValidBusinessName()
        {
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();
            string address = txtAddress.Text.Trim();
            string zipCode = txtZipCode.Text.Trim();
            string bussinessName = txtBusinessName.Text.Trim();

            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("Username is required.", "Validation Error");
                return;
            }
            else if (!isValidFirstName(firstName))
            {
                MessageBox.Show("Username can only contain valid characters", "Validation Error");
                return;
            }

            if (!isValidPhoneNumber(phoneNumber))
            {
                MessageBox.Show("Invalid email address.", "Validation Error");
                return;
            }

            if (!isValidEmail(email))
            {
                MessageBox.Show("Invalid email address.", "Validation Error");
                return;
            }

            if (!isValidDateOfBirth())
            {
                MessageBox.Show("Invalid email address.", "Validation Error");
                return;
            }

            if (!isValidAddress())
            {
                MessageBox.Show("Invalid email address.", "Validation Error");
                return;
            }

            if(!isValidZipCode())
            {

            }

            if(!isValidBusinessName())
            {

            }

        }
    }
}
