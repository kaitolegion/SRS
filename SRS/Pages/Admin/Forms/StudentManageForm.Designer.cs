namespace SRS.Pages.Admin.Forms
{
    partial class StudentManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentManageForm));
            panel1 = new Panel();
            updateStudentbtn = new Button();
            deleteStudentbtn = new Button();
            AddNewStudentbtn = new Button();
            panel2 = new Panel();
            exit = new Button();
            textBox1 = new TextBox();
            dataGridViewStudent = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(updateStudentbtn);
            panel1.Controls.Add(deleteStudentbtn);
            panel1.Controls.Add(AddNewStudentbtn);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1010, 70);
            panel1.TabIndex = 1;
            // 
            // updateStudentbtn
            // 
            updateStudentbtn.BackColor = SystemColors.MenuHighlight;
            updateStudentbtn.Cursor = Cursors.Hand;
            updateStudentbtn.FlatStyle = FlatStyle.Flat;
            updateStudentbtn.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            updateStudentbtn.ForeColor = SystemColors.Window;
            updateStudentbtn.Location = new Point(217, 14);
            updateStudentbtn.Name = "updateStudentbtn";
            updateStudentbtn.Size = new Size(84, 38);
            updateStudentbtn.TabIndex = 12;
            updateStudentbtn.Text = "Update";
            updateStudentbtn.UseVisualStyleBackColor = false;
            updateStudentbtn.Click += updateStudentbtn_Click;
            // 
            // deleteStudentbtn
            // 
            deleteStudentbtn.BackColor = Color.Crimson;
            deleteStudentbtn.Cursor = Cursors.Hand;
            deleteStudentbtn.FlatStyle = FlatStyle.Flat;
            deleteStudentbtn.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            deleteStudentbtn.ForeColor = SystemColors.Window;
            deleteStudentbtn.Location = new Point(119, 14);
            deleteStudentbtn.Name = "deleteStudentbtn";
            deleteStudentbtn.Size = new Size(84, 38);
            deleteStudentbtn.TabIndex = 11;
            deleteStudentbtn.Text = "Delete";
            deleteStudentbtn.UseVisualStyleBackColor = false;
            deleteStudentbtn.Click += deleteStudentbtn_Click;
            // 
            // AddNewStudentbtn
            // 
            AddNewStudentbtn.BackColor = Color.SeaGreen;
            AddNewStudentbtn.Cursor = Cursors.Hand;
            AddNewStudentbtn.FlatStyle = FlatStyle.Flat;
            AddNewStudentbtn.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewStudentbtn.ForeColor = SystemColors.Window;
            AddNewStudentbtn.Location = new Point(20, 14);
            AddNewStudentbtn.Name = "AddNewStudentbtn";
            AddNewStudentbtn.Size = new Size(84, 38);
            AddNewStudentbtn.TabIndex = 10;
            AddNewStudentbtn.Text = "Add";
            AddNewStudentbtn.UseVisualStyleBackColor = false;
            AddNewStudentbtn.Click += AddNewStudentbtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(exit);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(752, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 34);
            panel2.TabIndex = 7;
            // 
            // exit
            // 
            exit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            exit.BackColor = SystemColors.HotTrack;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Font = new Font("Segoe UI", 4.8F, FontStyle.Regular, GraphicsUnit.Point);
            exit.ForeColor = Color.White;
            exit.Image = (Image)resources.GetObject("exit.Image");
            exit.Location = new Point(209, 3);
            exit.Margin = new Padding(1);
            exit.Name = "exit";
            exit.Size = new Size(27, 25);
            exit.TabIndex = 6;
            exit.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = " Search...";
            textBox1.Size = new Size(202, 27);
            textBox1.TabIndex = 0;
            // 
            // dataGridViewStudent
            // 
            dataGridViewStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudent.Location = new Point(12, 76);
            dataGridViewStudent.Name = "dataGridViewStudent";
            dataGridViewStudent.RowHeadersWidth = 51;
            dataGridViewStudent.RowTemplate.Height = 29;
            dataGridViewStudent.Size = new Size(986, 635);
            dataGridViewStudent.TabIndex = 2;
            // 
            // StudentManageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 723);
            Controls.Add(dataGridViewStudent);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentManageForm";
            Text = "StudentManageForm";
            Load += StudentManageForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button deleteStudentbtn;
        private Button AddNewStudentbtn;
        private Panel panel2;
        private Button exit;
        private TextBox textBox1;
        private DataGridView dataGridViewStudent;
        private Button updateStudentbtn;
    }
}