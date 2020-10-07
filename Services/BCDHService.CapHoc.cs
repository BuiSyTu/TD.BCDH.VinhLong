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
        public List<CapHoc> CapHoc()
        {
            var db = new BCDHContext();
            return db.CapHoc.ToList();
        }
        public APIResult AddListCapHoc(List<CapHoc> listCapHoc)
        {
            var db = new BCDHContext();
            var result = new APIResult();

            try
            {
                db.CapHoc.AddRange(listCapHoc);
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
