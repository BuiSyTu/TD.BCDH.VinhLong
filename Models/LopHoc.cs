using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD.BCDH.VinhLong.Models
{
    public class LopHoc : BaseModel
    {   
        public string KhoiHoc { get; set; }
        public string MaGvcn { get; set; }
        public string PhanBan { get; set; }
        public string LopGhep { get; set; }
        public string LopChuyen { get; set; }
        public string BuoiHoc { get; set; }
        public string MaNn1 { get; set; }
        public string MaNn2 { get; set; }
        public string LopVnen { get; set; }
    }
}
