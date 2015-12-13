using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Class
{
    public class Staff
    {
        private Director team_director;
        private List<Employees> team_member;
        private string problem;
        private string date_of_staff_establishment;
        private string status;      //       primary, open, closed

        public Staff(Director team_director, List<Employees> team_member, string problem, string date_of_staff_establishment, string status)
        {
            this.team_director = team_director;
            this.team_member = team_member;
            this.problem = problem;
            this.date_of_staff_establishment = date_of_staff_establishment;
            this.status = status;

        }
    }
}