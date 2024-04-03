namespace SRS.Pages.Admin.Forms
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            totalStudents = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            totalFaculty = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(308, 65);
            label1.Name = "label1";
            label1.Size = new Size(459, 45);
            label1.TabIndex = 0;
            label1.Text = "ADMINISTRATOR DASHBOARD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(131, 58);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 1;
            label2.Text = "Total Students";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(totalStudents);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(251, 212);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 99);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 67);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // totalStudents
            // 
            totalStudents.AutoSize = true;
            totalStudents.FlatStyle = FlatStyle.Flat;
            totalStudents.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            totalStudents.ForeColor = SystemColors.ButtonHighlight;
            totalStudents.Location = new Point(187, 10);
            totalStudents.Name = "totalStudents";
            totalStudents.Size = new Size(33, 38);
            totalStudents.TabIndex = 2;
            totalStudents.Text = "0";
            // 
            // panel2
            // 
            panel2.BackColor = Color.ForestGreen;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(totalFaculty);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(531, 212);
            panel2.Name = "panel2";
            panel2.Size = new Size(248, 99);
            panel2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(33, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 59);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // totalFaculty
            // 
            totalFaculty.AutoSize = true;
            totalFaculty.FlatStyle = FlatStyle.Flat;
            totalFaculty.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            totalFaculty.ForeColor = SystemColors.ButtonHighlight;
            totalFaculty.Location = new Point(187, 10);
            totalFaculty.Name = "totalFaculty";
            totalFaculty.Size = new Size(33, 38);
            totalFaculty.TabIndex = 2;
            totalFaculty.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(131, 58);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 1;
            label5.Text = "Total Faculty";
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 632);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeForm";
            Text = "HomeForm";
            Load += HomeForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label totalStudents;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label totalFaculty;
        private Label label5;
    }
}