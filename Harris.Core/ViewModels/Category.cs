using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris.Core.ViewModels {
  public class Category {
    public int Id { get; set; }
    public string Name { get; set; }

    public IEnumerable<Capability> Capabilities { get; set; }
  }

  public class Capability {
    public int Id { get; set; }
    public string Name { get; set; }
  }

}
