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
        public void innit()
        {
            cbSALID.Items.Clear();

            foreach (var item in contract.SLAID())
            {
                
                cbSALID.Items.Add(item);
            }
            foreach (var item in contract.defineServices())
            {
                clbServices.Items.Add(item);
            }
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
            lblAvailablity.Hide();
            lblDiscount.Hide();
            lblPackagesName.Hide();
            lblSLAID.Hide();
            txtPackageName.Hide();
            txtAvailability.Hide();
            txtDiscount.Hide();
            cbSALID.Hide();
            btnSubmit.Hide();
            clbServices.Hide();
            //lblPackages.Hide();
            lblMaintance.Hide();
            lblDifficultyMeasure.Hide();
            lblPrices.Hide();
            lblFrequency.Hide();
            lblPackages.Hide();
            lblDesciption.Hide();
            lblTools.Hide();
            cbMaintances.Hide();
            cbdifficult.Hide();
            txtPrice.Hide();
            cbfrequency.Hide();
            lblDesciption.Hide();
            lblDescription.Hide();
            lblTools.Hide();
            txttools.Hide();
            btnSubmitService.Hide();
            lblPackages.Hide();
            txttask.Hide();
            lblTask.Hide();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            frmClose a = new frmClose();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmClient a = new frmClient();
            a.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnViewServices_Click(object sender, EventArgs e)
        {
            pannelClear();
            dgvServies.Show();
            dgvServies.Rows.Clear();
            dgvServies.ColumnCount = 9;
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
            dgvServies.Columns[8].Name = "Tools";

            foreach (var item in contract.definepackages())
            {
                List<string> itembreakdown = item.Split(',').ToList();
                dgvServies.Rows.Add(itembreakdown[0], itembreakdown[1], itembreakdown[2], itembreakdown[3], itembreakdown[4], itembreakdown[6], itembreakdown[7], itembreakdown[8]);
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pannelClear();
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
        int row = 0;
        private void dgvServies_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            try
            {
                row = dgvServies.CurrentRow.Index + 1;
                dgvServies.Rows.Clear();
           
                foreach (var item in contract.definepackages())
                {
                    List<string> itembreakdown = item.Split(',').ToList();
                    dgvServies.Rows.Add(itembreakdown[0], itembreakdown[1], itembreakdown[2], itembreakdown[3], itembreakdown[4], itembreakdown[6], itembreakdown[7], itembreakdown[8]);
                }
                dgvServies.Rows[row-1].Selected = true;
                dgvServies.Rows.Insert(row,null, "Service ID", "Maintances Type", "Difficulty", "Prices", "Frequency", "Task", "Description", "Tools Materials");
                //MessageBox.Show(dgvServies.Rows[row-1].Cells[0].Value.ToString()/*);*/
                foreach (var item in contract.serviesinPackages(dgvServies.Rows[row - 1].Cells[0].Value.ToString()))
                {
                    row++;
                    List<string> itembreakdown = item.Split(',').ToList();
                    dgvServies.Rows.Insert(row,null, itembreakdown[0], itembreakdown[1], itembreakdown[2], itembreakdown[3], itembreakdown[4], itembreakdown[5], itembreakdown[6], itembreakdown[7]);
                }
                dgvServies.Rows.Insert(row + 1, null, null, null, null, null, null, null, null,null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvServies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvServies_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvServies_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dgvServies.CurrentRow.Cells[0].Value.ToString());
        }

        private void dgvServies_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //contract.update(dgvServies.CurrentRow.Cells[1].Value.ToString(), dgvServies.CurrentRow.Cells[2].Value.ToString(), dgvServies.CurrentRow.Cells[3].Value.ToString(), dgvServies.CurrentRow.Cells[0].Value.ToString());

        }

        private void dgvServies_EditModeChanged(object sender, EventArgs e)
        {
            //contract.update(dgvServies.CurrentRow.Cells[1].Value.ToString(), dgvServies.CurrentRow.Cells[2].Value.ToString(), dgvServies.CurrentRow.Cells[3].Value.ToString(), dgvServies.CurrentRow.Cells[0].Value.ToString());

        }

        private void dgvServies_EnabledChanged(object sender, EventArgs e)
        {
            //contract.update(dgvServies.CurrentRow.Cells[1].Value.ToString(), dgvServies.CurrentRow.Cells[2].Value.ToString(), dgvServies.CurrentRow.Cells[3].Value.ToString(), dgvServies.CurrentRow.Cells[0].Value.ToString());

        }

        private void dgvServies_Enter(object sender, EventArgs e)
        {
            //contract.update(dgvServies.CurrentRow.Cells[1].Value.ToString(), dgvServies.CurrentRow.Cells[2].Value.ToString(), dgvServies.CurrentRow.Cells[3].Value.ToString(), dgvServies.CurrentRow.Cells[0].Value.ToString());

        }

        private void dgvServies_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to update?",
                      "Mood Test", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    contract.update(dgvServies.CurrentRow.Cells[1].Value.ToString(), dgvServies.CurrentRow.Cells[2].Value.ToString(), dgvServies.CurrentRow.Cells[3].Value.ToString(), dgvServies.CurrentRow.Cells[0].Value.ToString());
                    dgvServies.Rows.Clear();

                    foreach (var item in contract.definepackages())
                    {
                        List<string> itembreakdown = item.Split(',').ToList();
                        dgvServies.Rows.Add(itembreakdown[0], itembreakdown[1], itembreakdown[2], itembreakdown[3], itembreakdown[4], itembreakdown[6], itembreakdown[7], itembreakdown[8]);
                    }
                    break;
                case DialogResult.No:
                    break;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
               contract.DeletePackages(dgvServies.CurrentRow.Cells[0].Value.ToString());
            
           
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            contract.InsertPackages(txtPackageName.Text,txtAvailability.Text,txtDiscount.Text,cbSALID.Text);
            contract.insertservicesinpackages(contract.Lastitem(), clbServices);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pannelClear();
            innit();
            lblAvailablity.Show();
            lblDiscount.Show();
            lblPackagesName.Show();
            lblSLAID.Show();
            txtPackageName.Show();
            txtAvailability.Show();
            txtDiscount.Show();
            cbSALID.Show();
            btnSubmit.Show();
            clbServices.Show();
            lblPackages.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pannelClear();
            lblMaintance.Show();
            lblDifficultyMeasure.Show();
            lblPrices.Show();
            lblFrequency.Show();
            
            lblDesciption.Show();
            lblTools.Show();
            cbMaintances.Show();
            cbdifficult.Show();
            txtPrice.Show();
            cbfrequency.Show();
            lblDesciption.Show();
            lblDescription.Show();
            lblTools.Show();
            txttools.Show();
            btnSubmitService.Show();
            txttask.Show();
            lblTask.Show();
        }

        private void lblDesciption_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmitService_Click(object sender, EventArgs e)
        {
            contract.insertservices(cbMaintances.Text, cbdifficult.Text, txtPrice.Text, cbfrequency.Text, txttask.Text, lblDescription.Text, txttools.Text);
       
        }
    }
}
