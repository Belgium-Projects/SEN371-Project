using SEN371_Project.dataHandler;
using SEN371_Project.userExperience;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SEN371_Project
{
    public partial class frmManagementDept : Form
    {
        employee obj = new employee();
        public frmManagementDept()
        {
            InitializeComponent();
            lblContent1.Text = obj.EmpName + "Speek";
        }

        private void frmManagementDept_Load(object sender, EventArgs e)
        {
            formatUX format = new formatUX();
            format.formattingRules(this);
        }

        private void btnPerformance_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm =new frmLogin();
            frm.Show();
        }

        private void btndepartment_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManagementDept frm =new frmManagementDept();
            frm.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            this.Hide();
             frmCallCentre frm =new frmCallCentre();
            frm.Show();
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmServices frm =new frmServices();
            frm.Show();
        }
    }
}
