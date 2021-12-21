using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstAp.Models
{
    public class ServicesContext:DbContext
    {
        public DbSet <Student> Emp { get; set; }
    }
}