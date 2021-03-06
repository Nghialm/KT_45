/*
insert license info here
*/
using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using System.Data;
namespace Vns.Erp.Core.Admin.Domain
{
	/// <summary>
	///	Generated by MyGeneration using the NHibernate Object Mapping adapted by Gustavo And Modified By Hoang Quoc Dung
	/// </summary>

		
	public partial class DmHanghoa : DomainObject<Guid>
    {
        #region Mapping Excel Import
        public DmHanghoa(DataRow dr)
        {
            _ma_hanghoa = dr["MA_VAT_TU"].ToString();
            _ky_hieu = dr["KY_HIEU"].ToString();
            _ten_hanghoa = dr["TEN_HANG_HOA"].ToString();

            _ma_dvt = dr["DON_VI_TINH"].ToString();

            if (!decimal.TryParse(dr["LOAI_HANG_HOA"].ToString(), out _LoaiHangHoa))
            {
                _LoaiHangHoa = 1;
            }

            //_ma_hanghoa = dr["DON_VI_TINH"].ToString();
            if (!decimal.TryParse(dr["PP_TINH_GIA"].ToString(), out _pp_kt_htk))
            {
                _pp_kt_htk = 1;
            }

            _md_tk_kho = dr["TK_KHO"].ToString();
            _md_tk_giavon = dr["TK_GIA_VON"].ToString();
            _md_tk_giaban = dr["TK_DOANH_THU"].ToString();
            _md_tk_giaban_nb = dr["TK_DOANH_THU_NOI_BO"].ToString();
            _md_tk_hb_tralai = dr["TK_HANG_BAN_TRA_LAI"].ToString();
            _md_tk_sp_dd = dr["TK_SAN_PHAM_DO_DANG"].ToString();

            _ngay_tao = DateTime.Now;
            _ngay_sua = DateTime.Now;
            _nguoi_tao = Null.NullGuid;
            _nguoi_sua = Null.NullGuid;

            _co_su_dung = 1;
            _cho_phep_sua = 1;
        }
        #endregion
    }
}
