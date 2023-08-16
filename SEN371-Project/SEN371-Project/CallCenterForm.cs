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
        public static string CustomerID;
        public frmCallCentre()
        {
            InitializeComponent();

        }
        callCentre obj = new callCentre();
        employee obj2 = new employee();
        public void pannelClose()
        {
            txtNote.Hide();
            lblPriority.Hide();
            lblNote.Hide();
            lblServie.Hide();
            CBService1.Hide();
            CBPriority.Hide();
            btnSubmit.Hide();
            lbCustomer.Hide();
            dgvHistory.Hide();
            cbRedirect.Hide();
            lblRedirect.Hide();
            btnredirect.Hide();
            //pngCall.Hide();
        }
        public void comboboxinit()
        {
            CBService1.Items.Clear();
            CBPriority.Items.Clear();
            CBService1.Text = "Please select Services";
            CBPriority.Text = "Please select the Priority";
            CBPriority.Items.Add("High");
            CBPriority.Items.Add("Medium");
            CBPriority.Items.Add("Low");

            try
            {
                if (txtCustomerID.Text != null)
                {
                    foreach (var item in obj.returnServices(txtCustomerID.Text))
                    {
                        CBService1.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

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
            this.Hide();
            frmPackages a = new frmPackages();
            a.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmManagementDept a = new frmManagementDept();
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmServices a = new frmServices();
            a.Show();
        }

        private void initalizeVars(object sender, EventArgs e)
        {
            CustomerID = txtCustomerID.Text;
            comboboxinit();
            if (txtCustomerID.Text != "")
            {
             
                try
                {
                    List<client> customer = (obj.selectFromDB(int.Parse(txtCustomerID.Text)));
                    lbCustomer.Items.Clear();
                    MessageBox.Show(customer[0].CusName);
                    if (customer[0].CusName == "Business")
                    {

                        lbCustomer.Items.Add($"Customer Type: {customer[0].CusName}");
                        lbCustomer.Items.Add($"Business Name: {customer[0].CusSurname}");
                        //listBox1.Items.Add($"Packages ID {customer[0].packagesID}");
                        lbCustomer.Items.Add($"Street: {customer[0].CusService}");
                        lbCustomer.Items.Add($"Business Rep:");
                        
                        foreach (var item in obj.BUsinessRep(txtCustomerID.Text))
                        {
                            lbCustomer.Items.Add(item);
                        }
                    }
                    else
                    {
                        lbCustomer.Items.Add($"Customer Name: {customer[0].CusName}");
                        lbCustomer.Items.Add($"Customer Surname: {customer[0].CusSurname}");
                        lbCustomer.Items.Add($"Customer Name: {customer[0].CusService}");
                        lbCustomer.Items.Add($"Customer Surname: {customer[0].CusPhonenumber}");

                    }
                    lbCustomer.Items.Add("Services in customers packages:");
                    if (txtCustomerID.Text != null)
                    {
                        foreach (var item in obj.returnServices(txtCustomerID.Text))
                        {
                            lbCustomer.Items.Add(item);
                        }
                    }
                    lbCustomer.Items.Add("customer agreement:");
                    if (txtCustomerID.Text != null)
                    {
                        foreach (var item in obj.cusAgreement(txtCustomerID.Text))
                        {
                            List<string> itemBreakdown = item.Split(',').ToList();
                            lbCustomer.Items.Add("PackagesID:" + itemBreakdown[1]);
                            lbCustomer.Items.Add("Packages Name:" + itemBreakdown[2]);
                            lbCustomer.Items.Add("Start Date:" + itemBreakdown[7]);
                            lbCustomer.Items.Add("End Date:" + itemBreakdown[6]);
                            lbCustomer.Items.Add("Status:" + itemBreakdown[8]);

                        }

                    }

                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    MessageBox.Show("No Customer with that ID is there");
                }
                
            }
        }
        //View Services
        private void btnViewServices_Click(object sender, EventArgs e)
        {
            pannelClose();
            lblTitle.Text = "View Call History:";
            dgvHistory.Show();
            if(txtCustomerID.Text !=null || txtCustomerID.Text != "")
            {
           
                     dgvHistory.ColumnCount = 7;
                     dgvHistory.ColumnHeadersVisible = true;

                // Set the column header style.
                DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

                columnHeaderStyle.BackColor = Color.Beige;
                columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
                     dgvHistory.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

                     dgvHistory.Columns[0].Name = "Customer ID";
                     dgvHistory.Columns[1].Name = "Customer";
                     dgvHistory.Columns[2].Name = "Employee ID";
                     dgvHistory.Columns[3].Name = "Employee";
                     dgvHistory.Columns[4].Name = "Start time";
                     dgvHistory.Columns[5].Name = "End time";
                     dgvHistory.Columns[6].Name = "Duration ";
                try
                {
                    foreach (var item in obj.callHistory(int.Parse(txtCustomerID.Text)))
                    {

                        List<string> itembreakDown = item.Split(',').ToList();
                        dgvHistory.Rows.Add(itembreakDown[0], itembreakDown[1], itembreakDown[2], itembreakDown[3], itembreakDown[4], itembreakDown[5], itembreakDown[6] + "s");
                    }
                }
                catch (Exception)
                {
                    
                    MessageBox.Show("Ensure that customer id is filled in");
                }
               
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pannelClose();
            lblTitle.Text = "Log Issue";
            txtNote.Show();
            lblPriority.Show();
            lblNote.Show();
            lblServie.Show();
            lblServie.Show();
            CBPriority.Show();
            CBService1.Show();
            btnSubmit.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pannelClose();
            lblTitle.Text = "Transfer";
            cbRedirect.Show();
            lblRedirect.Show();
            btnredirect.Show();
            //pngCall.Show();
        }


        private void btnCustomer_Click(object sender, EventArgs e)
        {
            pannelClose();
            //pngCall.Show();
            lblTitle.Text = "Customer view";
            lbCustomer.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //obj2.EmpId = "1";
            int serviceID = int.Parse(CBService1.SelectedItem.ToString().Split(',')[0]);
            MessageBox.Show(serviceID.ToString());
            obj.logJob(int.Parse(txtCustomerID.Text), 0, txtNote.Text, "2023/08/15", serviceID, CBPriority.SelectedItem.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnredirect_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtCustomerID.Text) || string.IsNullOrWhiteSpace(txtCustomerID.Text))
            {
                MessageBox.Show("Please enter client ID before redirecting");
            }
            else
            {
                try
                {
                    string selectedOption = cbRedirect.Text;
                    frmSimulator frmsimulator = new frmSimulator();
                    // Change the form based on the selected option
                    switch (selectedOption)
                    {
                        case "Services Department":

                            frmServices form1 = new frmServices();
                            frmsimulator.Show();
                            frmsimulator.TopMost = true;
                            form1.Show();
                            this.Hide();
                            //MessageBox.Show("Transferred Succefully Services Department!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            break;

                        case "Packages Department":
                            // Open Form2

                            frmPackages form2 = new frmPackages();
                            form2.Show();
                            frmsimulator.Show();
                            frmsimulator.TopMost = true;
                            this.Hide();
                            //MessageBox.Show("Transferred Succefully Packages Department!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;

                        case "Management Department":
                            // Open Form3
                            frmsimulator.Show();
                            frmCallCentre form3 = new frmCallCentre();
                            frmsimulator.TopMost = true;
                            form3.Show();
                            this.Hide();
                            //MessageBox.Show("Transferred Succefully Management Department!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;


                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }

            }
            
            
        }

        private void frmCallCentre_Load(object sender, EventArgs e)
        {
            pannelClose();
            cbRedirect.Items.Add("Services Department");
            cbRedirect.Items.Add("Packages Department");
            cbRedirect.Items.Add("Management Department");
           
            // Set default selected index
            cbRedirect.SelectedIndex = -1;
            lblEmpName.Text = obj2.EmpName;
            //MessageBox.Show(obj.returnall()[0]);
        }

        private void chkSimulateCall_CheckedChanged(object sender, EventArgs e)
        {           
        }

        private void btnCallSimulation_Click(object sender, EventArgs e)
        {
                frmSimulator a = new frmSimulator();
                a.Show();
                a.TopMost = true;
                //this.Hide();
        }

        private void lblRedirect_Click(object sender, EventArgs e)
        {

        }
    } 
}
