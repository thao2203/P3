using BLL_Business_Logic_Layer_.ServiceInterface;
using DAO_Data_Access_Object_;
using DTO_Data_Transfer_Object_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Business_Logic_Layer_
{
    public class Customer_BLL : ICustomer
    {
        Customer_DAO cs = new Customer_DAO();

        public IList<Customer> getCustomer()
        {
            return cs.getCustomer("Select * from CUSTOMER");
        }
    }
}
