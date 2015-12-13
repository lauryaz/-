using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Class
{
    public class Director
    {
        private string id_number;
        private string password;
        private bool isDepartmentDirector;

        public Director(string id_number, string password, bool isDepartmentDirector)
        {
            this.id_number = id_number;
            this.password = password;
            this.isDepartmentDirector = isDepartmentDirector;

        }

        public string IdNumber
        {
            get
            {
                return id_number;
            }
            set
            {
                id_number = value;
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
        public bool IsDepartmentDirector
        {
            get
            {
                return isDepartmentDirector;
            }
            set
            {
                isDepartmentDirector = value;
            }
        }


    }
}