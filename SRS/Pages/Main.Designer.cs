namespace SRS
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            mainPanel = new Panel();
            exit = new Button();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            logo = new PictureBox();
            Username = new TextBox();
            Password = new TextBox();
            label2 = new Label();
            submitLogin = new Button();
            label4 = new Label();
            label3 = new Label();
            StudentReg = new Button();
            showPassword = new CheckBox();
            selectRoles = new ComboBox();
            label7 = new Label();
            mainPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = SystemColors.HotTrack;
            mainPanel.Controls.Add(exit);
            mainPanel.Location = new Point(-23, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1092, 36);
            mainPanel.TabIndex = 3;
            mainPanel.MouseDown += draggablePanel_MouseDown;
            mainPanel.MouseMove += draggablePanel_MouseMove;
            mainPanel.MouseUp += draggablePanel_MouseUp;
            // 
            // exit
            // 
            exit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            exit.BackColor = SystemColors.HotTrack;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Font = new Font("Segoe UI", 4.8F, FontStyle.Regular, GraphicsUnit.Point);
            exit.ForeColor = SystemColors.HotTrack;
            exit.Image = (Image)resources.GetObject("exit.Image");
            exit.Location = new Point(1059, 5);
            exit.Margin = new Padding(1);
            exit.Name = "exit";
            exit.Size = new Size(25, 25);
            exit.TabIndex = 5;
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(logo);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(354, 668);
            panel1.TabIndex = 4;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(93, 622);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(192, 22);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://github.com/kaitolegion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(32, 621);
            label6.Name = "label6";
            label6.Size = new Size(63, 21);
            label6.TabIndex = 8;
            label6.Text = "Github:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(32, 261);
            label5.Name = "label5";
            label5.Size = new Size(298, 31);
            label5.TabIndex = 7;
            label5.Text = "Student Registration System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(112, 222);
            label1.Name = "label1";
            label1.Size = new Size(122, 35);
            label1.TabIndex = 6;
            label1.Text = "Welcome";
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(95, 56);
            logo.Name = "logo";
            logo.Size = new Size(155, 155);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 5;
            logo.TabStop = false;
            // 
            // Username
            // 
            Username.BackColor = Color.FromArgb(230, 231, 232);
            Username.BorderStyle = BorderStyle.None;
            Username.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Username.Location = new Point(588, 249);
            Username.Name = "Username";
            Username.Size = new Size(259, 23);
            Username.TabIndex = 1;
            Username.WordWrap = false;
            // 
            // Password
            // 
            Password.BackColor = Color.FromArgb(230, 231, 232);
            Password.BorderStyle = BorderStyle.None;
            Password.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Password.Location = new Point(588, 317);
            Password.Name = "Password";
            Password.Size = new Size(259, 23);
            Password.TabIndex = 6;
            Password.UseSystemPasswordChar = true;
            Password.WordWrap = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(588, 226);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 7;
            label2.Text = "Username:";
            // 
            // submitLogin
            // 
            submitLogin.BackColor = SystemColors.HotTrack;
            submitLogin.Cursor = Cursors.Hand;
            submitLogin.FlatStyle = FlatStyle.Flat;
            submitLogin.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            submitLogin.ForeColor = SystemColors.Window;
            submitLogin.Location = new Point(589, 415);
            submitLogin.Name = "submitLogin";
            submitLogin.Size = new Size(258, 54);
            submitLogin.TabIndex = 9;
            submitLogin.Text = "Login";
            submitLogin.UseVisualStyleBackColor = false;
            submitLogin.Click += submitLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.InactiveCaptionText;
            label4.Location = new Point(674, 78);
            label4.Name = "label4";
            label4.Size = new Size(88, 35);
            label4.TabIndex = 7;
            label4.Text = "LOGIN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(588, 293);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 10;
            label3.Text = "Password:";
            // 
            // StudentReg
            // 
            StudentReg.BackColor = SystemColors.HotTrack;
            StudentReg.Cursor = Cursors.Hand;
            StudentReg.FlatStyle = FlatStyle.Flat;
            StudentReg.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            StudentReg.ForeColor = SystemColors.Window;
            StudentReg.Location = new Point(589, 484);
            StudentReg.Name = "StudentReg";
            StudentReg.Size = new Size(258, 54);
            StudentReg.TabIndex = 11;
            StudentReg.Text = "Student Register";
            StudentReg.UseVisualStyleBackColor = false;
            StudentReg.Click += StudentReg_Click;
            // 
            // showPassword
            // 
            showPassword.AutoSize = true;
            showPassword.Location = new Point(588, 359);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(132, 24);
            showPassword.TabIndex = 12;
            showPassword.Text = "Show Password";
            showPassword.UseVisualStyleBackColor = true;
            showPassword.CheckedChanged += showPassword_CheckedChanged;
            // 
            // selectRoles
            // 
            selectRoles.BackColor = Color.FromArgb(230, 231, 232);
            selectRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            selectRoles.FlatStyle = FlatStyle.Flat;
            selectRoles.ForeColor = SystemColors.WindowText;
            selectRoles.FormattingEnabled = true;
            selectRoles.Items.AddRange(new object[] { "Student", "Faculty", "Administrator" });
            selectRoles.Location = new Point(588, 181);
            selectRoles.Name = "selectRoles";
            selectRoles.Size = new Size(258, 28);
            selectRoles.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(588, 154);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 14;
            label7.Text = "Select Role:";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 661);
            Controls.Add(label7);
            Controls.Add(selectRoles);
            Controls.Add(showPassword);
            Controls.Add(StudentReg);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(submitLogin);
            Controls.Add(label2);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(panel1);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            mainPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel mainPanel;
        private Panel panel1;
        private PictureBox logo;
        private Label label1;
        private TextBox Username;
        private TextBox Password;
        private Label label2;
        private Button submitLogin;
        private Label label4;
        private Button exit;
        private Label label3;
        private Label label5;
        private LinkLabel linkLabel1;
        private Label label6;
        private Button StudentReg;
        private CheckBox showPassword;
        private ComboBox selectRoles;
        private Label label7;
    }
}