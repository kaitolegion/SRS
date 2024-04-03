namespace SRS.Pages.Faculty
{
    partial class Faculty_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Faculty_Dashboard));
            panel2 = new Panel();
            panel3 = new Panel();
            exit = new Button();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            viewstudentrecords = new Button();
            home = new Button();
            label5 = new Label();
            logoutbtn = new Button();
            label4 = new Label();
            logo = new PictureBox();
            facultyname = new Label();
            panelDesktop = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1262, 62);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Controls.Add(exit);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1262, 35);
            panel3.TabIndex = 10;
            panel3.MouseDown += draggablePanel_MouseDown;
            panel3.MouseMove += draggablePanel_MouseMove;
            panel3.MouseUp += draggablePanel_MouseUp;
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
            exit.Location = new Point(1232, 4);
            exit.Margin = new Padding(1);
            exit.Name = "exit";
            exit.Size = new Size(25, 25);
            exit.TabIndex = 5;
            exit.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(47, 5);
            label3.Name = "label3";
            label3.Size = new Size(164, 24);
            label3.TabIndex = 9;
            label3.Text = "Faculty Dashboard";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(728, 89);
            label2.Name = "label2";
            label2.Size = new Size(0, 28);
            label2.TabIndex = 6;
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(viewstudentrecords);
            panel1.Controls.Add(home);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(logoutbtn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(logo);
            panel1.Controls.Add(facultyname);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 699);
            panel1.TabIndex = 6;
            // 
            // viewstudentrecords
            // 
            viewstudentrecords.FlatAppearance.BorderSize = 0;
            viewstudentrecords.FlatStyle = FlatStyle.Flat;
            viewstudentrecords.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            viewstudentrecords.ForeColor = SystemColors.ButtonHighlight;
            viewstudentrecords.Image = (Image)resources.GetObject("viewstudentrecords.Image");
            viewstudentrecords.ImageAlign = ContentAlignment.MiddleLeft;
            viewstudentrecords.Location = new Point(48, 208);
            viewstudentrecords.Name = "viewstudentrecords";
            viewstudentrecords.Size = new Size(247, 53);
            viewstudentrecords.TabIndex = 13;
            viewstudentrecords.Text = "     View Student Records";
            viewstudentrecords.TextAlign = ContentAlignment.MiddleLeft;
            viewstudentrecords.TextImageRelation = TextImageRelation.ImageBeforeText;
            viewstudentrecords.UseVisualStyleBackColor = true;
            viewstudentrecords.Click += viewstudentrecords_Click;
            // 
            // home
            // 
            home.FlatAppearance.BorderSize = 0;
            home.FlatStyle = FlatStyle.Flat;
            home.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            home.ForeColor = SystemColors.ButtonHighlight;
            home.Image = (Image)resources.GetObject("home.Image");
            home.ImageAlign = ContentAlignment.MiddleLeft;
            home.Location = new Point(47, 150);
            home.Name = "home";
            home.Size = new Size(247, 53);
            home.TabIndex = 7;
            home.Text = "    Home";
            home.TextAlign = ContentAlignment.MiddleLeft;
            home.TextImageRelation = TextImageRelation.ImageBeforeText;
            home.UseVisualStyleBackColor = true;
            home.Click += home_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.LightSkyBlue;
            label5.Location = new Point(123, 90);
            label5.Name = "label5";
            label5.Size = new Size(60, 21);
            label5.TabIndex = 10;
            label5.Text = "Faculty";
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
            logoutbtn.Location = new Point(122, 302);
            logoutbtn.Margin = new Padding(1);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(56, 51);
            logoutbtn.TabIndex = 7;
            logoutbtn.UseVisualStyleBackColor = false;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(122, 45);
            label4.Name = "label4";
            label4.Size = new Size(92, 24);
            label4.TabIndex = 9;
            label4.Text = "Instructor";
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(25, 32);
            logo.Name = "logo";
            logo.Size = new Size(92, 89);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 7;
            logo.TabStop = false;
            // 
            // facultyname
            // 
            facultyname.AutoSize = true;
            facultyname.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            facultyname.ForeColor = SystemColors.Window;
            facultyname.Location = new Point(123, 66);
            facultyname.Name = "facultyname";
            facultyname.Size = new Size(146, 24);
            facultyname.TabIndex = 8;
            facultyname.Text = "Kaito Generalao";
            // 
            // panelDesktop
            // 
            panelDesktop.Location = new Point(296, 65);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(963, 696);
            panelDesktop.TabIndex = 7;
            // 
            // Faculty_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 761);
            Controls.Add(panelDesktop);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Faculty_Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Faculty_Dashboard";
            Load += Faculty_Dashboard_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button exit;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Label facultyname;
        private Label label4;
        private PictureBox logo;
        private Button logoutbtn;
        private Label label5;
        private Button home;
        private Panel panelDesktop;
        private Button viewstudentrecords;
        private Panel panel3;
    }
}