using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication2.Class;

namespace WebApplication2.DAL
{
    public class DatabaseFunctions
    {
        private SqlConnection con;

        public DatabaseFunctions()
        {
            string connectionString = DAL.STR;
            con = new SqlConnection(connectionString);
        }

        public Director directorLogin(string id, string password)
        {
            Director director = null;
            con.Open();         // open connection to database
            string getDetails = "SELECT * from Director WHERE Id = '" + id + "' AND Password = '" + password + "'";
            SqlCommand command = new SqlCommand(getDetails, con);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            if (reader.HasRows)
            {
                string idDirector = reader["Id"] + "";
                string pwdDirector = reader["Password"] + "";
                bool isDepartmentDirector = Convert.ToBoolean(reader["Type"]);

                director = new Director(idDirector, pwdDirector, isDepartmentDirector);
            }

            con.Close();
            reader.Close();

            return director;
        }

        public Director getDirector(string id)
        {
            Director director = null;
            con.Open();         // open connection to database
            string getDetails = "SELECT * from Director WHERE Id = '" + id + "'";
            SqlCommand command = new SqlCommand(getDetails, con);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            if (reader.HasRows)
            {
                string idDirector = reader["Id"] + "";
                string pwdDirector = reader["Password"] + "";
                bool isDepartmentDirector = Convert.ToBoolean(reader["Type"]);

                director = new Director(idDirector, pwdDirector, isDepartmentDirector);
            }

            con.Close();
            reader.Close();

            return director;
        }
    }
}