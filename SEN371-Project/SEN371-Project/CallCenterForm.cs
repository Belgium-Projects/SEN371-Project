using SEN371_Project.dataHandler;
using SEN371_Project.FunctionalAreas;
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
    public partial class frmCallCentre : Form
    {
        public frmCallCentre()
        {
            InitializeComponent();
        }

        private void frmJobs_Load(object sender, EventArgs e)
        {
            manager obj = new manager();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = obj.returnall();
            employee obj2 = new employee();
            lblEmpName.Text = obj2.EmpName;
            //MessageBox.Show(obj.returnall()[0]);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pnlDeptButton_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPackages a = new frmPackages();
            a.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            this.Close();
            frmClient a = new frmClient();
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            this.Close();
            frmServices a = new frmServices();
            a.Show();
        }
    }
}
