using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;

namespace Vns.Erp.Core.Accounting.Dao
{
	public interface ICtHNxDao:IDao<CtHNx,System.Guid>
	{
        IList<CtHNx> GetByLoaiChungTu(int PageIndex,int PageSize,Guid DonviId, string MaLoaiCt, int SoCTHienThi,out int TotalResult);
        IList<CtHNx> GetByLoaiChungTu( Guid DonviId, string MaLoaiCt, int SoCTHienThi);
        IList<CtDNx> GetAllSoDu(int PageIndex, int PageSize, Guid DonviId, int NamKeToan, out int TotalResult);
        IList<CtHNx> SearchChungTu(Guid DONVI_ID, string MA_LOAI_CT, string CT_SO_TU, string CT_SO_DEN, DateTime NGAY_CT_TU, DateTime NGAY_CT_DEN, decimal GHI, string MA_KHANG, string MA_TK_CO, string MA_TK_NO,
                                    decimal SO_TIEN_TU, decimal SO_TIEN_DEN, string NOI_DUNG, Guid ID_DM_KHOANPHI, Guid ID_DM_VUVIEC, Guid ID_DM_HOPDONG, Guid ID_DM_PHONGBAN, Guid ID_DM_TUDO_1, Guid ID_DM_TUDO_2, Guid ID_DM_TUDO_3,
                                    Guid ID_DM_TUDO_4, Guid ID_DM_TUDO_5, Guid KhoId, Decimal So_Luong_Tu, Decimal So_Luong_Den, String TenHangHoa);
	}
}