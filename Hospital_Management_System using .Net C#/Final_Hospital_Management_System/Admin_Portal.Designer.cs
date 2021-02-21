namespace Final_Hospital_Management_System
{
    partial class Admin_Portal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.AdminPortalMenuStrip = new System.Windows.Forms.MenuStrip();
            this.AdminMyProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminDoctorDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminPatientDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminCheckDoctorAttendence = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminPortalMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(811, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hospital Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(811, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome To Admin Portal";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.SkyBlue;
            this.BackButton.Image = global::Final_Hospital_Management_System.Properties.Resources.back_icon;
            this.BackButton.Location = new System.Drawing.Point(29, 74);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(33, 26);
            this.BackButton.TabIndex = 14;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.SkyBlue;
            this.LogOutButton.Image = global::Final_Hospital_Management_System.Properties.Resources.Apps_session_logout_icon__1_;
            this.LogOutButton.Location = new System.Drawing.Point(779, 72);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(33, 28);
            this.LogOutButton.TabIndex = 108;
            this.LogOutButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // AdminPortalMenuStrip
            // 
            this.AdminPortalMenuStrip.AutoSize = false;
            this.AdminPortalMenuStrip.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AdminPortalMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.AdminPortalMenuStrip.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPortalMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdminMyProfile,
            this.AdminDoctorDetails,
            this.AdminPatientDetail,
            this.AdminCheckDoctorAttendence});
            this.AdminPortalMenuStrip.Location = new System.Drawing.Point(121, 116);
            this.AdminPortalMenuStrip.Name = "AdminPortalMenuStrip";
            this.AdminPortalMenuStrip.Size = new System.Drawing.Size(578, 30);
            this.AdminPortalMenuStrip.TabIndex = 109;
            this.AdminPortalMenuStrip.Text = "menuStrip1";
            // 
            // AdminMyProfile
            // 
            this.AdminMyProfile.ForeColor = System.Drawing.Color.White;
            this.AdminMyProfile.Image = global::Final_Hospital_Management_System.Properties.Resources.download;
            this.AdminMyProfile.Name = "AdminMyProfile";
            this.AdminMyProfile.Size = new System.Drawing.Size(113, 26);
            this.AdminMyProfile.Text = "My Profile";
            this.AdminMyProfile.Click += new System.EventHandler(this.AdminMyProfile_Click);
            // 
            // AdminDoctorDetails
            // 
            this.AdminDoctorDetails.ForeColor = System.Drawing.Color.White;
            this.AdminDoctorDetails.Image = global::Final_Hospital_Management_System.Properties.Resources.doctor_icon;
            this.AdminDoctorDetails.Name = "AdminDoctorDetails";
            this.AdminDoctorDetails.Size = new System.Drawing.Size(141, 26);
            this.AdminDoctorDetails.Text = "Doctor Deatils";
            this.AdminDoctorDetails.Click += new System.EventHandler(this.AdminDoctorDetails_Click);
            // 
            // AdminPatientDetail
            // 
            this.AdminPatientDetail.ForeColor = System.Drawing.Color.White;
            this.AdminPatientDetail.Image = global::Final_Hospital_Management_System.Properties.Resources._56166495_blue_square_icon_hospital_bed;
            this.AdminPatientDetail.Name = "AdminPatientDetail";
            this.AdminPatientDetail.Size = new System.Drawing.Size(145, 26);
            this.AdminPatientDetail.Text = "Patient Details";
            this.AdminPatientDetail.Click += new System.EventHandler(this.AdminPatientDetail_Click);
            // 
            // AdminCheckDoctorAttendence
            // 
            this.AdminCheckDoctorAttendence.ForeColor = System.Drawing.Color.White;
            this.AdminCheckDoctorAttendence.Image = global::Final_Hospital_Management_System.Properties.Resources._8_secrets_emergency_megaflopp_1024x683;
            this.AdminCheckDoctorAttendence.Name = "AdminCheckDoctorAttendence";
            this.AdminCheckDoctorAttendence.Size = new System.Drawing.Size(169, 26);
            this.AdminCheckDoctorAttendence.Text = "Doctor Attendence";
            this.AdminCheckDoctorAttendence.Click += new System.EventHandler(this.AdminCheckDoctorAttendence_Click);
            // 
            // Admin_Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Hospital_Management_System.Properties.Resources._011;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(841, 492);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminPortalMenuStrip);
            this.IsMdiContainer = true;
            this.Name = "Admin_Portal";
            this.Text = "Admin_Portal";
            this.AdminPortalMenuStrip.ResumeLayout(false);
            this.AdminPortalMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.MenuStrip AdminPortalMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AdminMyProfile;
        private System.Windows.Forms.ToolStripMenuItem AdminDoctorDetails;
        private System.Windows.Forms.ToolStripMenuItem AdminPatientDetail;
        private System.Windows.Forms.ToolStripMenuItem AdminCheckDoctorAttendence;
    }
}