using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD.BCDH.VinhLong.Models
{
    public class HocSinh : BaseModel
    {
        public string NgaySinh { get;set; }
        public string GioiTinh { get; set; }
        public string DanToc { get; set; }
        public string NoiSinh { get; set; }
        public string TruongHoc { get; set; }
        public string LopHoc { get; set; }
        public string TrangThai { get; set; }
        public string TenLopHoc { get; set; }
        public string KhoiLop { get; set; }
        public string SdtBo { get; set; }
        public string SdtMe { get; set; }

    }
}
