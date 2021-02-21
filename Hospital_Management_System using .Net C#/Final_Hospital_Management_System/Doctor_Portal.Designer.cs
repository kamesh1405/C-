namespace Final_Hospital_Management_System
{
    partial class Doctor_Portal
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
            this.LogOutButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DoctorPortalMenuStrip = new System.Windows.Forms.MenuStrip();
            this.DoctorMyProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.DoctorAttendence = new System.Windows.Forms.ToolStripMenuItem();
            this.DoctorPatientDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DoctorPortalMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.SkyBlue;
            this.LogOutButton.Image = global::Final_Hospital_Management_System.Properties.Resources.Apps_session_logout_icon__1_;
            this.LogOutButton.Location = new System.Drawing.Point(779, 69);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(33, 28);
            this.LogOutButton.TabIndex = 113;
            this.LogOutButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.SkyBlue;
            this.BackButton.Image = global::Final_Hospital_Management_System.Properties.Resources.back_icon;
            this.BackButton.Location = new System.Drawing.Point(29, 71);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(33, 26);
            this.BackButton.TabIndex = 112;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(811, 31);
            this.label2.TabIndex = 111;
            this.label2.Text = "Welcome To Doctor  Portal";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(23, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(811, 65);
            this.label1.TabIndex = 110;
            this.label1.Text = "Hospital Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DoctorPortalMenuStrip
            // 
            this.DoctorPortalMenuStrip.AutoSize = false;
            this.DoctorPortalMenuStrip.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DoctorPortalMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.DoctorPortalMenuStrip.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorPortalMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DoctorMyProfile,
            this.DoctorAttendence,
            this.DoctorPatientDetail});
            this.DoctorPortalMenuStrip.Location = new System.Drawing.Point(225, 108);
            this.DoctorPortalMenuStrip.Name = "DoctorPortalMenuStrip";
            this.DoctorPortalMenuStrip.Size = new System.Drawing.Size(419, 30);
            this.DoctorPortalMenuStrip.TabIndex = 114;
            this.DoctorPortalMenuStrip.Text = "menuStrip1";
            // 
            // DoctorMyProfile
            // 
            this.DoctorMyProfile.ForeColor = System.Drawing.Color.White;
            this.DoctorMyProfile.Image = global::Final_Hospital_Management_System.Properties.Resources.images__1_;
            this.DoctorMyProfile.Name = "DoctorMyProfile";
            this.DoctorMyProfile.Size = new System.Drawing.Size(113, 26);
            this.DoctorMyProfile.Text = "My Profile";
            this.DoctorMyProfile.Click += new System.EventHandler(this.DoctorMyProfile_Click);
            // 
            // DoctorAttendence
            // 
            this.DoctorAttendence.ForeColor = System.Drawing.Color.White;
            this.DoctorAttendence.Image = global::Final_Hospital_Management_System.Properties.Resources.Fotolia_47301641_X_c_r_mxlyepc2frxtezwyeou9qnhb008kdrlu3qlnilfut4;
            this.DoctorAttendence.Name = "DoctorAttendence";
            this.DoctorAttendence.Size = new System.Drawing.Size(116, 26);
            this.DoctorAttendence.Text = "Attendence";
            this.DoctorAttendence.Click += new System.EventHandler(this.DoctorAttendence_Click);
            // 
            // DoctorPatientDetail
            // 
            this.DoctorPatientDetail.ForeColor = System.Drawing.Color.White;
            this.DoctorPatientDetail.Image = global::Final_Hospital_Management_System.Properties.Resources._56166495_blue_square_icon_hospital_bed;
            this.DoctorPatientDetail.Name = "DoctorPatientDetail";
            this.DoctorPatientDetail.Size = new System.Drawing.Size(145, 26);
            this.DoctorPatientDetail.Text = "Patient Details";
            this.DoctorPatientDetail.Click += new System.EventHandler(this.DoctorPatientDetail_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Hospital_Management_System.Properties.Resources.healthcare_students;
            this.pictureBox1.Location = new System.Drawing.Point(29, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(806, 349);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 115;
            this.pictureBox1.TabStop = false;
            // 
            // Doctor_Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Hospital_Management_System.Properties.Resources.bg991;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 512);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoctorPortalMenuStrip);
            this.IsMdiContainer = true;
            this.Name = "Doctor_Portal";
            this.Text = "Doctor_Portal";
            this.DoctorPortalMenuStrip.ResumeLayout(false);
            this.DoctorPortalMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip DoctorPortalMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem DoctorMyProfile;
        private System.Windows.Forms.ToolStripMenuItem DoctorAttendence;
        private System.Windows.Forms.ToolStripMenuItem DoctorPatientDetail;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}