
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
            this.pnlContent2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJobid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlBR3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnescalte1 = new System.Windows.Forms.Button();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblEscalte = new System.Windows.Forms.Label();
            this.btnSubmitEmp = new System.Windows.Forms.Button();
            this.cbescalte = new System.Windows.Forms.ComboBox();
            this.cbEmployeeID = new System.Windows.Forms.ComboBox();
            this.lbTrackJob = new System.Windows.Forms.ListBox();
            this.pnlContent3 = new System.Windows.Forms.Panel();
            this.dgvAlljobs = new System.Windows.Forms.DataGridView();
            this.btnWork = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.pnlContent1 = new System.Windows.Forms.Panel();
            this.lblContent2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblContent1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogJob = new System.Windows.Forms.Button();
            this.btnTrackJob = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlBR4 = new System.Windows.Forms.Panel();
            this.pnlBR1 = new System.Windows.Forms.Panel();
            this.pnlBR2 = new System.Windows.Forms.Panel();
            this.lblNote = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblService = new System.Windows.Forms.Label();
            this.cbService = new System.Windows.Forms.ComboBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.cbpriority = new System.Windows.Forms.ComboBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lnlCustomerID = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlContent2.SuspendLayout();
            this.pnlBR3.SuspendLayout();
            this.pnlContent3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlljobs)).BeginInit();
            this.pnlContent1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlBR4.SuspendLayout();
            this.pnlBR1.SuspendLayout();
            this.pnlBR2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent2
            // 
            this.pnlContent2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.pnlContent2.Controls.Add(this.pnlBR3);
            this.pnlContent2.Controls.Add(this.label1);
            this.pnlContent2.Controls.Add(this.txtJobid);
            this.pnlContent2.Controls.Add(this.label12);
            this.pnlContent2.Controls.Add(this.label10);
            this.pnlContent2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent2.Location = new System.Drawing.Point(10, 10);
            this.pnlContent2.Name = "pnlContent2";
            this.pnlContent2.Size = new System.Drawing.Size(1439, 780);
            this.pnlContent2.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(581, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Job ID";
            // 
            // txtJobid
            // 
            this.txtJobid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtJobid.Location = new System.Drawing.Point(666, 146);
            this.txtJobid.Name = "txtJobid";
            this.txtJobid.Size = new System.Drawing.Size(126, 34);
            this.txtJobid.TabIndex = 11;
            this.txtJobid.TextChanged += new System.EventHandler(this.PopulateItem);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label12.Location = new System.Drawing.Point(533, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(334, 29);
            this.label12.TabIndex = 10;
            this.label12.Text = "This is the service department";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label10.Location = new System.Drawing.Point(399, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(656, 46);
            this.label10.TabIndex = 9;
            this.label10.Text = "Welcome to your Client portal page!";
            // 
            // pnlBR3
            // 
            this.pnlBR3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pnlBR3.Controls.Add(this.lblEscalte);
            this.pnlBR3.Controls.Add(this.btnescalte1);
            this.pnlBR3.Controls.Add(this.cbescalte);
            this.pnlBR3.Controls.Add(this.btnSubmitEmp);
            this.pnlBR3.Controls.Add(this.cbEmployeeID);
            this.pnlBR3.Controls.Add(this.lblEmployeeID);
            this.pnlBR3.Controls.Add(this.pnlContent3);
            this.pnlBR3.Controls.Add(this.lbTrackJob);
            this.pnlBR3.Location = new System.Drawing.Point(28, 205);
            this.pnlBR3.Name = "pnlBR3";
            this.pnlBR3.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBR3.Size = new System.Drawing.Size(1380, 548);
            this.pnlBR3.TabIndex = 14;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(205)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnClose.Location = new System.Drawing.Point(1235, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 42);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close Job";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnescalte1
            // 
            this.btnescalte1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(205)))));
            this.btnescalte1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnescalte1.Location = new System.Drawing.Point(861, 267);
            this.btnescalte1.Name = "btnescalte1";
            this.btnescalte1.Size = new System.Drawing.Size(140, 50);
            this.btnescalte1.TabIndex = 11;
            this.btnescalte1.Text = "Escalate";
            this.btnescalte1.UseVisualStyleBackColor = false;
            this.btnescalte1.Click += new System.EventHandler(this.btnescalte1_Click);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEmployeeID.Location = new System.Drawing.Point(332, 164);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(151, 29);
            this.lblEmployeeID.TabIndex = 6;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // lblEscalte
            // 
            this.lblEscalte.AutoSize = true;
            this.lblEscalte.BackColor = System.Drawing.Color.Transparent;
            this.lblEscalte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEscalte.Location = new System.Drawing.Point(895, 164);
            this.lblEscalte.Name = "lblEscalte";
            this.lblEscalte.Size = new System.Drawing.Size(92, 29);
            this.lblEscalte.TabIndex = 10;
            this.lblEscalte.Text = "Escalte";
            // 
            // btnSubmitEmp
            // 
            this.btnSubmitEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(205)))));
            this.btnSubmitEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSubmitEmp.Location = new System.Drawing.Point(337, 267);
            this.btnSubmitEmp.Name = "btnSubmitEmp";
            this.btnSubmitEmp.Size = new System.Drawing.Size(140, 50);
            this.btnSubmitEmp.TabIndex = 8;
            this.btnSubmitEmp.Text = "Submit";
            this.btnSubmitEmp.UseVisualStyleBackColor = false;
            this.btnSubmitEmp.Click += new System.EventHandler(this.btnSubmitEmp_Click);
            // 
            // cbescalte
            // 
            this.cbescalte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbescalte.FormattingEnabled = true;
            this.cbescalte.Location = new System.Drawing.Point(806, 209);
            this.cbescalte.Name = "cbescalte";
            this.cbescalte.Size = new System.Drawing.Size(263, 37);
            this.cbescalte.TabIndex = 9;
            this.cbescalte.Text = "...";
            // 
            // cbEmployeeID
            // 
            this.cbEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbEmployeeID.FormattingEnabled = true;
            this.cbEmployeeID.Location = new System.Drawing.Point(278, 209);
            this.cbEmployeeID.Name = "cbEmployeeID";
            this.cbEmployeeID.Size = new System.Drawing.Size(263, 37);
            this.cbEmployeeID.TabIndex = 7;
            // 
            // lbTrackJob
            // 
            this.lbTrackJob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTrackJob.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrackJob.FormattingEnabled = true;
            this.lbTrackJob.ItemHeight = 42;
            this.lbTrackJob.Location = new System.Drawing.Point(10, 10);
            this.lbTrackJob.Name = "lbTrackJob";
            this.lbTrackJob.Size = new System.Drawing.Size(1360, 528);
            this.lbTrackJob.TabIndex = 4;
            // 
            // pnlContent3
            // 
            this.pnlContent3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.pnlContent3.Controls.Add(this.button2);
            this.pnlContent3.Controls.Add(this.lnlCustomerID);
            this.pnlContent3.Controls.Add(this.txtCustomerID);
            this.pnlContent3.Controls.Add(this.cbpriority);
            this.pnlContent3.Controls.Add(this.lblPriority);
            this.pnlContent3.Controls.Add(this.cbService);
            this.pnlContent3.Controls.Add(this.lblService);
            this.pnlContent3.Controls.Add(this.textBox1);
            this.pnlContent3.Controls.Add(this.lblNote);
            this.pnlContent3.Controls.Add(this.btnClose);
            this.pnlContent3.Controls.Add(this.dgvAlljobs);
            this.pnlContent3.Location = new System.Drawing.Point(7, 20);
            this.pnlContent3.Name = "pnlContent3";
            this.pnlContent3.Size = new System.Drawing.Size(1360, 528);
            this.pnlContent3.TabIndex = 14;
            // 
            // dgvAlljobs
            // 
            this.dgvAlljobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlljobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlljobs.Location = new System.Drawing.Point(0, 0);
            this.dgvAlljobs.Name = "dgvAlljobs";
            this.dgvAlljobs.RowHeadersWidth = 51;
            this.dgvAlljobs.RowTemplate.Height = 24;
            this.dgvAlljobs.Size = new System.Drawing.Size(1360, 528);
            this.dgvAlljobs.TabIndex = 0;
            this.dgvAlljobs.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAlljobs_RowHeaderMouseClick);
            // 
            // btnWork
            // 
            this.btnWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(205)))));
            this.btnWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnWork.Location = new System.Drawing.Point(735, 33);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(199, 55);
            this.btnWork.TabIndex = 45;
            this.btnWork.Text = "Packages";
            this.btnWork.UseVisualStyleBackColor = false;
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(205)))));
            this.btnClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnClient.Location = new System.Drawing.Point(556, 33);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(152, 55);
            this.btnClient.TabIndex = 44;
            this.btnClient.Text = "Client";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(205)))));
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnLogOut.Location = new System.Drawing.Point(1719, 33);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(152, 55);
            this.btnLogOut.TabIndex = 43;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnDepartment
            // 
            this.btnDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(205)))));
            this.btnDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnDepartment.Location = new System.Drawing.Point(963, 33);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(233, 55);
            this.btnDepartment.TabIndex = 42;
            this.btnDepartment.Text = "Department";
            this.btnDepartment.UseVisualStyleBackColor = false;
            // 
            // pnlContent1
            // 
            this.pnlContent1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.pnlContent1.Controls.Add(this.lblContent2);
            this.pnlContent1.Controls.Add(this.label2);
            this.pnlContent1.Controls.Add(this.lblContent1);
            this.pnlContent1.Controls.Add(this.button1);
            this.pnlContent1.Controls.Add(this.label3);
            this.pnlContent1.Controls.Add(this.btnLogJob);
            this.pnlContent1.Controls.Add(this.btnTrackJob);
            this.pnlContent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent1.Location = new System.Drawing.Point(10, 10);
            this.pnlContent1.Name = "pnlContent1";
            this.pnlContent1.Padding = new System.Windows.Forms.Padding(7);
            this.pnlContent1.Size = new System.Drawing.Size(328, 710);
            this.pnlContent1.TabIndex = 50;
            // 
            // lblContent2
            // 
            this.lblContent2.AutoSize = true;
            this.lblContent2.BackColor = System.Drawing.Color.Transparent;
            this.lblContent2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblContent2.Location = new System.Drawing.Point(117, 106);
            this.lblContent2.Name = "lblContent2";
            this.lblContent2.Size = new System.Drawing.Size(97, 29);
            this.lblContent2.TabIndex = 52;
            this.lblContent2.Text = "Options";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label2.Location = new System.Drawing.Point(78, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 4);
            this.label2.TabIndex = 51;
            // 
            // lblContent1
            // 
            this.lblContent1.AutoSize = true;
            this.lblContent1.BackColor = System.Drawing.Color.Transparent;
            this.lblContent1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblContent1.Location = new System.Drawing.Point(83, 52);
            this.lblContent1.Name = "lblContent1";
            this.lblContent1.Size = new System.Drawing.Size(173, 36);
            this.lblContent1.TabIndex = 50;
            this.lblContent1.Text = "Peter Jones";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(205)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(30, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 70);
            this.button1.TabIndex = 49;
            this.button1.Text = "Manage Job";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 10;
            // 
            // btnLogJob
            // 
            this.btnLogJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(205)))));
            this.btnLogJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogJob.Location = new System.Drawing.Point(30, 474);
            this.btnLogJob.Name = "btnLogJob";
            this.btnLogJob.Size = new System.Drawing.Size(270, 70);
            this.btnLogJob.TabIndex = 8;
            this.btnLogJob.Text = "Log Job";
            this.btnLogJob.UseVisualStyleBackColor = false;
            this.btnLogJob.Click += new System.EventHandler(this.btnescalte_Click);
            // 
            // btnTrackJob
            // 
            this.btnTrackJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(205)))));
            this.btnTrackJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrackJob.Location = new System.Drawing.Point(30, 340);
            this.btnTrackJob.Name = "btnTrackJob";
            this.btnTrackJob.Size = new System.Drawing.Size(270, 70);
            this.btnTrackJob.TabIndex = 7;
            this.btnTrackJob.Text = "Track Job";
            this.btnTrackJob.UseVisualStyleBackColor = false;
            this.btnTrackJob.Click += new System.EventHandler(this.btnTrackJob_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = global::SEN371_Project.Properties.Resources.Profile_Pic_3;
            this.pictureBox3.Location = new System.Drawing.Point(1608, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SEN371_Project.Properties.Resources.Premier_Service_Solutions_540_110_px_Final;
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.AutoSize = true;
            this.pnlHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(112)))));
            this.pnlHeader.Controls.Add(this.btnWork);
            this.pnlHeader.Controls.Add(this.btnDepartment);
            this.pnlHeader.Controls.Add(this.btnClient);
            this.pnlHeader.Controls.Add(this.pictureBox3);
            this.pnlHeader.Controls.Add(this.btnLogOut);
            this.pnlHeader.Controls.Add(this.pnlBR4);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(3);
            this.pnlHeader.Size = new System.Drawing.Size(1924, 117);
            this.pnlHeader.TabIndex = 51;
            // 
            // pnlBR4
            // 
            this.pnlBR4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pnlBR4.Controls.Add(this.pictureBox1);
            this.pnlBR4.Location = new System.Drawing.Point(9, 9);
            this.pnlBR4.Name = "pnlBR4";
            this.pnlBR4.Padding = new System.Windows.Forms.Padding(7);
            this.pnlBR4.Size = new System.Drawing.Size(526, 102);
            this.pnlBR4.TabIndex = 46;
            // 
            // pnlBR1
            // 
            this.pnlBR1.Controls.Add(this.pnlContent1);
            this.pnlBR1.Location = new System.Drawing.Point(25, 150);
            this.pnlBR1.Name = "pnlBR1";
            this.pnlBR1.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBR1.Size = new System.Drawing.Size(348, 730);
            this.pnlBR1.TabIndex = 52;
            // 
            // pnlBR2
            // 
            this.pnlBR2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pnlBR2.Controls.Add(this.pnlContent2);
            this.pnlBR2.Location = new System.Drawing.Point(426, 150);
            this.pnlBR2.Name = "pnlBR2";
            this.pnlBR2.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBR2.Size = new System.Drawing.Size(1459, 800);
            this.pnlBR2.TabIndex = 14;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(203, 90);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(82, 32);
            this.lblNote.TabIndex = 14;
            this.lblNote.Text = "Note:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 125);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(577, 101);
            this.textBox1.TabIndex = 15;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(203, 229);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(109, 32);
            this.lblService.TabIndex = 16;
            this.lblService.Text = "Service";
            // 
            // cbService
            // 
            this.cbService.FormattingEnabled = true;
            this.cbService.Location = new System.Drawing.Point(197, 279);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(577, 24);
            this.cbService.TabIndex = 17;
            this.cbService.Text = "Please Enter customerID to see service availability";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.Location = new System.Drawing.Point(203, 327);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(103, 32);
            this.lblPriority.TabIndex = 18;
            this.lblPriority.Text = "Priority";
            // 
            // cbpriority
            // 
            this.cbpriority.FormattingEnabled = true;
            this.cbpriority.Location = new System.Drawing.Point(209, 371);
            this.cbpriority.Name = "cbpriority";
            this.cbpriority.Size = new System.Drawing.Size(577, 24);
            this.cbpriority.TabIndex = 20;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(197, 65);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(577, 22);
            this.txtCustomerID.TabIndex = 21;
            this.txtCustomerID.TextChanged += new System.EventHandler(this.txtCustomerID_TextChanged);
            // 
            // lnlCustomerID
            // 
            this.lnlCustomerID.AutoSize = true;
            this.lnlCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlCustomerID.Location = new System.Drawing.Point(203, 18);
            this.lnlCustomerID.Name = "lnlCustomerID";
            this.lnlCustomerID.Size = new System.Drawing.Size(178, 32);
            this.lnlCustomerID.TabIndex = 22;
            this.lnlCustomerID.Text = "Customer ID:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(205)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button2.Location = new System.Drawing.Point(209, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 60);
            this.button2.TabIndex = 15;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::SEN371_Project.Properties.Resources.Wall_UnSat__1_;
            this.ClientSize = new System.Drawing.Size(1924, 1000);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlBR1);
            this.Controls.Add(this.pnlBR2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Name = "frmServices";
            this.Text = "Services Depmartment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.pnlContent2.ResumeLayout(false);
            this.pnlContent2.PerformLayout();
            this.pnlBR3.ResumeLayout(false);
            this.pnlBR3.PerformLayout();
            this.pnlContent3.ResumeLayout(false);
            this.pnlContent3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlljobs)).EndInit();
            this.pnlContent1.ResumeLayout(false);
            this.pnlContent1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlBR4.ResumeLayout(false);
            this.pnlBR1.ResumeLayout(false);
            this.pnlBR2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlContent2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnlContent1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogJob;
        private System.Windows.Forms.Button btnTrackJob;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtJobid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblContent1;
        private System.Windows.Forms.Label lblContent2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlBR1;
        private System.Windows.Forms.Panel pnlBR4;
        private System.Windows.Forms.Panel pnlBR2;
        private System.Windows.Forms.Panel pnlBR3;
        private System.Windows.Forms.ListBox lbTrackJob;
        private System.Windows.Forms.Button btnescalte1;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblEscalte;
        private System.Windows.Forms.Button btnSubmitEmp;
        private System.Windows.Forms.ComboBox cbescalte;
        private System.Windows.Forms.ComboBox cbEmployeeID;
        private System.Windows.Forms.Panel pnlContent3;
        private System.Windows.Forms.DataGridView dgvAlljobs;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cbService;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.ComboBox cbpriority;
        private System.Windows.Forms.Label lnlCustomerID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Button button2;
    }
}