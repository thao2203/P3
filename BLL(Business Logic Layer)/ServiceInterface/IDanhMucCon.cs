using DTO_Data_Transfer_Object_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Business_Logic_Layer_.ServiceInterface
{
    public interface IDanhMucCon
    {
        IList<danhmuccon> getdanhmuccon();
        IList<danhmuccon> getdanhmucconYMFooter();
        IList<danhmuccon> getDMCbyMaDM(string maDM);

    }
}
