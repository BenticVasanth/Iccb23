using iitmProject.Models;
using iitmProject.Models.EDMXModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace iitmProject.Controllers
{
    public class AuthController : Controller
    {
        //
        // GET: /Auth/


        private IitmDB db = new IitmDB();
        private static TimeZoneInfo INDIAN_ZONE = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");

        public ActionResult Index()
        {
            return View();
        }

    }
}
