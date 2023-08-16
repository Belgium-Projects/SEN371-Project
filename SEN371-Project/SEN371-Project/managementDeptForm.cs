using SEN371_Project.userExperience;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SEN371_Project
{
    public partial class frmManagementDept : Form
    {
        public frmManagementDept()
        {
            InitializeComponent();
        }

        private void frmManagementDept_Load(object sender, EventArgs e)
        {
            formatUX format = new formatUX();
            format.formattingRules(this);
        }
    }
}
