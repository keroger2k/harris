using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris.Core.Models {
  public class CapabilityCategory {
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<Capability> Capabilities { get; set; }
  }
}
