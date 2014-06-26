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
    public double CPARScore { get; set; }
    public double BestMatch { get; set; }
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public string CssClass { get; set; }

    public static string DetermineContractStatus(DateTime endDate) {
      string status = string.Empty;
      if (DateTime.Now < endDate) {
        status = "active";
      } else if (DateTime.Now.AddDays(-1095) < endDate) {
        status = "inactive";
      } else if (DateTime.Now.AddDays(-1825) < endDate) {
        status = "warning";
      } else  {
        status = "danger";
      }
      return status;
    }
  }
}
