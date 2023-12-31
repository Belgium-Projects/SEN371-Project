﻿using SEN371_Project.dataHandler;
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
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Timer = System.Windows.Forms.Timer;

namespace SEN371_Project
{
    public partial class frmSimulator : Form
    {
        public frmSimulator()
        {
            InitializeComponent();
        }
        public void ClearPannel()
        {
            pnDuration.Hide();
            lblDuration.Hide();
            lblTImer2.Hide();
        }

        private int timeElapsed;
        private void Form1_Load(object sender, EventArgs e)
        {
            formatUX format = new formatUX();
            format.formattingRules(this);

            ClearPannel();
        }
        callCentre obj = new callCentre();
        private void button1_Click(object sender, EventArgs e)
        {


            //btnAnswer.Hide();
            pnDuration.Show();
            lblDuration.Show();
            lblTImer2.Show();

            pictureBox3.Hide();
            label1.Hide();

            obj.anwsercall();
            duration.Start();

            //DialogResult result = MessageBox.Show("Press Cancel to end the call.", "Call in Progress", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            
            //if (result == DialogResult.Cancel)
            //{
               

              
            //}

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
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        int minElapsed = 0;
        int hour = 0;
        private void ChangeDuration(object sender, EventArgs e)
        {
           
            timeElapsed++;
           
            if(timeElapsed == 60)
            {
                timeElapsed = 0;
                if (minElapsed == 60)
                {
                    minElapsed = 0;
                    hour++;
                }
                minElapsed++;

            }
            lblTImer2.Text =hour.ToString()+"h:"+minElapsed.ToString()+"min:"+ timeElapsed.ToString()+"s";
        }

        employee employee = new employee();
        private void button1_Click_1(object sender, EventArgs e)
        {
            employee.EmpId = "1";
            frmCallCentre frmCallCentre = new frmCallCentre();
            if(frmCallCentre.CustomerID == ""|| frmCallCentre.CustomerID ==null )
            {
                MessageBox.Show("Please  enter customer id before ending call");
            }
            else
            {
                //MessageBox.Show(frmCallCentre.CustomerID + employee.empId);
                obj.endCall(int.Parse(frmCallCentre.CustomerID), int.Parse(employee.empId));
                duration.Stop();
                this.Hide();
            }
            
          
        }
    }
}
