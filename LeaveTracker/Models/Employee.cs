using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveTracker.Models
{
    public class Employee
    {

        public Employee()
        {

        }
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public long PhoneNumber { get; set; }
        public string ProjectName { get; set; }
        public string ManagerName { get; set; }

        public Team Team { get; set; }
        
    }
}
