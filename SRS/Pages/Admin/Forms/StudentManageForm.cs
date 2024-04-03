using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRS.Dialogs;

namespace SRS.Pages.Admin.Forms
{
    public partial class StudentManageForm : Form
    {

        String connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SRS;Integrated Security=True;Trusted_Connection=true;MultipleActiveResultSets=true";

        public StudentManageForm()
        {
            InitializeComponent();
        }


        // load student
        private void loadDataStudent()
        {

            String facultyquery = "SELECT student_tb.student_id, student_tb.firstname, student_tb.middlename, student_tb.lastname, student_tb.gender, student_tb.email_address, student_tb.contact_number, student_tb.date_of_birth,student_tb.course_id,student_tb.section, student_tb.year,student_tb.address,student_tb.username, student_tb.password,enrollment.enrollment_date FROM student_tb JOIN enrollment ON student_tb.student_id = enrollment.student_id;";
            using (SqlConnection ccn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(facultyquery, ccn))
                {
                    try
                    {
                        ccn.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dataGridViewStudent.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        ccn.Close();
                    }
                }
            }
        }

        // end
        // student main form
        private void StudentManageForm_Load(object sender, EventArgs e)
        {
           
            loadDataStudent();
        }
        // end


        private void deletefacultybtn_Click(object sender, EventArgs e)
        {

        }
        // delete
        private void deleteStudentbtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudent.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int rowIndex = dataGridViewStudent.SelectedRows[0].Index;

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // string deleteQuery = "DELETE FROM student_tb WHERE student_id = @student_id";
                        string deleteQuery = "BEGIN TRANSACTION; BEGIN TRY DELETE FROM enrollment WHERE student_id = @student_id; DELETE FROM student_tb WHERE student_id = @student_id; COMMIT; END TRY BEGIN CATCH ROLLBACK; END CATCH;";

                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.Add("@student_id", System.Data.SqlDbType.Int).Value = dataGridViewStudent.Rows[rowIndex].Cells["student_id"].Value;
                            command.ExecuteNonQuery();
                            MessageBox.Show("Record deleted successfully.");
                            loadDataStudent();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void updateStudentbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // string updateQuery = "BEGIN TRANSACTION; BEGIN TRY UPDATE student_tb SET firstname = @firstname, middlename = @middlename, lastname = @lastname, gender = @gender, email_address = @email, contact_number = @phone, date_of_birth = @dob, course_id = @courseid, section = @section, year = @year, address = @address, username, @username, password = @password WHERE student_id = @student_id; UPDATE enrollment SET enrollment_date = @enrollmentdate WHERE student_id = @student_id; COMMIT; END TRY BEGIN CATCH ROLLBACK; END CATCH;";
                string updateQuery = "BEGIN TRANSACTION; BEGIN TRY UPDATE student_tb SET firstname = @firstname, middlename = @middlename, lastname = @lastname, gender = @gender, email_address = @email, contact_number = @phone, date_of_birth = @dob, course_id = @courseid, section = @section, year = @year, address = @address, username = @usern, password = @password  WHERE student_id = @student_id; UPDATE enrollment SET enrollment_date = @enrollmentdate WHERE student_id = @student_id; COMMIT; END TRY BEGIN CATCH ROLLBACK; END CATCH;";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.Add("@firstname", SqlDbType.VarChar);
                    command.Parameters.Add("@middlename", SqlDbType.VarChar);
                    command.Parameters.Add("@lastname", SqlDbType.VarChar);
                    command.Parameters.Add("@gender", SqlDbType.VarChar);
                    command.Parameters.Add("@email", SqlDbType.VarChar);
                    command.Parameters.Add("@phone", SqlDbType.VarChar);
                    command.Parameters.Add("@dob", SqlDbType.VarChar);
                    command.Parameters.Add("@courseid", SqlDbType.Int);
                    command.Parameters.Add("@section", SqlDbType.VarChar);
                    command.Parameters.Add("@year", SqlDbType.VarChar);
                    command.Parameters.Add("@address", SqlDbType.VarChar);
                    command.Parameters.Add("@usern", SqlDbType.VarChar);
                    command.Parameters.Add("@password", SqlDbType.VarChar);
                    command.Parameters.Add("@enrollmentdate", SqlDbType.VarChar);
                    command.Parameters.Add("@student_id", SqlDbType.Int);

                    foreach (DataGridViewRow row in dataGridViewStudent.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            command.Parameters["@firstname"].Value = row.Cells["firstname"].Value;
                            command.Parameters["@middlename"].Value = row.Cells["middlename"].Value;
                            command.Parameters["@lastname"].Value = row.Cells["lastname"].Value;
                            command.Parameters["@gender"].Value = row.Cells["gender"].Value;
                            command.Parameters["@email"].Value = row.Cells["email_address"].Value;
                            command.Parameters["@phone"].Value = row.Cells["contact_number"].Value;
                            command.Parameters["@dob"].Value = row.Cells["date_of_birth"].Value;
                            command.Parameters["@courseid"].Value = row.Cells["course_id"].Value;
                            command.Parameters["@section"].Value = row.Cells["section"].Value;
                            command.Parameters["@year"].Value = row.Cells["year"].Value;
                            command.Parameters["@address"].Value = row.Cells["address"].Value;
                            command.Parameters["@usern"].Value = row.Cells["username"].Value;
                            command.Parameters["@password"].Value = row.Cells["password"].Value;
                            command.Parameters["@enrollmentdate"].Value = row.Cells["enrollment_date"].Value;
                            command.Parameters["@student_id"].Value = row.Cells["student_id"].Value;
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Student updated successfully.");
                    loadDataStudent();
                }
            }
        }

        private void AddNewStudentbtn_Click(object sender, EventArgs e)
        {
            Admin_AddStudent addStudent = new Admin_AddStudent();   
            addStudent.ShowDialog();
           
        }
        // end
    }
}
