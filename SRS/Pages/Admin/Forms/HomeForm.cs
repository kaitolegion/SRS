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

namespace SRS.Pages.Admin.Forms
{
    public partial class HomeForm : Form
    {

        String connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SRS;Integrated Security=True;Trusted_Connection=true;MultipleActiveResultSets=true";

        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            SqlConnection ccn = new SqlConnection(connectionString);
            ccn.Open();

            SqlCommand command_totalstudent, command_totalfaculty;
            SqlDataReader reader;

            // string sql = "SELECT count(course_name) FROM student_tb JOIN Course ON student_tb.course_id = Course.course_id where course_name = 'BSIT'";
            string totalstudent = "SELECT count(student_id) FROM student_tb";
            command_totalstudent = new SqlCommand(totalstudent, ccn);
            reader = command_totalstudent.ExecuteReader();
            while (reader.Read())
            {
                totalStudents.Text = reader.GetValue(0).ToString();
            }

            string totalfaculty = "SELECT count(faculty_id) FROM faculty_tb";
            command_totalfaculty = new SqlCommand(totalfaculty, ccn);
            reader = command_totalfaculty.ExecuteReader();
            while (reader.Read())
            {
                totalFaculty.Text = reader.GetValue(0).ToString();
            }

        }
    }
}
