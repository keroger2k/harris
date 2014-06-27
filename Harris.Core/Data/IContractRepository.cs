using Harris.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris.Core.Data {
  public interface IContractRepository {
    Contract GetById(int id);
  }

  public class ContractRepository : IContractRepository {

    public Contract GetById(int id) {
      var db = new DatabaseContext();
      return db.Contracts.SingleOrDefault(c => c.Id == id);
    }

  }
}
