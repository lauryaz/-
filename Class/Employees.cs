using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Class
{
    public class Employees
    {
        private string name;
        private int id_number;
        private string work_beginning;
        private string department_role;
        private string firstName, lastName;


        public Employees(string FirstName,string LastName, int id_number, string Work_beginning, string Department_role)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id_number = id_number;
            this.work_beginning = Work_beginning;
            this.department_role = Department_role;
        }

        public int IdNumber
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

        public string FirstName
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
        public string LastName
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
        public string Work_beginning
        {
            get
            {
                return work_beginning;
            }
            set
            {
                work_beginning = value;
            }
        }
        public string Department_role
        {
            get
            {
                return department_role;
            }
            set
            {
                department_role = value;
            }
        }
    }
}