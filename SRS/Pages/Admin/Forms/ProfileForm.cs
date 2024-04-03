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

namespace SRS.Pages.Admin.Forms
{
    public partial class ProfileForm : Form
    {
        String connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SRS;Integrated Security=True;Trusted_Connection=true;MultipleActiveResultSets=true";

        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            SqlConnection ccn = new SqlConnection(connectionString);
            ccn.Open();

            SqlCommand command_totalstudent, command_totalfaculty;
            SqlDataReader reader;
            string totalstudent = "SELECT * FROM admin_tb";
            command_totalstudent = new SqlCommand(totalstudent, ccn);
            reader = command_totalstudent.ExecuteReader();
            while (reader.Read())
            {
                fntxt.Text = reader["firstname"].ToString().Replace(" ","");
                mntxt.Text = reader["middlename"].ToString().Replace(" ", "");
                lntxt.Text = reader["lastname"].ToString().Replace(" ", "");
                emailtxt.Text = reader["email"].ToString().Replace(" ", "");
                phonetxt.Text = reader["phone"].ToString().Replace(" ", "");
                username.Text = reader["username"].ToString().Replace(" ", "");
                password.Text = reader["password"].ToString().Replace(" ", "");
            }
           
        }
    }
}
