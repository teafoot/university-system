using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    class Administrador
    {
        String login, password;
        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

    }
}
