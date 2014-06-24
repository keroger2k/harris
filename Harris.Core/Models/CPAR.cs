using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris.Core.Models {
  public class CPAR {
    public Criteria Name { get; set; }
    public Rating Score { get; set; }


    public enum Criteria {
      QUALITY_OF_PRODUCT_SERVICE,
      SCHEDULE,
      COST_CONTROL,
      BUSINESS_RELATIONS,
      MANAGEMENT_OF_KEY_PERSONNEL,
      UTILIZATION_OF_SMALL_BUSINESS
    }

    public enum Rating {
      EXCEPTIONAL = 5,
      VERY_GOOD = 4,
      SATISFACTORY = 3,
      MARGINAL = 2,
      UNSATISFACTORY = 1,
      NA = 0
    }
  }
}
