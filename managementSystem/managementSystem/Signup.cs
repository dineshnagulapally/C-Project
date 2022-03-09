using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace managementSystem
{
    public partial class Signup : Form
    {
        DBconnect connect = new DBconnect();
        //DBValidations dbvalid = new DBValidations();
        validateEmptyFields validateFields = new validateEmptyFields();

        public Signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userId = userName_signup.Text;
            string password = password_signup.Text;
            string retype_password = retype_password_signup.Text;
            DateTime dateCreated = DateTime.Now;

            SignUpForm(userId, password, retype_password, dateCreated);
        }

       

        public void SignUpForm(string userName, string password, string retype_password, DateTime dateOfSignup)
        {

            //Validate Fields before entering to Database

            if (validateFields.isUserNameEmpty(userName))
            {
                if (validateFields.isPasswordNull(password))
                {
                    if (validateFields.isRetypePasswordNull(password))
                    {
                        //perform some more validations
                        //validate whether password & confirm password equal
                        if (password.Equals(retype_password))
                        {
                            insertUserToDB(userName, password, dateOfSignup);
                        }
                        //clear the retype password and focus
                        else
                        {
                            MessageBox.Show("Confirm password doesnt match password");
                            retype_password_signup.Clear();
                            retype_password_signup.Focus();
                        }
                        
                    }
                    else
                    {
                        retype_password_signup.Focus();
                    }
                }
                else
                {
                    userName_signup.Focus();
                }
            }
            else
            {
                password_signup.Focus();
            }
        }


       
        public bool VerifyIfUserExist(string userName)
        {
            //Case senitive comparision using BINARY
            MySqlCommand command = new MySqlCommand("SELECT count(*) FROM `user` WHERE BINARY `userId`=@userId", connect.getconnection);
            command.Parameters.Add("@userId", MySqlDbType.VarChar).Value = userName;
            connect.OpenConnect();
            string noOfUsersWithSameUsername = command.ExecuteScalar().ToString();
            connect.CloseConnect();
            if (Int32.Parse(noOfUsersWithSameUsername) == 1)
            {
                return true;
            }
            return false;
            
        }
        //insert Signup user to db after all validations in User table
        public void insertUserToDB(string userName, string password, DateTime dateOfSignup)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `user`(`userId`,`password`,`dateOfCreation`,`role`) VALUES" +
                "(@userId, @password,@dateOfCreation,@role)", connect.getconnection);
            command.Parameters.Add("@userId", MySqlDbType.VarChar).Value = userName;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@dateOfCreation", MySqlDbType.Date).Value = dateOfSignup;
            command.Parameters.Add("@role", MySqlDbType.VarChar).Value = "student";
            if (VerifyIfUserExist(userName))
            {
                try
                {
                    throw new UsernameAlreadyExists(userName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    userName_signup.Clear();
                    password_signup.Clear();
                    retype_password_signup.Clear();
                    userName_signup.Focus();


                }
            }
            else
            {
         
                connect.OpenConnect();
                if (command.ExecuteNonQuery() == 1)
                {
                    connect.CloseConnect();
                    MessageBox.Show("Inserted record successfully");
                    OpenSignupChild(new Login());


                }
                else
                {
                    connect.CloseConnect();

                }
            }
        }
        //replacing login page on signup page on success
        private Form activeForm = null;
        private void OpenSignupChild(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            signup_form.Controls.Add(childForm);
            signup_form.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void signup_form_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }
    }
}
