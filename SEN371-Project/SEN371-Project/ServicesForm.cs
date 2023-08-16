using SEN371_Project.dataHandler;
using SEN371_Project.FunctionalAreas;
using SEN371_Project.userExperience;
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
    public partial class frmServices : Form
    {
        public frmServices()
        {
            InitializeComponent();
            txtJobid.Text = string.Empty;

        }
        public void comboboxinit()
        {
            callCentre obj = new callCentre();
            cbService.Items.Clear();
            cbpriority.Items.Clear();
             cbService.Text = "Please select Services";
            cbpriority.Text = "Please select the Priority";
            cbpriority.Items.Add("High");
            cbpriority.Items.Add("Medium");
            cbpriority.Items.Add("Low");
          
            try
            {
                if (txtCustomerID.Text != null)
                {
                    foreach (var item in obj.returnServices(txtCustomerID.Text))
                    {
                        cbService.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        public void ClearPannel()
        {
            lbTrackJob.Hide();
            dgvAlljobs.Hide();
            lblEmployeeID.Hide();
            btnSubmitEmp.Hide();
            cbEmployeeID.Hide();
            cbescalte.Hide();
            lblEscalte.Hide();
            btnescalte1.Hide();
            txtCustomerID.Hide();
            lblNote.Hide();
            //btnsubmit.Hide();
            lblPriority.Hide();
            lblService.Hide();
            cbService.Hide();
            cbpriority.Hide();
            textBox1.Hide();
            button2.Hide();
            lnlCustomerID.Hide();
        }
        employee obj = new employee();
        serviceDept obj2 = new serviceDept();
        private void frmClient_Load(object sender, EventArgs e)
        {
            formatUX format = new formatUX();
            format.formattingRules(this);

            ClearPannel();
            foreach (var item in obj2.employeeAvailabe())
            {
                List<string> itemBrokedown = item.Split(',').ToList();
                cbEmployeeID.Items.Add(itemBrokedown[0] + "  " + itemBrokedown[1] + " " + itemBrokedown[2]);
            }
            cbescalte.Items.Add("High");
            cbescalte.Items.Add("Medium");
            cbescalte.Items.Add("Low");
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtJobid.Text != "")
            {
                string temp = txtJobid.Text;
                dgvAlljobs.Rows.Clear();
                txtJobid.Text = temp;
                ClearPannel();
                lblEmployeeID.Show();
                btnSubmitEmp.Show();
                cbEmployeeID.Show();
                lblEscalte.Show();
                cbescalte.Show();
                btnescalte1.Show();
                dgvAlljobs.Show();
                dgvAlljobs.ColumnCount = 9;
                dgvAlljobs.ColumnHeadersVisible = true;

                // Set the column header style.
                DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

                columnHeaderStyle.BackColor = Color.Beige;
                columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
                dgvAlljobs.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

                dgvAlljobs.Columns[0].Name = "JOb ID";
                dgvAlljobs.Columns[1].Name = "Customer ID";
                dgvAlljobs.Columns[2].Name = "Employee ID";
                dgvAlljobs.Columns[3].Name = "Notes";
                dgvAlljobs.Columns[4].Name = "Status";
                dgvAlljobs.Columns[5].Name = "Date Started";
                dgvAlljobs.Columns[6].Name = "DateEnded";
                dgvAlljobs.Columns[7].Name = "Service ID";
                dgvAlljobs.Columns[8].Name = "Priority";
                if (txtJobid.Text != "")
                {
                    foreach (var item in obj2.TrackJobs(int.Parse(txtJobid.Text)))
                    {
                        List<string> itembreakdown = item.Split(',').ToList();
                        dgvAlljobs.Rows.Add(itembreakdown[0], itembreakdown[1], itembreakdown[2], itembreakdown[3], itembreakdown[4], itembreakdown[5], itembreakdown[6], itembreakdown[7], itembreakdown[8]);
                    }
                }
            }


        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmClose a = new frmClose();
            a.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmClient a = new frmClient();
            a.Show();
        }

        private void btnTrackJob_Click(object sender, EventArgs e)
        {
            ClearPannel();
            if (txtJobid.Text != "")
            {
                lbTrackJob.Show();
            }
            else if (txtJobid.Text == "" || txtJobid.Text == null)
            {
                ClearPannel();
                showall();
                dgvAlljobs.Show();
            }

        }
        public void showall()
        {
            if (txtJobid.Text == "" || txtJobid.Text == null)
            {
                ClearPannel();


                dgvAlljobs.Show();

                dgvAlljobs.ColumnCount = 9;
                dgvAlljobs.ColumnHeadersVisible = true;

                // Set the column header style.
                DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

                columnHeaderStyle.BackColor = Color.Beige;
                columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
                dgvAlljobs.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

                dgvAlljobs.Columns[0].Name = "JOb ID";
                dgvAlljobs.Columns[1].Name = "Customer ID";
                dgvAlljobs.Columns[2].Name = "Employee ID";
                dgvAlljobs.Columns[3].Name = "Notes";
                dgvAlljobs.Columns[4].Name = "Status";
                dgvAlljobs.Columns[5].Name = "Date Started";
                dgvAlljobs.Columns[6].Name = "DateEnded";
                dgvAlljobs.Columns[7].Name = "Service ID";
                dgvAlljobs.Columns[8].Name = "Priority";

                foreach (var item in obj2.returnJobs())
                {
                    List<string> itembreakdown = item.Split(',').ToList();
                    dgvAlljobs.Rows.Add(itembreakdown[0], itembreakdown[1], itembreakdown[2], itembreakdown[3], itembreakdown[5], itembreakdown[6], itembreakdown[7], itembreakdown[8]);
                }
                if (dgvAlljobs.RowCount > 0)
                {
                    lbTrackJob.Hide();
                    lblEmployeeID.Hide();
                    btnSubmitEmp.Hide();
                    cbEmployeeID.Hide();
                    cbescalte.Hide();
                    lblEscalte.Hide();
                    btnescalte1.Hide();
                }
            }
        }
        private void PopulateItem(object sender, EventArgs e)
        {
            if (txtJobid.Text != "")
            {
                lbTrackJob.Items.Clear();
                try
                {
                    foreach (var item in obj2.TrackJobs(int.Parse(txtJobid.Text)))
                    {
                        List<string> BreakdownItem = item.Split(',').ToList();
                        lbTrackJob.Items.Add("Job ID: " + BreakdownItem[0]);
                        lbTrackJob.Items.Add("Customer ID: " + BreakdownItem[1]);
                        lbTrackJob.Items.Add("Employee ID: " + BreakdownItem[2]);
                        lbTrackJob.Items.Add("Notes : " + BreakdownItem[3]);
                        lbTrackJob.Items.Add("Status : " + BreakdownItem[4]);
                        lbTrackJob.Items.Add("Date Started : " + BreakdownItem[5]);
                        lbTrackJob.Items.Add("Date Ended: " + BreakdownItem[6]);
                        lbTrackJob.Items.Add("Services ID: " + BreakdownItem[7]);
                        lbTrackJob.Items.Add("Priority : " + BreakdownItem[8]);
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Job id does not exist");
                }
            }
            else
            {
                showall();
            }
        }

        private void dgvAlljobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtJobid.Text = dgvAlljobs.CurrentRow.Cells[0].Value.ToString();
        }

        private void populateid(object sender, DataGridViewCellEventArgs e)
        {

            txtJobid.Text = dgvAlljobs.CurrentRow.Cells[0].Value.ToString();
        }

        private void pipulateID(object sender, DataGridViewCellMouseEventArgs e)
        {

            txtJobid.Text = dgvAlljobs.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnSubmitEmp_Click(object sender, EventArgs e)
        {
            string empid = cbEmployeeID.Text.Split(' ')[0];
            //MessageBox.Show(empid + txtJobid.Text);
            obj2.reAssign(empid, txtJobid.Text);
        }
        callCentre call = new callCentre();
        private void btnescalte_Click(object sender, EventArgs e)
        {
            ClearPannel();
            txtCustomerID.Show();
            lnlCustomerID.Show();
            lblNote.Show();
            textBox1.Show();
            lblService.Show();
            cbService.Show();
            cbpriority.Show();
            textBox1.Show();
            button2.Show();
            lnlCustomerID.Show();
            lblPriority.Show();
            //comboboxinit();

        }

        private void btnescalte1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbescalte.Text);
            obj2.escaltejob(txtJobid.Text, cbescalte.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            obj2.closeService(txtJobid.Text);
            dgvAlljobs.ColumnCount = 9;
            dgvAlljobs.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dgvAlljobs.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            dgvAlljobs.Columns[0].Name = "JOb ID";
            dgvAlljobs.Columns[1].Name = "Customer ID";
            dgvAlljobs.Columns[2].Name = "Employee ID";
            dgvAlljobs.Columns[3].Name = "Notes";
            dgvAlljobs.Columns[4].Name = "Status";
            dgvAlljobs.Columns[5].Name = "Date Started";
            dgvAlljobs.Columns[6].Name = "DateEnded";
            dgvAlljobs.Columns[7].Name = "Service ID";
            dgvAlljobs.Columns[8].Name = "Priority";

            foreach (var item in obj2.returnJobs())
            {
                List<string> itembreakdown = item.Split(',').ToList();
                dgvAlljobs.Rows.Add(itembreakdown[0], itembreakdown[1], itembreakdown[2], itembreakdown[3], itembreakdown[5], itembreakdown[6], itembreakdown[7], itembreakdown[8]);
            }
        }

        private void dgvAlljobs_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtJobid.Text = dgvAlljobs.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            call.logJob(int.Parse(txtCustomerID.Text), 0, textBox1.Text, DateTime.Now.ToString("yyyy/MM/dd"), int.Parse(cbService.SelectedItem.ToString()), cbpriority.SelectedItem.ToString());
        }
        Validation ob3j = new Validation();
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (ob3j.isNumber(cbService.SelectedItem.ToString().Split(',')[0]))
                {
                    int serviceid = int.Parse(cbService.SelectedItem.ToString().Split(',')[0]);
                    //MessageBox.Show(txtCustomerID.Text);
                    if (string.IsNullOrEmpty(txtCustomerID.Text) || string.IsNullOrWhiteSpace(txtCustomerID.Text))
                    {
                        MessageBox.Show("Please enter all the values");
                    }
                    else if (cbpriority.Text == "High" || cbpriority.Text == "Medium" || cbpriority.Text == "Low")
                    {
                        call.logJob(int.Parse(txtCustomerID.Text), 0, textBox1.Text, "2023/08/17", serviceid, cbpriority.SelectedItem.ToString());
                    }
                }
                

            }
            catch (Exception)
            {

                MessageBox.Show("Incorrect Service chosen");
            }
            
        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            comboboxinit();
        }
    }
}
