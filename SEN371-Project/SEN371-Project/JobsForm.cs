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
    public partial class frmJobs : Form
    {
        public frmJobs()
        {
            InitializeComponent();
        }

        private void frmJobs_Load(object sender, EventArgs e)
        {
            manager obj = new manager();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = obj.returnall();
            //MessageBox.Show(obj.returnall()[0]);
        }
    }
}
