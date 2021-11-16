using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Midterm.Models
{

    public class MVC_MidtermContext : DbContext
    {
        public MVC_MidtermContext() : base("name=MVC_MidtermContext")
        {

        }
        public DbSet<Course> Courses { get; set; }
        //public DbSet<Course> CourcesName { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}