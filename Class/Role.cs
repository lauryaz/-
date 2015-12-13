using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Class
{
    public class Role
    {
        private string name;
        private string start;
        private string end;

        public Role(string name, string start, string end)
        {
            this.name = name;
            this.start = start;
            this.end = end;

        }
    }
}