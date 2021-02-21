namespace Final_Hospital_Management_System
{
    partial class Attendence
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
            this.LogOutButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DoctorID = new System.Windows.Forms.TextBox();
            this.Timing = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.TextBox();
            this.WardNo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Department = new System.Windows.Forms.ComboBox();
            this.Day = new System.Windows.Forms.ComboBox();
            this.Shift = new System.Windows.Forms.ComboBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(761, 56);
            this.label1.TabIndex = 122;
            this.label1.Text = "Attendence ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(598, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 38);
            this.label2.TabIndex = 124;
            this.label2.Text = "Doctor Login";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.White;
            this.LogOutButton.Image = global::Final_Hospital_Management_System.Properties.Resources.Apps_session_logout_icon__1_;
            this.LogOutButton.Location = new System.Drawing.Point(736, 86);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(28, 21);
            this.LogOutButton.TabIndex = 125;
            this.LogOutButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.SkyBlue;
            this.BackButton.Image = global::Final_Hospital_Management_System.Properties.Resources.back_icon;
            this.BackButton.Location = new System.Drawing.Point(29, 79);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(42, 35);
            this.BackButton.TabIndex = 126;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Hospital_Management_System.Properties.Resources._8_secrets_emergency_megaflopp_1024x683;
            this.pictureBox1.Location = new System.Drawing.Point(29, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 127;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(28, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 128;
            this.label3.Text = "Doctor ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(28, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 129;
            this.label4.Text = "Shift :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(28, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 130;
            this.label5.Text = "Timing : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(28, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 131;
            this.label6.Text = "Date : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(28, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 132;
            this.label7.Text = "Day :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Location = new System.Drawing.Point(25, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 20);
            this.label8.TabIndex = 133;
            this.label8.Text = "Duty Department :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label9.Location = new System.Drawing.Point(28, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 20);
            this.label9.TabIndex = 134;
            this.label9.Text = "Ward / Room No :";
            // 
            // DoctorID
            // 
            this.DoctorID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.DoctorID.Location = new System.Drawing.Point(181, 23);
            this.DoctorID.Name = "DoctorID";
            this.DoctorID.Size = new System.Drawing.Size(193, 27);
            this.DoctorID.TabIndex = 135;
            // 
            // Timing
            // 
            this.Timing.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Timing.Location = new System.Drawing.Point(181, 97);
            this.Timing.Name = "Timing";
            this.Timing.Size = new System.Drawing.Size(193, 27);
            this.Timing.TabIndex = 136;
            // 
            // Date
            // 
            this.Date.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Date.Location = new System.Drawing.Point(181, 130);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(193, 27);
            this.Date.TabIndex = 137;
            // 
            // WardNo
            // 
            this.WardNo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.WardNo.Location = new System.Drawing.Point(181, 241);
            this.WardNo.Name = "WardNo";
            this.WardNo.Size = new System.Drawing.Size(193, 27);
            this.WardNo.TabIndex = 140;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.Department);
            this.groupBox1.Controls.Add(this.Day);
            this.groupBox1.Controls.Add(this.Shift);
            this.groupBox1.Controls.Add(this.UpdateButton);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.WardNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Date);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Timing);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.DoctorID);
            this.groupBox1.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(74, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 341);
            this.groupBox1.TabIndex = 142;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attendence";
            // 
            // Department
            // 
            this.Department.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Department.FormattingEnabled = true;
            this.Department.Items.AddRange(new object[] {
            "Emergency",
            "OPD",
            "Neurology Department",
            "Cardiology Department",
            "Urology Department",
            "Gaenycology Department",
            "Child Department"});
            this.Department.Location = new System.Drawing.Point(181, 203);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(193, 28);
            this.Department.TabIndex = 148;
            this.Department.Text = "Select";
            // 
            // Day
            // 
            this.Day.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Day.FormattingEnabled = true;
            this.Day.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.Day.Location = new System.Drawing.Point(181, 169);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(193, 28);
            this.Day.TabIndex = 147;
            this.Day.Text = "Select";
            // 
            // Shift
            // 
            this.Shift.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Shift.FormattingEnabled = true;
            this.Shift.Items.AddRange(new object[] {
            "Day",
            "Night"});
            this.Shift.Location = new System.Drawing.Point(181, 57);
            this.Shift.Name = "Shift";
            this.Shift.Size = new System.Drawing.Size(193, 28);
            this.Shift.TabIndex = 146;
            this.Shift.Text = "Select";
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.UpdateButton.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.Location = new System.Drawing.Point(464, 292);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(85, 43);
            this.UpdateButton.TabIndex = 145;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.DeleteButton.Font = new System.Drawing.Font("Book Antiqua", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(361, 292);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 43);
            this.DeleteButton.TabIndex = 144;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddButton.Font = new System.Drawing.Font("Book Antiqua", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(259, 292);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 43);
            this.AddButton.TabIndex = 143;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Final_Hospital_Management_System.Properties.Resources.images__1_;
            this.pictureBox2.Location = new System.Drawing.Point(414, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 134);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 142;
            this.pictureBox2.TabStop = false;
            // 
            // Attendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Hospital_Management_System.Properties.Resources.images__3_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(785, 502);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Attendence";
            this.Text = "Attendence";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DoctorID;
        private System.Windows.Forms.TextBox Timing;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.TextBox WardNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.ComboBox Department;
        private System.Windows.Forms.ComboBox Day;
        private System.Windows.Forms.ComboBox Shift;
    }
}