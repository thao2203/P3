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
    public class quangCao_BLL : IquangCao
    {
        quangCao_DAO qc = new quangCao_DAO();
        public IList<quangCao> getQuangCao728x90()
        {
            return qc.getQuangCao("Select hinhanh, video from QUANGCAO where tenQC=N'Món ngon Sài Gòn' and trangThai='1'");
        }
        public IList<quangCao> getQuangCao450x360()
        {
            return qc.getQuangCao("Select hinhanh, video from QUANGCAO where tenQC=N'KFC Cơm Vi Vu' and trangThai='1'");
        }
    }
}
