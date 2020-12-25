using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL_Business_Logic_Layer_;
using BLL_Business_Logic_Layer_.ServiceInterface;
using DTO_Data_Transfer_Object_;
namespace Areas.Controllers
{
    public class AdminController : Controller
    {
        IUS us = new US_bll();
        // GET: Admin
        public ActionResult Login()
        {
            return View();
        }
        public JsonResult login_ (US ad)
        {
            return Json(us.Gettaikhoanus(ad), JsonRequestBehavior.AllowGet);
        }

    }
}