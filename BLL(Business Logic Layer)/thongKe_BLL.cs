using BLL_Business_Logic_Layer_.ServiceInterface;
using DAO_Data_Access_Object_;
using DTO_Data_Transfer_Object_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Business_Logic_Layer_
{
    public class thongKe_BLL: IthongKe
    {
        thongKe_DAO tk = new thongKe_DAO();
        public IList<thongKe> getThongKe()
        {
            DataSet ds = tk.ThongKe();
            List<thongKe> listreg = new List<thongKe>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                listreg.Add(new thongKe
                {
                    BAIVIET = Convert.ToInt32(dr["BAIVIET"]),
                    DANHMUC = Convert.ToInt32(dr["DANHMUC"]),
                    CUSTOMER = Convert.ToInt32(dr["CUSTOMER"]),
                });
            }
            return listreg;
        }
    }
}
