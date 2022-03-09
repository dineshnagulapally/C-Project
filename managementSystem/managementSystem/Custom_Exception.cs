using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace managementSystem
{
    internal class UsernameAlreadyExists : Exception
    {
        public UsernameAlreadyExists() { }

        public UsernameAlreadyExists(string name)
            : base(String.Format("Username : {0} already exists", name))
        {

        }
    }

    internal class UserNotExists : Exception
    {
        public UserNotExists() { }

        public UserNotExists(string name)
            : base(String.Format("Username : {0} doesnt exist", name))
        {

        }
    }


    internal class PasswordNotMatch : Exception
    {
        public PasswordNotMatch() { }

        public PasswordNotMatch(string name)
            : base(String.Format("Username or Password doesnt match"))
        {

        }
    }
}
