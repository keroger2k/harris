using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris.Core.Models {
  public class Contact {
    public string Name { get; set; }
    public ICollection<string> PhoneNumbers { get; set; }
  }
}
