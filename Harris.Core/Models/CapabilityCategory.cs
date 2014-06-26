using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris.Core.Models {
  public class CapabilityCategory {

    public CapabilityCategory() {
      this.Capabilities = new List<Capability>();
    }

    public int Id { get; set; }
    public string Name { get; set; }

    public virtual ICollection<Capability> Capabilities { get; set; }
  }
}
