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
    public partial class frmSimulator : Form
    {
        public frmSimulator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startTime = DateTime.Now;

            DialogResult result = MessageBox.Show("Press Cancel to end the call.", "Call in Progress", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                TimeSpan duration = DateTime.Now - startTime;

                MessageBox.Show($"Call ended. Call duration: {duration.TotalMilliseconds} ms", "Call Ended", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                frmCallCentre a = new frmCallCentre();
                a.Show();
            }

           /* else if (result == DialogResult.OK)
            {
                TimeSpan duration = DateTime.Now - startTime;
                if (duration.TotalSeconds >= 45)
                {
                    MessageBox.Show("Call ended after 45 seconds.", "Call Ended", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    frmCallCentre a = new frmCallCentre();
                    a.Show();
                }
            }*/
        }
        private void btnDecline_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to decline the call?", "Decline Call", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Handle the call decline action here

                MessageBox.Show("Call declined.", "Call Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmCallCentre a = new frmCallCentre();
                a.Show();
            }
        }
    }
}
