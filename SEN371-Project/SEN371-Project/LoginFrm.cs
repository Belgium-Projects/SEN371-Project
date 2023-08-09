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
    public partial class LoginDashboard : Form
    {
        public LoginDashboard()
        {
            InitializeComponent();
        }

        private void LoginDashboard_Load(object sender, EventArgs e)
        {
            callCentre obj = new callCentre();
            //obj.logTicket(1,1,"supertest", "09/08/2023", 1, 'H');
            foreach (var item in obj.callHistory(1))
            {
                MessageBox.Show(item);
            }    
        }

        
    }
}
