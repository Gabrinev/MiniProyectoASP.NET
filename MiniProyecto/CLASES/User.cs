using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniProyecto.CLASES
{
    public class User
    {
        int _id;
        string _mail;
        string _password;

        public User()
        {
           
        }
        public User(int i, string m, string p)
        {
            _id = i;
            _mail = m;
            _password = p;
        }

       

    }
}