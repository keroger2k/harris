using Harris.Core.Data;
using Harris.Core.Models;
using Harris.Core.Services;
using Harris.Core.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Harris.Web.Controllers {
  public class HomeController : Controller {
    private readonly ICapabilityRepository _capRepo;
    private readonly ICompanyRepository _companyRepo;

    public HomeController(ICapabilityRepository capRepo,
      ICompanyRepository companyRepo) {
      this._capRepo = capRepo;
      this._companyRepo = companyRepo;
    }

    //
    // GET: /Home/

    public ActionResult Index() {
      var items = _capRepo.Get();
      return View(items);
    }

    public ActionResult UpdateCapabilitiesMatrix(IEnumerable<Capability> item) {

      //Get a single company; Most likely Harris.
      var company = _companyRepo.Get();
      var list = new List<MatrixViewModel>();

      //all companies with capabilities
      if (item != null) {
        var results = company.Contracts.Where(e => e.Capabilities.Any(c => item.Select(d => d.Id).Contains(c.Id)));
        foreach (var c in results) {
          var r = new MatrixCalculator(c, item);
          list.Add(new MatrixViewModel {
            Contract = c,
            CategoryMatch = r.GetCategoryMatch(),
            CPARScore = r.GetCPAR(),
            BestMatch = r.GetBestMatch(),
            StartDate = r.Contract.Start.ToString("MM/dd/yyyy"),
            EndDate = r.Contract.End.ToString("MM/dd/yyyy"),
          });
        }
      }
      return Json(list.OrderBy(c => c.BestMatch), JsonRequestBehavior.AllowGet);
    }
  }
}
