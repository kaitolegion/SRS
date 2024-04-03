namespace SRS.Pages.Admin
{
    partial class Admin_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Dashboard));
            panel1 = new Panel();
            hoverprofile = new Panel();
            hoverstudent = new Panel();
            hoverfaculty = new Panel();
            hoverhome = new Panel();
            logoutbtn = new Button();
            label1 = new Label();
            profilebtn = new Button();
            logo = new PictureBox();
            studentbtn = new Button();
            Homebtn = new Button();
            Facultybtn = new Button();
            topPanel = new Panel();
            minimizebtn = new Button();
            button1 = new Button();
            exit = new Button();
            panelDesktop = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(hoverprofile);
            panel1.Controls.Add(hoverstudent);
            panel1.Controls.Add(hoverfaculty);
            panel1.Controls.Add(hoverhome);
            panel1.Controls.Add(logoutbtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(profilebtn);
            panel1.Controls.Add(logo);
            panel1.Controls.Add(studentbtn);
            panel1.Controls.Add(Homebtn);
            panel1.Controls.Add(Facultybtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 760);
            panel1.TabIndex = 1;
            // 
            // hoverprofile
            // 
            hoverprofile.BackColor = SystemColors.ControlLightLight;
            hoverprofile.Location = new Point(0, 368);
            hoverprofile.Name = "hoverprofile";
            hoverprofile.Size = new Size(11, 54);
            hoverprofile.TabIndex = 12;
            hoverprofile.Visible = false;
            // 
            // hoverstudent
            // 
            hoverstudent.BackColor = SystemColors.ControlLightLight;
            hoverstudent.Location = new Point(0, 311);
            hoverstudent.Name = "hoverstudent";
            hoverstudent.Size = new Size(11, 54);
            hoverstudent.TabIndex = 11;
            hoverstudent.Visible = false;
            // 
            // hoverfaculty
            // 
            hoverfaculty.BackColor = SystemColors.ControlLightLight;
            hoverfaculty.Location = new Point(0, 254);
            hoverfaculty.Name = "hoverfaculty";
            hoverfaculty.Size = new Size(11, 54);
            hoverfaculty.TabIndex = 10;
            hoverfaculty.Visible = false;
            // 
            // hoverhome
            // 
            hoverhome.BackColor = SystemColors.ControlLightLight;
            hoverhome.Location = new Point(0, 197);
            hoverhome.Name = "hoverhome";
            hoverhome.Size = new Size(11, 54);
            hoverhome.TabIndex = 9;
            hoverhome.Visible = false;
            // 
            // logoutbtn
            // 
            logoutbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            logoutbtn.BackColor = SystemColors.HotTrack;
            logoutbtn.FlatAppearance.BorderSize = 0;
            logoutbtn.FlatStyle = FlatStyle.Flat;
            logoutbtn.Font = new Font("Segoe UI", 4.8F, FontStyle.Regular, GraphicsUnit.Point);
            logoutbtn.ForeColor = SystemColors.HotTrack;
            logoutbtn.Image = (Image)resources.GetObject("logoutbtn.Image");
            logoutbtn.Location = new Point(96, 463);
            logoutbtn.Margin = new Padding(1);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(56, 51);
            logoutbtn.TabIndex = 8;
            logoutbtn.UseVisualStyleBackColor = false;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(64, 136);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 3;
            label1.Text = "ADMINISTRATOR";
            // 
            // profilebtn
            // 
            profilebtn.FlatAppearance.BorderSize = 0;
            profilebtn.FlatStyle = FlatStyle.Flat;
            profilebtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            profilebtn.ForeColor = SystemColors.ControlLightLight;
            profilebtn.Image = (Image)resources.GetObject("profilebtn.Image");
            profilebtn.ImageAlign = ContentAlignment.MiddleLeft;
            profilebtn.Location = new Point(26, 369);
            profilebtn.Name = "profilebtn";
            profilebtn.Size = new Size(228, 54);
            profilebtn.TabIndex = 7;
            profilebtn.Text = "    PROFILE";
            profilebtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            profilebtn.UseVisualStyleBackColor = true;
            profilebtn.Click += profilebtn_Click;
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(70, 14);
            logo.Name = "logo";
            logo.Size = new Size(109, 108);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 3;
            logo.TabStop = false;
            // 
            // studentbtn
            // 
            studentbtn.FlatAppearance.BorderSize = 0;
            studentbtn.FlatStyle = FlatStyle.Flat;
            studentbtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            studentbtn.ForeColor = SystemColors.ControlLightLight;
            studentbtn.Image = (Image)resources.GetObject("studentbtn.Image");
            studentbtn.ImageAlign = ContentAlignment.MiddleLeft;
            studentbtn.Location = new Point(26, 315);
            studentbtn.Name = "studentbtn";
            studentbtn.Size = new Size(228, 49);
            studentbtn.TabIndex = 6;
            studentbtn.Text = "     STUDENT";
            studentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            studentbtn.UseVisualStyleBackColor = true;
            studentbtn.Click += studentbtn_Click;
            // 
            // Homebtn
            // 
            Homebtn.FlatAppearance.BorderSize = 0;
            Homebtn.FlatStyle = FlatStyle.Flat;
            Homebtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Homebtn.ForeColor = SystemColors.ControlLightLight;
            Homebtn.Image = (Image)resources.GetObject("Homebtn.Image");
            Homebtn.ImageAlign = ContentAlignment.MiddleLeft;
            Homebtn.Location = new Point(26, 197);
            Homebtn.Name = "Homebtn";
            Homebtn.Size = new Size(228, 54);
            Homebtn.TabIndex = 5;
            Homebtn.Text = "    HOME";
            Homebtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            Homebtn.UseVisualStyleBackColor = true;
            Homebtn.Click += Homebtn_Click;
            // 
            // Facultybtn
            // 
            Facultybtn.FlatAppearance.BorderSize = 0;
            Facultybtn.FlatStyle = FlatStyle.Flat;
            Facultybtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Facultybtn.ForeColor = SystemColors.ControlLightLight;
            Facultybtn.Image = (Image)resources.GetObject("Facultybtn.Image");
            Facultybtn.ImageAlign = ContentAlignment.MiddleLeft;
            Facultybtn.Location = new Point(26, 259);
            Facultybtn.Name = "Facultybtn";
            Facultybtn.Size = new Size(228, 49);
            Facultybtn.TabIndex = 4;
            Facultybtn.Text = "     FACULTY";
            Facultybtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            Facultybtn.UseVisualStyleBackColor = true;
            Facultybtn.Click += Facultybtn_Click;
            // 
            // topPanel
            // 
            topPanel.BackColor = SystemColors.HotTrack;
            topPanel.Controls.Add(minimizebtn);
            topPanel.Controls.Add(button1);
            topPanel.Controls.Add(exit);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(254, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1010, 30);
            topPanel.TabIndex = 2;
            topPanel.MouseDown += draggablePanel_MouseDown;
            topPanel.MouseMove += draggablePanel_MouseMove;
            topPanel.MouseUp += draggablePanel_MouseUp;
            // 
            // minimizebtn
            // 
            minimizebtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            minimizebtn.BackColor = SystemColors.HotTrack;
            minimizebtn.FlatAppearance.BorderSize = 0;
            minimizebtn.FlatStyle = FlatStyle.Flat;
            minimizebtn.Font = new Font("Segoe UI", 4.8F, FontStyle.Regular, GraphicsUnit.Point);
            minimizebtn.ForeColor = SystemColors.HotTrack;
            minimizebtn.Image = (Image)resources.GetObject("minimizebtn.Image");
            minimizebtn.Location = new Point(923, 1);
            minimizebtn.Margin = new Padding(1);
            minimizebtn.Name = "minimizebtn";
            minimizebtn.Size = new Size(25, 25);
            minimizebtn.TabIndex = 8;
            minimizebtn.UseVisualStyleBackColor = false;
            minimizebtn.Click += minimizebtn_Click;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = SystemColors.HotTrack;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 4.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.HotTrack;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(949, 1);
            button1.Margin = new Padding(1);
            button1.Name = "button1";
            button1.Size = new Size(25, 25);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = false;
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
            exit.Location = new Point(981, 2);
            exit.Margin = new Padding(1);
            exit.Name = "exit";
            exit.Size = new Size(25, 25);
            exit.TabIndex = 6;
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(254, 30);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1010, 730);
            panelDesktop.TabIndex = 3;
            // 
            // Admin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 760);
            Controls.Add(panelDesktop);
            Controls.Add(topPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin_Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_Dashboard";
            Load += Admin_Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            topPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel topPanel;
        private PictureBox logo;
        private Button Homebtn;
        private Button Facultybtn;
        private Button studentbtn;
        private Label label1;
        private Button profilebtn;
        private Button exit;
        private Button logoutbtn;
        private Panel panelDesktop;
        private Panel hoverhome;
        private Panel hoverprofile;
        private Panel hoverstudent;
        private Panel hoverfaculty;
        private Button button1;
        private Button minimizebtn;
    }
}