namespace SRS.Pages.Faculty.Forms
{
    partial class ViewStudentRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudentRecords));
            dataGridViewStudent = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            searchButton = new Button();
            textSearch = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewStudent
            // 
            dataGridViewStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudent.Location = new Point(0, 66);
            dataGridViewStudent.Name = "dataGridViewStudent";
            dataGridViewStudent.RowHeadersWidth = 51;
            dataGridViewStudent.RowTemplate.Height = 29;
            dataGridViewStudent.Size = new Size(955, 613);
            dataGridViewStudent.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(955, 64);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(searchButton);
            panel2.Controls.Add(textSearch);
            panel2.Location = new Point(703, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 34);
            panel2.TabIndex = 11;
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
            // textSearch
            // 
            textSearch.BorderStyle = BorderStyle.FixedSingle;
            textSearch.Location = new Point(3, 3);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = " Search...";
            textSearch.Size = new Size(202, 27);
            textSearch.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(630, 20);
            label3.Name = "label3";
            label3.Size = new Size(70, 24);
            label3.TabIndex = 10;
            label3.Text = "Search:";
            // 
            // ViewStudentRecords
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 673);
            Controls.Add(panel1);
            Controls.Add(dataGridViewStudent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewStudentRecords";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "ViewStudentRecords";
            Load += ViewStudentRecords_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewStudent;
        private Panel panel1;
        private Label label3;
        private Panel panel2;
        private Button searchButton;
        private TextBox textSearch;
    }
}