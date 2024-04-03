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
    public partial class Admin_AddFaculty : Form
    {

        String connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SRS;Integrated Security=True;Trusted_Connection=true;MultipleActiveResultSets=true";

        public Admin_AddFaculty()
        {
            InitializeComponent();
        }


        // METHOD INSERTING DATA
        public bool insertDataFaculty()
        {
            bool insertSuccess = false;

            if (string.IsNullOrWhiteSpace(firstname.Text) ||
                string.IsNullOrWhiteSpace(middlename.Text) || string.IsNullOrWhiteSpace(lastname.Text) ||
                string.IsNullOrWhiteSpace(gender.Text) || string.IsNullOrWhiteSpace(dateofbirth.Text) || string.IsNullOrWhiteSpace(email.Text) ||
                string.IsNullOrWhiteSpace(phone.Text) || string.IsNullOrWhiteSpace(address.Text) ||
                string.IsNullOrWhiteSpace(department.Text) || string.IsNullOrWhiteSpace(username.Text) ||
                string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Please provide values for all fields.");
                return false; // exit the method if input is not valid
            }

            using (SqlConnection ccn = new SqlConnection(connectionString))
            {
                try
                {
                    ccn.Open();
                    string insertQuery = "INSERT INTO faculty_tb (firstname, middlename, lastname, gender, date_of_birth, email, phone, address, department, username, password) VALUES (@firstname, @middlename, @lastname, @gender, @dateofbirth, @email, @phone, @address, @department, @username, @password)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, ccn))
                    {
                        cmd.Parameters.AddWithValue("@firstname", firstname.Text);
                        cmd.Parameters.AddWithValue("@middlename", middlename.Text);
                        cmd.Parameters.AddWithValue("@lastname", lastname.Text);
                        cmd.Parameters.AddWithValue("@gender", gender.Text);
                        cmd.Parameters.AddWithValue("@dateofbirth", dateofbirth.Value.ToShortDateString());
                        cmd.Parameters.AddWithValue("@email", email.Text);
                        cmd.Parameters.AddWithValue("@phone", phone.Text);
                        cmd.Parameters.AddWithValue("@address", address.Text);
                        cmd.Parameters.AddWithValue("@department", department.Text);
                        cmd.Parameters.AddWithValue("@username", username.Text);
                        cmd.Parameters.AddWithValue("@password", password.Text);
                        cmd.ExecuteNonQuery();
                    }
                    insertSuccess = true;
                    MessageBox.Show("Added Faculty successfully.");

                }
                catch (Exception e)
                {
                    MessageBox.Show("Something wrong: " + e);
                }
                finally
                {
                    ccn.Close();

                }
            }


            return insertSuccess;

        }

        // END
        private void submitAdd_Click(object sender, EventArgs e)
        {
            if (insertDataFaculty() == true)
            {
                this.Close();
            }
        }

        private void firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateofbirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Admin_AddFaculty_Load(object sender, EventArgs e)
        {

        }
    }
}
