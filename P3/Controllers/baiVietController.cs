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
        IquangCao iqc = new quangCao_BLL();

        // GET: baiViet
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult baiViet()
        {
            
            return View();
        }
        public JsonResult getbaivietngaunhien()
        {
            return Json(bv.getBaiVietNgauNhien(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult getbaivietngaunhien1()
        {
            return Json(bv.getBaiVietNgauNhien1(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult getbaivietngaunhien2()
        {
            return Json(bv.getBaiVietNgauNhien2(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult getbaivietngaunhien3()
        {
            return Json(bv.getBaiVietNgauNhien3(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult getbaivietyummy()
        {
            return Json(bv.getBaiVietYummy(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult getbaivietyummy2()
        {
            return Json(bv.getBaiVietYummy2(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult getbaivietyummy3()
        {
            return Json(bv.getBaiVietYummy3(), JsonRequestBehavior.AllowGet);

        }
        public JsonResult getbaiviethot()
        {
            return Json(bv.getBaiVietHot(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult getbaivietmoinhat()
        {
            return Json(bv.getBaiVietMoiNhat(),JsonRequestBehavior.AllowGet);
        }

        public JsonResult getbaivietmoinhatCT()
        {
            return Json(bv.getBaiVietMoiNhatCT(), JsonRequestBehavior.AllowGet);
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
        public void updateluotXemView(string maDMC)
        {
            bv.upluotxemview(maDMC);
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

        public JsonResult getQuangCao728x90()
        {
            return Json(iqc.getQuangCao728x90(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult getQuangCao450x360()
        {
            return Json(iqc.getQuangCao450x360(), JsonRequestBehavior.AllowGet);
        }
    }
}