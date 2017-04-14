using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Service;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System;
using System.ServiceModel;

namespace Vns.Erp.Core.Accounting.Service.Interface
{
    [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
	public interface ICtHNxService:IErpService<CtHNx, System.Guid>
	{
        [OperationContract]
        IList<CtHNx> GetByDonviId(Guid DonviId);
        [OperationContract]
        IList<CtDNx> GetAllSoDu(int PageIndex, int PageSize, Guid DonviId, int NamKeToan, out int TotalResult);
        [OperationContract]
        IList<CtHNx> GetByLoaiChungTu( Guid DonviId, string MaLoaiCt, int SoCTHienThi);
        [OperationContract(Name = "GetAllByLoaiChungTuAndPhieuNhapKho")]
        IList<CtHNx> GetByLoaiChungTu(int PageIndex, int PageSize,Guid DonviId, string MaLoaiCt, int SoCTHienThi,out int TotalResult);
        [OperationContract]
        IList<CtHNx> SearchChungTu(Guid DONVI_ID, string MA_LOAI_CT, string CT_SO_TU, string CT_SO_DEN, DateTime NGAY_CT_TU, DateTime NGAY_CT_DEN, decimal GHI, string MA_KHANG, string MA_TK_CO, string MA_TK_NO,
                                    decimal SO_TIEN_TU, decimal SO_TIEN_DEN, string NOI_DUNG, Guid ID_DM_KHOANPHI, Guid ID_DM_VUVIEC, Guid ID_DM_HOPDONG, Guid ID_DM_PHONGBAN, Guid ID_DM_TUDO_1, Guid ID_DM_TUDO_2, Guid ID_DM_TUDO_3,
                                    Guid ID_DM_TUDO_4, Guid ID_DM_TUDO_5, Guid KhoId, Decimal So_Luong_Tu, Decimal So_Luong_Den, String TenHangHoa);
        [OperationContract]
        Boolean DeleteChungTu(CtHNx objCtHNx);
        [OperationContract]
        Boolean SaveChungTuKho(Boolean isUpdate, ref CtHNx _cthInfo, ref List<CtDNx> _lstctdInfo, List<CtDNx> _lstDelCtdInfo);
        [OperationContract]
        void SaveChungTuMuaBan(Boolean isUpdate, ref CtHNx _cthnxInfo, ref List<CtDNx> _lstctdnxInfo, List<CtDNx> _lstDelCtdInfo, ref CtHoadon _ctHoaDonInfo, Decimal _phieuXuat);
	}
}
