using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris.Core.Models {
  public class Contract {
    public Contract() {
      this.CPARs = new List<CPAR>();
      this.Capabilities = new List<Capability>();
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Prime { get; set; }
    public string ContractNumber { get; set; }
    public string TaskOrder { get; set; }
    public string ContractVehicle { get; set; }
    public string Customer { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public string Description { get; set; }

    public string ProgramManager { get; set; }
    public string ContractManager { get; set; }

    public virtual ICollection<CPAR> CPARs { get; set; }
    public virtual ICollection<Capability> Capabilities { get; set; }
  }
}
