using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD.BCDH.VinhLong.Models
{
    public class DanToc
    {
        public string ID { get; set; }
        public string MaDanToc { get; set; }
        public string TenDanToc{ get; set; }
        public string LoaiDanToc { get; set; }
        public string TrangThai { get; set; }
        public string NgayCapNhat { get; set; }                       
    }
}
