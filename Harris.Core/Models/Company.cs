﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris.Core.Models {
  public class Company {
    public Company() {
      this.Contracts = new List<Contract>();
      this.Capabilities = new List<Capability>();
    }
    public int Id { get; set; }
    public string Name { get; set; }

    public virtual ICollection<Contract> Contracts { get; set; }
    public virtual ICollection<Capability> Capabilities { get; set; }
  }
}
