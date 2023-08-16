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

namespace SEN371_Project.userExperience
{
    internal class formatUX : Form
    {
        public void formattingRules(Form form)
        {
            //Making Form dynamic in sizing elements
            Rectangle resolutionRect = System.Windows.Forms.Screen.FromControl(form).Bounds;
            if (form.Width >= resolutionRect.Width || form.Height >= resolutionRect.Height)
            {
                form.WindowState = FormWindowState.Maximized;
            }

            //Variables for setting transparency
            int maxIndex = 0;
            int indexCount1 = 1;
            int indexCount2 = 1;
            bool stop1 = false;
            bool stop2 = false;

            //Setting Content Panel transparency/fixing flickering (Content Panel border Naming) *"pnlContent{Num}*
            while (!stop1)
            {
                String ctlName = $"pnlContent{indexCount1}";
                Panel panel = form.Controls.Find(ctlName, true).FirstOrDefault() as Panel;
                if (panel != null)
                {
                    typeof(Panel).InvokeMember("DoubleBuffered",
                    BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                    null, panel, new object[] { true });

                    SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

                    switch (indexCount1)
                    {
                        case 1:
                            panel.BackColor = Color.FromArgb(150, 65, 65, 65);
                            break;
                        case 2:
                            panel.BackColor = Color.FromArgb(150, 104, 104, 104);
                            break;
                        case 3:
                            panel.BackColor = Color.FromArgb(190, 154, 154, 154);
                            break;
                        default:
                            break;
                    }
                    indexCount1++;
                }
                else
                {
                    maxIndex = indexCount1;
                    indexCount1 = 1;
                    stop1 = true;
                }
            }

            //Setting Panel borders transparency/fixing flickering (Panel border Naming) *"pnlBR{Num}*
            while (!stop2)
            {
                String ctlName = $"pnlBR{indexCount2}";
                Panel panel = form.Controls.Find(ctlName, true).FirstOrDefault() as Panel;
                if (panel != null)
                {
                    typeof(Panel).InvokeMember("DoubleBuffered",
                    BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                    null, panel, new object[] { true });

                    SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

                    switch (indexCount2)
                    {
                        case 1:
                            panel.BackColor = Color.FromArgb(90, 217, 217, 217);
                            break;
                        case 2:
                            panel.BackColor = Color.FromArgb(90, 217, 217, 217);
                            break;
                        case 3:
                            panel.BackColor = Color.FromArgb(150, 217, 217, 217);
                            break;
                        case 4:
                            panel.BackColor = Color.FromArgb(150, 217, 217, 217);
                            break;
                        default:
                            break;
                    }
                    indexCount2++;
                }
                else
                {
                    indexCount2 = 1;
                    stop2 = true;
                }
            }
        }
    }
}
