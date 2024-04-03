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

namespace SRS.Dialogs
{
    public partial class Admin_AddStudent : Form
    {
        String connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SRS;Integrated Security=True;Trusted_Connection=true;MultipleActiveResultSets=true";

        // course dictionary
        private Dictionary<int, string> courseDictionary = new Dictionary<int, string>();

        public Admin_AddStudent()
        {
            InitializeComponent();
            // custom datetimepicker
            date.Format = DateTimePickerFormat.Custom;
            date.CustomFormat = "dd/MM/yyyy";
            // end

            // list data of course
            courseDictionary.Add(0, "");
            courseDictionary.Add(1, "BSIT");
            courseDictionary.Add(2, "BSIS");
            courseDictionary.Add(3, "BSCS");
            courseDictionary.Add(4, "BSCE");

            course.DataSource = new BindingSource(courseDictionary, null);
            course.DisplayMember = "Value";  // Display member (string)
            course.ValueMember = "Key";      // Value member (integer)

        }

        // METHOD INSERTING DATA
        public bool insertDataStudent()
        {
            bool insertSuccess = false;

            if (string.IsNullOrWhiteSpace(firstname.Text) || string.IsNullOrWhiteSpace(lastname.Text) || string.IsNullOrWhiteSpace(gender.Text) ||
                string.IsNullOrWhiteSpace(email.Text) || string.IsNullOrWhiteSpace(phone.Text) || string.IsNullOrWhiteSpace(section.Text) || string.IsNullOrWhiteSpace(year.Text) ||
                string.IsNullOrWhiteSpace(address.Text) || string.IsNullOrWhiteSpace(username.Text) || string.IsNullOrWhiteSpace(course.Text) || string.IsNullOrWhiteSpace(enrolldate.Text) ||
                string.IsNullOrWhiteSpace(username.Text) || string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Please provide values for all fields.");
                return false; // exit the method if input is not valid
            }
            using (SqlConnection ccn = new SqlConnection(connectionString))
            {
                ccn.Open();
                using (SqlTransaction transaction = ccn.BeginTransaction())
                {
                    try
                    {
                        string insertQuery = "INSERT INTO student_tb (firstname, middlename, lastname, gender, email_address, contact_number, date_of_birth, course_id, section, year, address, username, password) VALUES (@firstname, @middlename, @lastname, @gender, @email_address, @contact_number, @date_of_birth, @course_id, @section, @year, @address, @username, @password); SELECT SCOPE_IDENTITY();";


                        int studentid;
                        using (SqlCommand cmd = new SqlCommand(insertQuery, ccn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@firstname", firstname.Text);
                            cmd.Parameters.AddWithValue("@middlename", middlename.Text);
                            cmd.Parameters.AddWithValue("@lastname", lastname.Text);
                            cmd.Parameters.AddWithValue("@gender", gender.Text);
                            cmd.Parameters.AddWithValue("@email_address", email.Text);
                            cmd.Parameters.AddWithValue("@contact_number", phone.Text);
                            cmd.Parameters.AddWithValue("@date_of_birth", date.Value.ToShortDateString());
                            cmd.Parameters.AddWithValue("@course_id", (int)course.SelectedValue);
                            cmd.Parameters.AddWithValue("@section", section.Text);
                            cmd.Parameters.AddWithValue("@year", year.Text);
                            cmd.Parameters.AddWithValue("@address", address.Text);
                            cmd.Parameters.AddWithValue("@username", username.Text);
                            cmd.Parameters.AddWithValue("@password", password.Text);

                            studentid = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                        string enrollmentQuery = "INSERT INTO enrollment (student_id, course_id, enrollment_date, grade) VALUES (@studentid, @courseid, @enrollmentdate, @grade)";
                        using (SqlCommand cmd = new SqlCommand(enrollmentQuery, ccn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@studentid", studentid);
                            cmd.Parameters.AddWithValue("@courseid", (int)course.SelectedValue);
                            cmd.Parameters.AddWithValue("@enrollmentdate", enrolldate.Text);
                            cmd.Parameters.AddWithValue("@grade", "");
                            cmd.ExecuteNonQuery();
                        }
                        transaction.Commit();
                        insertSuccess = true;
                        MessageBox.Show("Added Student successfully.");

                    }
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Something wrong: " + e);
                    }
                    finally
                    {
                        ccn.Close();
                    }
                }


                return insertSuccess;

            }
        }

        // END

        private void Admin_AddStudent_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("MM/dd/yy");
            enrolldate.Text = formattedDate.ToString();
        }

        private void submitAdd_Click(object sender, EventArgs e)
        {
            if (insertDataStudent())
            {
                this.Close();
            }

        }
    }
}
