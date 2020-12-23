using DTO_Data_Transfer_Object_;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_Data_Access_Object_
{
    public class US_Dao
    {
        //phương thức Lấy về tài khoản người dùng với user name và password đăng nhập
        public IList<US> checkAcount(string tk, string mk)
        {
            DataTable dt = new DataTable();
            string cmdtext = string.Format("Select * from US WHERE (taiKhoanUS='"+tk+"') and (matKhau= '"+mk+"')");
            dt = DataAccessHelper.exc(cmdtext);
            List<US> li = new List<US>();
            if(dt.Rows.Count<=0)
            {
                return null;
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    US bv = new US();
                    bv.taiKhoanUS = dr[0].ToString();
                    bv.matKhau = dr[1].ToString();
                    bv.tenUser = dr[2].ToString();
                    bv.chucVu = dr[3].ToString();
                    bv.ghiChu = dr[4].ToString();

                    li.Add(bv);
                }
                return li;
            }
        }

        //admin
        //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString);

        //public DataSet Get_US()
        //{
        //    string sql = "select*from US";
        //    SqlCommand com = new SqlCommand(sql, con);
        //    SqlDataAdapter da = new SqlDataAdapter(com);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds);
        //    return ds;
        //}

        public IList<US> Gettaikhoanus(string sql)
        {
            DataTable dt = new DataTable();
            string cmdtext = sql;
            dt = DataAccessHelper.exc(cmdtext);
            List<US> li = new List<US>();

            foreach (DataRow dr in dt.Rows)
            {
                US bv = new US();
                bv.taiKhoanUS = dr[0].ToString();
                bv.tenUser = dr[1].ToString();
                li.Add(bv);
            }
            return li;
        }
    }
}
