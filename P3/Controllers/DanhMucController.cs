using BLL_Business_Logic_Layer_;
using BLL_Business_Logic_Layer_.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P3.Controllers
{
    public class DanhMucController : Controller
    {
        IDanhMuc bv = new DanhMuc_bll();
        // GET: DanhMuc
        public ActionResult Index()
        {
            return View();
        }
        
        public JsonResult GetDanhMuc()
        {
            return Json(bv.getdanhmuc(), JsonRequestBehavior.AllowGet);
        }
    }
}