using Harris.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris.Core.Data {
  public interface ICompanyRepository {
    Company Get();
  }

  public class CompanyRepository : ICompanyRepository {
    public Company Get() {
      var db = new DatabaseContext();
      return db.Companies.SingleOrDefault(c => c.Name.Equals("Harris", StringComparison.OrdinalIgnoreCase));
    }
  }
}
