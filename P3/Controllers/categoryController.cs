using BLL_Business_Logic_Layer_;
using BLL_Business_Logic_Layer_.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P3.Controllers
{
    public class categoryController : Controller
    {
        IBaiViet bv = new BaiViet_bll();

        // GET: category
        public ActionResult Index()
        {
            return View();
        }
        //public JsonResult getbaiviettheoloai(string maLoai)
        //{
        //    return Json(bv.getBvTheoLoai(maLoai), JsonRequestBehavior.AllowGet);

        //}
        //public ActionResult baiviettheoloai()
        //{
        //    return View();
        //}
    }
}