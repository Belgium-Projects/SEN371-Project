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
            clientMange obj = new clientMange();
            obj.manamgnentInfo();
        }

        
    }
}
