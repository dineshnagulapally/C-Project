using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace managementSystem
{
    public partial class Login : Form
    {
        Signup signup = new Signup();
        DBconnect connect = new DBconnect();
        validateEmptyFields validateFields = new validateEmptyFields();
        //DBValidations dbvalid = new DBValidations();
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }
        private void Login_Load(object sender, EventArgs e)
        {
        }
        //replacing signup page on login page 
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
            login_form.Controls.Add(childForm);
            login_form.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenSignupChild(new Signup());
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string login = login_username.Text;
            string password_validate = login_password.Text;
            if (validateFields.isUserNameEmpty(login))
            {
                if (validateFields.isPasswordNull(password_validate))
                {
                    Login_Form(login, password_validate);
                }
                else
                {
                    login_password.Focus();
                }
            }
            else
            {
                login_username.Focus();
            }
            
        }

        public void Login_Form(string login, string password)
        {
            
            if (signup.VerifyIfUserExist(login))
            {

                if(validatePassword(login, password))
                {
                    if (login.Equals("admin"))
                    {
                        MessageBox.Show("Welcome to the Home Page");
                        this.Hide();
                        Form1 home_page = new Form1();
                        home_page.Show();
                    }



                    


                }
                else
                {
                    try
                    {
                        throw new PasswordNotMatch(login);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        login_username.Clear();
                        login_password.Clear();
                        login_username.Focus();
                    }
                }
                

            }
            else
            {
                try
                {
                    throw new UserNotExists(login);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    login_username.Clear();
                    login_username.Focus();
                    login_password.Clear();
                }
            }
        }

        public bool validatePassword(string userName, string password)
        {
            string db_password = "";
            MySqlCommand command = new MySqlCommand("SELECT password FROM USER WHERE BINARY userId=@userId", connect.getconnection);
            command.Parameters.Add("@userId", MySqlDbType.VarChar).Value = userName;

            connect.OpenConnect();
            MySqlDataReader column = command.ExecuteReader();
            column.Read();
            db_password = column.GetValue(0).ToString();
            connect.CloseConnect();
            if (password.Equals(db_password))
            {
                return true;
            }
            return false;
        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }
        ////


    }
}

