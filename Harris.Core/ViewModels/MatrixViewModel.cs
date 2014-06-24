using Harris.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris.Core.ViewModels {
  public class MatrixViewModel {
    public Contract Contract { get; set; }
    public double CategoryMatch { get; set; }
    public int CPARScore { get; set; }
    public double BestMatch { get; set; }
    public string StartDate { get; set; }
    public string EndDate { get; set; }
  }
}
