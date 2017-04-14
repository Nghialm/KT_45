using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Service;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System;
using System.Collections.Generic;
using Vns.Erp.Core.Accounting.Domain.Extend;
using System.ServiceModel;

namespace Vns.Erp.Core.Accounting.Service.Interface
{
    [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
	public interface ICtHService:IErpService<CtH, System.Guid>
	{
        [OperationContract]
        IList<CtH> GetByDonviId(Guid DonviId);
        [OperationContract]
        IList<CtH> GetSoDu(Guid DonviId, int NamKeToan);
        [OperationContract]
        IList<CtD> GetAllSoDu(Guid DonviId, int NamKeToan);
        //[OperationContract]
        //IList<CtH> GetByLoaiChungTu(int PageIndex, int PageSize, Guid DonviId, string MaLoaiCt, out int TotalResult);
        [OperationContract(Name = "GetByLoaiChungTuBySoCTHienThi")]
        IList<CtH> GetByLoaiChungTu(int PageIndex, int PageSize, Guid DonviId, string MaLoaiCt, out int TotalResult);
        [OperationContract(Name = "GetByLoaiChungTuByNgayCT")]
        CtH GetByLoaiChungTu(Guid DonviId, string MaLoaiCt, DateTime NgayCt);
        [OperationContract]
        Boolean DeleteChungTu(CtH objCtH, IList<CtD> lstCtD);
        [OperationContract]
        void SaveChungTuKeToan(Boolean IsInsert, ref CtHoadon _ctHoaDonInfo, ref CtH _cthInfo, ref List<CtD> _lstctdInfo, List<CtD> _lstDelCtdInfo, Guid TK_THUE, ref List<CtD> _lstCT_DInfo_Thue, ref CtD _objctdthue, ref List<CtThue> _lstCT_Thue, ref List<CtThue> _lstDel_CT_Thue);
        [OperationContract(Name = "SaveChungTuKeToanByCtd")]
        void SaveChungTuKeToan(Boolean IsInsert, ref CtH _cthInfo, ref List<CtD> _lstCtdInfo);
        [OperationContract(Name = "SaveChungTuPhanBoByMonth")]
        void SaveChungTuPhanBo(ref CtH _cthInfo, ref List<CtD> _lstctdInfo, ref List<KtThBtPhanbo> _lstctPhanBoNamInfo, decimal _month);
        [OperationContract]
        void SaveCTDK(Vns.Erp.Core.FormGlobals.DataInputState status, ref CtH _cthInfo, List<CT_D_KInfo> lstCTDK, List<CT_D_KInfo> del_lstobj_ct_d_k);
        [OperationContract]
        IList<CtH> SearchChungTu(Guid DONVI_ID, string MA_LOAI_CT, string CT_SO_TU, string CT_SO_DEN, DateTime NGAY_CT_TU, DateTime NGAY_CT_DEN, decimal GHI, string MA_KHANG, string MA_TK_CO, string MA_TK_NO,
                                    decimal SO_TIEN_TU, decimal SO_TIEN_DEN, string NOI_DUNG, Guid ID_DM_KHOANPHI, Guid ID_DM_VUVIEC, Guid ID_DM_HOPDONG, Guid ID_DM_PHONGBAN, Guid ID_DM_TUDO_1, Guid ID_DM_TUDO_2, Guid ID_DM_TUDO_3,
                                    Guid ID_DM_TUDO_4, Guid ID_DM_TUDO_5);
        [OperationContract]
        Boolean DeleteMa(Guid IdLoaiCt, DateTime NgayCt, Guid DonviId);
        [OperationContract]
        Boolean DeleteChungTuCTH(CtH objCtH, IList<CtD> lstCtD, CtHoadon objHoaDon);
        [OperationContract]
        Boolean DeleteChungTuCTHK(CtH objCtH, List<CT_D_KInfo> lstCTDK);
        #region TSCD
        [OperationContract]
        void DeleteChungTuKhauHao(Decimal Thang, Decimal Nam, Guid DonviId, string MaLoaiCt);
        #endregion
    }
}
