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
            lbServices.Hide();
            cbRedirect.Hide();
            lblRedirect.Hide();
            btnredirect.Hide();
            pngCall.Hide();
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
                        lbServices.Items.Add(item);
                        cbRedirect.Items.Add(item);
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

        private void initalizeVars(object sender, EventArgs e)
        {
            comboboxinit();
            if (txtCustomerID.Text != "")
            {
                List<client> customer = (obj.selectFromDB(int.Parse(txtCustomerID.Text)));
                lbCustomer.Items.Clear();
                if (customer[0].CusName == "Business")
                {

                    lbCustomer.Items.Add($"Customer Type: {customer[0].CusName}");
                    lbCustomer.Items.Add($"Business Name: {customer[0].CusSurname}");
                    //listBox1.Items.Add($"Packages ID {customer[0].packagesID}");
                    lbCustomer.Items.Add($"Street: {customer[0].CusService}");
                    //foreach (var item in customer[0].CusRepresentativeName)
                    //{
                    //    listBox1.Items.Add(item);
                    //}
                }
                else
                {
                    lbCustomer.Items.Add($"Customer Name: {customer[0].CusName}");
                    lbCustomer.Items.Add($"Customer Surname: {customer[0].CusSurname}");
                    lbCustomer.Items.Add($"Customer Name: {customer[0].CusService}");
                    lbCustomer.Items.Add($"Customer Surname: {customer[0].CusPhonenumber}");

                }
            }



        }

        private void btnViewServices_Click(object sender, EventArgs e)
        {
            pannelClose();
            lblTitle.Text = "View Services";
            lbServices.Show();
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
            pngCall.Show();

        }


        private void btnCustomer_Click(object sender, EventArgs e)
        {
            pannelClose();
            pngCall.Show();
            lblTitle.Text = "Customer view";
            lbCustomer.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            obj2.EmpId = "1";
            int serviceID = int.Parse(CBService1.SelectedItem.ToString().Split(',')[0]);
            MessageBox.Show(serviceID.ToString());
            obj.logJob(int.Parse(txtCustomerID.Text), 0, txtNote.Text, "2023/08/15", serviceID, CBPriority.SelectedItem.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnredirect_Click(object sender, EventArgs e)
        {
            string selectedOption = cbRedirect.SelectedItem.ToString();

            // Change the form based on the selected option
            switch (selectedOption)
            {
                case "Services Department":
                    // Open Form1
                    frmServices form1 = new frmServices();
                    form1.Show();
                    break;

                case "Packages Department":
                    // Open Form2
                    frmPackages form2 = new frmPackages();
                    form2.Show();
                    break;

                case "Management Department":
                    // Open Form3
                    frmCallCentre form3 = new frmCallCentre();
                    form3.Show();
                    break;
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
    }
}
