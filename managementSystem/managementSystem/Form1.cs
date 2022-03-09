using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace managementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            MessageBox.Show("In COnstructor");
            InitializeComponent();
            CustomDesign();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void CustomDesign()
        {
            student_details.Visible = false;
            course_details.Visible = false;

            faculty_details.Visible = false;

        }
        //show submenu on click of student button
        private void ShowStudentSubMenu()
        {
            //if student section is not visible make it visible
            if (student_details.Visible == false)
            {
                student_details.Visible = true;
            }
            //vice versa
            else
            {
                student_details.Visible = false;
            }
        }
        private void ShowCourseSubMenu()
        {
            //if course section is not visible make it visible
            if (course_details.Visible == false)
            {
                course_details.Visible = true;
            }
            //vice versa
            else
            {
                course_details.Visible = false;
            }
        }
        private void ShowFacultySubMenu()
        {
            //if faculty section is not visible make it visible
            if (faculty_details.Visible == false)
            {
                faculty_details.Visible = true;
            }
            //vice versa
            else
            {
                faculty_details.Visible = false;
            }
        }

        private void button1_student_Click(object sender, EventArgs e)
        {
           
        }

        private Form activeForm = null;
        private void OpenChild(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            main_area.Controls.Add(childForm);
            main_area.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void registration_student_Click(object sender, EventArgs e)
        {
            OpenChild(new Form_Registration());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void student_Click(object sender, EventArgs e)
        {
            ShowStudentSubMenu();
        }

        private void course_Click(object sender, EventArgs e)
        {
            ShowCourseSubMenu();
        }

        private void faculty_Click(object sender, EventArgs e)
        {
            ShowFacultySubMenu();
        }

        private void add_student_Click(object sender, EventArgs e)
        {
            OpenChild(new Form_Registration());
        }

        
    }
}
