using System;
using System.Collections.Generic;
using System.Linq;
using TD.BCDH.VinhLong.APIResults;
using TD.BCDH.VinhLong.Data;
using TD.BCDH.VinhLong.Models;

namespace TD.BCDH.VinhLong
{
    public partial class BCDHVinhLongService
    {
        public List<ChucVu> ChucVu()
        {
            var db = new BCDHContext();
            return db.ChucVu.ToList();
        }

        public APIResult AddListChucVu(List<ChucVu> listChucVu)
        {
            var result = new APIResult();
            var db = new BCDHContext();

            try
            {
                db.ChucVu.AddRange(listChucVu);
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
