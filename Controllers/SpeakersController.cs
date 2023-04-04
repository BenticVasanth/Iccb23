using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iitmProject.Models
{
    public class SpeakersController : Controller
    {
        //
        // GET: /Speakers/

        public ActionResult Index()
        {
            return View();
        }

    }
}
