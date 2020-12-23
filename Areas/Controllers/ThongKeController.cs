using BLL_Business_Logic_Layer_;
using BLL_Business_Logic_Layer_.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Areas.Controllers
{
    public class ThongKeController : Controller
    {
        // GET: ThongKe
        IthongKe itk = new thongKe_BLL();
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult ThongKe()
        {
            return Json(itk.getThongKe(), JsonRequestBehavior.AllowGet);
        }
    }
}