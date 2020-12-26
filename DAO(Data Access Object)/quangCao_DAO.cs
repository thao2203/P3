using DTO_Data_Transfer_Object_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_Data_Access_Object_
{
    public class quangCao_DAO
    {
        public IList<quangCao> getQuangCao(string sql)
        {
            DataTable dt = new DataTable();
            string cmdtext = sql;
            dt = DataAccessHelper.exc(cmdtext);
            List<quangCao> li = new List<quangCao>();
            foreach (DataRow dr in dt.Rows)
            {
                quangCao qc = new quangCao();
                qc.hinhAnh = dr[0].ToString();
                qc.video = dr[1].ToString();
                li.Add(qc);
            }
            return li;
        }

    }
}
