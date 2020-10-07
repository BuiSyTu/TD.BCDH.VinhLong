using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD.BCDH.VinhLong.Models
{
    public class HoSo
    {
        public string ID { get; set; }
        public string SoBienNhan { get; set; }
        public string ThuTuc { get; set; }
        public string LinhVuc { get; set; }
        public string NgayNhan { get; set; }
        public string NgayHoanThanh { get; set; }
        public string NoiNhan { get; set; }
        public Boolean NhanQuaMang { get; set; }
    }
}
