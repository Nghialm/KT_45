using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Accounting.Domain;
using System.Data;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Accounting.Report.Domain;

namespace Vns.Erp.Core.Accounting.Report.Dao
{
    public interface IRpLedgerAccountDao : IDao<BcKetoan, System.Guid>
    {
        DataTable GetDataS06Dn(String MaTk, String MaTkDu, DateTime TuNgay, DateTime DenNgay, Guid DonviId);
        DataTable GetDataS06DnWithDetail(String MaTk, String MaTkDu, Guid KhangId, DateTime TuNgay, DateTime DenNgay, Guid DonviId);
        DataTable GetDataS38Dn(String p_Ma_Tk, Guid p_DonviId, DateTime p_Tu_Ngay, DateTime p_Den_Ngay);
        DataTable GetDataS07Dn(String MaTk, String MaTkDu, DateTime TuNgay, DateTime DenNgay, Guid DonviId, String MaNte);
        DataTable GetDataS03a_SoNhatKyChung(String MaTk, String MaTkDu, DateTime TuNgay, DateTime DenNgay, Guid DonviId);
        DataTable GetDataS03A_ThuChi(Boolean IsNo, String MaTk, String MaTkDu, DateTime TuNgay, DateTime DenNgay, Guid DonviId);
        DataTable GetDataS03A_MuaHang(String MaTk, DateTime TuNgay, DateTime DenNgay, Guid DonviId);
        DataTable GetDataS03A_Banhang(String MaTk, DateTime TuNgay, DateTime DenNgay, Guid DonviId);
        Decimal Get_GiaTri_BaoCao(KtHDong objKtHDong, DateTime TuNgay, DateTime DenNgay, Guid DonviId);
        IList<RpLedgerAdminDTO> GetDataDetail(String MaTk, String MaTkDu, DateTime TuNgay, DateTime DenNgay, Guid DonviId, Guid KhachHangId, Guid HopDongId);
    }
}
