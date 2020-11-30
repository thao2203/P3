using BLL_Business_Logic_Layer_;
using BLL_Business_Logic_Layer_.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace P3.Controllers
{
    public class baiVietController : Controller
    {
        Tool.Class1 h = new Tool.Class1();
        IBaiViet bv = new BaiViet_bll();
        // GET: baiViet
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult baiViet()
        {
            return View();
        }
        public JsonResult getbaiviethot()
        {
            return Json(bv.getBaiVietHot(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult getbaivietmoinhat()
        {
            return Json(bv.getBaiVietMoiNhat(),JsonRequestBehavior.AllowGet);
        }

        public JsonResult getbaivietBanhNgot()
        {
            return Json(bv.getBaiVietBanhNgot(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult getbaivietHaNoi()
        {
            return Json(bv.getBaiVietHaNoi(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult getbaivietNoiBat()
        {
            return Json(bv.getBaiVietNoiBat(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult getthongtinbaiviet(string mabaiviet)
        {
            return Json(bv.getThongTinBV(), JsonRequestBehavior.AllowGet);

        }
        public ActionResult search()
        {
            return View();
        }
        public JsonResult searchByName(string key)
        {
            key = key.Replace("%20"," ");
            return Json(bv.Search(key),JsonRequestBehavior.AllowGet);
        }
        public JsonResult getbaiviettheoloai(string maLoai)
        {
            return Json(bv.getBvTheoLoai(maLoai), JsonRequestBehavior.AllowGet);

        }
        public JsonResult getphantrangBV(string maLoai, string pagesize)
        {
            return Json(bv.getPhanTrangBV(maLoai, pagesize), JsonRequestBehavior.AllowGet);

        }

        public ActionResult baiviettheoloai()
        {
            return View();
        }
        public ActionResult chiTietBaiViet()
        {
            return View();
        }

        public void SendMail(string mail)
        {
            h.mail(mail);
        }

    }
}