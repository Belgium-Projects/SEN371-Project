
namespace SEN371_Project
{
    partial class frmServices
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
            this.pnlDept = new System.Windows.Forms.Panel();
            this.txtJobid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSubmitEmp = new System.Windows.Forms.Button();
            this.cbEmployeeID = new System.Windows.Forms.ComboBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.dgvAlljobs = new System.Windows.Forms.DataGridView();
            this.lbTrackJob = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.pnlClientButtons = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btnescalte = new System.Windows.Forms.Button();
            this.btnTrackJob = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbescalte = new System.Windows.Forms.ComboBox();
            this.lblEscalte = new System.Windows.Forms.Label();
            this.btnescalte1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlDept.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlljobs)).BeginInit();
            this.pnlClientButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDept
            // 
            this.pnlDept.Controls.Add(this.btnClose);
            this.pnlDept.Controls.Add(this.label1);
            this.pnlDept.Controls.Add(this.txtJobid);
            this.pnlDept.Controls.Add(this.label12);
            this.pnlDept.Controls.Add(this.label10);
            this.pnlDept.Controls.Add(this.panel6);
            this.pnlDept.Location = new System.Drawing.Point(263, 69);
            this.pnlDept.Name = "pnlDept";
            this.pnlDept.Size = new System.Drawing.Size(744, 546);
            this.pnlDept.TabIndex = 40;
            // 
            // txtJobid
            // 
            this.txtJobid.Location = new System.Drawing.Point(99, 65);
            this.txtJobid.Name = "txtJobid";
            this.txtJobid.Size = new System.Drawing.Size(100, 23);
            this.txtJobid.TabIndex = 11;
            this.txtJobid.TextChanged += new System.EventHandler(this.PopulateItem);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(217, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(238, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "THIS IS THE SERVICE DEPARTMENT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(130, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(451, 35);
            this.label10.TabIndex = 9;
            this.label10.Text = "Welcome to your Client portal page!";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.btnescalte1);
            this.panel6.Controls.Add(this.lblEscalte);
            this.panel6.Controls.Add(this.cbescalte);
            this.panel6.Controls.Add(this.btnSubmitEmp);
            this.panel6.Controls.Add(this.cbEmployeeID);
            this.panel6.Controls.Add(this.lblEmployeeID);
            this.panel6.Controls.Add(this.dgvAlljobs);
            this.panel6.Controls.Add(this.lbTrackJob);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Location = new System.Drawing.Point(35, 112);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(691, 406);
            this.panel6.TabIndex = 6;
            // 
            // btnSubmitEmp
            // 
            this.btnSubmitEmp.Location = new System.Drawing.Point(62, 189);
            this.btnSubmitEmp.Name = "btnSubmitEmp";
            this.btnSubmitEmp.Size = new System.Drawing.Size(131, 47);
            this.btnSubmitEmp.TabIndex = 8;
            this.btnSubmitEmp.Text = "Submit";
            this.btnSubmitEmp.UseVisualStyleBackColor = true;
            this.btnSubmitEmp.Click += new System.EventHandler(this.btnSubmitEmp_Click);
            // 
            // cbEmployeeID
            // 
            this.cbEmployeeID.FormattingEnabled = true;
            this.cbEmployeeID.Location = new System.Drawing.Point(62, 144);
            this.cbEmployeeID.Name = "cbEmployeeID";
            this.cbEmployeeID.Size = new System.Drawing.Size(263, 24);
            this.cbEmployeeID.TabIndex = 7;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(70, 112);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(81, 16);
            this.lblEmployeeID.TabIndex = 6;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // dgvAlljobs
            // 
            this.dgvAlljobs.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAlljobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlljobs.Location = new System.Drawing.Point(-2, -2);
            this.dgvAlljobs.Name = "dgvAlljobs";
            this.dgvAlljobs.RowHeadersWidth = 51;
            this.dgvAlljobs.RowTemplate.Height = 24;
            this.dgvAlljobs.Size = new System.Drawing.Size(686, 395);
            this.dgvAlljobs.TabIndex = 5;
            this.dgvAlljobs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlljobs_CellContentClick);
            this.dgvAlljobs.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.pipulateID);
            this.dgvAlljobs.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.populateid);
            // 
            // lbTrackJob
            // 
            this.lbTrackJob.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrackJob.FormattingEnabled = true;
            this.lbTrackJob.ItemHeight = 42;
            this.lbTrackJob.Location = new System.Drawing.Point(-2, 4);
            this.lbTrackJob.Name = "lbTrackJob";
            this.lbTrackJob.Size = new System.Drawing.Size(691, 382);
            this.lbTrackJob.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(393, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnWork
            // 
            this.btnWork.Location = new System.Drawing.Point(373, 0);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(104, 52);
            this.btnWork.TabIndex = 45;
            this.btnWork.Text = "Packages";
            this.btnWork.UseVisualStyleBackColor = true;
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(263, 0);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(104, 52);
            this.btnClient.TabIndex = 44;
            this.btnClient.Text = "Client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(898, 1);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(114, 51);
            this.btnLogOut.TabIndex = 43;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnDepartment
            // 
            this.btnDepartment.Location = new System.Drawing.Point(483, 1);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(104, 52);
            this.btnDepartment.TabIndex = 42;
            this.btnDepartment.Text = "Department";
            this.btnDepartment.UseVisualStyleBackColor = true;
            // 
            // pnlClientButtons
            // 
            this.pnlClientButtons.Controls.Add(this.pictureBox8);
            this.pnlClientButtons.Controls.Add(this.pictureBox4);
            this.pnlClientButtons.Controls.Add(this.button1);
            this.pnlClientButtons.Controls.Add(this.pictureBox6);
            this.pnlClientButtons.Controls.Add(this.pictureBox7);
            this.pnlClientButtons.Controls.Add(this.label3);
            this.pnlClientButtons.Controls.Add(this.button5);
            this.pnlClientButtons.Controls.Add(this.btnescalte);
            this.pnlClientButtons.Controls.Add(this.btnTrackJob);
            this.pnlClientButtons.Location = new System.Drawing.Point(12, 69);
            this.pnlClientButtons.Name = "pnlClientButtons";
            this.pnlClientButtons.Size = new System.Drawing.Size(226, 365);
            this.pnlClientButtons.TabIndex = 50;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Image = global::SEN371_Project.Properties.Resources.download__3_;
            this.pictureBox4.Location = new System.Drawing.Point(27, 180);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 50;
            this.pictureBox4.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 48);
            this.button1.TabIndex = 49;
            this.button1.Text = "     Manage Job";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox6.Image = global::SEN371_Project.Properties.Resources.download__1_1;
            this.pictureBox6.Location = new System.Drawing.Point(27, 258);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(52, 47);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 48;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox7.Image = global::SEN371_Project.Properties.Resources.download__1_;
            this.pictureBox7.Location = new System.Drawing.Point(27, 92);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(52, 55);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 47;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox8.Image = global::SEN371_Project.Properties.Resources.download__2_;
            this.pictureBox8.Location = new System.Drawing.Point(27, 27);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(52, 43);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 46;
            this.pictureBox8.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(33, 258);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 47);
            this.button5.TabIndex = 9;
            this.button5.Text = "    Delete Account";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnescalte
            // 
            this.btnescalte.Location = new System.Drawing.Point(33, 180);
            this.btnescalte.Name = "btnescalte";
            this.btnescalte.Size = new System.Drawing.Size(161, 48);
            this.btnescalte.TabIndex = 8;
            this.btnescalte.Text = "Escalate";
            this.btnescalte.UseVisualStyleBackColor = true;
            this.btnescalte.Click += new System.EventHandler(this.btnescalte_Click);
            // 
            // btnTrackJob
            // 
            this.btnTrackJob.Location = new System.Drawing.Point(30, 92);
            this.btnTrackJob.Name = "btnTrackJob";
            this.btnTrackJob.Size = new System.Drawing.Size(164, 55);
            this.btnTrackJob.TabIndex = 7;
            this.btnTrackJob.Text = "Track Job";
            this.btnTrackJob.UseVisualStyleBackColor = true;
            this.btnTrackJob.Click += new System.EventHandler(this.btnTrackJob_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = global::SEN371_Project.Properties.Resources.Tony_Hawk_137489040;
            this.pictureBox3.Location = new System.Drawing.Point(813, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(79, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SEN371_Project.Properties.Resources.Wall_UnSat__1_;
            this.pictureBox2.Location = new System.Drawing.Point(-4, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1031, 569);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SEN371_Project.Properties.Resources.Premier_Service_Solutions_540_110_px_Final;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // cbescalte
            // 
            this.cbescalte.FormattingEnabled = true;
            this.cbescalte.Location = new System.Drawing.Point(373, 144);
            this.cbescalte.Name = "cbescalte";
            this.cbescalte.Size = new System.Drawing.Size(263, 24);
            this.cbescalte.TabIndex = 9;
            this.cbescalte.Text = "...";
            // 
            // lblEscalte
            // 
            this.lblEscalte.AutoSize = true;
            this.lblEscalte.Location = new System.Drawing.Point(381, 112);
            this.lblEscalte.Name = "lblEscalte";
            this.lblEscalte.Size = new System.Drawing.Size(47, 16);
            this.lblEscalte.TabIndex = 10;
            this.lblEscalte.Text = "Escalte";
            // 
            // btnescalte1
            // 
            this.btnescalte1.Location = new System.Drawing.Point(373, 204);
            this.btnescalte1.Name = "btnescalte1";
            this.btnescalte1.Size = new System.Drawing.Size(131, 47);
            this.btnescalte1.TabIndex = 11;
            this.btnescalte1.Text = "Escalate";
            this.btnescalte1.UseVisualStyleBackColor = true;
            this.btnescalte1.Click += new System.EventHandler(this.btnescalte1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Job ID:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(515, 56);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 41);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close Job";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1007, 620);
            this.Controls.Add(this.pnlClientButtons);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnDepartment);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pnlDept);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmServices";
            this.Text = "Services Depmartment";
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.pnlDept.ResumeLayout(false);
            this.pnlDept.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlljobs)).EndInit();
            this.pnlClientButtons.ResumeLayout(false);
            this.pnlClientButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlDept;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnlClientButtons;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnescalte;
        private System.Windows.Forms.Button btnTrackJob;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtJobid;
        private System.Windows.Forms.ListBox lbTrackJob;
        private System.Windows.Forms.DataGridView dgvAlljobs;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.ComboBox cbEmployeeID;
        private System.Windows.Forms.Button btnSubmitEmp;
        private System.Windows.Forms.Label lblEscalte;
        private System.Windows.Forms.ComboBox cbescalte;
        private System.Windows.Forms.Button btnescalte1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
    }
}