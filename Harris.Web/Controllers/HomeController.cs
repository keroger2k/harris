using Harris.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Harris.Web.Controllers {
  public class HomeController : Controller {
    //
    // GET: /Home/

    public ActionResult Index() {
      var items = new List<Category>();
      items.AddRange(new List<Category> { 
        new Category { 
          Id  = 1, 
          Name = "Information Assurance", 
          Capabilities = new List<Capability> {
            new Capability { 
              Id = 1,
              Name = "C&A (DISA STIGs, DIACAP, FISMA"
            },
            new Capability { 
              Id = 2,
              Name = "Information Assurance Vulnerability Alert (IAVA)"
            },
            new Capability { 
              Id = 3,
              Name = "Configuration Control & Management"
            },
            new Capability { 
              Id = 4,
              Name = "Physical Security"
            }
        }},
        new Category { 
          Id  = 2, 
          Name = "IT Services", 
          Capabilities = new List<Capability> {
            new Capability { 
              Id = 1,
              Name = "Change Management"
            },
            new Capability { 
              Id = 2,
              Name = "Configuration Management"
            },
            new Capability { 
              Id = 3,
              Name = "Capacity Planning"
            },
            new Capability { 
              Id = 4,
              Name = "Computer-Aided Design/Computer-Aided Manufacturing (CAD/CAM)"
            }
        }}
      });
      return View(items);
    }

  }
}
