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
    public partial class FacultyManageForm : Form
    {

        String connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SRS;Integrated Security=True;Trusted_Connection=true;MultipleActiveResultSets=true";
        private DataTable dataTable;
        public FacultyManageForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            
        }

        private void InitializeDataGridView()
        {
            // Assuming you have a DataTable as the data source
            dataTable = new DataTable();
            dataGridViewFaculty.DataSource = dataTable;
        }

        private void AddNewFacultybtn_Click(object sender, EventArgs e)
        {
            Admin_AddFaculty add = new Admin_AddFaculty();
            add.Show();
        }

        // load faculty
        private void loadDataFaculty()
        {
           
            String facultyquery = "SELECT * FROM faculty_tb";
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
                        dataGridViewFaculty.DataSource = dataTable;
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
        private void FacultyManageForm_Load(object sender, EventArgs e)
        {
            loadDataFaculty();
        }

        // update
        private void Updatebtn_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "update faculty_tb set firstname=@firstname, middlename=@middlename, lastname=@lastname, date_of_birth=@dob, email=@email, phone=@phone, address=@address, department=@department, username=@username, password=@password,gender=@gender WHERE faculty_id = @faculty_id";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.Add("@firstname", SqlDbType.VarChar);
                    command.Parameters.Add("@middlename", SqlDbType.VarChar);
                    command.Parameters.Add("@lastname", SqlDbType.VarChar);
                    command.Parameters.Add("@dob", SqlDbType.VarChar);
                    command.Parameters.Add("@email", SqlDbType.VarChar);
                    command.Parameters.Add("@phone", SqlDbType.VarChar);
                    command.Parameters.Add("@address", SqlDbType.VarChar);
                    command.Parameters.Add("@department", SqlDbType.VarChar);
                    command.Parameters.Add("@username", SqlDbType.VarChar);
                    command.Parameters.Add("@password", SqlDbType.VarChar);
                    command.Parameters.Add("@gender", SqlDbType.VarChar);
                    command.Parameters.Add("@faculty_id", SqlDbType.Int);

                    foreach (DataGridViewRow row in dataGridViewFaculty.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            command.Parameters["@firstname"].Value = row.Cells["firstname"].Value;
                            command.Parameters["@middlename"].Value = row.Cells["middlename"].Value;
                            command.Parameters["@lastname"].Value = row.Cells["lastname"].Value;
                            command.Parameters["@dob"].Value = row.Cells["date_of_birth"].Value;
                            command.Parameters["@email"].Value = row.Cells["email"].Value;
                            command.Parameters["@phone"].Value = row.Cells["phone"].Value;
                            command.Parameters["@address"].Value = row.Cells["address"].Value;
                            command.Parameters["@department"].Value = row.Cells["department"].Value;
                            command.Parameters["@username"].Value = row.Cells["username"].Value;
                            command.Parameters["@password"].Value = row.Cells["password"].Value;
                            command.Parameters["@gender"].Value = row.Cells["gender"].Value;
                            command.Parameters["@faculty_id"].Value = row.Cells["faculty_id"].Value;
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Faculty updated successfully.");
                    loadDataFaculty();
                }
            }
        }

        // end

        // delete
        private void deletefacultybtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewFaculty.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int rowIndex = dataGridViewFaculty.SelectedRows[0].Index;

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string deleteQuery = "DELETE FROM faculty_tb WHERE faculty_id = @faculty_id";

                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.Add("@faculty_id", System.Data.SqlDbType.Int).Value = dataGridViewFaculty.Rows[rowIndex].Cells["faculty_id"].Value;
                            command.ExecuteNonQuery();
                            MessageBox.Show("Record deleted successfully.");
                            loadDataFaculty();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // end

        // search
        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchText = searchFaculty.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {

                var foundRows = dataTable.AsEnumerable()
                    .Where(row => row.ItemArray.Any(field => field.ToString().Contains(searchText)))
                    .ToArray();

 
                if (foundRows.Length > 0)
                {

                    DataTable searchResultTable = foundRows.CopyToDataTable();

                  
                    dataGridViewFaculty.DataSource = searchResultTable;
                }
                else
                {
                    MessageBox.Show("No matching records found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
             
                dataGridViewFaculty.DataSource = dataTable;
            }
        
        }

        // end
    }
}
