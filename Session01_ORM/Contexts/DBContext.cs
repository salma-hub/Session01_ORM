using Microsoft.EntityFrameworkCore;
using Session01_ORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01_ORM.Contexts
{
    public class CompanyContext : DbContext

    {        public CompanyContext():base()
            {
            }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      
        {
            optionsBuilder.UseSqlServer("server=.;database=CompanyG01;Trusted_Connection=True;TrustServerCertificate=true;");

        }        public DbSet <Employee> Employees { get; set; }

    }
}
