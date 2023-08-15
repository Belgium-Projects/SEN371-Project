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
            //add management function here
            pnlDept.Hide();
            pnlDeptButton.Hide();

            pnlWork.Hide();
            pnlWorkButtons.Hide();

        }
        private void btnWork_Click(object sender, EventArgs e)
        {

            pnlWork.Show();
            pnlWorkButtons.Show();

            pnlClient.Hide();
            pnlClientButtons.Hide();
            
            pnlDept.Hide();
            pnlDeptButton.Hide();

        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            pnlDept.Show();
            pnlDeptButton.Show();

            pnlClient.Hide();
            pnlClientButtons.Hide();

            pnlWork.Hide();
            pnlWorkButtons.Hide();

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            pnlClientButtons.Show();
            pnlWork.Show();

            pnlDept.Hide();
            pnlDeptButton.Hide();

            pnlWork.Hide();
            pnlWorkButtons.Hide();
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
