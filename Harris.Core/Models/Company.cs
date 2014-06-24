﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris.Core.Models {
  public class Company {
    public string Name { get; set; }

    public ICollection<Contract> Contracts { get; set; }
    public ICollection<Capability> Capabilities { get; set; }
  }
}
