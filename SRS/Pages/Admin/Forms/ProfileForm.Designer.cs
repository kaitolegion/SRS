namespace SRS.Pages.Admin.Forms
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            label1 = new Label();
            logo = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            emailtxt = new TextBox();
            phonetxt = new TextBox();
            password = new TextBox();
            label4 = new Label();
            Updatebtn = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            gender = new ComboBox();
            label8 = new Label();
            username = new TextBox();
            label9 = new Label();
            fntxt = new TextBox();
            label10 = new Label();
            mntxt = new TextBox();
            label11 = new Label();
            lntxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(563, 21);
            label1.Name = "label1";
            label1.Size = new Size(174, 45);
            label1.TabIndex = 1;
            label1.Text = "Edit Profile";
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(-1, -1);
            logo.Name = "logo";
            logo.Size = new Size(162, 162);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 4;
            logo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(163, 218);
            label2.Name = "label2";
            label2.Size = new Size(167, 30);
            label2.TabIndex = 5;
            label2.Text = "Kaito Generalao";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(193, 250);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 6;
            label3.Text = "Administrator";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(157, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(177, 177);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(logo);
            panel2.Location = new Point(8, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(162, 162);
            panel2.TabIndex = 8;
            // 
            // emailtxt
            // 
            emailtxt.Location = new Point(563, 285);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(280, 27);
            emailtxt.TabIndex = 8;
            // 
            // phonetxt
            // 
            phonetxt.Location = new Point(563, 341);
            phonetxt.Name = "phonetxt";
            phonetxt.Size = new Size(280, 27);
            phonetxt.TabIndex = 9;
            // 
            // password
            // 
            password.Location = new Point(563, 514);
            password.Name = "password";
            password.Size = new Size(280, 27);
            password.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(563, 491);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 11;
            label4.Text = "Change Password";
            // 
            // Updatebtn
            // 
            Updatebtn.BackColor = SystemColors.MenuHighlight;
            Updatebtn.Cursor = Cursors.Hand;
            Updatebtn.FlatStyle = FlatStyle.Flat;
            Updatebtn.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Updatebtn.ForeColor = SystemColors.Window;
            Updatebtn.Location = new Point(816, 563);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(84, 38);
            Updatebtn.TabIndex = 14;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(563, 321);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 15;
            label5.Text = "Phone Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(563, 261);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 16;
            label6.Text = "Email Address:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(563, 374);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 18;
            label7.Text = "Gender:";
            // 
            // gender
            // 
            gender.DropDownStyle = ComboBoxStyle.DropDownList;
            gender.FlatStyle = FlatStyle.Flat;
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Male", "Female" });
            gender.Location = new Point(563, 401);
            gender.Name = "gender";
            gender.Size = new Size(280, 28);
            gender.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(563, 435);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 21;
            label8.Text = "Username:";
            // 
            // username
            // 
            username.Location = new Point(563, 460);
            username.Name = "username";
            username.Size = new Size(280, 27);
            username.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(563, 80);
            label9.Name = "label9";
            label9.Size = new Size(83, 20);
            label9.TabIndex = 23;
            label9.Text = "First Name:";
            // 
            // fntxt
            // 
            fntxt.Location = new Point(563, 104);
            fntxt.Name = "fntxt";
            fntxt.Size = new Size(280, 27);
            fntxt.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(563, 135);
            label10.Name = "label10";
            label10.Size = new Size(103, 20);
            label10.TabIndex = 25;
            label10.Text = "Middle Name:";
            // 
            // mntxt
            // 
            mntxt.Location = new Point(563, 159);
            mntxt.Name = "mntxt";
            mntxt.Size = new Size(280, 27);
            mntxt.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(563, 199);
            label11.Name = "label11";
            label11.Size = new Size(82, 20);
            label11.TabIndex = 27;
            label11.Text = "Last Name:";
            // 
            // lntxt
            // 
            lntxt.Location = new Point(563, 223);
            lntxt.Name = "lntxt";
            lntxt.Size = new Size(280, 27);
            lntxt.TabIndex = 26;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 659);
            Controls.Add(label11);
            Controls.Add(lntxt);
            Controls.Add(label10);
            Controls.Add(mntxt);
            Controls.Add(label9);
            Controls.Add(fntxt);
            Controls.Add(label8);
            Controls.Add(username);
            Controls.Add(gender);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Updatebtn);
            Controls.Add(label4);
            Controls.Add(password);
            Controls.Add(phonetxt);
            Controls.Add(emailtxt);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProfileForm";
            Text = "ProfileForm";
            Load += ProfileForm_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox logo;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private TextBox emailtxt;
        private TextBox phonetxt;
        private TextBox password;
        private Label label4;
        private Button Updatebtn;
        private Panel panel2;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox gender;
        private Label label8;
        private TextBox username;
        private Label label9;
        private TextBox fntxt;
        private Label label10;
        private TextBox mntxt;
        private Label label11;
        private TextBox lntxt;
    }
}