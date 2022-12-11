using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDataAnnotations.Models;

namespace MVCDataAnnotations.Controllers
{
    public class UserController : Controller
    {
        public ActionResult AddUser()
        {
            return View();
        }

        public ViewResult SaveUser(User obj)
        {
            if (ModelState.IsValid)
                return View(obj);
            else
                return View("AddUser");
        }
        public JsonResult IsValidDate(DateTime DOB)
        {
            bool Status;
            if (DOB > DateTime.Now.AddYears(-18))
                Status = false;
            else
                Status = true;
            return Json(Status, JsonRequestBehavior.AllowGet);
        }
    }
}