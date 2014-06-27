using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris.Core.Models {
  public class Contract {
    
    public Contract() {
      this.CPARs = new List<CPAR>();
      this.PastPerformances = new List<PastPerformance>();
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public bool Prime { get; set; }
    [DisplayName("Contract #")]
    public string ContractNumber { get; set; }
    [DisplayName("Task Order")]
    public string TaskOrder { get; set; }
    [DisplayName("Contract Vehicle")]
    public string ContractVehicle { get; set; }
    public string Customer { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public string Description { get; set; }

    [DisplayName("Program Manager")]
    public string ProgramManager { get; set; }
    [DisplayName("Contract Manager")]
    public string ContractManager { get; set; }

    public virtual ICollection<CPAR> CPARs { get; set; }
    public virtual ICollection<PastPerformance> PastPerformances { get; set; }
  }
}
