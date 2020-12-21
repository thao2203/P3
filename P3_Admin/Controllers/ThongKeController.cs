using BLL_Business_Logic_Layer_;
using BLL_Business_Logic_Layer_.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P3_Admin.Controllers
{
    public class ThongKeController : Controller
    {
        // GET: ThongKe
        IthongKe tk = new thongKe_BLL();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ThongKe()
        {
            return View();
        }
        public JsonResult getThongKe()
        {
            return Json(tk.getThongKe(), JsonRequestBehavior.AllowGet);
        }
    }
}