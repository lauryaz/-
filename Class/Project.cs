using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Class
{
    public class Project
    {
        private string id_director;
        private string id_teamLeader;
        private List<Employees> team_member;
        private string problem;
        private string date_of_staff_establishment;
        private string status;      //       primary, open, closed

        public Project(string id_director, string id_teamLeader, List<Employees> team_member, string problem, string date_of_staff_establishment, string status)
        {
            this.id_director = id_director;
            this.team_member = team_member;
            this.problem = problem;
            this.date_of_staff_establishment = date_of_staff_establishment;
            this.status = status;

        }
    }
}