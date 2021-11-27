using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace testwcf
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> students { get; set; }
        public StudentContext() : base("studentWCFCS")
        {

        }
    }
}