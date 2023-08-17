
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCallCentre));
            this.btnWork = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.pnlContent2 = new System.Windows.Forms.Panel();
            this.btnCallSimulation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContent3 = new System.Windows.Forms.Panel();
            this.CBService1 = new System.Windows.Forms.ComboBox();
            this.btnredirect = new System.Windows.Forms.Button();
            this.lblRedirect = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.CBPriority = new System.Windows.Forms.ComboBox();
            this.lblServie = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.cbRedirect = new System.Windows.Forms.ComboBox();
            this.lbCustomer = new System.Windows.Forms.ListBox();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pnlContent1 = new System.Windows.Forms.Panel();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.btnViewServices = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlBR4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlBR1 = new System.Windows.Forms.Panel();
            this.pnlBR2 = new System.Windows.Forms.Panel();
            this.pnlBR3 = new System.Windows.Forms.Panel();
            this.pnlContent2.SuspendLayout();
            this.pnlContent3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.pnlContent1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlBR4.SuspendLayout();
            this.pnlBR1.SuspendLayout();
            this.pnlBR2.SuspendLayout();
            this.pnlBR3.SuspendLayout();
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
            // pnlContent2
            // 
            this.pnlContent2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.pnlContent2.Controls.Add(this.btnCallSimulation);
            this.pnlContent2.Controls.Add(this.label2);
            this.pnlContent2.Controls.Add(this.txtCustomerID);
            this.pnlContent2.Controls.Add(this.lblTitle);
            this.pnlContent2.Controls.Add(this.pnlBR3);
            this.pnlContent2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent2.Location = new System.Drawing.Point(10, 10);
            this.pnlContent2.Name = "pnlContent2";
            this.pnlContent2.Size = new System.Drawing.Size(1439, 780);
            this.pnlContent2.TabIndex = 48;
            this.pnlContent2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlWork_Paint);
            // 
            // btnCallSimulation
            // 
            this.btnCallSimulation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(205)))));
            this.btnCallSimulation.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCallSimulation.FlatAppearance.BorderSize = 0;
            this.btnCallSimulation.ForeColor = System.Drawing.Color.Black;
            this.btnCallSimulation.Location = new System.Drawing.Point(655, 7);
            this.btnCallSimulation.Name = "btnCallSimulation";
            this.btnCallSimulation.Size = new System.Drawing.Size(119, 43);
            this.btnCallSimulation.TabIndex = 55;
            this.btnCallSimulation.Text = "Call Simulation";
            this.btnCallSimulation.UseVisualStyleBackColor = false;
            this.btnCallSimulation.Click += new System.EventHandler(this.btnCallSimulation_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 53;
            this.label2.Text = "Customer ID:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(125, 24);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(121, 22);
            this.txtCustomerID.TabIndex = 5;
            this.txtCustomerID.TextChanged += new System.EventHandler(this.initalizeVars);
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
            // pnlContent3
            // 
            this.pnlContent3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.pnlContent3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlContent3.Controls.Add(this.CBService1);
            this.pnlContent3.Controls.Add(this.btnredirect);
            this.pnlContent3.Controls.Add(this.lblRedirect);
            this.pnlContent3.Controls.Add(this.btnSubmit);
            this.pnlContent3.Controls.Add(this.CBPriority);
            this.pnlContent3.Controls.Add(this.lblServie);
            this.pnlContent3.Controls.Add(this.lblNote);
            this.pnlContent3.Controls.Add(this.lblPriority);
            this.pnlContent3.Controls.Add(this.cbRedirect);
            this.pnlContent3.Controls.Add(this.lbCustomer);
            this.pnlContent3.Controls.Add(this.dgvHistory);
            this.pnlContent3.Controls.Add(this.txtNote);
            this.pnlContent3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent3.Location = new System.Drawing.Point(10, 10);
            this.pnlContent3.Name = "pnlContent3";
            this.pnlContent3.Size = new System.Drawing.Size(1360, 528);
            this.pnlContent3.TabIndex = 3;
            // 
            // CBService1
            // 
            this.CBService1.FormattingEnabled = true;
            this.CBService1.Location = new System.Drawing.Point(124, 201);
            this.CBService1.Name = "CBService1";
            this.CBService1.Size = new System.Drawing.Size(477, 24);
            this.CBService1.TabIndex = 12;
            // 
            // btnredirect
            // 
            this.btnredirect.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnredirect.Location = new System.Drawing.Point(188, 168);
            this.btnredirect.Name = "btnredirect";
            this.btnredirect.Size = new System.Drawing.Size(116, 43);
            this.btnredirect.TabIndex = 11;
            this.btnredirect.Text = "Redirect";
            this.btnredirect.UseVisualStyleBackColor = true;
            this.btnredirect.Click += new System.EventHandler(this.btnredirect_Click);
            // 
            // lblRedirect
            // 
            this.lblRedirect.AutoSize = true;
            this.lblRedirect.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedirect.Location = new System.Drawing.Point(187, 104);
            this.lblRedirect.Name = "lblRedirect";
            this.lblRedirect.Size = new System.Drawing.Size(104, 20);
            this.lblRedirect.TabIndex = 9;
            this.lblRedirect.Text = "Redirect Call";
            this.lblRedirect.Click += new System.EventHandler(this.lblRedirect_Click);
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
            // CBPriority
            // 
            this.CBPriority.FormattingEnabled = true;
            this.CBPriority.Location = new System.Drawing.Point(124, 275);
            this.CBPriority.Name = "CBPriority";
            this.CBPriority.Size = new System.Drawing.Size(477, 24);
            this.CBPriority.TabIndex = 5;
            // 
            // lblServie
            // 
            this.lblServie.AutoSize = true;
            this.lblServie.Location = new System.Drawing.Point(121, 179);
            this.lblServie.Name = "lblServie";
            this.lblServie.Size = new System.Drawing.Size(53, 16);
            this.lblServie.TabIndex = 2;
            this.lblServie.Text = "Service";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(121, 66);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(36, 16);
            this.lblNote.TabIndex = 1;
            this.lblNote.Text = "Note";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(121, 256);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(48, 16);
            this.lblPriority.TabIndex = 0;
            this.lblPriority.Text = "Priority";
            // 
            // cbRedirect
            // 
            this.cbRedirect.FormattingEnabled = true;
            this.cbRedirect.Location = new System.Drawing.Point(188, 132);
            this.cbRedirect.Name = "cbRedirect";
            this.cbRedirect.Size = new System.Drawing.Size(213, 24);
            this.cbRedirect.TabIndex = 10;
            // 
            // lbCustomer
            // 
            this.lbCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCustomer.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomer.FormattingEnabled = true;
            this.lbCustomer.ItemHeight = 31;
            this.lbCustomer.Location = new System.Drawing.Point(0, 0);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(1356, 524);
            this.lbCustomer.TabIndex = 7;
            // 
            // dgvHistory
            // 
            this.dgvHistory.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.RowHeadersWidth = 51;
            this.dgvHistory.RowTemplate.Height = 24;
            this.dgvHistory.Size = new System.Drawing.Size(1356, 524);
            this.dgvHistory.TabIndex = 13;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(124, 83);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(477, 79);
            this.txtNote.TabIndex = 3;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(205)))));
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnLogOut.Location = new System.Drawing.Point(1719, 33);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(152, 55);
            this.btnLogOut.TabIndex = 53;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pnlContent1
            // 
            this.pnlContent1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.pnlContent1.Controls.Add(this.label3);
            this.pnlContent1.Controls.Add(this.btnCustomer);
            this.pnlContent1.Controls.Add(this.button3);
            this.pnlContent1.Controls.Add(this.label1);
            this.pnlContent1.Controls.Add(this.lblEmpName);
            this.pnlContent1.Controls.Add(this.btnViewServices);
            this.pnlContent1.Controls.Add(this.button5);
            this.pnlContent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent1.Location = new System.Drawing.Point(10, 10);
            this.pnlContent1.Name = "pnlContent1";
            this.pnlContent1.Size = new System.Drawing.Size(328, 710);
            this.pnlContent1.TabIndex = 57;
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(205)))));
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCustomer.Location = new System.Drawing.Point(30, 608);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(270, 70);
            this.btnCustomer.TabIndex = 13;
            this.btnCustomer.Text = "View Customer";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(205)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button3.Location = new System.Drawing.Point(30, 474);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(270, 70);
            this.button3.TabIndex = 12;
            this.button3.Text = "Tranfer Call";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(117, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Options";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblEmpName.Location = new System.Drawing.Point(83, 52);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(173, 36);
            this.lblEmpName.TabIndex = 10;
            this.lblEmpName.Text = "Peter Jones";
            // 
            // btnViewServices
            // 
            this.btnViewServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(205)))));
            this.btnViewServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnViewServices.Location = new System.Drawing.Point(30, 205);
            this.btnViewServices.Name = "btnViewServices";
            this.btnViewServices.Size = new System.Drawing.Size(270, 70);
            this.btnViewServices.TabIndex = 8;
            this.btnViewServices.Text = "Call History";
            this.btnViewServices.UseVisualStyleBackColor = false;
            this.btnViewServices.Click += new System.EventHandler(this.btnViewServices_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(205)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button5.Location = new System.Drawing.Point(30, 340);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(270, 70);
            this.button5.TabIndex = 7;
            this.button5.Text = "Log Issue";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(205)))));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button7.Location = new System.Drawing.Point(840, 33);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(190, 55);
            this.button7.TabIndex = 60;
            this.button7.Text = "Services";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(205)))));
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button8.Location = new System.Drawing.Point(556, 33);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(245, 55);
            this.button8.TabIndex = 59;
            this.button8.Text = "Management";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(205)))));
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button9.Location = new System.Drawing.Point(1069, 33);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(209, 55);
            this.button9.TabIndex = 58;
            this.button9.Text = "Packages";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(112)))));
            this.pictureBox5.Image = global::SEN371_Project.Properties.Resources.Profile_Pic_3;
            this.pictureBox5.Location = new System.Drawing.Point(1608, 9);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 100);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 61;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(10, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(506, 82);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 50;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-107, -104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.AutoSize = true;
            this.pnlHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(112)))));
            this.pnlHeader.Controls.Add(this.pnlBR4);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(3);
            this.pnlHeader.Size = new System.Drawing.Size(1924, 117);
            this.pnlHeader.TabIndex = 62;
            // 
            // pnlBR4
            // 
            this.pnlBR4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pnlBR4.Controls.Add(this.pictureBox4);
            this.pnlBR4.Location = new System.Drawing.Point(9, 9);
            this.pnlBR4.Name = "pnlBR4";
            this.pnlBR4.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBR4.Size = new System.Drawing.Size(526, 102);
            this.pnlBR4.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label3.Location = new System.Drawing.Point(78, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 4);
            this.label3.TabIndex = 14;
            // 
            // pnlBR1
            // 
            this.pnlBR1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pnlBR1.Controls.Add(this.pnlContent1);
            this.pnlBR1.Location = new System.Drawing.Point(25, 150);
            this.pnlBR1.Name = "pnlBR1";
            this.pnlBR1.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBR1.Size = new System.Drawing.Size(348, 730);
            this.pnlBR1.TabIndex = 63;
            // 
            // pnlBR2
            // 
            this.pnlBR2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pnlBR2.Controls.Add(this.pnlContent2);
            this.pnlBR2.Location = new System.Drawing.Point(426, 150);
            this.pnlBR2.Name = "pnlBR2";
            this.pnlBR2.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBR2.Size = new System.Drawing.Size(1459, 800);
            this.pnlBR2.TabIndex = 64;
            // 
            // pnlBR3
            // 
            this.pnlBR3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pnlBR3.Controls.Add(this.pnlContent3);
            this.pnlBR3.Location = new System.Drawing.Point(28, 205);
            this.pnlBR3.Name = "pnlBR3";
            this.pnlBR3.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBR3.Size = new System.Drawing.Size(1380, 548);
            this.pnlBR3.TabIndex = 65;
            // 
            // frmCallCentre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::SEN371_Project.Properties.Resources.Wall_UnSat__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1000);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnDepartment);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlBR1);
            this.Controls.Add(this.pnlBR2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Name = "frmCallCentre";
            this.Text = "CallCentre";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCallCentre_Load);
            this.pnlContent2.ResumeLayout(false);
            this.pnlContent2.PerformLayout();
            this.pnlContent3.ResumeLayout(false);
            this.pnlContent3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.pnlContent1.ResumeLayout(false);
            this.pnlContent1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlBR4.ResumeLayout(false);
            this.pnlBR1.ResumeLayout(false);
            this.pnlBR2.ResumeLayout(false);
            this.pnlBR3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlContent2;
        private System.Windows.Forms.Panel pnlContent3;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel pnlContent1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmpName;
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
        private System.Windows.Forms.ListBox lbCustomer;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox CBPriority;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblServie;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox CBService1;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnCallSimulation;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlBR4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlBR1;
        private System.Windows.Forms.Panel pnlBR2;
        private System.Windows.Forms.Panel pnlBR3;
    }
}