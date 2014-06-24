using Harris.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris.Core.Services {
  public class MatrixCalculator {

    public Contract Contract;
    private readonly IEnumerable<Capability> _capabilities;

    public MatrixCalculator(Contract contract, IEnumerable<Capability> capabilities) {
      this.Contract = contract;
      this._capabilities = capabilities;
    }

    public double GetCategoryMatch() {
      var matchingCapabilities = Contract.Capabilities.Count(c => _capabilities.Select(d => d.Id).Contains(c.Id));
      return Math.Round((matchingCapabilities / (double)_capabilities.Count()) * 100, 2);
    }

    public int GetCPAR() {
      return 0;
    }

    public double GetBestMatch() {
      return 0f;
    }

  }
}
