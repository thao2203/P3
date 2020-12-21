using BLL_Business_Logic_Layer_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Areas.Controllers
{
    public class QLBaiVietController : Controller
    {
        BaiViet_bll bvb = new BaiViet_bll();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DanhSachBV()
        {
            return View();
        }
        public ActionResult ThemBV()
        {
            return View();
        }
        public ActionResult SuaBV(string id)
        {
            return View();
        }
        public JsonResult Get_data_BV(int pageindex, int pagesize)
        {
            return Json(bvb.Get_Paging_BV(pageindex, pagesize), JsonRequestBehavior.AllowGet);
        }
    }
}