using Harris.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris.Core.Data {
  public class DatabaseContext : DbContext {

    public DatabaseContext()
      : base("DefaultConnection") {

    }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Contract> Contracts { get; set; }
    public DbSet<Capability> Capabilities { get; set; }
    public DbSet<CapabilityCategory> Categories { get; set; }
    public DbSet<CPAR> CPARs { get; set; }
    public DbSet<PastPerformance> PastPerformances { get; set; }

    
  }
}
