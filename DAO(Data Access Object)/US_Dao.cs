using DTO_Data_Transfer_Object_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_Data_Access_Object_
{
    public class US_Dao
    {
        public IList<US> getLogin(string tk, string mk)
        {
            DataTable dt = new DataTable();
            string cmdtext = string.Format("Select tenUser from US WHERE taiKhoanUS='{0}' and matKhau= '{1}'", tk, mk);
            dt = DataAccessHelper.exc(cmdtext);
            List<US> li = new List<US>();
            foreach (DataRow dr in dt.Rows)
            {
                US bv = new US();
                bv.tenUser = dr[0].ToString();
                li.Add(bv);
            }
            return li;
            
            
        }
    }
}
