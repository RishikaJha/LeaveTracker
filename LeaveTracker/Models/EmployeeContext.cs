using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveTracker.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(): base()
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
