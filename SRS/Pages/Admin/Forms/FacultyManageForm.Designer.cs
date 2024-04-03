namespace SRS.Pages.Admin.Forms
{
    partial class FacultyManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacultyManageForm));
            panel1 = new Panel();
            Updatebtn = new Button();
            deletefacultybtn = new Button();
            AddNewFacultybtn = new Button();
            panel2 = new Panel();
            searchButton = new Button();
            searchFaculty = new TextBox();
            dataGridViewFaculty = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFaculty).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(Updatebtn);
            panel1.Controls.Add(deletefacultybtn);
            panel1.Controls.Add(AddNewFacultybtn);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1010, 70);
            panel1.TabIndex = 0;
            // 
            // Updatebtn
            // 
            Updatebtn.BackColor = SystemColors.MenuHighlight;
            Updatebtn.Cursor = Cursors.Hand;
            Updatebtn.FlatStyle = FlatStyle.Flat;
            Updatebtn.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Updatebtn.ForeColor = SystemColors.Window;
            Updatebtn.Location = new Point(220, 14);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(84, 38);
            Updatebtn.TabIndex = 13;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = false;
            Updatebtn.Click += Updatebtn_Click;
            // 
            // deletefacultybtn
            // 
            deletefacultybtn.BackColor = Color.Crimson;
            deletefacultybtn.Cursor = Cursors.Hand;
            deletefacultybtn.FlatStyle = FlatStyle.Flat;
            deletefacultybtn.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            deletefacultybtn.ForeColor = SystemColors.Window;
            deletefacultybtn.Location = new Point(119, 14);
            deletefacultybtn.Name = "deletefacultybtn";
            deletefacultybtn.Size = new Size(84, 38);
            deletefacultybtn.TabIndex = 11;
            deletefacultybtn.Text = "Delete";
            deletefacultybtn.UseVisualStyleBackColor = false;
            deletefacultybtn.Click += deletefacultybtn_Click;
            // 
            // AddNewFacultybtn
            // 
            AddNewFacultybtn.BackColor = Color.SeaGreen;
            AddNewFacultybtn.Cursor = Cursors.Hand;
            AddNewFacultybtn.FlatStyle = FlatStyle.Flat;
            AddNewFacultybtn.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewFacultybtn.ForeColor = SystemColors.Window;
            AddNewFacultybtn.Location = new Point(20, 14);
            AddNewFacultybtn.Name = "AddNewFacultybtn";
            AddNewFacultybtn.Size = new Size(84, 38);
            AddNewFacultybtn.TabIndex = 10;
            AddNewFacultybtn.Text = "Add";
            AddNewFacultybtn.UseVisualStyleBackColor = false;
            AddNewFacultybtn.Click += AddNewFacultybtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(searchButton);
            panel2.Controls.Add(searchFaculty);
            panel2.Location = new Point(752, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 34);
            panel2.TabIndex = 7;
            // 
            // searchButton
            // 
            searchButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchButton.BackColor = SystemColors.HotTrack;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Segoe UI", 4.8F, FontStyle.Regular, GraphicsUnit.Point);
            searchButton.ForeColor = Color.White;
            searchButton.Image = (Image)resources.GetObject("searchButton.Image");
            searchButton.Location = new Point(209, 3);
            searchButton.Margin = new Padding(1);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(27, 25);
            searchButton.TabIndex = 6;
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // searchFaculty
            // 
            searchFaculty.BorderStyle = BorderStyle.FixedSingle;
            searchFaculty.Location = new Point(3, 3);
            searchFaculty.Name = "searchFaculty";
            searchFaculty.PlaceholderText = " Search...";
            searchFaculty.Size = new Size(202, 27);
            searchFaculty.TabIndex = 0;
            // 
            // dataGridViewFaculty
            // 
            dataGridViewFaculty.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFaculty.Location = new Point(12, 76);
            dataGridViewFaculty.Name = "dataGridViewFaculty";
            dataGridViewFaculty.RowHeadersWidth = 51;
            dataGridViewFaculty.RowTemplate.Height = 29;
            dataGridViewFaculty.Size = new Size(986, 635);
            dataGridViewFaculty.TabIndex = 1;
            // 
            // FacultyManageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 723);
            Controls.Add(dataGridViewFaculty);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FacultyManageForm";
            Text = "FacultyManageForm";
            Load += FacultyManageForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFaculty).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox searchFaculty;
        private Button searchButton;
        private Panel panel2;
        private Button AddNewFacultybtn;
        private Button deletefacultybtn;
        private DataGridView dataGridViewFaculty;
        private Button Updatebtn;
    }
}