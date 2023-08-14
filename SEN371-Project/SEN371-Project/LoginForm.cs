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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            clientMange obj = new clientMange();
            List<string> check = new List<string>();
            check.Add("CEO,Susan,Susanson,+278150523");
            check.Add("Driver,Bob,Susanson,+278130523");

            obj.BusinessClient("Premier", 2, "255 This street", "Gotham", "3333", check);
        }
    }
}
