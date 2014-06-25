using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris.Core.Models {
  public class Contract {
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Prime { get; set; }
    public string ContractNumber { get; set; }
    public string TaskOrder { get; set; }
    public string ContractVehicle { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public string Description { get; set; }

    public virtual Contact ProgramManager { get; set; }
    public virtual Company Customer { get; set; }
    public virtual Contact ContractManager { get; set; }

    public virtual ICollection<CPAR> CPARs { get; set; }
    public virtual ICollection<Capability> Capabilities { get; set; }
  }
}
