using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace managementSystem
{
    internal class validateEmptyFields
    {
        //validate fields in this class to enable CRUD operations

        public bool isUserNameEmpty(string username)
        {
            if(username == "")
            {
                MessageBox.Show("Please enter username");
                return false;
            }
            return true;
        }

        public bool isPasswordNull(string password)
        {
            if (password == "")
            {
                MessageBox.Show("Please enter Password");
                return false;
            }
            return true;
        }

        public bool isRetypePasswordNull(string retype_password)
        {
            if (retype_password == "")
            {
                MessageBox.Show("Please enter confirm Password");
                return false;
            }
            return true;
        }
    }
}
