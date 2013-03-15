using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRSamples.Web.Controllers
{
    public class StartController : Controller
    {
        //
        // GET: /Start/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SimpleHub()
        {
            return View();
        }

        public ActionResult Groups()
        {
            return View();
        }

        public ActionResult SharedState()
        {
            return View();
        }
    }
}
