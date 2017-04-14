using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vns.Erp.Core.Accounting.Report.Dao;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Dao.NHibernate;
using System.Data;
using NHibernate;
using NHibernate.Transform;
using Vns.Erp.Core.Accounting.Report.Domain;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Dao.Util;
using System.Collections;

namespace Vns.Erp.Core.Accounting.Report.Dao.NHibernate
{
    [Serializable]
    public class RpLedgerTaxDao : GenericDao<BcKetoan, System.Guid>, IRpLedgerTaxDao
    {
        public DataTable GetDataBangKeThue(String MaTk, DateTime TuNgay, DateTime DenNgay, Guid DonviId)
        {
            IList<RpThueDTO> lstThue = new List<RpThueDTO>();

            string sql = "Select hd.SoHoadon as SoHoadon, hd.SoSeri as SoSeri, hd.NgayHoadon as NgayHoadon, " +
                "hd.TenKhachhang as TenKhachhang, hd.MaSoThue as MaSoThue, " +
                " t.SoThuTu as STT, t.TenHanghoa as TenHanghoa, t.SoLuong as SoLuong, t.DoanhSo as DoanhSo, " + 
                "t.TyLe as TyLe, t.SoTien as SoTien, t.DonGia as DonGia, t.GhiChu as GhiChu, " +
                "t.ThueId as ThueId, t.TenThue as TenThue" +
                " from CtHoadon hd inner join hd.LstCtThue t " +
                "where hd.DonviId = :DonviId " +
                (String.IsNullOrEmpty(MaTk) ? "" : "AND t.MaTaikhoan like :MaTaikhoan ") +
                " And hd.NgayHoadon >= :TuNgay And hd.NgayHoadon <= :DenNgay " +
                "Order by t.TenThue Desc";
            IQuery qbc_tk = NHibernateSession.CreateQuery(sql);
            qbc_tk.SetParameter("DonviId", DonviId);
            if (!String.IsNullOrEmpty(MaTk)) qbc_tk.SetParameter("MaTaikhoan", MaTk + "%");
            qbc_tk.SetParameter("TuNgay", TuNgay);
            qbc_tk.SetParameter("DenNgay", DenNgay);

            qbc_tk.SetResultTransformer(Transformers.AliasToBean<RpThueDTO>());
            lstThue = qbc_tk.List<RpThueDTO>();

            DataTable dt = DataHelper.ToDataTable<RpThueDTO>(lstThue);
            return dt;
        }
    }
}
