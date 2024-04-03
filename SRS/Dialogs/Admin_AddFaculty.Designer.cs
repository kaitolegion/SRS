namespace SRS.Dialogs
{
    partial class Admin_AddFaculty
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            firstname = new TextBox();
            middlename = new TextBox();
            lastname = new TextBox();
            email = new TextBox();
            phone = new TextBox();
            address = new TextBox();
            department = new TextBox();
            username = new TextBox();
            password = new TextBox();
            submitAdd = new Button();
            dateofbirth = new DateTimePicker();
            label12 = new Label();
            gender = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(379, 24);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 0;
            label1.Text = "Add New Faculty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 218);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Lastname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 148);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 2;
            label3.Text = "Middlename";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 74);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 3;
            label4.Text = "Firstname";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 358);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 4;
            label5.Text = "Date of Birth";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(84, 427);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(492, 74);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 6;
            label7.Text = "Phone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(492, 133);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 7;
            label8.Text = "Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(492, 218);
            label9.Name = "label9";
            label9.Size = new Size(89, 20);
            label9.TabIndex = 8;
            label9.Text = "Department";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(492, 298);
            label10.Name = "label10";
            label10.Size = new Size(75, 20);
            label10.TabIndex = 9;
            label10.Text = "Username";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(492, 367);
            label11.Name = "label11";
            label11.Size = new Size(70, 20);
            label11.TabIndex = 10;
            label11.Text = "Password";
            // 
            // firstname
            // 
            firstname.Location = new Point(83, 97);
            firstname.Name = "firstname";
            firstname.Size = new Size(247, 27);
            firstname.TabIndex = 11;
            firstname.TextChanged += firstname_TextChanged;
            // 
            // middlename
            // 
            middlename.Location = new Point(83, 171);
            middlename.Name = "middlename";
            middlename.Size = new Size(247, 27);
            middlename.TabIndex = 12;
            // 
            // lastname
            // 
            lastname.Location = new Point(83, 241);
            lastname.Name = "lastname";
            lastname.Size = new Size(247, 27);
            lastname.TabIndex = 13;
            // 
            // email
            // 
            email.Location = new Point(84, 450);
            email.Name = "email";
            email.Size = new Size(247, 27);
            email.TabIndex = 14;
            // 
            // phone
            // 
            phone.Location = new Point(492, 97);
            phone.Name = "phone";
            phone.Size = new Size(247, 27);
            phone.TabIndex = 16;
            phone.TextChanged += phone_TextChanged;
            // 
            // address
            // 
            address.Location = new Point(492, 156);
            address.Multiline = true;
            address.Name = "address";
            address.Size = new Size(247, 42);
            address.TabIndex = 17;
            // 
            // department
            // 
            department.Location = new Point(492, 241);
            department.Name = "department";
            department.Size = new Size(247, 27);
            department.TabIndex = 18;
            // 
            // username
            // 
            username.Location = new Point(492, 321);
            username.Name = "username";
            username.Size = new Size(247, 27);
            username.TabIndex = 19;
            // 
            // password
            // 
            password.Location = new Point(492, 390);
            password.Name = "password";
            password.Size = new Size(247, 27);
            password.TabIndex = 20;
            // 
            // submitAdd
            // 
            submitAdd.BackColor = SystemColors.HotTrack;
            submitAdd.Cursor = Cursors.Hand;
            submitAdd.FlatStyle = FlatStyle.Flat;
            submitAdd.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            submitAdd.ForeColor = SystemColors.Window;
            submitAdd.Location = new Point(665, 500);
            submitAdd.Name = "submitAdd";
            submitAdd.Size = new Size(81, 54);
            submitAdd.TabIndex = 22;
            submitAdd.Text = "ADD";
            submitAdd.UseVisualStyleBackColor = false;
            submitAdd.Click += submitAdd_Click;
            // 
            // dateofbirth
            // 
            dateofbirth.Location = new Point(84, 381);
            dateofbirth.Name = "dateofbirth";
            dateofbirth.Size = new Size(250, 27);
            dateofbirth.TabIndex = 23;
            dateofbirth.ValueChanged += dateofbirth_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(82, 282);
            label12.Name = "label12";
            label12.Size = new Size(57, 20);
            label12.TabIndex = 24;
            label12.Text = "Gender";
            // 
            // gender
            // 
            gender.DropDownStyle = ComboBoxStyle.DropDownList;
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Male", "Female" });
            gender.Location = new Point(84, 306);
            gender.Name = "gender";
            gender.Size = new Size(246, 28);
            gender.TabIndex = 26;
            // 
            // Admin_AddFaculty
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 587);
            Controls.Add(gender);
            Controls.Add(label12);
            Controls.Add(dateofbirth);
            Controls.Add(submitAdd);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(department);
            Controls.Add(address);
            Controls.Add(phone);
            Controls.Add(email);
            Controls.Add(lastname);
            Controls.Add(middlename);
            Controls.Add(firstname);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Admin_AddFaculty";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Faculty";
            Load += Admin_AddFaculty_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox firstname;
        private TextBox middlename;
        private TextBox lastname;
        private TextBox email;
        private TextBox phone;
        private TextBox address;
        private TextBox department;
        private TextBox username;
        private TextBox password;
        private Button submitAdd;
        private DateTimePicker dateofbirth;
        private Label label12;
        private ComboBox gender;
    }
}