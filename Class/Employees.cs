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

        public Employees(string name, int id_number, string work_beginning, string department_role)
        {
            this.name = name;
            this.id_number = id_number;
            this.work_beginning = work_beginning;
            this.department_role = department_role;
        }
    }
}