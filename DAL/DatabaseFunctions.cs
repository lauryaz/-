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
                string firstName = reader["FirstName"] + "";
                string lastName = reader["LastName"] + "";
                bool isDepartmentDirector = Convert.ToBoolean(reader["Type"]);


                director = new Director(idDirector, firstName, lastName, pwdDirector, isDepartmentDirector);
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
                string firstName = reader["FirstName"] + "";
                string lastName = reader["LastName"] + "";
                bool isDepartmentDirector = Convert.ToBoolean(reader["Type"]);

                director = new Director(idDirector, firstName, lastName, pwdDirector, isDepartmentDirector);
            }

            con.Close();
            reader.Close();

            return director;
        }

        public bool addNewEmployee(Employees employee)
        {
            //add if new
            con.Open();
            //String addDetails = "INSERT INTO Patient VALUES('" + patient.PatientId + "','" + patient.FirstName + "','" + patient.LastName + "','" + patient.Mail + "','" + patient.PhoneNumber + "','" + patient.Address + "','"  + patient.Hmo + "','" + patient.Password + "','" + patient.TherapistId + "')";
            //  MySqlCommand command = new MySqlCommand(addDetails, con);
            SqlCommand comm = con.CreateCommand();
            comm.CommandText = "INSERT INTO Employee(Id, FirstName, LastName, Date_begin, Role_employee) VALUES(@id, @firstName, @lastName, @date_begin, @role)";
           

            //comm.ExecuteNonQuery();
            //  con.Close();
            if (comm.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }

            con.Close();
            return false;
        }
        public 
    }
}