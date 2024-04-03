using SRS.Pages.Admin;
using SRS.Pages.Student;
using SRS.Pages.Faculty;
using System.Data.SqlClient;
namespace SRS
{
    public partial class Main : Form
    {

        String connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SRS;Integrated Security=True;Trusted_Connection=true;MultipleActiveResultSets=true";
        private bool isDragging = false;
        private Point mouseDownPoint = Point.Empty;
       

        public Main()
        {
            InitializeComponent();
        }

        // check valid login faculty
        private bool IsValidLoginFaculty(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM faculty_tb WHERE Username = @Username AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }
        // end 

        // check valid login admin
        private bool IsValidLoginAdmin(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM admin_tb WHERE Username = @Username AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        // end 

        // check valid login student
        private bool IsValidLoginStudent(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM student_tb WHERE Username = @Username AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        // end 


        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentReg_Click(object sender, EventArgs e)
        {
            StudentRegistration studentRegistration = new StudentRegistration();
            studentRegistration.Show();
            this.Hide();
        }

        private void submitLogin_Click(object sender, EventArgs e)
        {
            if (selectRoles.Text == "Student")
            {


                if (IsValidLoginStudent(Username.Text, Password.Text))
                {
                    MessageBox.Show("Login successfully Student");
                    Student_Dashboard student_Dashboard = new Student_Dashboard();
                    student_Dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Username.Clear();
                    Password.Clear();
                }
            }
            else if (selectRoles.Text == "Faculty")
            {

                if (IsValidLoginFaculty(Username.Text, Password.Text))
                {
                    MessageBox.Show("Login successfully Faculty");
                    Faculty_Dashboard faculty_Dashboard = new Faculty_Dashboard();
                    faculty_Dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Username.Clear();
                    Password.Clear();
                }
            }
            else if (selectRoles.Text == "Administrator")
            {

                if (IsValidLoginAdmin(Username.Text, Password.Text))
                {
                    MessageBox.Show("Login Successfully.", " Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Admin_Dashboard admin_Dashboard = new Admin_Dashboard();
                    admin_Dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Username.Clear();
                    Password.Clear();
                }
            }
            else
            {
                MessageBox.Show("Not Recognized Role", "Roles required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                Password.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
            }
        }

        private void draggablePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownPoint = new Point(e.X, e.Y);
                isDragging = true;
            }
        }

        private void draggablePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point mousePosition = Control.MousePosition;
                mousePosition.Offset(-mouseDownPoint.X, -mouseDownPoint.Y);
                Location = mousePosition;
            }
        }

        private void draggablePanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
    }
}