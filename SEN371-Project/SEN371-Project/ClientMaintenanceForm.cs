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
    public partial class ClientMaintenanceForm : Form
    {
        public ClientMaintenanceForm()
        {
            InitializeComponent();
        }

        private void ClientMaintenanceForm_Load(object sender, EventArgs e)
        {
            employee obj = new employee();
            lblEmpName.Text = obj.EmpName;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
