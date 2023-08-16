
namespace SEN371_Project
{
    partial class frmPackages
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPackages));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnViewServices = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pnlWork = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvServies = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.serviceinPackagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.txtAvailability = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.cbSALID = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblPackagesName = new System.Windows.Forms.Label();
            this.lblAvailablity = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSLAID = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddServices = new System.Windows.Forms.Button();
            this.clbServices = new System.Windows.Forms.CheckedListBox();
            this.lblPackages = new System.Windows.Forms.Label();
            this.lblMaintance = new System.Windows.Forms.Label();
            this.lblDifficultyMeasure = new System.Windows.Forms.Label();
            this.lblPrices = new System.Windows.Forms.Label();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.lblTask = new System.Windows.Forms.Label();
            this.lblDesciption = new System.Windows.Forms.Label();
            this.lblTools = new System.Windows.Forms.Label();
            this.cbdifficult = new System.Windows.Forms.ComboBox();
            this.cbMaintances = new System.Windows.Forms.ComboBox();
            this.cbfrequency = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.TextBox();
            this.txttools = new System.Windows.Forms.TextBox();
            this.btnSubmitService = new System.Windows.Forms.Button();
            this.txttask = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlWork.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceinPackagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddServices);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblEmpName);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnViewServices);
            this.panel1.Location = new System.Drawing.Point(19, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 472);
            this.panel1.TabIndex = 66;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox7.Image = global::SEN371_Project.Properties.Resources.download__2_;
            this.pictureBox7.Location = new System.Drawing.Point(3, 170);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(60, 43);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 66;
            this.pictureBox7.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(37, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 43);
            this.button3.TabIndex = 65;
            this.button3.Text = "Services offered";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox6.Image = global::SEN371_Project.Properties.Resources.download__1_1;
            this.pictureBox6.Location = new System.Drawing.Point(3, 252);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(60, 44);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 64;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::SEN371_Project.Properties.Resources.download__2_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.button4.Location = new System.Drawing.Point(37, 252);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 44);
            this.button4.TabIndex = 9;
            this.button4.Text = "Delete Packages";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnViewServices
            // 
            this.btnViewServices.Location = new System.Drawing.Point(37, 96);
            this.btnViewServices.Name = "btnViewServices";
            this.btnViewServices.Size = new System.Drawing.Size(177, 43);
            this.btnViewServices.TabIndex = 8;
            this.btnViewServices.Text = "View Packages";
            this.btnViewServices.UseVisualStyleBackColor = true;
            this.btnViewServices.Click += new System.EventHandler(this.btnViewServices_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 52);
            this.button1.TabIndex = 65;
            this.button1.Text = "Work";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(265, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 52);
            this.button2.TabIndex = 64;
            this.button2.Text = "Client";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(836, -1);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(114, 52);
            this.btnLogOut.TabIndex = 63;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(485, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 52);
            this.button6.TabIndex = 62;
            this.button6.Text = "Department";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // pnlWork
            // 
            this.pnlWork.Controls.Add(this.label10);
            this.pnlWork.Controls.Add(this.panel3);
            this.pnlWork.Controls.Add(this.label2);
            this.pnlWork.Location = new System.Drawing.Point(265, 75);
            this.pnlWork.Name = "pnlWork";
            this.pnlWork.Size = new System.Drawing.Size(676, 508);
            this.pnlWork.TabIndex = 59;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(159, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(451, 35);
            this.label10.TabIndex = 10;
            this.label10.Text = "Welcome to your Client portal page!";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnSubmitService);
            this.panel3.Controls.Add(this.txttask);
            this.panel3.Controls.Add(this.txttools);
            this.panel3.Controls.Add(this.lblDescription);
            this.panel3.Controls.Add(this.txtPrice);
            this.panel3.Controls.Add(this.cbfrequency);
            this.panel3.Controls.Add(this.cbMaintances);
            this.panel3.Controls.Add(this.cbdifficult);
            this.panel3.Controls.Add(this.lblTools);
            this.panel3.Controls.Add(this.lblDesciption);
            this.panel3.Controls.Add(this.lblTask);
            this.panel3.Controls.Add(this.lblFrequency);
            this.panel3.Controls.Add(this.lblPrices);
            this.panel3.Controls.Add(this.lblDifficultyMeasure);
            this.panel3.Controls.Add(this.lblMaintance);
            this.panel3.Controls.Add(this.lblPackages);
            this.panel3.Controls.Add(this.clbServices);
            this.panel3.Controls.Add(this.lblSLAID);
            this.panel3.Controls.Add(this.lblDiscount);
            this.panel3.Controls.Add(this.lblAvailablity);
            this.panel3.Controls.Add(this.lblPackagesName);
            this.panel3.Controls.Add(this.btnSubmit);
            this.panel3.Controls.Add(this.cbSALID);
            this.panel3.Controls.Add(this.txtDiscount);
            this.panel3.Controls.Add(this.txtAvailability);
            this.panel3.Controls.Add(this.txtPackageName);
            this.panel3.Controls.Add(this.dgvServies);
            this.panel3.Location = new System.Drawing.Point(18, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(634, 416);
            this.panel3.TabIndex = 3;
            // 
            // dgvServies
            // 
            this.dgvServies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServies.Location = new System.Drawing.Point(-1, 2);
            this.dgvServies.Margin = new System.Windows.Forms.Padding(2);
            this.dgvServies.Name = "dgvServies";
            this.dgvServies.RowHeadersWidth = 51;
            this.dgvServies.RowTemplate.Height = 24;
            this.dgvServies.Size = new System.Drawing.Size(633, 416);
            this.dgvServies.TabIndex = 0;
            this.dgvServies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServies_CellContentClick);
            this.dgvServies.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServies_CellEnter);
            this.dgvServies.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServies_CellValueChanged);
            this.dgvServies.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvServies_RowHeaderMouseClick);
            this.dgvServies.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServies_RowLeave);
            this.dgvServies.EnabledChanged += new System.EventHandler(this.dgvServies_EnabledChanged);
            this.dgvServies.Enter += new System.EventHandler(this.dgvServies_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "THIS IS THE PACKAGES DEPARTMENT";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(751, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(79, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 61;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(246, 54);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 60;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-2, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1028, 562);
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // serviceinPackagesBindingSource
            // 
            this.serviceinPackagesBindingSource.DataMember = "ServiceinPackages";
            // 
            // packagesBindingSource
            // 
            this.packagesBindingSource.DataMember = "Packages";
            // 
            // txtPackageName
            // 
            this.txtPackageName.Location = new System.Drawing.Point(136, 34);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(319, 23);
            this.txtPackageName.TabIndex = 1;
            // 
            // txtAvailability
            // 
            this.txtAvailability.Location = new System.Drawing.Point(136, 96);
            this.txtAvailability.Name = "txtAvailability";
            this.txtAvailability.Size = new System.Drawing.Size(319, 23);
            this.txtAvailability.TabIndex = 2;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(136, 141);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(319, 23);
            this.txtDiscount.TabIndex = 3;
            // 
            // cbSALID
            // 
            this.cbSALID.FormattingEnabled = true;
            this.cbSALID.Location = new System.Drawing.Point(136, 195);
            this.cbSALID.Name = "cbSALID";
            this.cbSALID.Size = new System.Drawing.Size(319, 24);
            this.cbSALID.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(222, 322);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(134, 66);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblPackagesName
            // 
            this.lblPackagesName.AutoSize = true;
            this.lblPackagesName.Location = new System.Drawing.Point(133, 15);
            this.lblPackagesName.Name = "lblPackagesName";
            this.lblPackagesName.Size = new System.Drawing.Size(97, 16);
            this.lblPackagesName.TabIndex = 6;
            this.lblPackagesName.Text = "Packages Name";
            // 
            // lblAvailablity
            // 
            this.lblAvailablity.AutoSize = true;
            this.lblAvailablity.Location = new System.Drawing.Point(133, 76);
            this.lblAvailablity.Name = "lblAvailablity";
            this.lblAvailablity.Size = new System.Drawing.Size(64, 16);
            this.lblAvailablity.TabIndex = 7;
            this.lblAvailablity.Text = "Availablity";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(133, 122);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(58, 16);
            this.lblDiscount.TabIndex = 8;
            this.lblDiscount.Text = "Discount";
            // 
            // lblSLAID
            // 
            this.lblSLAID.AutoSize = true;
            this.lblSLAID.Location = new System.Drawing.Point(133, 172);
            this.lblSLAID.Name = "lblSLAID";
            this.lblSLAID.Size = new System.Drawing.Size(47, 16);
            this.lblSLAID.TabIndex = 9;
            this.lblSLAID.Text = "SLAID";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 324);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(211, 43);
            this.btnAdd.TabIndex = 67;
            this.btnAdd.Text = "Packages Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddServices
            // 
            this.btnAddServices.Location = new System.Drawing.Point(3, 389);
            this.btnAddServices.Name = "btnAddServices";
            this.btnAddServices.Size = new System.Drawing.Size(211, 43);
            this.btnAddServices.TabIndex = 68;
            this.btnAddServices.Text = "Packages Add";
            this.btnAddServices.UseVisualStyleBackColor = true;
            this.btnAddServices.Click += new System.EventHandler(this.button5_Click);
            // 
            // clbServices
            // 
            this.clbServices.FormattingEnabled = true;
            this.clbServices.Location = new System.Drawing.Point(136, 249);
            this.clbServices.Name = "clbServices";
            this.clbServices.Size = new System.Drawing.Size(329, 58);
            this.clbServices.TabIndex = 10;
            // 
            // lblPackages
            // 
            this.lblPackages.AutoSize = true;
            this.lblPackages.Location = new System.Drawing.Point(133, 230);
            this.lblPackages.Name = "lblPackages";
            this.lblPackages.Size = new System.Drawing.Size(120, 16);
            this.lblPackages.TabIndex = 11;
            this.lblPackages.Text = "Service in Packages";
            // 
            // lblMaintance
            // 
            this.lblMaintance.AutoSize = true;
            this.lblMaintance.Location = new System.Drawing.Point(133, 15);
            this.lblMaintance.Name = "lblMaintance";
            this.lblMaintance.Size = new System.Drawing.Size(103, 16);
            this.lblMaintance.TabIndex = 12;
            this.lblMaintance.Text = "Maintances Type";
            // 
            // lblDifficultyMeasure
            // 
            this.lblDifficultyMeasure.AutoSize = true;
            this.lblDifficultyMeasure.Location = new System.Drawing.Point(133, 77);
            this.lblDifficultyMeasure.Name = "lblDifficultyMeasure";
            this.lblDifficultyMeasure.Size = new System.Drawing.Size(106, 16);
            this.lblDifficultyMeasure.TabIndex = 13;
            this.lblDifficultyMeasure.Text = "Difficult Measure";
            // 
            // lblPrices
            // 
            this.lblPrices.AutoSize = true;
            this.lblPrices.Location = new System.Drawing.Point(138, 122);
            this.lblPrices.Name = "lblPrices";
            this.lblPrices.Size = new System.Drawing.Size(42, 16);
            this.lblPrices.TabIndex = 14;
            this.lblPrices.Text = "Prices";
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Location = new System.Drawing.Point(138, 172);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(67, 16);
            this.lblFrequency.TabIndex = 15;
            this.lblFrequency.Text = "Frequency";
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Location = new System.Drawing.Point(138, 222);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(34, 16);
            this.lblTask.TabIndex = 16;
            this.lblTask.Text = "Task";
            // 
            // lblDesciption
            // 
            this.lblDesciption.AutoSize = true;
            this.lblDesciption.Location = new System.Drawing.Point(138, 276);
            this.lblDesciption.Name = "lblDesciption";
            this.lblDesciption.Size = new System.Drawing.Size(72, 16);
            this.lblDesciption.TabIndex = 17;
            this.lblDesciption.Text = "Description";
            this.lblDesciption.Click += new System.EventHandler(this.lblDesciption_Click);
            // 
            // lblTools
            // 
            this.lblTools.AutoSize = true;
            this.lblTools.Location = new System.Drawing.Point(138, 322);
            this.lblTools.Name = "lblTools";
            this.lblTools.Size = new System.Drawing.Size(116, 16);
            this.lblTools.TabIndex = 18;
            this.lblTools.Text = "Tools and materials";
            // 
            // cbdifficult
            // 
            this.cbdifficult.FormattingEnabled = true;
            this.cbdifficult.Items.AddRange(new object[] {
            "Easy",
            "Medium ",
            "Hard"});
            this.cbdifficult.Location = new System.Drawing.Point(136, 95);
            this.cbdifficult.Name = "cbdifficult";
            this.cbdifficult.Size = new System.Drawing.Size(319, 24);
            this.cbdifficult.TabIndex = 19;
            // 
            // cbMaintances
            // 
            this.cbMaintances.FormattingEnabled = true;
            this.cbMaintances.Items.AddRange(new object[] {
            "Preventive",
            "Corrective ",
            "Predetermined ",
            "Condition-Based ",
            "Predictive "});
            this.cbMaintances.Location = new System.Drawing.Point(136, 33);
            this.cbMaintances.Name = "cbMaintances";
            this.cbMaintances.Size = new System.Drawing.Size(319, 24);
            this.cbMaintances.TabIndex = 20;
            // 
            // cbfrequency
            // 
            this.cbfrequency.FormattingEnabled = true;
            this.cbfrequency.Items.AddRange(new object[] {
            "M",
            "Y",
            "D"});
            this.cbfrequency.Location = new System.Drawing.Point(136, 195);
            this.cbfrequency.Name = "cbfrequency";
            this.cbfrequency.Size = new System.Drawing.Size(319, 24);
            this.cbfrequency.TabIndex = 21;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(136, 146);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(319, 23);
            this.txtPrice.TabIndex = 22;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(141, 295);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(319, 23);
            this.lblDescription.TabIndex = 23;
            // 
            // txttools
            // 
            this.txttools.Location = new System.Drawing.Point(141, 341);
            this.txttools.Name = "txttools";
            this.txttools.Size = new System.Drawing.Size(319, 23);
            this.txttools.TabIndex = 24;
            // 
            // btnSubmitService
            // 
            this.btnSubmitService.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitService.Location = new System.Drawing.Point(222, 380);
            this.btnSubmitService.Name = "btnSubmitService";
            this.btnSubmitService.Size = new System.Drawing.Size(134, 29);
            this.btnSubmitService.TabIndex = 25;
            this.btnSubmitService.Text = "Submit";
            this.btnSubmitService.UseVisualStyleBackColor = true;
            this.btnSubmitService.Click += new System.EventHandler(this.btnSubmitService_Click);
            // 
            // txttask
            // 
            this.txttask.Location = new System.Drawing.Point(136, 241);
            this.txttask.Name = "txttask";
            this.txttask.Size = new System.Drawing.Size(319, 23);
            this.txttask.TabIndex = 25;
            // 
            // frmPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(952, 605);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pnlWork);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPackages";
            this.Text = "Packages";
            this.Load += new System.EventHandler(this.frmPackages_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlWork.ResumeLayout(false);
            this.pnlWork.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceinPackagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnViewServices;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel pnlWork;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvServies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button button3;
        //private PremierServiceSolutionsDataSet premierServiceSolutionsDataSet;
        private System.Windows.Forms.BindingSource serviceinPackagesBindingSource;
        //private PremierServiceSolutionsDataSetTableAdapters.ServiceinPackagesTableAdapter serviceinPackagesTableAdapter;
        private System.Windows.Forms.BindingSource packagesBindingSource;
        private System.Windows.Forms.Label lblSLAID;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblAvailablity;
        private System.Windows.Forms.Label lblPackagesName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cbSALID;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtAvailability;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddServices;
        private System.Windows.Forms.Label lblPackages;
        private System.Windows.Forms.CheckedListBox clbServices;
        private System.Windows.Forms.Label lblTools;
        private System.Windows.Forms.Label lblDesciption;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.Label lblPrices;
        private System.Windows.Forms.Label lblDifficultyMeasure;
        private System.Windows.Forms.Label lblMaintance;
        private System.Windows.Forms.TextBox txttools;
        private System.Windows.Forms.TextBox lblDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cbfrequency;
        private System.Windows.Forms.ComboBox cbMaintances;
        private System.Windows.Forms.ComboBox cbdifficult;
        private System.Windows.Forms.Button btnSubmitService;
        private System.Windows.Forms.TextBox txttask;
        //private PremierServiceSolutionsDataSetTableAdapters.PackagesTableAdapter packagesTableAdapter;
    }
}