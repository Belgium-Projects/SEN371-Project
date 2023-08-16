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
    public partial class frmPackages : Form
    {
        public frmPackages()
        {
            InitializeComponent();
        }
        contractMaintenance contract = new contractMaintenance();
        private void frmPackages_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'premierServiceSolutionsDataSet.Packages' table. You can move, or remove it, as needed.
            //this.packagesTableAdapter.Fill(this.premierServiceSolutionsDataSet.Packages);
            // TODO: This line of code loads data into the 'premierServiceSolutionsDataSet.ServiceinPackages' table. You can move, or remove it, as needed.
            //this.serviceinPackagesTableAdapter.Fill(this.premierServiceSolutionsDataSet.ServiceinPackages);
            employee obj = new employee();
            lblEmpName.Text = obj.EmpName;
            pannelClear();
            
        }
        public void pannelClear()
        {
            dgvServies.Hide();
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
            dgvServies.Show();
            dgvServies.Rows.Clear();
            dgvServies.ColumnCount = 8;
            dgvServies.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dgvServies.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            dgvServies.Columns[0].Name = "Packages ID";
            dgvServies.Columns[1].Name = "Packages Name";
            dgvServies.Columns[2].Name = "Avaialbility";
            dgvServies.Columns[3].Name = "Discount";
            dgvServies.Columns[4].Name = "SLAID";
            dgvServies.Columns[5].Name = "ExpireDate";
            dgvServies.Columns[6].Name = "StartDate";
            dgvServies.Columns[7].Name = "Status";

            foreach (var item in contract.definepackages())
            {
                List<string> itembreakdown = item.Split(',').ToList();
                dgvServies.Rows.Add(itembreakdown[0], itembreakdown[1], itembreakdown[2], itembreakdown[3], itembreakdown[4], itembreakdown[5], itembreakdown[6], itembreakdown[7]);
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvServies.Show();
            dgvServies.Rows.Clear();

            dgvServies.ColumnCount = 8;
            dgvServies.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dgvServies.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            dgvServies.Columns[0].Name = "Service ID";
            dgvServies.Columns[1].Name = "Maintances Type";
            dgvServies.Columns[2].Name = "Difficulty";
            dgvServies.Columns[3].Name = "Prices";
            dgvServies.Columns[4].Name = "Frequency";
            dgvServies.Columns[5].Name = "Task";
            dgvServies.Columns[6].Name = "Description";
            dgvServies.Columns[7].Name = "Tools Materials";

            foreach (var item in contract.defineServices())
            {
                List<string> itembreakdown = item.Split(',').ToList();
                dgvServies.Rows.Add(itembreakdown[0], itembreakdown[1], itembreakdown[2], itembreakdown[3], itembreakdown[4], itembreakdown[5], itembreakdown[6], itembreakdown[7]);
            }
        }

        private void btnServicesinPackages_Click(object sender, EventArgs e)
        {

        }

        private void dgvServies_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = dgvServies.CurrentRow.Index+1;
            dgvServies.Rows.Insert(row, "Service ID", "Maintances Type", "Difficulty", "Prices", "Frequency", "Task", "Description", "Tools Materials");
            foreach (var item in contract.serviesinPackages(dgvServies.CurrentRow.Cells[0].ToString()))
            {
                row++;
                List<string> itembreakdown = item.Split(',').ToList();
                dgvServies.Rows.Insert(row, itembreakdown[0], itembreakdown[1], itembreakdown[2], itembreakdown[3], itembreakdown[4], itembreakdown[5], itembreakdown[6], itembreakdown[7]);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvServies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
