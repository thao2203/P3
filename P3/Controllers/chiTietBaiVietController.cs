using BLL_Business_Logic_Layer_;
using BLL_Business_Logic_Layer_.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DTO_Data_Transfer_Object_;

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
        public ActionResult ChiTietTacGia()
        {
            return View();
        }
        public JsonResult getChiTietTacGia(string maDMC)
        {
            return Json(bv.getCTacGia(maDMC), JsonRequestBehavior.AllowGet);
        }
        public void updateView(string mbv)
        {
            bv.upview(mbv);
        }
    }
}