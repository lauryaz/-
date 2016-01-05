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
        private string firstName;
        private string lastName;
        private bool isDepartmentDirector;

        public Director(string id_number, string firstName, string lastName, string password, bool isDepartmentDirector)
        {
            this.id_number = id_number;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
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
        public string First_Name
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string Last_Name
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }


    }
}