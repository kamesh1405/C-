namespace WindowsFormsApplication6
{
    partial class Admin_Login_Portal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Login_Portal));
            this.label1 = new System.Windows.Forms.Label();
            this.adminpanel1 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.adminpictureBox = new System.Windows.Forms.PictureBox();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.weladminportlabel = new System.Windows.Forms.Label();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.adminidlabel = new System.Windows.Forms.Label();
            this.adminpasstextBox2 = new System.Windows.Forms.TextBox();
            this.adminidtextBox1 = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminpanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Salmon;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Andalus", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1073, 73);
            this.label1.TabIndex = 207;
            this.label1.Text = "WELCOME TO QUESTION PAPER GENERATOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminpanel1
            // 
            this.adminpanel1.AutoSize = true;
            this.adminpanel1.BackColor = System.Drawing.SystemColors.Info;
            this.adminpanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminpanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminpanel1.Controls.Add(this.pictureBox8);
            this.adminpanel1.Controls.Add(this.adminpictureBox);
            this.adminpanel1.Controls.Add(this.Exitbutton);
            this.adminpanel1.Controls.Add(this.weladminportlabel);
            this.adminpanel1.Controls.Add(this.Loginbutton);
            this.adminpanel1.Controls.Add(this.adminidlabel);
            this.adminpanel1.Controls.Add(this.adminpasstextBox2);
            this.adminpanel1.Controls.Add(this.adminidtextBox1);
            this.adminpanel1.Controls.Add(this.passwordlabel);
            this.adminpanel1.Location = new System.Drawing.Point(325, 83);
            this.adminpanel1.Name = "adminpanel1";
            this.adminpanel1.Size = new System.Drawing.Size(496, 408);
            this.adminpanel1.TabIndex = 208;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox8.Image = global::WindowsFormsApplication6.Properties.Resources.main_qimg_9e1846d011e86f29511ae7bac015b134_c;
            this.pictureBox8.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(53, 77);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 124;
            this.pictureBox8.TabStop = false;
            // 
            // adminpictureBox
            // 
            this.adminpictureBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.adminpictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("adminpictureBox.Image")));
            this.adminpictureBox.Location = new System.Drawing.Point(29, 108);
            this.adminpictureBox.Name = "adminpictureBox";
            this.adminpictureBox.Size = new System.Drawing.Size(100, 104);
            this.adminpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.adminpictureBox.TabIndex = 8;
            this.adminpictureBox.TabStop = false;
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Exitbutton.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.Location = new System.Drawing.Point(213, 317);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(107, 32);
            this.Exitbutton.TabIndex = 14;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // weladminportlabel
            // 
            this.weladminportlabel.BackColor = System.Drawing.Color.LightSalmon;
            this.weladminportlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weladminportlabel.Font = new System.Drawing.Font("Andalus", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weladminportlabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.weladminportlabel.Location = new System.Drawing.Point(3, 0);
            this.weladminportlabel.Name = "weladminportlabel";
            this.weladminportlabel.Size = new System.Drawing.Size(488, 78);
            this.weladminportlabel.TabIndex = 7;
            this.weladminportlabel.Text = "Welcome To Admin Login Portal";
            this.weladminportlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Loginbutton
            // 
            this.Loginbutton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Loginbutton.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbutton.Location = new System.Drawing.Point(213, 277);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(107, 32);
            this.Loginbutton.TabIndex = 13;
            this.Loginbutton.Text = "Login";
            this.Loginbutton.UseVisualStyleBackColor = false;
            // 
            // adminidlabel
            // 
            this.adminidlabel.BackColor = System.Drawing.Color.LightSalmon;
            this.adminidlabel.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminidlabel.Location = new System.Drawing.Point(179, 115);
            this.adminidlabel.Name = "adminidlabel";
            this.adminidlabel.Size = new System.Drawing.Size(172, 31);
            this.adminidlabel.TabIndex = 9;
            this.adminidlabel.Text = "Admin ID";
            this.adminidlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminpasstextBox2
            // 
            this.adminpasstextBox2.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminpasstextBox2.Location = new System.Drawing.Point(179, 230);
            this.adminpasstextBox2.Name = "adminpasstextBox2";
            this.adminpasstextBox2.PasswordChar = '.';
            this.adminpasstextBox2.Size = new System.Drawing.Size(172, 25);
            this.adminpasstextBox2.TabIndex = 12;
            // 
            // adminidtextBox1
            // 
            this.adminidtextBox1.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminidtextBox1.Location = new System.Drawing.Point(179, 158);
            this.adminidtextBox1.Name = "adminidtextBox1";
            this.adminidtextBox1.Size = new System.Drawing.Size(172, 25);
            this.adminidtextBox1.TabIndex = 10;
            // 
            // passwordlabel
            // 
            this.passwordlabel.BackColor = System.Drawing.Color.LightSalmon;
            this.passwordlabel.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlabel.Location = new System.Drawing.Point(182, 192);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(169, 29);
            this.passwordlabel.TabIndex = 11;
            this.passwordlabel.Text = "Password";
            this.passwordlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::WindowsFormsApplication6.Properties.Resources.microsoft_clipart_any_question_3;
            this.pictureBox2.Location = new System.Drawing.Point(1, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 223;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(827, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 425);
            this.panel1.TabIndex = 224;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = global::WindowsFormsApplication6.Properties.Resources.top_7_books_that_changed_the_world;
            this.pictureBox4.Location = new System.Drawing.Point(-1, 291);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(247, 134);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::WindowsFormsApplication6.Properties.Resources.Why_Final_Exams_May_Not_Measure_Learning_300x199;
            this.pictureBox3.Location = new System.Drawing.Point(-1, 145);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(247, 145);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::WindowsFormsApplication6.Properties.Resources.exam;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Admin_Login_Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminpanel1);
            this.Name = "Admin_Login_Portal";
            this.Text = "Admin Login Portal";
            this.adminpanel1.ResumeLayout(false);
            this.adminpanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel adminpanel1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox adminpictureBox;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Label weladminportlabel;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.Label adminidlabel;
        private System.Windows.Forms.TextBox adminpasstextBox2;
        private System.Windows.Forms.TextBox adminidtextBox1;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}