using BLL_Business_Logic_Layer_;
using BLL_Business_Logic_Layer_.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P3.Controllers
{
    public class DanhMucConController : Controller
    {
        IDanhMucCon bv = new DanhMucCon_bll();
        // GET: DanhMuc
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetDanhMucCon()
        {
            return Json(bv.getdanhmuccon(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetDanhMucConYMFOOTER()
        {
            return Json(bv.getdanhmuccon(), JsonRequestBehavior.AllowGet);
        }
    }
}