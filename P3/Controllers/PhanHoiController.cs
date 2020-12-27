using BLL_Business_Logic_Layer_;
using BLL_Business_Logic_Layer_.ServiceInterface;
using DTO_Data_Transfer_Object_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P3.Controllers
{
    public class PhanHoiController : Controller
    {
        binhLuan_BLL blb = new binhLuan_BLL();
        IbinhLuan ibl = new binhLuan_BLL();
        ITLbinhLuan itb = new TLbinhLuan_BLL();
        ICustomer ics = new Customer_BLL();

        // GET: PhanHoi
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult getBinhLuan(string maBV)
        {
            return Json(ibl.getbinhluan(maBV), JsonRequestBehavior.AllowGet);
        }
        public JsonResult getTLBinhLuan()
        {
            return Json(itb.getTLbinhluan(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult getCustomer()
        {
            return Json(ics.getCustomer(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Them_BL(binhLuan cm)
        {
            return Json(blb.Add_BL(cm), JsonRequestBehavior.AllowGet);
        }
    }
}