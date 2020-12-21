using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BLL_Business_Logic_Layer_;
using BLL_Business_Logic_Layer_.ServiceInterface;
using P3_Admin.Models;

namespace P3_Admin.Controllers
{
    //[Authorize] xác thực người dùng cho các hành động mà không muốn cho người dùng ẩn danh nào truy cập
    
    public class AdminController : Controller
    {
        DB db = new DB();
        IBaiViet bv = new BaiViet_bll();
        IUS us = new US_bll();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult danhSachBaiViet()
        {
            return View();
        }

        //public JsonResult getAllRecord()
        //{
        //    return Json(bv.getAllRecord(), JsonRequestBehavior.AllowGet);
        //}
        //public JsonResult get_data(int pageindex, int pagesize)
        //{
        //    return Json(bv.get_data(pageindex, pagesize), JsonRequestBehavior.AllowGet);
        //}

















        //public JsonResult getdanhsachbaiviet()
        //{
        //    return Json(bv.getDSBV(), JsonRequestBehavior.AllowGet);
        //}
        
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Login(string tk, string mk)
        {
            var a = db.US.SingleOrDefault(m => m.taiKhoanUs == tk && m.matKhau == mk);
            if (a != null)
            {
                Session["User"] = a;
                return RedirectToAction("danhSachBaiViet", "Admin", new { });
            }
            else
            {
                return View();
            }
        }
    }
}