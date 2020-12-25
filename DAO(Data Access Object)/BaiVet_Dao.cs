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
    public class BaiVet_Dao
    {
        public IList<baiViet> getbaiviet(string sql)
        {
            DataTable dt = new DataTable();
            string cmdtext = sql;
            dt = DataAccessHelper.exc(cmdtext);
            List<baiViet> li = new List<baiViet>();
            foreach (DataRow dr in dt.Rows)
            {
                baiViet bv = new baiViet();
                bv.MaBV = dr[0].ToString();
                bv.TaiKhoanUS = dr[1].ToString();
                bv.MaDMC = dr[8].ToString();
                bv.TieuDe = dr[2].ToString();
                bv.NoiDungCon = dr[3].ToString();
                bv.HinhAnh = dr[7].ToString();
                bv.ThoiGianDang =DateTime.Parse(dr[4].ToString());
                bv.TrangThai = dr[5].ToString();
                bv.MaDM = dr[6].ToString();
                bv.tacgia = dr[9].ToString();
                bv.tendanhmuc = dr[10].ToString();
                bv.tendanhmuccon = dr[11].ToString();
                li.Add(bv);
            }
            return li;
        }

        public IList<baiViet> getBaiViet(string sql)
        {
            DataTable dt = new DataTable();
            string cmdtext = sql;
            dt = DataAccessHelper.exc(cmdtext);
            List<baiViet> li = new List<baiViet>();
            foreach (DataRow dr in dt.Rows)
            {
                baiViet bv = new baiViet();
                bv.MaBV = dr[0].ToString();
                bv.TaiKhoanUS = dr[1].ToString();
                bv.TieuDe = dr[2].ToString();
                bv.NoiDungCon = dr[3].ToString();
                bv.ThoiGianDang = DateTime.Parse(dr[4].ToString());
                bv.TrangThai = dr[5].ToString();
                bv.MaDM = dr[6].ToString();
                bv.HinhAnh = dr[7].ToString();
                bv.MaDMC = dr[8].ToString();
                li.Add(bv);
            }
            return li;
        }
        public IList<baiViet> getbaivietngaunhien12(string sql)
        {
            DataTable dt = new DataTable();
            string cmdtext = sql;
            dt = DataAccessHelper.exc(cmdtext);
            List<baiViet> li = new List<baiViet>();
            foreach (DataRow dr in dt.Rows)
            {
                baiViet bv = new baiViet();
                bv.MaBV = dr[0].ToString();
                bv.MaDMC = dr[1].ToString();
                bv.TieuDe = dr[2].ToString();
                bv.HinhAnh = dr[3].ToString();
                bv.tendanhmuc = dr[4].ToString();
                bv.tendanhmuccon = dr[5].ToString();

                li.Add(bv);
            }
            return li;
        }

        public IList<baiViet> getbaivietnoibat_DAO(string sql)
        {
            DataTable dt = new DataTable();
            string cmdtext = sql;
            dt = DataAccessHelper.exc(cmdtext);
            
            List<baiViet> li = new List<baiViet>();
            foreach (DataRow dr in dt.Rows)
            {
                baiViet bv = new baiViet();
                bv.MaBV = dr[0].ToString();
                bv.MaDMC = dr[1].ToString();
                bv.TieuDe = dr[2].ToString();
                bv.tendanhmuc = dr[3].ToString();
                bv.tendanhmuccon = dr[4].ToString();
                bv.HinhAnh = dr[5].ToString();
                bv.luotXem = int.Parse(dr[6].ToString());
                li.Add(bv);
            }
            return li;
        }

        //admin
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString);
        SqlDataAdapter da;
        SqlDataReader dr;
        SqlCommand com;
        DataSet ds;
        ListBV bvlist = new ListBV();
        public ListBV Get_Paging_BV(int pageindex, int pagesize)
        {
            com = new SqlCommand("sp_data_baiViet", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Pageindex", pageindex);
            com.Parameters.AddWithValue("@Pagesize", pagesize);

            con.Open();
            dr = com.ExecuteReader();
            List<baiViet> list = new List<baiViet>();
            while (dr.Read())

            {
                baiViet dt = new baiViet();
                dt.MaBV = dr["MaBV"].ToString();
                dt.MaDM = dr["MaDM"].ToString();
                dt.MaDMC = dr["MaDMC"].ToString();
                dt.TaiKhoanUS = dr["TaiKhoanUS"].ToString();
                dt.TieuDe = dr["TieuDe"].ToString();
                dt.TrangThai = dr["TrangThai"].ToString();
                dt.ThoiGianDang = DateTime.Parse(dr["ThoiGianDang"].ToString());
                dt.NoiDungCon = dr["NoiDungNho"].ToString();
                dt.HinhAnh = dr["HinhAnh"].ToString();
               
                list.Add(dt);
            }
            dr.NextResult();
            while (dr.Read())
            {
                bvlist.totalcount = Convert.ToInt32(dr["totalcount"]);
            }
            bvlist.listBaiViet = list;
            return bvlist;
        }

        public DataSet Get_bv_byid(string id)
        {
            SqlCommand com = new SqlCommand("baiviet_id", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@MaBV", id);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void Add_BV(baiViet dt)
        {
            SqlCommand com = new SqlCommand("them_baiviet", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@maBV", dt.MaBV);
            com.Parameters.AddWithValue("@maDM", dt.MaDM);
            com.Parameters.AddWithValue("@maDMC", dt.MaDMC);
            com.Parameters.AddWithValue("@taiKhoanUS", dt.TaiKhoanUS);
            com.Parameters.AddWithValue("@tieuDe", dt.TieuDe);
            com.Parameters.AddWithValue("@trangThai", dt.TrangThai);
            com.Parameters.AddWithValue("@thoiGianDang", dt.ThoiGianDang);
            com.Parameters.AddWithValue("@noiDungNho", dt.NoiDungCon);
            com.Parameters.AddWithValue("@hinhAnh", dt.HinhAnh);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        public void Update_BV(baiViet dt)
        {
            SqlCommand com = new SqlCommand("sua_baiviet", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@maBV", dt.MaBV);
            com.Parameters.AddWithValue("@maDM", dt.MaDM);
            com.Parameters.AddWithValue("@maDMC", dt.MaDMC);
            com.Parameters.AddWithValue("@taiKhoanUS", dt.TaiKhoanUS);
            com.Parameters.AddWithValue("@tieuDe", dt.TieuDe);
            com.Parameters.AddWithValue("@trangThai", dt.TrangThai);
            com.Parameters.AddWithValue("@thoiGianDang", dt.ThoiGianDang);
            com.Parameters.AddWithValue("@noiDungNho", dt.NoiDungCon);
            com.Parameters.AddWithValue("@hinhAnh", dt.HinhAnh);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        public void Delete_BV(string MaBV)
        {
            SqlCommand com = new SqlCommand("xoa_baiviet", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@maBV", MaBV);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }


    }
}
