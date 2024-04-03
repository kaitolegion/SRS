using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRS.Pages.Faculty.Forms
{
    public partial class ViewStudentRecords : Form
    {

        String connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SRS;Integrated Security=True;Trusted_Connection=true;MultipleActiveResultSets=true";

        public ViewStudentRecords()
        {
            InitializeComponent();
    


        }

  


        // load student
        private void loadDataStudent()
        {

            String facultyquery = "SELECT student_tb.student_id, student_tb.firstname, student_tb.middlename, student_tb.lastname, student_tb.gender, student_tb.email_address, student_tb.contact_number, student_tb.date_of_birth, course_tb.course_name,student_tb.section, student_tb.year,student_tb.address,student_tb.username, student_tb.password,enrollment.enrollment_date FROM student_tb JOIN enrollment ON student_tb.student_id = enrollment.student_id JOIN course_tb ON student_tb.course_id = course_tb.course_id;";
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

        private void ViewStudentRecords_Load(object sender, EventArgs e)
        {
            loadDataStudent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

     
            string searchTerm = textSearch.Text.ToLower();
            dataGridViewStudent.ClearSelection();
            foreach (DataGridViewRow row in dataGridViewStudent.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchTerm))
                    {

                        cell.Selected = true;
                        break;
                    }
                }
            }


  


        }
    }
}
