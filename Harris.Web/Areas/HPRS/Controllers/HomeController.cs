using Harris.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Harris.Web.Areas.HPRS.Controllers
{
    public class HomeController : Controller
    {
        HPRSContext db = new HPRSContext();

        // GET: HPRS/Home
        public ActionResult Index()
        {


            return View();
        }

    }
}