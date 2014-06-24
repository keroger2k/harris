using Harris.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris.Core.Data {
  public interface ICapabilityRepository {
    ICollection<Category> Get();
  }

  public class FakeCapabilityRepository : ICapabilityRepository {
    public ICollection<Category> Get() {
      var items = new List<Category>();
      items.AddRange(new List<Category> { 
        new Category { 
          Id  = 1, 
          Name = "Information Assurance", 
          Capabilities = new List<Capability> {
            new Capability { 
              Id = 1,
              Name = "C&A (DISA STIGs, DIACAP, FISMA"
            },
            new Capability { 
              Id = 2,
              Name = "Information Assurance Vulnerability Alert (IAVA)"
            },
            new Capability { 
              Id = 3,
              Name = "Configuration Control & Management"
            },
            new Capability { 
              Id = 4,
              Name = "Physical Security"
            }
        }},
        new Category { 
          Id  = 2, 
          Name = "IT Services", 
          Capabilities = new List<Capability> {
            new Capability { 
              Id = 5,
              Name = "Change Management"
            },
            new Capability { 
              Id = 6,
              Name = "Configuration Management"
            },
            new Capability { 
              Id = 7,
              Name = "Capacity Planning"
            },
            new Capability { 
              Id = 8,
              Name = "Computer-Aided Design/Computer-Aided Manufacturing (CAD/CAM)"
            }
        }}
      });
      return items;
    }
  }
}
