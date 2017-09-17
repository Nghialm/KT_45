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
    public interface IKtCtHHddvService : IErpService<KtCtHHddv, System.Guid>
    {
        [OperationContract]
        IList<KtCtHHddv> GetByDonviId(Guid DonviId);

        [OperationContract(Name = "GetByLoaiChungTuByHoaDonDichVu")]
        IList<KtCtHHddv> GetByLoaiChungTu(int PageIndex, int PageSize, Guid DonviId, string MaLoaiCt, int SoCTHienThi, out int TotalResult);
        [OperationContract]
        Boolean DeleteChungTu(KtCtHHddv objCtH, IList<KtCtDHddv> lstCtD);
        [OperationContract]
        void SaveHDDVMuaBanHang(Boolean IsInsert, ref KtCtHHddv _cthHddvInfo, ref CtHoadon _ctHoaDonInfo, ref List<KtCtDHddv> _lstctdHddvInfo, List<KtCtDHddv> _dellstctdHddv);

        [OperationContract]
        IList<KtCtHHddv> SearchChungTu(Guid DONVI_ID, string MA_LOAI_CT, string CT_SO, DateTime NGAY_CT_TU, DateTime NGAY_CT_DEN, decimal GHI, string TenKhachHang, string MA_TK_NO, string MA_TK_CO, string Ma_tk_thue,
                                   decimal SO_TIEN_TU, decimal SO_TIEN_DEN, string NOI_DUNG, Decimal So_Luong_Tu, Decimal So_Luong_Den, String TenHangHoa,
                                   Guid ID_DM_KHOANPHI, Guid ID_DM_VUVIEC, Guid ID_DM_HOPDONG, Guid ID_DM_PHONGBAN, Guid ID_DM_TUDO_1, Guid ID_DM_TUDO_2, Guid ID_DM_TUDO_3,
                                   Guid ID_DM_TUDO_4, Guid ID_DM_TUDO_5);

        #region Syn data
        [OperationContract]
        void SaveData4Syn(KtCtHHddv _cth, List<KtCtDHddv> _lstctd);

        [OperationContract]
        void UpdateSynFlag(Guid id);
        #endregion
    }
}
