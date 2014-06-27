using Harris.Core.Data;
using Harris.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Harris.Web.Controllers {
  public class ContractDetailsViewModel {
    public Contract Contract { get; set; }
    public IEnumerable<CapabilityCategory> Categories { get; set; }
  }
  public class ContractController : Controller {

    private readonly IContractRepository _contractRepo;
    private readonly ICapabilityRepository _capRepo;

    public ContractController(IContractRepository contractRepo, ICapabilityRepository capRepo) {
      this._contractRepo = contractRepo;
      this._capRepo = capRepo;
    }

    public ActionResult Index() {
      return View();
    }

    public ActionResult Details(int id) {
      return View(new ContractDetailsViewModel {
        Contract = _contractRepo.GetById(id),
        Categories = _capRepo.Get()
      });
    }

  }
}
