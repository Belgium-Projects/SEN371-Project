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
        Validation obj = new Validation();
        private void frmManagement_Load(object sender, EventArgs e)
        {
            //add management function here
             employee obj = new employee();
            lblEmpName.Text = obj.EmpName;
            panel9.BackColor = Color.FromArgb(128, Color.AliceBlue);
        }
        private void btnWork_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCallCentre a = new frmCallCentre();
            a.Show();

        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmServices a = new frmServices();
            a.Show();

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            this.Hide();
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

     


        private void btnSave_Click(object sender, EventArgs e)
        {
            obj.ApplicationForm(txtFirstName, txtEmail, txtLastName, txtPhoneNumber, txtAddress, txtZipCode, txtBusinessName, dateDateOfBirth);
        }
    }
}
