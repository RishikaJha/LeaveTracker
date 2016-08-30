using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveTracker.Models
{
    public class Team
    {
        public Team()
        {

        }
        public int TeamId { get; set; }
        public string TeamName { get; set; }

        public ICollection<Employee> Employees { get; set; }

    }

}

