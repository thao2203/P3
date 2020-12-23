using BLL_Business_Logic_Layer_;
using BLL_Business_Logic_Layer_.ServiceInterface;
using DTO_Data_Transfer_Object_;
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
        DanhMuc_bll dmb = new DanhMuc_bll();
        DanhMucCon_bll dmcb = new DanhMucCon_bll();
        US_bll usb = new US_bll();
        IDanhMucCon idmc = new DanhMucCon_bll();
        IDanhMuc idm = new DanhMuc_bll();
        IUS ius = new US_bll();


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
        public JsonResult Get_BV_byid(string id)
        {
            return Json(bvb.Get_BV_byid(id), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult Them_BV(baiViet dt)
        {
            return Json(bvb.Add_BV(dt), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Sua_BV(baiViet dt)
        {
            return Json(bvb.Update_BV(dt), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Xoa_BV(string id)
        {
            return Json(bvb.Delete_BV(id), JsonRequestBehavior.AllowGet);
        }
        //public JsonResult Get_maDM()
        //{
        //    return Json(dmb.Get_maDM(), JsonRequestBehavior.AllowGet);
        //}
        public JsonResult GetmaDM()
        {
            return Json(idm.GetmaDM(), JsonRequestBehavior.AllowGet);
        }
        //public JsonResult Get_maDMC()
        //{
        //    return Json(dmcb.Get_maDMC(), JsonRequestBehavior.AllowGet);
        //}
        //public JsonResult Get_US()
        //{
        //    return Json(usb.Get_US(), JsonRequestBehavior.AllowGet);
        //}

        public JsonResult Gettaikhoanus()
        {
            return Json(ius.Gettaikhoanus(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult getmaDMC()
        {
            return Json(idmc.getmaDMC(), JsonRequestBehavior.AllowGet);
        }
    }
}