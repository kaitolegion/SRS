using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SRS.Pages.Admin
{
    public partial class Admin_Dashboard : Form
    {
        private Form activeForm;
        private bool isDragging = false;
        private Point mouseDownPoint = Point.Empty;
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

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


        private void Homebtn_Click(object sender, EventArgs e)
        {
            hoverhome.Visible = !hoverhome.Visible;
            OpenForm(new Forms.HomeForm(), sender);
        }

        private void Facultybtn_Click(object sender, EventArgs e)
        {
            hoverfaculty.Visible = !hoverfaculty.Visible;
            OpenForm(new Forms.FacultyManageForm(), sender);
        }

        private void studentbtn_Click(object sender, EventArgs e)
        {
            hoverstudent.Visible = !hoverstudent.Visible;
            OpenForm(new Forms.StudentManageForm(), sender);
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            hoverprofile.Visible = !hoverprofile.Visible;
            OpenForm(new Forms.ProfileForm(), sender);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Log Out Successfully!");
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            OpenForm(new Forms.HomeForm(), sender);
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
