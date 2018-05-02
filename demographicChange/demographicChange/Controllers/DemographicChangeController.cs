using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demographicChange.Controllers
{
    public class DemographicChangeController : Controller
    {
        // GET: DemographicChange
        public ActionResult Total()
        {
            return View();
        }

        public ActionResult ByEthnicity()
        {
            return View();
        }
    }
}