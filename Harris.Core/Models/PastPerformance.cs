﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris.Core.Models {
  public class PastPerformance {
    public int Id { get; set; }
    public string Description { get; set; }

    public virtual Capability Capability { get; set; }
  }
}
