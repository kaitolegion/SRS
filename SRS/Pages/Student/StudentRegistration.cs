using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace SRS.Pages.Student
{
    public partial class StudentRegistration : Form
    {

        bool isDragging;
        private int mouseX, mouseY;
        String connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SRS;Integrated Security=True;Trusted_Connection=true;MultipleActiveResultSets=true";
        private Dictionary<int, string> courseDictionary = new Dictionary<int, string>();

        public StudentRegistration()
        {
            InitializeComponent();

            // custom datetimepicker
            date.Format = DateTimePickerFormat.Custom;
            date.CustomFormat = "dd/MM/yyyy";
            // end

            courseDictionary.Add(0, "");
            courseDictionary.Add(1, "BSIT");
            courseDictionary.Add(2, "BSIS");
            courseDictionary.Add(3, "BSCS");
            courseDictionary.Add(4, "BSCE");

            courseInput.DataSource = new BindingSource(courseDictionary, null);
            courseInput.DisplayMember = "Value";  // Display member (string)
            courseInput.ValueMember = "Key";      // Value member (integer)

        }

        // METHOD INSERTING DATA
        public bool insertDataStudent()
        {
            bool insertSuccess = false;

            if (string.IsNullOrWhiteSpace(FirstnameInput.Text) ||
                string.IsNullOrWhiteSpace(LastnameInput.Text) || string.IsNullOrWhiteSpace(genderInput.Text) ||
                string.IsNullOrWhiteSpace(emailInput.Text) || string.IsNullOrWhiteSpace(contactNoInput.Text) ||
                string.IsNullOrWhiteSpace(sectionInput.Text) || string.IsNullOrWhiteSpace(yearInput.Text) ||
                string.IsNullOrWhiteSpace(addressInput.Text) || string.IsNullOrWhiteSpace(usernameInput.Text) ||
                string.IsNullOrWhiteSpace(passwordInput.Text))
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
                            cmd.Parameters.AddWithValue("@firstname", FirstnameInput.Text);
                            cmd.Parameters.AddWithValue("@middlename", MiddlenameInput.Text);
                            cmd.Parameters.AddWithValue("@lastname", LastnameInput.Text);
                            cmd.Parameters.AddWithValue("@gender", genderInput.Text);
                            cmd.Parameters.AddWithValue("@email_address", emailInput.Text);
                            cmd.Parameters.AddWithValue("@contact_number", contactNoInput.Text);
                            cmd.Parameters.AddWithValue("@date_of_birth", date.Value.ToShortDateString());
                            cmd.Parameters.AddWithValue("@course_id", (int)courseInput.SelectedValue);
                            cmd.Parameters.AddWithValue("@section", sectionInput.Text);
                            cmd.Parameters.AddWithValue("@year", yearInput.Text);
                            cmd.Parameters.AddWithValue("@address", addressInput.Text);
                            cmd.Parameters.AddWithValue("@username", usernameInput.Text);
                            cmd.Parameters.AddWithValue("@password", passwordInput.Text);
                           
                            studentid = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                        string enrollmentQuery = "INSERT INTO enrollment (student_id, course_id, enrollment_date, grade) VALUES (@studentid, @courseid, @enrollmentdate, @grade)";
                        using (SqlCommand cmd = new SqlCommand(enrollmentQuery, ccn, transaction))
                        {
                            DateTime currentDate = DateTime.Now;
                            string formattedDate = currentDate.ToString("MM/dd/yy");
                            cmd.Parameters.AddWithValue("@studentid", studentid);
                            cmd.Parameters.AddWithValue("@courseid", (int)courseInput.SelectedValue);
                            cmd.Parameters.AddWithValue("@enrollmentdate", formattedDate);
                            cmd.Parameters.AddWithValue("@grade", "");
                            cmd.ExecuteNonQuery();
                        }
                        transaction.Commit();
                        insertSuccess = true;
                        MessageBox.Show("Data inserted successfully.");

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


        private void back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void StudentRegistration_Load(object sender, EventArgs e)
        {

        }

        private void RegisterSubmit_Click(object sender, EventArgs e)
        {
            int selectedCourseId = (int)courseInput.SelectedValue;
            if (selectedCourseId != 0)
            {
                if (insertDataStudent())
                {
                    Main main = new Main();
                    main.Show();
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("Not recognized Course, Please select your course");
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int mousex = MousePosition.X - 400;
                int mousey = MousePosition.Y - 20;
                this.DesktopLocation = new Point(mousex, mousey);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}
