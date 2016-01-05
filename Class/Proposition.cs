using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Class
{
    public class Proposition
    {
        private int id;
        private string title;
        private string content;
        private int id_project;
        private int id_employee;
        private bool isValidate;

        public Proposition (int id , string title , string content , int id_project , int id_employee , bool isValidate)
        {
            this.id = id;
            this.title = title;
            this.content = content;
            this.id_project = id_project;
            this.isValidate = isValidate;

        }
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Title
        {
             get
            {
                return title;
            }
            set
            {
                title = value;
            }

         }
        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
            }

        }
        public int Id_project
        {
            get
            {
                return id_project;
            }
            set
            {
                id_project = value;
            }

        }
        public int Id_empployee
        {
            get
            {
                return id_employee;
            }
            set
            {
                id_employee = value;
            }

        }
        public bool IsValidate
        {
            get
            {
                return isValidate;
            }
            set
            {
                isValidate = value;
            }

        }




    }
}