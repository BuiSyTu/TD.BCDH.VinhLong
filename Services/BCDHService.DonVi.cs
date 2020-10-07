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
        public List<DonVi> DonVi()
        {
            var db = new BCDHContext();
            return db.DonVi.ToList();
        }

        public APIResult AddListDonVi(List<DonVi> listDonVi)
        {
            var db = new BCDHContext();
            var result = new APIResult();

            try
            {
                db.DonVi.AddRange(listDonVi);
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
