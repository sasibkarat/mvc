using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Test2.Models
{
    public class LeaveManagementContext : DbContext
    {
        public LeaveManagementContext()
            : base("name=LeaveManagementConnection")
        {

        }
        public DbSet<Employe> EmployeTable { get; set; }
        public DbSet<User> UserTable { get; set; }
        public DbSet<Apply> ApplyTable { get; set; }
        public DbSet<HrLogin> HrTable { get; set; }
        public DbSet<LeaveDetails> LeaveTable { get; set; }
        public DbSet <LeaveType> LeaveTypeTable { get; set; }
        public DbSet<Approve> ApproveTable { get; set; }

    }
}