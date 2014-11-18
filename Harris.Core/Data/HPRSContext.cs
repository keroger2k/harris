using Harris.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris.Core.Data
{
    public class HPRSContext : DbContext
    {
        public HPRSContext()
            : base("HPRSConnection")
        {

        }

        public DbSet<Tag> Tags { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Status>().HasRequired(c => c.Employee).WithMany().Map(c => c.MapKey("EmployeeId"));
            modelBuilder.Entity<Status>().HasMany(c => c.Tags).WithMany(c => c.Statuses).Map(c => c.MapLeftKey("StatusId").MapRightKey("TagId").ToTable("StatusTag"));
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
