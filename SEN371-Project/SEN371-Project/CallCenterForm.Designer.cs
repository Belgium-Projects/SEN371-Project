﻿
namespace SEN371_Project
{
    partial class frmCallCentre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWork = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.pnlWork = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnViewServices = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblServie = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.CBPriority = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lbCustomer = new System.Windows.Forms.ListBox();
            this.lbServices = new System.Windows.Forms.ListBox();
            this.lblRedirect = new System.Windows.Forms.Label();
            this.cbRedirect = new System.Windows.Forms.ComboBox();
            this.btnredirect = new System.Windows.Forms.Button();
            this.CBService1 = new System.Windows.Forms.ComboBox();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.pnlWork.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWork
            // 
            this.btnWork.Location = new System.Drawing.Point(280, -104);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(104, 52);
            this.btnWork.TabIndex = 41;
            this.btnWork.Text = "Work";
            this.btnWork.UseVisualStyleBackColor = true;
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(170, -104);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(104, 52);
            this.btnClient.TabIndex = 40;
            this.btnClient.Text = "Client";
            this.btnClient.UseVisualStyleBackColor = true;
            // 
            // btnDepartment
            // 
            this.btnDepartment.Location = new System.Drawing.Point(390, -103);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(104, 52);
            this.btnDepartment.TabIndex = 38;
            this.btnDepartment.Text = "Department";
            this.btnDepartment.UseVisualStyleBackColor = true;
            // 
            // pnlWork
            // 
            this.pnlWork.Controls.Add(this.txtCustomerID);
            this.pnlWork.Controls.Add(this.lblTitle);
            this.pnlWork.Controls.Add(this.panel3);
            this.pnlWork.Location = new System.Drawing.Point(265, 79);
            this.pnlWork.Name = "pnlWork";
            this.pnlWork.Size = new System.Drawing.Size(750, 508);
            this.pnlWork.TabIndex = 48;
            this.pnlWork.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlWork_Paint);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.CBService1);
            this.panel3.Controls.Add(this.btnredirect);
            this.panel3.Controls.Add(this.lblRedirect);
            this.panel3.Controls.Add(this.btnSubmit);
            this.panel3.Controls.Add(this.CBPriority);
            this.panel3.Controls.Add(this.txtNote);
            this.panel3.Controls.Add(this.lblServie);
            this.panel3.Controls.Add(this.lblNote);
            this.panel3.Controls.Add(this.lblPriority);
            this.panel3.Controls.Add(this.lbServices);
            this.panel3.Controls.Add(this.cbRedirect);
            this.panel3.Controls.Add(this.lbCustomer);
            this.panel3.Location = new System.Drawing.Point(18, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(729, 416);
            this.panel3.TabIndex = 3;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(836, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(114, 52);
            this.btnLogOut.TabIndex = 53;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = global::SEN371_Project.Properties.Resources.Tony_Hawk_137489040;
            this.pictureBox3.Location = new System.Drawing.Point(751, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(79, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SEN371_Project.Properties.Resources.Wall_UnSat__1_;
            this.pictureBox2.Location = new System.Drawing.Point(-2, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1051, 562);
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SEN371_Project.Properties.Resources.Premier_Service_Solutions_540_110_px_Final;
            this.pictureBox1.Location = new System.Drawing.Point(-107, -104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblEmpName);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnViewServices);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(19, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 471);
            this.panel1.TabIndex = 57;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(37, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 43);
            this.button3.TabIndex = 12;
            this.button3.Text = "Tranfer Call";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Options:";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpName.Location = new System.Drawing.Point(50, 24);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(131, 26);
            this.lblEmpName.TabIndex = 10;
            this.lblEmpName.Text = "Peter Jones";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(37, 256);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 43);
            this.button4.TabIndex = 9;
            this.button4.Text = "Assign Job";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnViewServices
            // 
            this.btnViewServices.Location = new System.Drawing.Point(37, 96);
            this.btnViewServices.Name = "btnViewServices";
            this.btnViewServices.Size = new System.Drawing.Size(159, 43);
            this.btnViewServices.TabIndex = 8;
            this.btnViewServices.Text = "View Services";
            this.btnViewServices.UseVisualStyleBackColor = true;
            this.btnViewServices.Click += new System.EventHandler(this.btnViewServices_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(37, 179);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 43);
            this.button5.TabIndex = 7;
            this.button5.Text = "Log Issue";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(375, 1);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(104, 51);
            this.button7.TabIndex = 60;
            this.button7.Text = "Services";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(265, 1);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(104, 51);
            this.button8.TabIndex = 59;
            this.button8.Text = "Clients";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(485, 1);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(104, 51);
            this.button9.TabIndex = 58;
            this.button9.Text = "Packages";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SEN371_Project.Properties.Resources.Premier_Service_Solutions_540_110_px_Final;
            this.pictureBox4.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(246, 54);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 50;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(278, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(202, 46);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Call Centre";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(121, 256);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(49, 16);
            this.lblPriority.TabIndex = 0;
            this.lblPriority.Text = "Priority";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(121, 66);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(34, 16);
            this.lblNote.TabIndex = 1;
            this.lblNote.Text = "Note";
            // 
            // lblServie
            // 
            this.lblServie.AutoSize = true;
            this.lblServie.Location = new System.Drawing.Point(121, 179);
            this.lblServie.Name = "lblServie";
            this.lblServie.Size = new System.Drawing.Size(49, 16);
            this.lblServie.TabIndex = 2;
            this.lblServie.Text = "Service";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(124, 86);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(477, 79);
            this.txtNote.TabIndex = 3;
            // 
            // CBPriority
            // 
            this.CBPriority.FormattingEnabled = true;
            this.CBPriority.Location = new System.Drawing.Point(124, 275);
            this.CBPriority.Name = "CBPriority";
            this.CBPriority.Size = new System.Drawing.Size(477, 24);
            this.CBPriority.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(124, 328);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(167, 42);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(110, 24);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(121, 23);
            this.txtCustomerID.TabIndex = 5;
            this.txtCustomerID.TextChanged += new System.EventHandler(this.initalizeVars);
            // 
            // lbCustomer
            // 
            this.lbCustomer.FormattingEnabled = true;
            this.lbCustomer.ItemHeight = 16;
            this.lbCustomer.Location = new System.Drawing.Point(11, 10);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(719, 404);
            this.lbCustomer.TabIndex = 7;
            // 
            // lbServices
            // 
            this.lbServices.FormattingEnabled = true;
            this.lbServices.ItemHeight = 16;
            this.lbServices.Location = new System.Drawing.Point(11, 10);
            this.lbServices.Name = "lbServices";
            this.lbServices.Size = new System.Drawing.Size(719, 404);
            this.lbServices.TabIndex = 8;
            // 
            // lblRedirect
            // 
            this.lblRedirect.AutoSize = true;
            this.lblRedirect.Location = new System.Drawing.Point(212, 89);
            this.lblRedirect.Name = "lblRedirect";
            this.lblRedirect.Size = new System.Drawing.Size(54, 16);
            this.lblRedirect.TabIndex = 9;
            this.lblRedirect.Text = "Redirect";
            // 
            // cbRedirect
            // 
            this.cbRedirect.FormattingEnabled = true;
            this.cbRedirect.Location = new System.Drawing.Point(215, 132);
            this.cbRedirect.Name = "cbRedirect";
            this.cbRedirect.Size = new System.Drawing.Size(213, 24);
            this.cbRedirect.TabIndex = 10;
            // 
            // btnredirect
            // 
            this.btnredirect.Location = new System.Drawing.Point(215, 190);
            this.btnredirect.Name = "btnredirect";
            this.btnredirect.Size = new System.Drawing.Size(116, 43);
            this.btnredirect.TabIndex = 11;
            this.btnredirect.Text = "Redirect";
            this.btnredirect.UseVisualStyleBackColor = true;
            // 
            // CBService1
            // 
            this.CBService1.FormattingEnabled = true;
            this.CBService1.Location = new System.Drawing.Point(124, 200);
            this.CBService1.Name = "CBService1";
            this.CBService1.Size = new System.Drawing.Size(477, 24);
            this.CBService1.TabIndex = 12;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(37, 411);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(159, 43);
            this.btnCustomer.TabIndex = 13;
            this.btnCustomer.Text = "View Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // frmCallCentre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1056, 596);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pnlWork);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnDepartment);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCallCentre";
            this.Text = "CallCentre";
            this.Load += new System.EventHandler(this.frmJobs_Load);
            this.pnlWork.ResumeLayout(false);
            this.pnlWork.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlWork;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnViewServices;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnredirect;
        private System.Windows.Forms.ComboBox cbRedirect;
        private System.Windows.Forms.Label lblRedirect;
        private System.Windows.Forms.ListBox lbServices;
        private System.Windows.Forms.ListBox lbCustomer;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox CBPriority;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblServie;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox CBService1;
        private System.Windows.Forms.Button btnCustomer;
    }
}