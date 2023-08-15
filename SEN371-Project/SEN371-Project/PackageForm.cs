using SEN371_Project.dataHandler;
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
    public partial class frmPackages : Form
    {
        public frmPackages()
        {
            InitializeComponent();
        }

        private void frmPackages_Load(object sender, EventArgs e)
        {
            employee obj = new employee();
            lblEmpName.Text = obj.EmpName;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            frmClose a = new frmClose();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmClient a = new frmClient();
            a.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnViewServices_Click(object sender, EventArgs e)
        {

        }
    }
}
