
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
            btnAnswer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnDuration.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnswer
            // 
            btnAnswer.BackColor = System.Drawing.Color.Transparent;
            btnAnswer.BackgroundImage = global::SEN371_Project.Properties.Resources.awnsercall;
            btnAnswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnAnswer.FlatAppearance.BorderSize = 0;
            btnAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAnswer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAnswer.ForeColor = System.Drawing.Color.Coral;
            btnAnswer.Location = new System.Drawing.Point(9, 123);
            btnAnswer.Name = "btnAnswer";
            btnAnswer.Size = new System.Drawing.Size(75, 80);
            btnAnswer.TabIndex = 0;
            btnAnswer.UseVisualStyleBackColor = false;
            btnAnswer.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::SEN371_Project.Properties.Resources.favpng_icon;
            this.pictureBox3.Location = new System.Drawing.Point(103, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(84, 67);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(64, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 19);
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
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(220, 123);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 79);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pnDuration
            // 
            this.pnDuration.BackColor = System.Drawing.Color.Transparent;
            this.pnDuration.Controls.Add(this.lbltimer);
            this.pnDuration.Controls.Add(this.lblDuration);
            this.pnDuration.Location = new System.Drawing.Point(9, 4);
            this.pnDuration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnDuration.Name = "pnDuration";
            this.pnDuration.Size = new System.Drawing.Size(294, 90);
            this.pnDuration.TabIndex = 8;
            // 
            // lbltimer
            // 
            this.lbltimer.AutoSize = true;
            this.lbltimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimer.Location = new System.Drawing.Point(98, 44);
            this.lbltimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(0, 26);
            this.lbltimer.TabIndex = 1;
            this.lbltimer.Click += new System.EventHandler(this.lbltimer_Click);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(53, 5);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(179, 31);
            this.lblDuration.TabIndex = 0;
            this.lblDuration.Text = "Call Duration:";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // duration
            // 
            this.duration.Interval = 1000;
            this.duration.Tick += new System.EventHandler(this.ChangeDuration);
            // 
            // frmSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(313, 206);
            this.Controls.Add(this.pnDuration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(btnAnswer);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSimulator";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "!!_Incoming Call_!!";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnDuration.ResumeLayout(false);
            this.pnDuration.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnDuration;
        private System.Windows.Forms.Label lbltimer;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Timer duration;
    }
}