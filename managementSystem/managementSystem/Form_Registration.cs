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
    public partial class Form_Registration : Form
    {
        Student st = new Student();
        public Form_Registration()
        {
            InitializeComponent();
        }

        private void submit_reg_Click(object sender, EventArgs e)
        {
            
            string first = firstName.Text;
            string last = lastName.Text;
            DateTime birth = dateOfBirth.Value;
            string phone_no = phone.Text;
            string gendr = male.Checked?"M":"F";


            try {
                //Update the record
                if ("Update".Equals(submit_reg.Text)) {
                    if (st.updateStudent(Convert.ToInt32(id.Text) ,first, last, birth, phone_no, gendr))
                    {
                        MessageBox.Show("Updated ");
                        ShowStudentData();
                        clearFields();


                    }
                    else
                    {
                        MessageBox.Show("Problem in update");
                    }
                }
                //insert the record
                else
                {
                    if (st.insertStudent(first, last, birth, phone_no, gendr))
                    {
                        MessageBox.Show("Added ");
                        ShowStudentData();
                        clearFields();

                    }
                    else
                    {
                        MessageBox.Show("Problem");
                    }
                }
                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }

        //clear form
        public void clearFields()
        {
            firstName.Clear();
            lastName.Clear();
            phone.Clear();
            male.Checked = false;
            female.Checked = false;
        }
        //after loading the form, display data
        private void Form_Registration_Load(object sender, EventArgs e)
        {
            ShowStudentData();
            AddDeleteButtonToGrid();
            AddUpdateButtonToGrid();

        }
        //display grid data
        public void AddDeleteButtonToGrid()
        {
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Text = "Delete";
            button.Name = "delete";
            button.UseColumnTextForButtonValue = true;
            student_grid.Columns.Add(button);
        }

        public void AddUpdateButtonToGrid()
        {
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Text = "Update";
            button.Name = "update";
            button.UseColumnTextForButtonValue = true;
            student_grid.Columns.Add(button);
        }
        public void ShowStudentData()
        {
            student_grid.DataSource = st.getStudents();
            
           

        }

        private void clear_reg_Click(object sender, EventArgs e)
        {
            firstName.Clear();
            lastName.Clear();
            phone.Clear();
            male.Checked = false;
            female.Checked = false;


        }

        private void student_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string updateButton = student_grid["update", e.RowIndex].Value.ToString();
            int buttonClicked = e.ColumnIndex;

            
            if (buttonClicked == 0)
            {
                string cellValue = student_grid["studentId", e.RowIndex].Value.ToString();
                if (cellValue != "")
                {
                    int studentIdDelete = Convert.ToInt32(cellValue);
                    if (st.deleteStudent(studentIdDelete))
                    {
                        ShowStudentData();
                    }
                }
                else
                {
                    MessageBox.Show("no rows in table");
                }
            }
            //else update
            else if(buttonClicked == 1)
            {
                form_label.Text = "Update Student";
                string Id = student_grid["studentId", e.RowIndex].Value.ToString();
                string first = student_grid["firstName", e.RowIndex].Value.ToString();
                string last = student_grid["lastName", e.RowIndex].Value.ToString();
                string phone_no = student_grid["phone", e.RowIndex].Value.ToString();
                string dateofbirth = student_grid["dateOfBirth", e.RowIndex].Value.ToString();
                string gender_m_f = student_grid["gender", e.RowIndex].Value.ToString();
                firstName.Text = first;
                lastName.Text = last;
                phone.Text = phone_no;
                dateOfBirth.Value = DateTime.ParseExact(dateofbirth, "dd-MM-yyyy hh:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

                if (gender_m_f.Equals("M"))
                {
                    male.Checked = true;
                }
                else
                {
                    female.Checked = true;
                }

                //update student id as label to update
                id.Text = Id;
                submit_reg.Text = "Update";





            }







        }

        private void student_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
