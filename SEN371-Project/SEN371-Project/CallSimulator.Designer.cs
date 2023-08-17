
namespace SEN371_Project
{
    partial class frmSimulator
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
            System.Windows.Forms.Button btnAnswer;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSimulator));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnDuration = new System.Windows.Forms.Panel();
            this.lbltimer = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.Timer(this.components);
            this.pnlContent1 = new System.Windows.Forms.Panel();
            this.pnlBR1 = new System.Windows.Forms.Panel();
            this.lblTImer2 = new System.Windows.Forms.Label();
            btnAnswer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnDuration.SuspendLayout();
            this.pnlContent1.SuspendLayout();
            this.pnlBR1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnswer
            // 
            btnAnswer.BackColor = System.Drawing.Color.Transparent;
            btnAnswer.BackgroundImage = global::SEN371_Project.Properties.Resources.awnsercall;
            btnAnswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnAnswer.FlatAppearance.BorderSize = 0;
            btnAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            btnAnswer.ForeColor = System.Drawing.SystemColors.ControlText;
            btnAnswer.Location = new System.Drawing.Point(34, 185);
            btnAnswer.Margin = new System.Windows.Forms.Padding(4);
            btnAnswer.Name = "btnAnswer";
            btnAnswer.Size = new System.Drawing.Size(100, 100);
            btnAnswer.TabIndex = 0;
            btnAnswer.UseVisualStyleBackColor = false;
            btnAnswer.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::SEN371_Project.Properties.Resources.favpng_icon;
            this.pictureBox3.Location = new System.Drawing.Point(176, 39);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(112, 82);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(101, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "You have an Incoming Call!!";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::SEN371_Project.Properties.Resources.Endcall;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(326, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pnDuration
            // 
            this.pnDuration.BackColor = System.Drawing.Color.Transparent;
            this.pnDuration.Controls.Add(this.lbltimer);
            this.pnDuration.Location = new System.Drawing.Point(34, -4);
            this.pnDuration.Name = "pnDuration";
            this.pnDuration.Size = new System.Drawing.Size(392, 36);
            this.pnDuration.TabIndex = 8;
            // 
            // lbltimer
            // 
            this.lbltimer.Location = new System.Drawing.Point(0, 0);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(100, 23);
            this.lbltimer.TabIndex = 1;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(154, -7);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(155, 39);
            this.lblDuration.TabIndex = 0;
            this.lblDuration.Text = "Duration:";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // duration
            // 
            this.duration.Interval = 1000;
            this.duration.Tick += new System.EventHandler(this.ChangeDuration);
            // 
            // pnlContent1
            // 
            this.pnlContent1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.pnlContent1.Controls.Add(this.lblTImer2);
            this.pnlContent1.Controls.Add(this.label1);
            this.pnlContent1.Controls.Add(this.pictureBox3);
            this.pnlContent1.Controls.Add(btnAnswer);
            this.pnlContent1.Controls.Add(this.lblDuration);
            this.pnlContent1.Controls.Add(this.button1);
            this.pnlContent1.Controls.Add(this.pnDuration);
            this.pnlContent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent1.Location = new System.Drawing.Point(10, 10);
            this.pnlContent1.Name = "pnlContent1";
            this.pnlContent1.Size = new System.Drawing.Size(461, 315);
            this.pnlContent1.TabIndex = 2;
            // 
            // pnlBR1
            // 
            this.pnlBR1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pnlBR1.Controls.Add(this.pnlContent1);
            this.pnlBR1.Location = new System.Drawing.Point(-1, -1);
            this.pnlBR1.Name = "pnlBR1";
            this.pnlBR1.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBR1.Size = new System.Drawing.Size(481, 335);
            this.pnlBR1.TabIndex = 9;
            // 
            // lblTImer2
            // 
            this.lblTImer2.AutoSize = true;
            this.lblTImer2.BackColor = System.Drawing.Color.Transparent;
            this.lblTImer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTImer2.Location = new System.Drawing.Point(180, 32);
            this.lblTImer2.Name = "lblTImer2";
            this.lblTImer2.Size = new System.Drawing.Size(0, 25);
            this.lblTImer2.TabIndex = 2;
            this.lblTImer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(479, 333);
            this.Controls.Add(this.pnlBR1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSimulator";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "!! Incoming Call !!";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnDuration.ResumeLayout(false);
            this.pnlContent1.ResumeLayout(false);
            this.pnlContent1.PerformLayout();
            this.pnlBR1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnDuration;
        private System.Windows.Forms.Label lbltimer;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Timer duration;
        private System.Windows.Forms.Panel pnlContent1;
        private System.Windows.Forms.Panel pnlBR1;
        private System.Windows.Forms.Label lblTImer2;
    }
}