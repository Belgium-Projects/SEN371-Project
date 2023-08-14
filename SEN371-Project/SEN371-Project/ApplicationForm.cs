using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            int newWidth = 207;
            int newHeight = 279;

            pnlDept.Hide();
            pnlDeptButton.Hide();

            pnlWork.Hide();
            pnlWorkButtons.Hide();


            pnlClientButtons.Width = newWidth;
            pnlClientButtons.Height = newHeight;
            pnlClientButtons.Left = 12;
            pnlClientButtons.Top = 60;
            pnlClient.Width = 900;
            pnlClient.Height = 350;
            pnlClient.Left=150;
            pnlClient.Top = 60;
        }
        private void btnWork_Click(object sender, EventArgs e)
        {
            int newWidth = 200;
            int newHeight = 150;

        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            int newWidth = 200;
            int newHeight = 150;

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            int newWidth = 350;
            int newHeight = 150;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //add log out function here
            this.Close();
            frmClose a = new frmClose();
            a.Show();
           
            
        }
    }
}
