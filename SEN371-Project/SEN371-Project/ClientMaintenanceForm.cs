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
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        private void ClientMaintenanceForm_Load(object sender, EventArgs e)
        {
            employee obj = new employee();
            lblEmpName.Text ="Welcome " +obj.EmpName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCallCentre a = new frmCallCentre();
            a.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            frmClose a = new frmClose();
            a.Show();
        }
    }
}
