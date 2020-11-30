using BLL_Business_Logic_Layer_;
using BLL_Business_Logic_Layer_.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P3.Controllers
{
    public class chiTietBaiVietController : Controller
    {
        IChiTietBaiViet bv = new ChiTietBaiViet_bll();

        // GET: chiTietBaiViet
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ChiTietBaiViet()
        {
            return View();
        }

        public JsonResult getChiTietBaiViet(string maBV)
        {
            return Json(bv.getCTBaiViet(maBV), JsonRequestBehavior.AllowGet);

        }
    }
}