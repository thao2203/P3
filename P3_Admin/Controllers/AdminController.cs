using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL_Business_Logic_Layer_;
using BLL_Business_Logic_Layer_.ServiceInterface;

namespace P3_Admin.Controllers
{
    public class AdminController : Controller
    {
        IBaiViet bv = new BaiViet_bll();

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult danhSachBaiViet()
        {
            return View();
        }

        public JsonResult getdanhsachbaiviet()
        {
            return Json(bv.getDSBV(), JsonRequestBehavior.AllowGet);
        }
    }
}