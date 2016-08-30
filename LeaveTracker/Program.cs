using LeaveTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveTracker
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new EmployeeContext())
            {
                Employee emp = new Employee() { EmployeeName = "New Student" };

                ctx.Employees.Add(emp);
                ctx.SaveChanges();
            }
        }
    }
}
