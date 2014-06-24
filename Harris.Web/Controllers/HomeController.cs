using Harris.Core.Data;
using Harris.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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


      return Json(new { }, JsonRequestBehavior.AllowGet);
    }
  }
}
