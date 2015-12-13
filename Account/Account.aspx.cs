using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.Class;
using WebApplication2.DAL;

namespace WebApplication2.Account
{
    public partial class Account : System.Web.UI.Page
    {
        public Director director;
        protected void Page_Load(object sender, EventArgs e)
        {
            director = null;
            DatabaseFunctions db = new DatabaseFunctions();

            if (Session["Id"] != null)
            {
                director = db.getDirector(Session["Id"].ToString());
            }
        }
    }
}