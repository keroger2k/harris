﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris.Core.Models {
  [Serializable]
  public class Capability {

    public Capability() {
      this.Contracts = new List<Contract>();
    }

    public int Id { get; set; }
    public string Name { get; set; }

    public virtual ICollection<Contract> Contracts { get; set; }

  }
}
