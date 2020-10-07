using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD.BCDH.VinhLong.APIResults;
using TD.BCDH.VinhLong.Data;
using TD.BCDH.VinhLong.Models;

namespace TD.BCDH.VinhLong
{
    public partial class BCDHVinhLongService
    {
        public List<GiaoVien> GiaoVien()
        {
            var db = new BCDHContext();
            return db.GiaoVien.ToList();
        }

        public APIResult AddListGiaoVien(List<GiaoVien> listGiaoVien)
        {
            var db = new BCDHContext();
            var result = new APIResult();

            try
            {
                db.GiaoVien.AddRange(listGiaoVien);
                db.SaveChanges();
                result.error = new Error
                {
                    code = "201",
                    internalMessage = "Success",
                    userMessage = "Thêm thành công"
                };
            }
            catch (Exception ex)
            {
                result.error = new Error
                {
                    code = "500",
                    internalMessage = ex.ToString(),
                    userMessage = "Lỗi khi thêm"
                };
            }

            return result;
        }
    }
}
