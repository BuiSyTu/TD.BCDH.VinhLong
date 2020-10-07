using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using TD.BCDH.VinhLong.APIResults;
using TD.BCDH.VinhLong.Models;
using TD.BCDH.VinhLong.ViewModels;

namespace TD.BCDH.VinhLong
{
    [ServiceContract]
    public interface IBCDHVinhLongService
    {
        [OperationContract]
        [WebGet(UriTemplate = "HelloWorld", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string HelloWorld();

        [OperationContract]
        [WebGet(UriTemplate = "CapHoc", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<CapHoc> CapHoc();

        [WebInvoke(UriTemplate = "CapHoc", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        APIResult AddListCapHoc(List<CapHoc> listCapHoc);

        #region ChucVu
        [OperationContract]
        [WebGet(UriTemplate = "ChucVu", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<ChucVu> ChucVu();

        [WebInvoke(UriTemplate = "ChucVu", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        APIResult AddListChucVu(List<ChucVu> listChucVu);
        #endregion

        [OperationContract]
        [WebGet(UriTemplate = "DanToc", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<DanToc> DanToc();

        [WebInvoke(UriTemplate = "DanToc", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        APIResult AddListDanToc(List<DanToc> listDanToc);

        #region DonVi
        [OperationContract]
        [WebGet(UriTemplate = "DonVi", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<DonVi> DonVi();

        [WebInvoke(UriTemplate = "DonVi", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        APIResult AddListDonVi(List<DonVi> listDonVi);
        #endregion

        [OperationContract]
        [WebGet(UriTemplate = "DonViGiaoDuc", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<DonViGiaoDuc> DonViGiaoDuc();

        [WebInvoke(UriTemplate = "DonViGiaoDuc", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        APIResult AddListDonViGiaoDuc(List<DonVi> listDonViGiaoDuc);

        [OperationContract]
        [WebGet(UriTemplate = "GiaoVien", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<GiaoVien> GiaoVien();

        [WebInvoke(UriTemplate = "GiaoVien", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        APIResult AddListGiaoVien(List<GiaoVien> listGiaoVien);

        #region GioiTinh
        [OperationContract]
        [WebGet(UriTemplate = "GioiTinh", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<GioiTinh> GioiTinh();

        [WebInvoke(UriTemplate = "GioiTinh", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        APIResult AddListGioiTinh(List<GioiTinh> listGioiTinh);
        #endregion

        #region HocVi
        [OperationContract]
        [WebGet(UriTemplate = "HocSinh", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<HocSinh> HocSinh();

        [WebInvoke(UriTemplate = "HocSinh", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        APIResult AddListHocSinh(List<HocSinh> listHocSinh);
        #endregion

        #region 
        [OperationContract]
        [WebGet(UriTemplate = "HoSo", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<HoSo> HoSo();

        [WebInvoke(UriTemplate = "HoSo", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        APIResult AddListHoSo(List<HoSo> listHoSo);
        #endregion

        #region 
        [OperationContract]
        [WebGet(UriTemplate = "KhoiHoc", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<KhoiHoc> KhoiHoc();

        [WebInvoke(UriTemplate = "KhoiHoc", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        APIResult AddListKhoiHoc(List<KhoiHoc> listKhoiHoc);
        #endregion

        #region 
        [OperationContract]
        [WebGet(UriTemplate = "LinhVuc", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<LinhVuc> LinhVuc();

        [WebInvoke(UriTemplate = "LinhVuc", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        APIResult AddListLinhVuc(List<LinhVuc> listLinhVuc);
        #endregion

        #region 
        [OperationContract]
        [WebGet(UriTemplate = "LopHoc", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<LopHoc> LopHoc();

        [WebInvoke(UriTemplate = "LopHoc", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        APIResult AddListLopHoc(List<LopHoc> listLopHoc);
        #endregion

        #region 
        [OperationContract]
        [WebGet(UriTemplate = "PhongHoc", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<PhongHoc> PhongHoc();

        [WebInvoke(UriTemplate = "PhongHoc", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        APIResult AddListPhongHoc(List<PhongHoc> listPhongHoc);
        #endregion

        #region 
        [OperationContract]
        [WebGet(UriTemplate = "PhuongXa", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<PhuongXa> PhuongXa();

        [WebInvoke(UriTemplate = "PhuongXa", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        APIResult AddListPhuongXa(List<PhuongXa> listPhuongXa);
        #endregion

        #region 
        [OperationContract]
        [WebGet(UriTemplate = "QuanHuyen", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<QuanHuyen> QuanHuyen();

        [WebInvoke(UriTemplate = "QuanHuyen", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        APIResult AddListQuanHuyen(List<QuanHuyen> listQuanHuyen);
        #endregion

        #region 
        [OperationContract]
        [WebGet(UriTemplate = "ThuTucHanhChinh", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<ThuTucHanhChinh> ThuTucHanhChinh();

        [WebInvoke(UriTemplate = "ThuTucHanhChinh", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        APIResult AddListThuTucHanhChinh(List<ThuTucHanhChinh> listThuTucHanhChinh);
        #endregion

        #region 
        [OperationContract]
        [WebGet(UriTemplate = "TinhThanh", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<TinhThanh> TinhThanh();

        [WebInvoke(UriTemplate = "TinhThanh", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        APIResult AddListTinhThanh(List<TinhThanh> listTinhThanh);
        #endregion
        [OperationContract]
        [WebGet(UriTemplate = "TonGiao", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<TonGiao> TonGiao();

        [WebInvoke(UriTemplate = "TonGiao", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        APIResult AddListTonGiao(List<TonGiao> listTonGiao);

        [OperationContract]
        [WebGet(UriTemplate = "TruongHoc", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<TruongHoc> TruongHoc();

        [WebInvoke(UriTemplate = "TruongHoc", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        APIResult AddListTruongHoc(List<TruongHoc> listTruongHoc);
       
        [WebInvoke(UriTemplate = "Loc", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        ChartOutput Loc(ChartInput input);

        [WebInvoke(UriTemplate = "Loc1", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        ChartOutput Loc1(ChartInputByMonth input);

        [WebInvoke(UriTemplate = "LayDanhSachApiDashboard", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        [OperationContract]
        APIResult LayDanhSachApiDashboard(string fields);

        [OperationContract]
        [WebInvoke(Method ="DELETE", UriTemplate = "VanBan/Truncate", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        bool TruncateVanBan();

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "VanBan/Random/Office", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        bool RandomOffice(int skip, int take);
    }
}
