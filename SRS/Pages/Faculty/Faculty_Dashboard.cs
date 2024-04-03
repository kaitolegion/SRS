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
namespace SRS.Pages.Faculty;

public partial class Faculty_Dashboard : Form
{
    String connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SRS;Integrated Security=True;Trusted_Connection=true;MultipleActiveResultSets=true";

    private Form activeForm;
    private bool isDragging = false;
    private Point mouseDownPoint = Point.Empty;
    public Faculty_Dashboard()
    {
        InitializeComponent();
    }


    // is faculty valid
    static bool IsFacultyIdValid(int facultyId, SqlConnection connection)
    {
        string query = "SELECT COUNT(*) FROM faculty_tb WHERE faculty_id = @FacultyId";

        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@FacultyId", facultyId);
            int count = (int)command.ExecuteScalar();
            return count > 0;
        }
    }
    // end 


    // get faculty information
    private static void GetFacultyInformation(int facultyId, SqlConnection connection)
    {
        string query = "SELECT * FROM faculty_tb WHERE faculty_id = @FacultyId";

        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@FacultyId", facultyId);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Access data using reader["ColumnName"]
                    int id = Convert.ToInt32(reader["faculty_id"]);
                    string name = Convert.ToString(reader["firstname"]);
                    string lastname = Convert.ToString(reader["lastname"]);

                }
            }
        }
    }

    // end

    private void OpenForm(Form form, object btnSender)
    {
        if (activeForm != null)
        {
            activeForm.Close();
        }
        //  ActivateButton(btnSender);
        activeForm = form;
        form.TopLevel = false;
        form.FormBorderStyle = FormBorderStyle.None;
        form.Dock = DockStyle.Fill;
        this.panelDesktop.Controls.Add(form);
        this.panelDesktop.Tag = form;
        form.BringToFront();
        form.Show();
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void Faculty_Dashboard_Load(object sender, EventArgs e)
    {
        OpenForm(new Forms.HomeForm(), sender);

        int loggedInFacultyId = 1;

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                if (IsFacultyIdValid(loggedInFacultyId, connection))
                {

                    GetFacultyInformation(loggedInFacultyId, connection);
                }
                else
                {
                    Console.WriteLine("Invalid faculty ID");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    private void logoutbtn_Click(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

    }

    private void home_Click(object sender, EventArgs e)
    {
        OpenForm(new Forms.HomeForm(), sender);
    }

    private void viewstudentrecords_Click(object sender, EventArgs e)
    {
        OpenForm(new Forms.ViewStudentRecords(), sender);
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



