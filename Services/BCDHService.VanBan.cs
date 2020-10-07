using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using TD.BCDH.APIResults;
using TD.BCDH.Data;
using TD.BCDH.Models;
using TD.BCDH.Utilities;
using TD.BCDH.ViewModels;

namespace TD.BCDH
{
    public partial class BCDHService
    {
        public List<VanBan> VanBan()
        {
            var db = new BCDHContext();
            return db.VanBan.ToList();
        }

        public APIResult AddListVanBan(List<VanBan> listVanBan)
        {
            var db = new BCDHContext();
            var result = new APIResult();

            try
            {
                db.VanBan.AddRange(listVanBan);
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

        public ChartOutput Loc(ChartInput input)
        {
            var result = new ChartOutput();
            var data = new List<ChartOutputItem>();

            var fields = input.fields.Split(new string[] { "##" }, StringSplitOptions.None);
            var fieldsLength = fields.Length;
            var values = input.values.Split(new string[] { "##" }, StringSplitOptions.None);
            string function = "";
            var tuNgay = string.IsNullOrEmpty(input.tuNgay) ? DateTime.MinValue : DateTime.ParseExact(input.tuNgay, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            var denNgay = string.IsNullOrEmpty(input.denNgay) ? DateTime.MaxValue : DateTime.ParseExact(input.denNgay, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            var listVanBan = new List<VanBan>();

            using (var db = new BCDHContext())
            {
                var vanBan = db.VanBan.
                    Where(x => x.PhanMem == input.maPhanMem
                    && (x.DonViXuLyChinh == input.maDonVi
                     || x.DonViXuLyChinh == input.maDonVi)
                    )
                    .ToList();

                //vanBan = vanBan.Where(
                //    x => (DateTime.ParseExact(HttpUtility.UrlDecode(x.NgayGiao), "dd/MM/yyyy", CultureInfo.InvariantCulture) >= tuNgay)
                //    && (DateTime.ParseExact(HttpUtility.UrlDecode(x.NgayGiao), "dd/MM/yyyy", CultureInfo.InvariantCulture) <= denNgay))
                //    .ToList();

                foreach (var item in vanBan)
                {
                    string ngayGiao = HttpUtility.UrlDecode(item.NgayGiao);

                    if (string.IsNullOrEmpty(ngayGiao)) continue;

                    if (DateTime.ParseExact(ngayGiao, "dd/MM/yyyy", CultureInfo.InvariantCulture) >= tuNgay 
                        && DateTime.ParseExact(ngayGiao, "dd/MM/yyyy", CultureInfo.InvariantCulture) <= denNgay)
                    {
                        listVanBan.Add(item);
                    }
                }

                vanBan.Clear();
                vanBan.AddRange(listVanBan);

                for (int i = 0; i < fieldsLength; i++)
                {
                    if (fields[i] == "TrangThaiChung")
                    {
                        if (i == fieldsLength - 1)
                        {
                            if (values[i] == "null")
                            {
                                var listTrangThaiChung = db.TrangThaiChung.ToList();
                                foreach (var item in listTrangThaiChung)
                                {
                                    var value = vanBan.Where(x => x.MaTrangThaiChung == item.Ma).Count();
                                    var chartOutputItem = new ChartOutputItem
                                    {
                                        title = item.Ten,
                                        code = item.Ma,
                                        value = value
                                    };

                                    data.Add(chartOutputItem);
                                }
                                result.type = "cot";
                                result.title = "Biểu đồ theo trạng thái";
                                result.function = function + "TrangThaiChung";
                            } else
                            {
                                var maTrangThaiChung = values[i];
                                var trangThaiChung = db.TrangThaiChung.Where(x => x.Ma == maTrangThaiChung).FirstOrDefault();
                                var value = vanBan.Where(x => x.MaTrangThaiChung == maTrangThaiChung).ToList().Count();

                                var charOutputItem = new ChartOutputItem
                                {
                                    title = trangThaiChung.Ten,
                                    code = maTrangThaiChung,
                                    value = value
                                };

                                data.Add(charOutputItem);

                                result.type = "cot";
                                result.title = "Biểu đồ theo trạng thái";
                                result.function = function + "TrangThaiChung";
                            }
                            
                        }
                        else
                        {
                            var trangThai = values[i];
                            vanBan = vanBan.Where(x => x.MaTrangThaiChung == trangThai).ToList();
                            function += fields[i] + "##";
                        }
                    }

                    if (fields[i] == "TinhTrang")
                    {
                        if (i == fieldsLength - 1)
                        {
                            if (values[i] == "null")
                            {
                                var listTinhTrang = db.TinhTrang.ToList();

                                foreach (var item in listTinhTrang)
                                {
                                    var value = vanBan.Where(x => x.MaTinhTrang == item.Ma).Count();

                                    var chartOutputItem = new ChartOutputItem
                                    {
                                        title = item.Ten,
                                        code = item.Ma,
                                        value = value
                                    };

                                    data.Add(chartOutputItem);
                                }

                                result.type = "cot";
                                result.title = "Biểu đồ theo tình trạng xử lý";
                                result.function = function + "TinhTrang";
                            } 
                            else
                            {
                                var maTinhTrang = values[i];
                                var tinhTrang = db.TinhTrang.Where(x => x.Ma == maTinhTrang).FirstOrDefault();
                                var value = vanBan.Where(x => x.MaTinhTrang == maTinhTrang).ToList().Count();

                                var charOutputItem = new ChartOutputItem
                                {
                                    title = tinhTrang.Ten,
                                    code = maTinhTrang,
                                    value = value 
                                };

                                data.Add(charOutputItem);

                                result.type = "cot";
                                result.title = "Biểu đồ theo tình trạng xử lý";
                                result.function = function + "TinhTrang";
                            }
                        }
                        else
                        {
                            var tinhTrang = values[i];
                            vanBan = vanBan.Where(x => x.MaTinhTrang == tinhTrang).ToList();
                            function += fields[i] + "##";
                        }
                    }

                    if (fields[i] == "TrangThaiPhanMem")
                    {
                        if (i == fieldsLength)
                        {

                            if (values[i] == "null")
                            {
                                var listTrangThaiPhanMem = db.TrangThaiPhanMem.ToList();
                                foreach (var item in listTrangThaiPhanMem)
                                {
                                    var value = vanBan.Where(x => x.MaTrangThaiPhanMem == item.Ma).Count();

                                    var chartOutputItem = new ChartOutputItem
                                    {
                                        title = item.Ten,
                                        code = item.Ma,
                                        value = value
                                    };

                                    data.Add(chartOutputItem);
                                }

                                result.type = "cot";
                                result.title = "Biểu đồ theo trạng thái phần mềm";
                                result.function = function + "TrangThaiPhanMem";
                            }
                            else
                            {
                                var maTrangThaiPhanMem = values[i];
                                var trangThaiPhanMem = db.TrangThaiPhanMem.Where(x => x.Ma == maTrangThaiPhanMem).FirstOrDefault();
                                var value = vanBan.Where(x => x.MaTrangThaiPhanMem == maTrangThaiPhanMem).ToList().Count();

                                var charOutputItem = new ChartOutputItem
                                {
                                    title = trangThaiPhanMem.Ten,
                                    code = maTrangThaiPhanMem,
                                    value = value
                                };

                                data.Add(charOutputItem);

                                result.type = "cot";
                                result.title = "Biểu đồ theo trạng thái phần mềm";
                                result.function = function + "TrangThaiPhanMem";
                            }
                        }

                        else
                        {
                            var trangThaiPhanMem = values[i];
                            vanBan = vanBan.Where(x => x.MaTrangThaiPhanMem == trangThaiPhanMem).ToList();
                            function += fields[i] + "##";
                        }
                    }
                }

                var listAvailable = new List<string> { "TrangThaiChung", "TinhTrang", "TrangThaiPhanMem" };
                var available = "";

                foreach (var item in listAvailable)
                {
                    if (!input.fields.Contains(item))
                    {
                        available += item + "##";
                    }
                }

                result.data = data;
                result.available = available;
                return result;
            }
        }

        public ChartOutput Loc1(ChartInputByMonth input)
        {
            var result = new ChartOutput();
            var data = new List<ChartOutputItem>();

            var fields = input.fields.Split(new string[] { "##" }, StringSplitOptions.None);
            var fieldsLength = fields.Length;
            var values = input.values.Split(new string[] { "##" }, StringSplitOptions.None);
            string function = "";

            var tuNgaystr = DateTimeHelper.GetStartDateOfMonth(input.month, input.year);
            var denNgaystr = DateTimeHelper.GetLastDateOfMonth(input.month, input.year);

            var tuNgay = string.IsNullOrEmpty(tuNgaystr) ? DateTime.MinValue : DateTime.ParseExact(tuNgaystr, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            var denNgay = string.IsNullOrEmpty(denNgaystr) ? DateTime.MaxValue : DateTime.ParseExact(denNgaystr, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            var listVanBan = new List<VanBan>();

            using (var db = new BCDHContext())
            {
                var vanBan = db.VanBan.
                    Where(x => x.PhanMem == input.maPhanMem
                    && (x.DonViXuLyChinh == input.maDonVi
                     || x.DonViXuLyChinh == input.maDonVi)
                    )
                    .ToList();

                //vanBan = vanBan.Where(
                //    x => (DateTime.ParseExact(HttpUtility.UrlDecode(x.NgayGiao), "dd/MM/yyyy", CultureInfo.InvariantCulture) >= tuNgay)
                //    && (DateTime.ParseExact(HttpUtility.UrlDecode(x.NgayGiao), "dd/MM/yyyy", CultureInfo.InvariantCulture) <= denNgay))
                //    .ToList();

                foreach (var item in vanBan)
                {
                    string ngayGiao = HttpUtility.UrlDecode(item.NgayGiao);

                    if (string.IsNullOrEmpty(ngayGiao)) continue;

                    if (DateTime.ParseExact(ngayGiao, "dd/MM/yyyy", CultureInfo.InvariantCulture) >= tuNgay
                        && DateTime.ParseExact(ngayGiao, "dd/MM/yyyy", CultureInfo.InvariantCulture) <= denNgay)
                    {
                        listVanBan.Add(item);
                    }
                }

                vanBan.Clear();
                vanBan.AddRange(listVanBan);

                for (int i = 0; i < fieldsLength; i++)
                {
                    if (fields[i] == "TrangThaiChung")
                    {
                        if (i == fieldsLength - 1)
                        {
                            if (values[i] == "null")
                            {
                                var listTrangThaiChung = db.TrangThaiChung.ToList();
                                foreach (var item in listTrangThaiChung)
                                {
                                    var value = vanBan.Where(x => x.MaTrangThaiChung == item.Ma).Count();
                                    var chartOutputItem = new ChartOutputItem
                                    {
                                        title = item.Ten,
                                        code = item.Ma,
                                        value = value
                                    };

                                    data.Add(chartOutputItem);
                                }
                                result.type = "cot";
                                result.title = "Biểu đồ theo trạng thái";
                                result.function = function + "TrangThaiChung";
                            }
                            else
                            {
                                var maTrangThaiChung = values[i];
                                var trangThaiChung = db.TrangThaiChung.Where(x => x.Ma == maTrangThaiChung).FirstOrDefault();
                                var value = vanBan.Where(x => x.MaTrangThaiChung == maTrangThaiChung).ToList().Count();

                                var charOutputItem = new ChartOutputItem
                                {
                                    title = trangThaiChung.Ten,
                                    code = maTrangThaiChung,
                                    value = value
                                };

                                data.Add(charOutputItem);

                                result.type = "cot";
                                result.title = "Biểu đồ theo trạng thái";
                                result.function = function + "TrangThaiChung";
                            }

                        }
                        else
                        {
                            var trangThai = values[i];
                            vanBan = vanBan.Where(x => x.MaTrangThaiChung == trangThai).ToList();
                            function += fields[i] + "##";
                        }
                    }

                    if (fields[i] == "TinhTrang")
                    {
                        if (i == fieldsLength - 1)
                        {
                            if (values[i] == "null")
                            {
                                var listTinhTrang = db.TinhTrang.ToList();

                                foreach (var item in listTinhTrang)
                                {
                                    var value = vanBan.Where(x => x.MaTinhTrang == item.Ma).Count();

                                    var chartOutputItem = new ChartOutputItem
                                    {
                                        title = item.Ten,
                                        code = item.Ma,
                                        value = value
                                    };

                                    data.Add(chartOutputItem);
                                }

                                result.type = "cot";
                                result.title = "Biểu đồ theo tình trạng xử lý";
                                result.function = function + "TinhTrang";
                            }
                            else
                            {
                                var maTinhTrang = values[i];
                                var tinhTrang = db.TinhTrang.Where(x => x.Ma == maTinhTrang).FirstOrDefault();
                                var value = vanBan.Where(x => x.MaTinhTrang == maTinhTrang).ToList().Count();

                                var charOutputItem = new ChartOutputItem
                                {
                                    title = tinhTrang.Ten,
                                    code = maTinhTrang,
                                    value = value
                                };

                                data.Add(charOutputItem);

                                result.type = "cot";
                                result.title = "Biểu đồ theo tình trạng xử lý";
                                result.function = function + "TinhTrang";
                            }
                        }
                        else
                        {
                            var tinhTrang = values[i];
                            vanBan = vanBan.Where(x => x.MaTinhTrang == tinhTrang).ToList();
                            function += fields[i] + "##";
                        }
                    }

                    if (fields[i] == "TrangThaiPhanMem")
                    {
                        if (i == fieldsLength)
                        {

                            if (values[i] == "null")
                            {
                                var listTrangThaiPhanMem = db.TrangThaiPhanMem.ToList();
                                foreach (var item in listTrangThaiPhanMem)
                                {
                                    var value = vanBan.Where(x => x.MaTrangThaiPhanMem == item.Ma).Count();

                                    var chartOutputItem = new ChartOutputItem
                                    {
                                        title = item.Ten,
                                        code = item.Ma,
                                        value = value
                                    };

                                    data.Add(chartOutputItem);
                                }

                                result.type = "cot";
                                result.title = "Biểu đồ theo trạng thái phần mềm";
                                result.function = function + "TrangThaiPhanMem";
                            }
                            else
                            {
                                var maTrangThaiPhanMem = values[i];
                                var trangThaiPhanMem = db.TrangThaiPhanMem.Where(x => x.Ma == maTrangThaiPhanMem).FirstOrDefault();
                                var value = vanBan.Where(x => x.MaTrangThaiPhanMem == maTrangThaiPhanMem).ToList().Count();

                                var charOutputItem = new ChartOutputItem
                                {
                                    title = trangThaiPhanMem.Ten,
                                    code = maTrangThaiPhanMem,
                                    value = value
                                };

                                data.Add(charOutputItem);

                                result.type = "cot";
                                result.title = "Biểu đồ theo trạng thái phần mềm";
                                result.function = function + "TrangThaiPhanMem";
                            }
                        }

                        else
                        {
                            var trangThaiPhanMem = values[i];
                            vanBan = vanBan.Where(x => x.MaTrangThaiPhanMem == trangThaiPhanMem).ToList();
                            function += fields[i] + "##";
                        }
                    }
                }

                var listAvailable = new List<string> { "TrangThaiChung", "TinhTrang", "TrangThaiPhanMem" };
                var available = "";

                foreach (var item in listAvailable)
                {
                    if (!input.fields.Contains(item))
                    {
                        available += item + "##";
                    }
                }

                result.data = data;
                result.available = available;
                return result;
            }
        }

        public bool TruncateVanBan()
        {
            using (var db = new BCDHContext())
            {
                try
                {
                    db.Database.ExecuteSqlCommand("truncate table [BCDH].[dbo].[VanBan]");
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }

            }
        }

        public bool RandomOffice(int skip, int take)
        {
            Random rnd = new Random();
            int officeRandom;

            using (var db = new BCDHContext())
            {
                var vanBans = db.VanBan
                    .OrderBy(x => x.ID)
                    .Skip(skip)
                    .Take(take)
                    .ToList();

                foreach (var item in vanBans)
                {
                    officeRandom = rnd.Next(1, 4); // Random 1- 3

                    switch (officeRandom)
                    {
                        case 1:
                            item.DonViXuLyChinh = "000-00-12-H40";
                            break;
                        case 2:
                            item.DonViXuLyChinh = "000-00-19-H40";
                            break;
                        case 3:
                            item.DonViXuLyChinh = "000-00-20-H40";
                            break;
                        default:
                            break;
                    }
                }

                db.SaveChanges();
            }

            return true;
        }
    }
}
