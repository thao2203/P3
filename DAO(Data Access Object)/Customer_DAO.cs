using DTO_Data_Transfer_Object_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_Data_Access_Object_
{
    public class Customer_DAO
    {
        public IList<Customer> getCustomer(string sql)
        {
            DataTable dt = new DataTable();
            string cmdtext = sql;
            dt = DataAccessHelper.exc(cmdtext);
            List<Customer> li = new List<Customer>();
            foreach (DataRow dr in dt.Rows)
            {
                Customer cs = new Customer();
                cs.maCustomer = int.Parse(dr[0].ToString());
                cs.tenCustomer = dr[2].ToString();
                cs.email = dr[5].ToString();
                cs.ghiChu = dr[6].ToString();
                li.Add(cs);
            }
            return li;
        }
    }
}
