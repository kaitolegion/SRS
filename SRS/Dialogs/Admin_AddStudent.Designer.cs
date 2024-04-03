namespace SRS.Dialogs
{
    partial class Admin_AddStudent
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
            label1 = new Label();
            lastname = new TextBox();
            middlename = new TextBox();
            firstname = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            gender = new ComboBox();
            label12 = new Label();
            email = new TextBox();
            label6 = new Label();
            password = new TextBox();
            username = new TextBox();
            address = new TextBox();
            phone = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            submitAdd = new Button();
            label5 = new Label();
            label13 = new Label();
            year = new TextBox();
            label14 = new Label();
            enrolldate = new TextBox();
            label15 = new Label();
            course = new ComboBox();
            section = new ComboBox();
            date = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(364, 25);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 1;
            label1.Text = "Add New Student";
            // 
            // lastname
            // 
            lastname.Location = new Point(80, 220);
            lastname.Name = "lastname";
            lastname.Size = new Size(247, 27);
            lastname.TabIndex = 19;
            // 
            // middlename
            // 
            middlename.Location = new Point(80, 167);
            middlename.Name = "middlename";
            middlename.PlaceholderText = "(Optional)";
            middlename.Size = new Size(247, 27);
            middlename.TabIndex = 18;
            // 
            // firstname
            // 
            firstname.Location = new Point(80, 114);
            firstname.Name = "firstname";
            firstname.Size = new Size(247, 27);
            firstname.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 91);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 16;
            label4.Text = "Firstname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 144);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 15;
            label3.Text = "Middlename";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 197);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 14;
            label2.Text = "Lastname";
            // 
            // gender
            // 
            gender.DropDownStyle = ComboBoxStyle.DropDownList;
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Male", "Female" });
            gender.Location = new Point(81, 273);
            gender.Name = "gender";
            gender.Size = new Size(246, 28);
            gender.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(79, 249);
            label12.Name = "label12";
            label12.Size = new Size(57, 20);
            label12.TabIndex = 27;
            label12.Text = "Gender";
            // 
            // email
            // 
            email.Location = new Point(81, 326);
            email.Name = "email";
            email.Size = new Size(247, 27);
            email.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(82, 303);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 29;
            label6.Text = "Email";
            // 
            // password
            // 
            password.Location = new Point(474, 442);
            password.Name = "password";
            password.Size = new Size(247, 27);
            password.TabIndex = 40;
            // 
            // username
            // 
            username.Location = new Point(474, 373);
            username.Name = "username";
            username.Size = new Size(247, 27);
            username.TabIndex = 39;
            // 
            // address
            // 
            address.Location = new Point(82, 432);
            address.Multiline = true;
            address.Name = "address";
            address.Size = new Size(247, 42);
            address.TabIndex = 37;
            // 
            // phone
            // 
            phone.Location = new Point(82, 380);
            phone.Name = "phone";
            phone.Size = new Size(247, 27);
            phone.TabIndex = 36;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(474, 419);
            label11.Name = "label11";
            label11.Size = new Size(70, 20);
            label11.TabIndex = 35;
            label11.Text = "Password";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(473, 348);
            label10.Name = "label10";
            label10.Size = new Size(75, 20);
            label10.TabIndex = 34;
            label10.Text = "Username";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(82, 474);
            label9.Name = "label9";
            label9.Size = new Size(94, 20);
            label9.TabIndex = 33;
            label9.Text = "Date of Birth";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(82, 409);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 32;
            label8.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(80, 359);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 31;
            label7.Text = "Contact No";
            // 
            // submitAdd
            // 
            submitAdd.BackColor = SystemColors.HotTrack;
            submitAdd.Cursor = Cursors.Hand;
            submitAdd.FlatStyle = FlatStyle.Flat;
            submitAdd.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            submitAdd.ForeColor = SystemColors.Window;
            submitAdd.Location = new Point(649, 523);
            submitAdd.Name = "submitAdd";
            submitAdd.Size = new Size(81, 54);
            submitAdd.TabIndex = 41;
            submitAdd.Text = "ADD";
            submitAdd.UseVisualStyleBackColor = false;
            submitAdd.Click += submitAdd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(474, 160);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 43;
            label5.Text = "Section:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(474, 91);
            label13.Name = "label13";
            label13.Size = new Size(57, 20);
            label13.TabIndex = 42;
            label13.Text = "Course:";
            // 
            // year
            // 
            year.Location = new Point(474, 231);
            year.Name = "year";
            year.Size = new Size(247, 27);
            year.TabIndex = 47;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(474, 208);
            label14.Name = "label14";
            label14.Size = new Size(40, 20);
            label14.TabIndex = 46;
            label14.Text = "Year:";
            // 
            // enrolldate
            // 
            enrolldate.Location = new Point(474, 296);
            enrolldate.Name = "enrolldate";
            enrolldate.Size = new Size(247, 27);
            enrolldate.TabIndex = 49;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(474, 273);
            label15.Name = "label15";
            label15.Size = new Size(100, 20);
            label15.TabIndex = 48;
            label15.Text = "Enrolled Date";
            // 
            // course
            // 
            course.DropDownStyle = ComboBoxStyle.DropDownList;
            course.FormattingEnabled = true;
            course.Location = new Point(475, 113);
            course.Name = "course";
            course.Size = new Size(246, 28);
            course.TabIndex = 50;
            // 
            // section
            // 
            section.DropDownStyle = ComboBoxStyle.DropDownList;
            section.FormattingEnabled = true;
            section.Items.AddRange(new object[] { "A", "B", "C", "D" });
            section.Location = new Point(475, 182);
            section.Name = "section";
            section.Size = new Size(246, 28);
            section.TabIndex = 51;
            // 
            // date
            // 
            date.Location = new Point(82, 497);
            date.Name = "date";
            date.Size = new Size(250, 27);
            date.TabIndex = 52;
            // 
            // Admin_AddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 634);
            Controls.Add(date);
            Controls.Add(section);
            Controls.Add(course);
            Controls.Add(enrolldate);
            Controls.Add(label15);
            Controls.Add(year);
            Controls.Add(label14);
            Controls.Add(label5);
            Controls.Add(label13);
            Controls.Add(submitAdd);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(address);
            Controls.Add(phone);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(email);
            Controls.Add(label6);
            Controls.Add(gender);
            Controls.Add(label12);
            Controls.Add(lastname);
            Controls.Add(middlename);
            Controls.Add(firstname);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Admin_AddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Student";
            Load += Admin_AddStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox lastname;
        private TextBox middlename;
        private TextBox firstname;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox gender;
        private Label label12;
        private TextBox email;
        private Label label6;
        private TextBox password;
        private TextBox username;
        private TextBox address;
        private TextBox phone;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button submitAdd;
        private Label label5;
        private Label label13;
        private TextBox year;
        private Label label14;
        private TextBox enrolldate;
        private Label label15;
        private ComboBox course;
        private ComboBox section;
        private DateTimePicker date;
    }
}