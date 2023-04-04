using iitmProject.Models;
using iitmProject.Models.IITMModel;
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
    public class RegistrationController : Controller
    {
        private iitmEntities db = new iitmEntities();

        #region Registration

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ReguserModel user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var objuser = new UserTest();
                    objuser.id = user.id;
                    objuser.Name = user.Name.Trim();
                    objuser.Email = user.Email.Trim();
                    objuser.Mobile = user.Mobile;
                    objuser.Org = user.Org.Trim();
                    objuser.Position = user.Position.Trim();
                    objuser.Address = user.Address.Trim();
                    objuser.State = user.State.Trim();
                    objuser.Country = user.Country.Trim();
                    objuser.Pincode = user.Pincode;
                    db.UserTests.Add(objuser);
                    db.SaveChanges();
                    ViewBag.TheResult = "Register Successfully";
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "Please check details.";
                ViewBag.ErrorMessage1 = ex;
            }
            return View(user);
        }

        #endregion

    }
}