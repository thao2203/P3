using BLL_Business_Logic_Layer_;
using BLL_Business_Logic_Layer_.ServiceInterface;
using DTO_Data_Transfer_Object_;
using System.Web.Mvc;
namespace Areas.Controllers
{   public class QLBaiVietController : Controller
    {   BaiViet_bll bvb = new BaiViet_bll();
        DanhMuc_bll dmb = new DanhMuc_bll();
        DanhMucCon_bll dmcb = new DanhMucCon_bll();
        US_bll usb = new US_bll();
        IDanhMucCon idmc = new DanhMucCon_bll();
        IDanhMuc idm = new DanhMuc_bll();
        IUS ius = new US_bll();
        IBaiViet ibv = new BaiViet_bll();
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Them_BV(baiViet info)
        {
            return Json(bvb.Add_BV(info), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Sua_BV(baiViet dt)
        {
            return Json(bvb.Update_BV(dt), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Xoa_BV(string id)
        {
            return Json(bvb.Delete_BV(id), JsonRequestBehavior.AllowGet);
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
        
        public JsonResult GetmaDM()
        {
            return Json(idm.GetmaDM(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Gettaikhoanus()
        {
            return Json(ius.getUS(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult getmaDMC()
        {
            return Json(idmc.getdanhmuccon(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult getDMCbyMaDM(string MaDM)
        {
            return Json(idmc.getDMCbyMaDM(MaDM), JsonRequestBehavior.AllowGet);
        }

    }
}