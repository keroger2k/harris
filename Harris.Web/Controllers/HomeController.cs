using Harris.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Harris.Web.Controllers {
  public class HomeController : Controller {
    private readonly ICapabilityRepository _capRepo;

    public HomeController(ICapabilityRepository capRepo) {
      this._capRepo = capRepo;
    }
    
    //
    // GET: /Home/

    public ActionResult Index() {
      var items = _capRepo.Get();
      return View(items);
    }

  }
}
