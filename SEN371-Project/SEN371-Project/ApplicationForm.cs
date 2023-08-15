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
         

        }
        private void btnWork_Click(object sender, EventArgs e)
        {
            this.Close();
            frmJobs a = new frmJobs();
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
    }
}
