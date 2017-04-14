using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Transform;
using Vns.Erp.Core.Dao.NHibernate;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Admin.Domain;
using System.Data;
using Vns.Erp.Core.Accounting.Report.Domain;
using Vns.Erp.Core.Dao.Util;

namespace Vns.Erp.Core.Accounting.Report.Dao.NHibernate
{
    public class RpLedgerStoreDao : GenericDao<BcKetoan, System.Guid>, IRpLedgerStoreDao
    {
        public DataTable GetDataS10Dn(DateTime NgayDk, DateTime NgayCk, String MaTk, Guid KhoId, Guid HanghoaId, Guid DonviId)
        {
            String MaTkDu = "";
            String sql = "select bc.CtSo as CtSo, bc.NgayCt as NgayCt, bc.DienGiai as DienGiai, " +
                "Case When bc.Xuat = 0 Then bc.MaTknGiavon " +
                "When bc.Xuat = 1 Then bc.MaTkcGiavon End as MaTk, " +
                "Case When bc.Xuat = 1 Then bc.MaTkcGiavon " +
                "When bc.Xuat = 0 Then bc.MaTknGiavon End as MaTkDu, " +
                "bc.DonGiaVon as DonGiaVon, " +
                "Case When bc.Xuat = 0 Then bc.SoLuong " +
                "When bc.Xuat = 1 Then 0 End as SlNhap, " +
                "Case When bc.Xuat = 0 Then bc.GiaVon " +
                "When bc.Xuat = 1 Then 0 End as SoTienNhap, " +
                "Case When bc.Xuat = 1 Then bc.SoLuong " +
                "When bc.Xuat = 0 Then 0 End as SlXuat, " +
                "Case When bc.Xuat = 1 Then bc.GiaVon " +
                "When bc.Xuat = 0 Then 0 End as SoTienXuat, " +
                "bc.CthNxId as CthId, bc.CtdNxId as CtdId, " +
                "bc.HanghoaId as HanghoaId, bc.MaHanghoa as MaHanghoa, bc.TenHanghoa as TenHanghoa, bc.DonviId as DonviId, bc.IdLoaiCt as IdLoaiCt, 2 as Nhom, bc.Xuat as Xuat " +
             "from BcKetoanKho bc " +
             "where " +
             "bc.HanghoaId = :HanghoaId " +
               "AND bc.NgayCt >= :NgayDk And bc.NgayCt <= :NgayCk " +
               (String.IsNullOrEmpty(MaTk) ? "" : "AND ((bc.MaTkcGiavon like :MaTk and bc.Xuat = 1) or (bc.MaTknGiavon like :MaTk and bc.Xuat = 0)) ") +
               (String.IsNullOrEmpty(MaTkDu) ? "" : "AND ((bc.MaTknGiavon like :MaTkDu and bc.Xuat = 1) or (bc.MaTkcGiavon like :MaTkDu and bc.Xuat = 0))") +
               (VnsCheck.IsNullGuid(KhoId) ? "" : "AND (bc.KhoXuatId = :KhoId or bc.KhoNhapId = :KhoId) ") +
               "AND bc.DonviId = :DonviId " +
               "AND bc.SoDu = 0 ";

            //So du dau ky
            RpLedgerS10DnDTO dk = new RpLedgerS10DnDTO();
            DateTime NgayTinhDauKy = NgayDk.AddDays(-1);
            dk.DienGiai = "Số tồn đầu kỳ";
            dk.SlTon = fn_so_luong_ton_kho(MaTk, MaTkDu, KhoId, HanghoaId, DonviId, NgayTinhDauKy,
                Null.NullGuid,Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid,Null.NullGuid);

            dk.SoTienTon = fn_so_tien_ton_kho(MaTk, MaTkDu, KhoId, HanghoaId, DonviId, NgayTinhDauKy,
                Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid);
            dk.Nhom = 1;

            //Ps trong ky
            IQuery qbcketoan = NHibernateSession.CreateQuery(sql);
            qbcketoan.SetParameter("HanghoaId", HanghoaId);
            qbcketoan.SetParameter("NgayDk", NgayDk);
            qbcketoan.SetParameter("NgayCk", NgayCk);
            if (!String.IsNullOrEmpty(MaTk)) qbcketoan.SetParameter("MaTk", MaTk);
            if (!String.IsNullOrEmpty(MaTkDu)) qbcketoan.SetParameter("MaTkDu", MaTkDu);
            if (!VnsCheck.IsNullGuid(KhoId)) qbcketoan.SetParameter("KhoId", KhoId);
            qbcketoan.SetParameter("DonviId", DonviId);

            qbcketoan.SetResultTransformer(Transformers.AliasToBean<RpLedgerS10DnDTO>());
            IList<RpLedgerS10DnDTO> lst = qbcketoan.List<RpLedgerS10DnDTO>();

            //So du cuoi ky
            RpLedgerS10DnDTO ck = new RpLedgerS10DnDTO();
            ck.DienGiai = "Số tồn cuối kỳ";
            ck.SlTon = fn_so_luong_ton_kho(MaTk, MaTkDu, KhoId, HanghoaId, DonviId, NgayCk,
                Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid);

            ck.SoTienTon = fn_so_tien_ton_kho(MaTk, MaTkDu, KhoId, HanghoaId, DonviId, NgayCk,
                Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid,
             Null.NullGuid, Null.NullGuid);
            ck.Nhom = 3;

            lst.Add(dk);
            lst.Add(ck);

            DataTable dt = DBUtil.ToDataTable<RpLedgerS10DnDTO>(lst);
            dt.DefaultView.Sort = "Nhom, NgayCt";
            return dt;
        }

        public DataTable GetDataS11Dn(DateTime NgayDk, DateTime NgayCk, Guid KhoId, Guid DonviId)
        {
            IList<DmHanghoa> lstHanghoa = new List<DmHanghoa>();
            List<RpLedgerStoreS11DnDTO> lstRp = new List<RpLedgerStoreS11DnDTO>();

            //string sql = ;
            IQuery qbc_tk = NHibernateSession.CreateQuery("Select a from DmHanghoa a where a.DonviId = :DonviId Order by a.KyHieu");
            qbc_tk.SetParameter("DonviId", DonviId);
            lstHanghoa = qbc_tk.List<DmHanghoa>();
            DateTime NgayTinhDauKy = NgayDk.AddDays(-1); 
            foreach (DmHanghoa tmp in lstHanghoa)
            {
                RpLedgerStoreS11DnDTO tmpRp = new RpLedgerStoreS11DnDTO() { HangHoaId = tmp.Id, TenHangHoa = tmp.TenHanghoa };
                tmpRp.SlTonDauKy = fn_so_luong_ton_kho(String.Empty, String.Empty, KhoId, tmpRp.HangHoaId, DonviId, NgayTinhDauKy, 
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid,Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid,Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid,Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid,Null.NullGuid, Null.NullGuid,Null.NullGuid, Null.NullGuid);

                tmpRp.SlNhapTrongKy =  fn_sl_nhap_kho(String.Empty, String.Empty, KhoId, tmpRp.HangHoaId, DonviId, NgayDk, NgayCk,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);

                tmpRp.SlXuatTrongKy = fn_sl_xuat_kho(String.Empty, String.Empty, KhoId, tmpRp.HangHoaId, DonviId, NgayDk, NgayCk,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);

                lstRp.Add(tmpRp);
            }

            DataTable dt = DBUtil.ToDataTable<RpLedgerStoreS11DnDTO>(lstRp);
            dt.DefaultView.Sort = "";
            return dt;
        }

        public DataTable GetDataS11Dn_All(DateTime NgayDk, DateTime NgayCk, Guid KhoId, Guid DonviId)
        {
            IList<DmHanghoa> lstHanghoa = new List<DmHanghoa>();
            List<RpLedgerStoreS11DnDTO> lstRp = new List<RpLedgerStoreS11DnDTO>();

            //string sql = ;
            IQuery qbc_tk = NHibernateSession.CreateQuery("Select a from DmHanghoa a where a.DonviId = :DonviId Order by a.KyHieu");
            qbc_tk.SetParameter("DonviId", DonviId);
            lstHanghoa = qbc_tk.List<DmHanghoa>();
            DateTime NgayTinhDauKy = NgayDk.AddDays(-1);
            foreach (DmHanghoa tmp in lstHanghoa)
            {
                RpLedgerStoreS11DnDTO tmpRp = new RpLedgerStoreS11DnDTO() { HangHoaId = tmp.Id, TenHangHoa = tmp.TenHanghoa };
                tmpRp.SlTonDauKy = fn_so_luong_ton_kho(String.Empty, String.Empty, KhoId, tmpRp.HangHoaId, DonviId, NgayTinhDauKy,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);

                tmpRp.StTonDauKy = fn_so_tien_ton_kho(String.Empty, String.Empty, KhoId, tmpRp.HangHoaId, DonviId, NgayTinhDauKy,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);

                tmpRp.SlNhapTrongKy = fn_sl_nhap_kho(String.Empty, String.Empty, KhoId, tmpRp.HangHoaId, DonviId, NgayDk, NgayCk,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);

                tmpRp.StNhapTrongKy = fn_SoTien_nhap_kho(String.Empty, String.Empty, KhoId, tmpRp.HangHoaId, DonviId, NgayDk, NgayCk,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);

                tmpRp.SlXuatTrongKy = fn_sl_xuat_kho(String.Empty, String.Empty, KhoId, tmpRp.HangHoaId, DonviId, NgayDk, NgayCk,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);

                tmpRp.StXuatTrongKy = fn_SoTien_xuat_kho(String.Empty, String.Empty, KhoId, tmpRp.HangHoaId, DonviId, NgayDk, NgayCk,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);

                lstRp.Add(tmpRp);
            }

            DataTable dt = DBUtil.ToDataTable<RpLedgerStoreS11DnDTO>(lstRp);
            dt.DefaultView.Sort = "";
            return dt;
        }

        #region Function
        public Decimal fn_so_luong_ton_kho_4_update(String MaTk, String MaTkDu, Guid KhoId, Guid HanghoaId, Guid DonviId,
            DateTime NgayTinh,
            Guid IdDmHopDong, Guid IdDmHopDongDu,
            Guid IdDmPtqt, Guid IdDmPtqtDu,
            Guid IdDmPhongban, Guid IdDmPhongbanDu,
            Guid IdDmVuviec, Guid IdDmVuviecDu,
            Guid IdDmKhang, Guid IdDmKhangDu,
            Guid IdDmKhoanphi, Guid IdDmKhoanphiDu,
            Guid IdDmTudo1, Guid IdDmTudo1Du,
            Guid IdDmTudo2, Guid IdDmTudo2Du,
            Guid IdDmTudo3, Guid IdDmTudo3Du,
            Guid IdDmTudo4, Guid IdDmTudo4Du,
            Guid IdDmTudo5, Guid IdDmTudo5Du,
            Guid CthNxId)
        {
            DateTime TuNgay = DateTime.MinValue;
            DateTime DenNgay = NgayTinh;
            Decimal sl_nhap, sl_xuat;
            sl_nhap = fn_nhap_kho("SoLuong", MaTk, MaTkDu, KhoId, HanghoaId, DonviId,
                TuNgay, DenNgay, 2,
                 IdDmHopDong, IdDmHopDongDu,
             IdDmPtqt, IdDmPtqtDu,
             IdDmPhongban, IdDmPhongbanDu,
             IdDmVuviec, IdDmVuviecDu,
             IdDmKhang, IdDmKhangDu,
             IdDmKhoanphi, IdDmKhoanphiDu,
             IdDmTudo1, IdDmTudo1Du,
             IdDmTudo2, IdDmTudo2Du,
             IdDmTudo3, IdDmTudo3Du,
             IdDmTudo4, IdDmTudo4Du,
             IdDmTudo5, IdDmTudo5Du,
             CthNxId);

            sl_xuat = fn_xuat_kho("SoLuong", MaTk, MaTkDu, KhoId, HanghoaId, DonviId,
                TuNgay, DenNgay, 2,
                 IdDmHopDong, IdDmHopDongDu,
             IdDmPtqt, IdDmPtqtDu,
             IdDmPhongban, IdDmPhongbanDu,
             IdDmVuviec, IdDmVuviecDu,
             IdDmKhang, IdDmKhangDu,
             IdDmKhoanphi, IdDmKhoanphiDu,
             IdDmTudo1, IdDmTudo1Du,
             IdDmTudo2, IdDmTudo2Du,
             IdDmTudo3, IdDmTudo3Du,
             IdDmTudo4, IdDmTudo4Du,
             IdDmTudo5, IdDmTudo5Du,
             CthNxId);
            return sl_nhap - sl_xuat;
        }

        public Decimal fn_so_luong_ton_kho(String MaTk, String MaTkDu, Guid KhoId, Guid HanghoaId, Guid DonviId,
            DateTime NgayTinh,
            Guid IdDmHopDong, Guid IdDmHopDongDu,
            Guid IdDmPtqt, Guid IdDmPtqtDu,
            Guid IdDmPhongban, Guid IdDmPhongbanDu,
            Guid IdDmVuviec, Guid IdDmVuviecDu,
            Guid IdDmKhang, Guid IdDmKhangDu,
            Guid IdDmKhoanphi, Guid IdDmKhoanphiDu,
            Guid IdDmTudo1, Guid IdDmTudo1Du,
            Guid IdDmTudo2, Guid IdDmTudo2Du,
            Guid IdDmTudo3, Guid IdDmTudo3Du,
            Guid IdDmTudo4, Guid IdDmTudo4Du,
            Guid IdDmTudo5, Guid IdDmTudo5Du)
        {
            DateTime TuNgay = DateTime.MinValue;
            DateTime DenNgay = NgayTinh;
            Decimal sl_nhap, sl_xuat;
            sl_nhap = fn_nhap_kho("SoLuong", MaTk, MaTkDu, KhoId, HanghoaId, DonviId,
                TuNgay, DenNgay, 2,
                 IdDmHopDong, IdDmHopDongDu,
             IdDmPtqt, IdDmPtqtDu,
             IdDmPhongban, IdDmPhongbanDu,
             IdDmVuviec, IdDmVuviecDu,
             IdDmKhang, IdDmKhangDu,
             IdDmKhoanphi, IdDmKhoanphiDu,
             IdDmTudo1, IdDmTudo1Du,
             IdDmTudo2, IdDmTudo2Du,
             IdDmTudo3, IdDmTudo3Du,
             IdDmTudo4, IdDmTudo4Du,
             IdDmTudo5, IdDmTudo5Du);

            sl_xuat = fn_xuat_kho("SoLuong", MaTk, MaTkDu, KhoId, HanghoaId, DonviId,
                TuNgay, DenNgay,
                 IdDmHopDong, IdDmHopDongDu,
             IdDmPtqt, IdDmPtqtDu,
             IdDmPhongban, IdDmPhongbanDu,
             IdDmVuviec, IdDmVuviecDu,
             IdDmKhang, IdDmKhangDu,
             IdDmKhoanphi, IdDmKhoanphiDu,
             IdDmTudo1, IdDmTudo1Du,
             IdDmTudo2, IdDmTudo2Du,
             IdDmTudo3, IdDmTudo3Du,
             IdDmTudo4, IdDmTudo4Du,
             IdDmTudo5, IdDmTudo5Du);
            return sl_nhap - sl_xuat;
        }

        public Decimal fn_so_tien_ton_kho(String MaTk, String MaTkDu, Guid KhoId, Guid HanghoaId, Guid DonviId,
            DateTime NgayTinh,
            Guid IdDmHopDong, Guid IdDmHopDongDu,
            Guid IdDmPtqt, Guid IdDmPtqtDu,
            Guid IdDmPhongban, Guid IdDmPhongbanDu,
            Guid IdDmVuviec, Guid IdDmVuviecDu,
            Guid IdDmKhang, Guid IdDmKhangDu,
            Guid IdDmKhoanphi, Guid IdDmKhoanphiDu,
            Guid IdDmTudo1, Guid IdDmTudo1Du,
            Guid IdDmTudo2, Guid IdDmTudo2Du,
            Guid IdDmTudo3, Guid IdDmTudo3Du,
            Guid IdDmTudo4, Guid IdDmTudo4Du,
            Guid IdDmTudo5, Guid IdDmTudo5Du)
        {
            DateTime TuNgay = DateTime.MinValue;
            DateTime DenNgay = NgayTinh;
            Decimal sl_nhap, sl_xuat;
            sl_nhap = fn_nhap_kho("GiaVon", MaTk, MaTkDu, KhoId, HanghoaId, DonviId,
                TuNgay, DenNgay, 2,
                 IdDmHopDong, IdDmHopDongDu,
             IdDmPtqt, IdDmPtqtDu,
             IdDmPhongban, IdDmPhongbanDu,
             IdDmVuviec, IdDmVuviecDu,
             IdDmKhang, IdDmKhangDu,
             IdDmKhoanphi, IdDmKhoanphiDu,
             IdDmTudo1, IdDmTudo1Du,
             IdDmTudo2, IdDmTudo2Du,
             IdDmTudo3, IdDmTudo3Du,
             IdDmTudo4, IdDmTudo4Du,
             IdDmTudo5, IdDmTudo5Du);

            sl_xuat = fn_xuat_kho("GiaVon", MaTk, MaTkDu, KhoId, HanghoaId, DonviId,
                TuNgay, DenNgay,
                 IdDmHopDong, IdDmHopDongDu,
             IdDmPtqt, IdDmPtqtDu,
             IdDmPhongban, IdDmPhongbanDu,
             IdDmVuviec, IdDmVuviecDu,
             IdDmKhang, IdDmKhangDu,
             IdDmKhoanphi, IdDmKhoanphiDu,
             IdDmTudo1, IdDmTudo1Du,
             IdDmTudo2, IdDmTudo2Du,
             IdDmTudo3, IdDmTudo3Du,
             IdDmTudo4, IdDmTudo4Du,
             IdDmTudo5, IdDmTudo5Du);
            return sl_nhap - sl_xuat;
        }

        public Decimal fn_sl_nhap_kho(String MaTk, String MaTkDu, Guid KhoNhapId, Guid HanghoaId, Guid DonviId,
            DateTime TuNgay, DateTime DenNgay,
            Guid IdDmHopDong, Guid IdDmHopDongDu,
            Guid IdDmPtqt, Guid IdDmPtqtDu,
            Guid IdDmPhongban, Guid IdDmPhongbanDu,
            Guid IdDmVuviec, Guid IdDmVuviecDu,
            Guid IdDmKhang, Guid IdDmKhangDu,
            Guid IdDmKhoanphi, Guid IdDmKhoanphiDu,
            Guid IdDmTudo1, Guid IdDmTudo1Du,
            Guid IdDmTudo2, Guid IdDmTudo2Du,
            Guid IdDmTudo3, Guid IdDmTudo3Du,
            Guid IdDmTudo4, Guid IdDmTudo4Du,
            Guid IdDmTudo5, Guid IdDmTudo5Du)
        {
            return fn_nhap_kho("SoLuong", MaTk, MaTkDu, KhoNhapId, HanghoaId, DonviId,
                TuNgay, DenNgay, 0,
                 IdDmHopDong, IdDmHopDongDu,
             IdDmPtqt, IdDmPtqtDu,
             IdDmPhongban, IdDmPhongbanDu,
             IdDmVuviec, IdDmVuviecDu,
             IdDmKhang, IdDmKhangDu,
             IdDmKhoanphi, IdDmKhoanphiDu,
             IdDmTudo1, IdDmTudo1Du,
             IdDmTudo2, IdDmTudo2Du,
             IdDmTudo3, IdDmTudo3Du,
             IdDmTudo4, IdDmTudo4Du,
             IdDmTudo5, IdDmTudo5Du);
         }

        public Decimal fn_SoTien_nhap_kho(String MaTk, String MaTkDu, Guid KhoNhapId, Guid HanghoaId, Guid DonviId,
            DateTime TuNgay, DateTime DenNgay,
            Guid IdDmHopDong, Guid IdDmHopDongDu,
            Guid IdDmPtqt, Guid IdDmPtqtDu,
            Guid IdDmPhongban, Guid IdDmPhongbanDu,
            Guid IdDmVuviec, Guid IdDmVuviecDu,
            Guid IdDmKhang, Guid IdDmKhangDu,
            Guid IdDmKhoanphi, Guid IdDmKhoanphiDu,
            Guid IdDmTudo1, Guid IdDmTudo1Du,
            Guid IdDmTudo2, Guid IdDmTudo2Du,
            Guid IdDmTudo3, Guid IdDmTudo3Du,
            Guid IdDmTudo4, Guid IdDmTudo4Du,
            Guid IdDmTudo5, Guid IdDmTudo5Du)
        {
            return fn_nhap_kho("GiaVon", MaTk, MaTkDu, KhoNhapId, HanghoaId, DonviId,
                TuNgay, DenNgay, 0,
                 IdDmHopDong, IdDmHopDongDu,
             IdDmPtqt, IdDmPtqtDu,
             IdDmPhongban, IdDmPhongbanDu,
             IdDmVuviec, IdDmVuviecDu,
             IdDmKhang, IdDmKhangDu,
             IdDmKhoanphi, IdDmKhoanphiDu,
             IdDmTudo1, IdDmTudo1Du,
             IdDmTudo2, IdDmTudo2Du,
             IdDmTudo3, IdDmTudo3Du,
             IdDmTudo4, IdDmTudo4Du,
             IdDmTudo5, IdDmTudo5Du);
        }

        public Decimal fn_nhap_kho(String Field, String MaTk, String MaTkDu, Guid KhoNhapId, Guid HanghoaId, Guid DonviId,
            DateTime TuNgay, DateTime DenNgay,
            Guid IdDmHopDong, Guid IdDmHopDongDu,
            Guid IdDmPtqt, Guid IdDmPtqtDu,
            Guid IdDmPhongban, Guid IdDmPhongbanDu,
            Guid IdDmVuviec, Guid IdDmVuviecDu,
            Guid IdDmKhang, Guid IdDmKhangDu,
            Guid IdDmKhoanphi, Guid IdDmKhoanphiDu,
            Guid IdDmTudo1, Guid IdDmTudo1Du,
            Guid IdDmTudo2, Guid IdDmTudo2Du,
            Guid IdDmTudo3, Guid IdDmTudo3Du,
            Guid IdDmTudo4, Guid IdDmTudo4Du,
            Guid IdDmTudo5, Guid IdDmTudo5Du)
        {
            Int16 Kieu = 0;
            return fn_nhap_kho(Field, MaTk, MaTkDu, KhoNhapId, HanghoaId, DonviId, TuNgay, DenNgay, Kieu,
                IdDmHopDong, IdDmHopDongDu,
                IdDmPtqt, IdDmPtqtDu, IdDmPhongban, IdDmPhongbanDu, IdDmVuviec, IdDmVuviecDu, IdDmKhang, IdDmKhangDu, IdDmKhoanphi, IdDmKhoanphiDu,
                IdDmTudo1, IdDmTudo1Du,
             IdDmTudo2, IdDmTudo2Du,
             IdDmTudo3, IdDmTudo3Du,
             IdDmTudo4, IdDmTudo4Du,
             IdDmTudo5, IdDmTudo5Du);
        }

        public Decimal fn_nhap_kho(String Field, String MaTk, String MaTkDu, Guid KhoNhapId, Guid HanghoaId, Guid DonviId,
            DateTime TuNgay, DateTime DenNgay,
            Int16 Kieu,
            Guid IdDmHopDong, Guid IdDmHopDongDu,
            Guid IdDmPtqt, Guid IdDmPtqtDu,
            Guid IdDmPhongban, Guid IdDmPhongbanDu,
            Guid IdDmVuviec, Guid IdDmVuviecDu,
            Guid IdDmKhang, Guid IdDmKhangDu,
            Guid IdDmKhoanphi, Guid IdDmKhoanphiDu,
            Guid IdDmTudo1, Guid IdDmTudo1Du,
            Guid IdDmTudo2, Guid IdDmTudo2Du,
            Guid IdDmTudo3, Guid IdDmTudo3Du,
            Guid IdDmTudo4, Guid IdDmTudo4Du,
            Guid IdDmTudo5, Guid IdDmTudo5Du)
        {
            return fn_nhap_kho(Field, MaTk, MaTkDu, KhoNhapId, HanghoaId, DonviId, TuNgay, DenNgay, Kieu,
                           IdDmHopDong, IdDmHopDongDu,
                           IdDmPtqt, IdDmPtqtDu, IdDmPhongban, IdDmPhongbanDu, IdDmVuviec, IdDmVuviecDu, IdDmKhang, IdDmKhangDu, IdDmKhoanphi, IdDmKhoanphiDu,
                           IdDmTudo1, IdDmTudo1Du,
                        IdDmTudo2, IdDmTudo2Du,
                        IdDmTudo3, IdDmTudo3Du,
                        IdDmTudo4, IdDmTudo4Du,
                        IdDmTudo5, IdDmTudo5Du, Null.NullGuid);
        }
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Field"></param>
        /// <param name="MaTk"></param>
        /// <param name="MaTkDu"></param>
        /// <param name="KhoNhapId"></param>
        /// <param name="HanghoaId"></param>
        /// <param name="DonviId"></param>
        /// <param name="TuNgay"></param>
        /// <param name="DenNgay"></param>
        /// <param name="Kieu">0: So Du, 1: Phat sinh, 2: Tat ca</param>
        /// <param name="IdDmHopDong"></param>
        /// <param name="IdDmHopDongDu"></param>
        /// <param name="IdDmPtqt"></param>
        /// <param name="IdDmPtqtDu"></param>
        /// <param name="IdDmPhongban"></param>
        /// <param name="IdDmPhongbanDu"></param>
        /// <param name="IdDmVuviec"></param>
        /// <param name="IdDmVuviecDu"></param>
        /// <param name="IdDmKhang"></param>
        /// <param name="IdDmKhangDu"></param>
        /// <param name="IdDmKhoanphi"></param>
        /// <param name="IdDmKhoanphiDu"></param>
        /// <param name="IdDmTudo1"></param>
        /// <param name="IdDmTudo1Du"></param>
        /// <param name="IdDmTudo2"></param>
        /// <param name="IdDmTudo2Du"></param>
        /// <param name="IdDmTudo3"></param>
        /// <param name="IdDmTudo3Du"></param>
        /// <param name="IdDmTudo4"></param>
        /// <param name="IdDmTudo4Du"></param>
        /// <param name="IdDmTudo5"></param>
        /// <param name="IdDmTudo5Du"></param>
        /// <param name="CthNxId"></param>
        /// <returns></returns>
        public Decimal fn_nhap_kho(String Field, String MaTk, String MaTkDu, Guid KhoNhapId, Guid HanghoaId, Guid DonviId,
            DateTime TuNgay, DateTime DenNgay,
            Int16 Kieu,
            Guid IdDmHopDong, Guid IdDmHopDongDu,
            Guid IdDmPtqt, Guid IdDmPtqtDu,
            Guid IdDmPhongban, Guid IdDmPhongbanDu,
            Guid IdDmVuviec, Guid IdDmVuviecDu,
            Guid IdDmKhang, Guid IdDmKhangDu,
            Guid IdDmKhoanphi, Guid IdDmKhoanphiDu,
            Guid IdDmTudo1, Guid IdDmTudo1Du,
            Guid IdDmTudo2, Guid IdDmTudo2Du,
            Guid IdDmTudo3, Guid IdDmTudo3Du,
            Guid IdDmTudo4, Guid IdDmTudo4Du,
            Guid IdDmTudo5, Guid IdDmTudo5Du,
            Guid CthNxId)
        {
            String KieuSQL = "";
            switch (Kieu)
            {
                case 0:
                    KieuSQL = "And SoDu = 0 ";
                    break;
                case 1:
                    KieuSQL = "And SoDu = 1 ";
                    break;
                case 2:
                    KieuSQL = String.Empty;
                    break;
            }
       
            String SQL = String.Format("SELECT sum({0}) ", Field) +
                        "FROM BcKetoanKho " +
                        "WHERE " +
                        "DonviId = :DonviId " +
                        KieuSQL +
                        "And (Xuat = 0 or Xuat = 2) " +
                        (!VnsCheck.IsNullGuid(KhoNhapId) ? "and KhoNhapId = :KhoNhapId " : "") +
                        "And HanghoaId = :HanghoaId " +
                        "AND NgayCt <= :DenNgay " +
                        (TuNgay == DateTime.MinValue ? "" : "AND NgayCt >= :TuNgay ") +
                        (String.IsNullOrEmpty(MaTk) ? "" :"AND (MaTknGiavon like :MaTk)") +
                        (String.IsNullOrEmpty(MaTkDu) ? "" : "AND (MaTkcGiavon like :MaTkDu)") +
                        (VnsCheck.IsNullGuid(IdDmKhang) ? "" : "AND (IdDmKhangNo = :IdDmKhang) ") +
                        (VnsCheck.IsNullGuid(IdDmKhangDu) ? "" : "AND (IdDmKhangCo = :IdDmKhangDu) ") +
                        (VnsCheck.IsNullGuid(IdDmHopDong) ? "" : "AND (IdDmHopdongNo =  :IdDmHopDong) ") +
                        (VnsCheck.IsNullGuid(IdDmHopDongDu) ? "" : "AND (IdDmHopdongCo =  :IdDmHopDongDu) ") +
                        (VnsCheck.IsNullGuid(IdDmPtqt) ? "" : "AND (IdDmPtqtNo = :IdDmPtqt) ") +
                        (VnsCheck.IsNullGuid(IdDmPtqtDu) ? "" : "AND (IdDmPtqtCo = :IdDmPtqtDu) ") +
                        (VnsCheck.IsNullGuid(IdDmPhongban) ? "" : "AND (IdDmPhongbanNo = :IdDmPhongban) ") +
                        (VnsCheck.IsNullGuid(IdDmPhongbanDu) ? "" : "AND (IdDmPhongbanCo = :IdDmPhongbanDu) ") +
                        (VnsCheck.IsNullGuid(IdDmVuviec) ? "" : "AND (IdDmVuviecNo = :IdDmVuviec) ") +
                        (VnsCheck.IsNullGuid(IdDmVuviecDu) ? "" : "AND (IdDmVuviecCo = :IdDmVuviecDu) ") +
                        (VnsCheck.IsNullGuid(IdDmTudo1) ? "" : "AND (IdDmTudo1No = :IdDmTudo1) ") +
                        (VnsCheck.IsNullGuid(IdDmTudo1Du) ? "" : "AND (IdDmTudo1Co = :IdDmTudo1Du) ") +
                        (VnsCheck.IsNullGuid(IdDmTudo2) ? "" : "AND (IdDmTudo2No = :IdDmTudo2) ") +
                        (VnsCheck.IsNullGuid(IdDmTudo2Du) ? "" : "AND (IdDmTudo2Co = :IdDmTudo2Du) ") +
                        (VnsCheck.IsNullGuid(IdDmTudo3) ? "" : "AND (IdDmTudo3No = :IdDmTudo3) ") +
                        (VnsCheck.IsNullGuid(IdDmTudo3Du) ? "" : "AND (IdDmTudo3Co = :IdDmTudo3Du) ") +
                        (VnsCheck.IsNullGuid(IdDmTudo4) ? "" : "AND (IdDmTudo4No = :IdDmTudo4) ") +
                        (VnsCheck.IsNullGuid(IdDmTudo4Du) ? "" : "AND (IdDmTudo4Co = :IdDmTudo4Du) ") +
                        (VnsCheck.IsNullGuid(IdDmTudo5) ? "" : "AND (IdDmTudo5No = :IdDmTudo5) ") +
                        (VnsCheck.IsNullGuid(IdDmTudo5Du) ? "" : "AND (IdDmTudo5Co = :IdDmTudo5Du) ") +
                        (VnsCheck.IsNullGuid(IdDmKhoanphi) ? "" : "AND (IdDmKhoanphiNo = :IdDmKhoanphi) ") +
                        (VnsCheck.IsNullGuid(IdDmKhoanphiDu) ? "" : "AND (IdDmKhoanphiCo = :IdDmKhoanphiDu) ") +
                        (VnsCheck.IsNullGuid(CthNxId) ? "" : "AND (CthNxId != :CthNxId) ");

            IQuery qbcketoan = NHibernateSession.CreateQuery(SQL);
            qbcketoan.SetParameter("DonviId", DonviId);
            if (!VnsCheck.IsNullGuid(KhoNhapId)) qbcketoan.SetParameter("KhoNhapId", KhoNhapId);
            qbcketoan.SetParameter("HanghoaId", HanghoaId);
            qbcketoan.SetParameter("DenNgay", DenNgay);
            if (TuNgay != DateTime.MinValue) qbcketoan.SetParameter("TuNgay", TuNgay);
            if (!String.IsNullOrEmpty(MaTk)) qbcketoan.SetParameter("MaTk", String.Format("{0}%", MaTk));
            if (!String.IsNullOrEmpty(MaTkDu)) qbcketoan.SetParameter("MaTkDu", String.Format("{0}%", MaTkDu));
            if (!VnsCheck.IsNullGuid(IdDmKhang)) qbcketoan.SetParameter("IdDmKhang", IdDmKhang);
            if (!VnsCheck.IsNullGuid(IdDmKhangDu)) qbcketoan.SetParameter("IdDmKhangDu", IdDmKhangDu);
            if (!VnsCheck.IsNullGuid(IdDmHopDong)) qbcketoan.SetParameter("IdDmHopDong", IdDmHopDong);
            if (!VnsCheck.IsNullGuid(IdDmHopDongDu)) qbcketoan.SetParameter("IdDmHopDongDu", IdDmHopDongDu);
            if (!VnsCheck.IsNullGuid(IdDmPtqt)) qbcketoan.SetParameter("IdDmPtqt", IdDmPtqt);
            if (!VnsCheck.IsNullGuid(IdDmPtqtDu)) qbcketoan.SetParameter("IdDmPtqtDu", IdDmPtqtDu);
            if (!VnsCheck.IsNullGuid(IdDmPhongban)) qbcketoan.SetParameter("IdDmPhongban", IdDmPhongban);
            if (!VnsCheck.IsNullGuid(IdDmPhongbanDu)) qbcketoan.SetParameter("IdDmPhongbanDu", IdDmPhongbanDu);
            if (!VnsCheck.IsNullGuid(IdDmVuviec)) qbcketoan.SetParameter("IdDmVuviec", IdDmVuviec);
            if (!VnsCheck.IsNullGuid(IdDmVuviecDu)) qbcketoan.SetParameter("IdDmVuviecDu", IdDmVuviecDu);
            if (!VnsCheck.IsNullGuid(IdDmTudo1)) qbcketoan.SetParameter("IdDmTudo1", IdDmTudo1);
            if (!VnsCheck.IsNullGuid(IdDmTudo1Du)) qbcketoan.SetParameter("IdDmTudo1Du", IdDmTudo1Du);
            if (!VnsCheck.IsNullGuid(IdDmTudo2)) qbcketoan.SetParameter("IdDmTudo2", IdDmTudo2);
            if (!VnsCheck.IsNullGuid(IdDmTudo2Du)) qbcketoan.SetParameter("IdDmTudo2Du", IdDmTudo2Du);
            if (!VnsCheck.IsNullGuid(IdDmTudo3)) qbcketoan.SetParameter("IdDmTudo3", IdDmTudo3);
            if (!VnsCheck.IsNullGuid(IdDmTudo3Du)) qbcketoan.SetParameter("IdDmTudo3Du", IdDmTudo3Du);
            if (!VnsCheck.IsNullGuid(IdDmTudo4)) qbcketoan.SetParameter("IdDmTudo4", IdDmTudo4);
            if (!VnsCheck.IsNullGuid(IdDmTudo4Du)) qbcketoan.SetParameter("IdDmTudo4Du", IdDmTudo4Du);
            if (!VnsCheck.IsNullGuid(IdDmTudo5)) qbcketoan.SetParameter("IdDmTudo5", IdDmTudo5);
            if (!VnsCheck.IsNullGuid(IdDmTudo5Du)) qbcketoan.SetParameter("IdDmTudo5Du", IdDmTudo5Du);
            if (!VnsCheck.IsNullGuid(CthNxId)) qbcketoan.SetParameter("CthNxId", CthNxId);

            return qbcketoan.UniqueResult<decimal>();
        }

        public Decimal fn_xuat_kho(String Field, String MaTk, String MaTkDu, Guid KhoXuatId, Guid HanghoaId, Guid DonviId,
            DateTime TuNgay, DateTime DenNgay,
            Guid IdDmHopDong, Guid IdDmHopDongDu,
            Guid IdDmPtqt, Guid IdDmPtqtDu,
            Guid IdDmPhongban, Guid IdDmPhongbanDu,
            Guid IdDmVuviec, Guid IdDmVuviecDu,
            Guid IdDmKhang, Guid IdDmKhangDu,
            Guid IdDmKhoanphi, Guid IdDmKhoanphiDu,
            Guid IdDmTudo1, Guid IdDmTudo1Du,
            Guid IdDmTudo2, Guid IdDmTudo2Du,
            Guid IdDmTudo3, Guid IdDmTudo3Du,
            Guid IdDmTudo4, Guid IdDmTudo4Du,
            Guid IdDmTudo5, Guid IdDmTudo5Du,
            Guid CthNxId)
        {
            Int16 Kieu = 0;
            return fn_xuat_kho(Field, MaTk, MaTkDu, KhoXuatId, HanghoaId, DonviId, TuNgay, DenNgay, Kieu,
                IdDmHopDong, IdDmHopDongDu,
                IdDmPtqt, IdDmPtqtDu, IdDmPhongban, IdDmPhongbanDu, IdDmVuviec, IdDmVuviecDu, IdDmKhang, IdDmKhangDu, IdDmKhoanphi, IdDmKhoanphiDu,
                IdDmTudo1, IdDmTudo1Du,
             IdDmTudo2, IdDmTudo2Du,
             IdDmTudo3, IdDmTudo3Du,
             IdDmTudo4, IdDmTudo4Du,
             IdDmTudo5, IdDmTudo5Du, CthNxId);
        }

        public Decimal fn_xuat_kho(String Field, String MaTk, String MaTkDu, Guid KhoXuatId, Guid HanghoaId, Guid DonviId,
            DateTime TuNgay, DateTime DenNgay,
            Guid IdDmHopDong, Guid IdDmHopDongDu,
            Guid IdDmPtqt, Guid IdDmPtqtDu,
            Guid IdDmPhongban, Guid IdDmPhongbanDu,
            Guid IdDmVuviec, Guid IdDmVuviecDu,
            Guid IdDmKhang, Guid IdDmKhangDu,
            Guid IdDmKhoanphi, Guid IdDmKhoanphiDu,
            Guid IdDmTudo1, Guid IdDmTudo1Du,
            Guid IdDmTudo2, Guid IdDmTudo2Du,
            Guid IdDmTudo3, Guid IdDmTudo3Du,
            Guid IdDmTudo4, Guid IdDmTudo4Du,
            Guid IdDmTudo5, Guid IdDmTudo5Du)
        {
            Int16 Kieu = 0;
            return fn_xuat_kho(Field, MaTk, MaTkDu, KhoXuatId, HanghoaId, DonviId, TuNgay, DenNgay, Kieu,
                IdDmHopDong, IdDmHopDongDu,
                IdDmPtqt, IdDmPtqtDu, IdDmPhongban, IdDmPhongbanDu, IdDmVuviec, IdDmVuviecDu, IdDmKhang, IdDmKhangDu, IdDmKhoanphi, IdDmKhoanphiDu,
                IdDmTudo1, IdDmTudo1Du,
             IdDmTudo2, IdDmTudo2Du,
             IdDmTudo3, IdDmTudo3Du,
             IdDmTudo4, IdDmTudo4Du,
             IdDmTudo5, IdDmTudo5Du, Null.NullGuid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Field"></param>
        /// <param name="MaTk"></param>
        /// <param name="MaTkDu"></param>
        /// <param name="KhoXuatId"></param>
        /// <param name="HanghoaId"></param>
        /// <param name="DonviId"></param>
        /// <param name="TuNgay"></param>
        /// <param name="DenNgay"></param>
        /// <param name="Kieu">0: So Du, 1: Phat sinh, 2: Tat ca</param>
        /// <param name="IdDmHopDong"></param>
        /// <param name="IdDmHopDongDu"></param>
        /// <param name="IdDmPtqt"></param>
        /// <param name="IdDmPtqtDu"></param>
        /// <param name="IdDmPhongban"></param>
        /// <param name="IdDmPhongbanDu"></param>
        /// <param name="IdDmVuviec"></param>
        /// <param name="IdDmVuviecDu"></param>
        /// <param name="IdDmKhang"></param>
        /// <param name="IdDmKhangDu"></param>
        /// <param name="IdDmKhoanphi"></param>
        /// <param name="IdDmKhoanphiDu"></param>
        /// <param name="IdDmTudo1"></param>
        /// <param name="IdDmTudo1Du"></param>
        /// <param name="IdDmTudo2"></param>
        /// <param name="IdDmTudo2Du"></param>
        /// <param name="IdDmTudo3"></param>
        /// <param name="IdDmTudo3Du"></param>
        /// <param name="IdDmTudo4"></param>
        /// <param name="IdDmTudo4Du"></param>
        /// <param name="IdDmTudo5"></param>
        /// <param name="IdDmTudo5Du"></param>
        /// <returns></returns>
        public Decimal fn_xuat_kho(String Field, String MaTk, String MaTkDu, Guid KhoXuatId, Guid HanghoaId, Guid DonviId,
            DateTime TuNgay, DateTime DenNgay,
            Int16 Kieu,
            Guid IdDmHopDong, Guid IdDmHopDongDu,
            Guid IdDmPtqt, Guid IdDmPtqtDu,
            Guid IdDmPhongban, Guid IdDmPhongbanDu,
            Guid IdDmVuviec, Guid IdDmVuviecDu,
            Guid IdDmKhang, Guid IdDmKhangDu,
            Guid IdDmKhoanphi, Guid IdDmKhoanphiDu,
            Guid IdDmTudo1, Guid IdDmTudo1Du,
            Guid IdDmTudo2, Guid IdDmTudo2Du,
            Guid IdDmTudo3, Guid IdDmTudo3Du,
            Guid IdDmTudo4, Guid IdDmTudo4Du,
            Guid IdDmTudo5, Guid IdDmTudo5Du,
            Guid CthNxId)
        {

            String KieuSQL = "";
            switch (Kieu)
            {
                case 0:
                    KieuSQL = "And SoDu = 0 ";
                    break;
                case 1:
                    KieuSQL = "And SoDu = 1 ";
                    break;
                case 2:
                    KieuSQL = String.Empty;
                    break;
            }

            String SQL = String.Format("SELECT sum({0}) ", Field) +
                        "FROM BcKetoanKho " +
                        "WHERE " +
                        "DonviId = :DonviId " +
                        KieuSQL +
                        "and (Xuat = 1 or Xuat = 2) " +
                        (!VnsCheck.IsNullGuid(KhoXuatId) ? "and KhoXuatId = :KhoXuatId " : "") +
                        "and HanghoaId = :HanghoaId " +
                        "AND NgayCt <= :DenNgay " +
                        (TuNgay == DateTime.MinValue ? "" : "AND NgayCt >= :TuNgay ") +
                        (String.IsNullOrEmpty(MaTk) ? "" :"AND (MaTkcGiavon like :MaTk)") +
                        (String.IsNullOrEmpty(MaTkDu) ? "" : "AND (MaTknGiavon like :MaTkDu)") +
                        (VnsCheck.IsNullGuid(IdDmKhang) ? "" : "AND (IdDmKhangCo = :IdDmKhang) ") +
                        (VnsCheck.IsNullGuid(IdDmKhangDu) ? "" : "AND (IdDmKhangNo = :IdDmKhangDu) ") +
                        (VnsCheck.IsNullGuid(IdDmHopDong) ? "" : "AND (IdDmHopdongCo =  :IdDmHopDong) ") +
                        (VnsCheck.IsNullGuid(IdDmHopDongDu) ? "" : "AND (IdDmHopdongNo =  :IdDmHopDongDu) ") +
                        (VnsCheck.IsNullGuid(IdDmPtqt) ? "" : "AND (IdDmPtqtCo = :IdDmPtqt) ") +
                        (VnsCheck.IsNullGuid(IdDmPtqtDu) ? "" : "AND (IdDmPtqtNo = :IdDmPtqtDu) ") +
                        (VnsCheck.IsNullGuid(IdDmPhongban) ? "" : "AND (IdDmPhongbanCo = :IdDmPhongban) ") +
                        (VnsCheck.IsNullGuid(IdDmPhongbanDu) ? "" : "AND (IdDmPhongbanNo = :IdDmPhongbanDu) ") +
                        (VnsCheck.IsNullGuid(IdDmVuviec) ? "" : "AND (IdDmVuviecCo = :IdDmVuviec) ") +
                        (VnsCheck.IsNullGuid(IdDmVuviecDu) ? "" : "AND (IdDmVuviecNo = :IdDmVuviecDu) ") +
                        (VnsCheck.IsNullGuid(IdDmTudo1) ? "" : "AND (IdDmTudo1Co = :IdDmTudo1) ") +
                        (VnsCheck.IsNullGuid(IdDmTudo1Du) ? "" : "AND (IdDmTudo1No = :IdDmTudo1Du) ") +
                        (VnsCheck.IsNullGuid(IdDmTudo2) ? "" : "AND (IdDmTudo2Co = :IdDmTudo2) ") +
                        (VnsCheck.IsNullGuid(IdDmTudo2Du) ? "" : "AND (IdDmTudo2No = :IdDmTudo2Du) ") +
                        (VnsCheck.IsNullGuid(IdDmTudo3) ? "" : "AND (IdDmTudo3Co = :IdDmTudo3) ") +
                        (VnsCheck.IsNullGuid(IdDmTudo3Du) ? "" : "AND (IdDmTudo3No = :IdDmTudo3Du) ") +
                        (VnsCheck.IsNullGuid(IdDmTudo4) ? "" : "AND (IdDmTudo4Co = :IdDmTudo4) ") +
                        (VnsCheck.IsNullGuid(IdDmTudo4Du) ? "" : "AND (IdDmTudo4No = :IdDmTudo4Du) ") +
                        (VnsCheck.IsNullGuid(IdDmTudo5) ? "" : "AND (IdDmTudo5Co = :IdDmTudo5) ") +
                        (VnsCheck.IsNullGuid(IdDmTudo5Du) ? "" : "AND (IdDmTudo5No = :IdDmTudo5Du) ") +
                        (VnsCheck.IsNullGuid(IdDmKhoanphi) ? "" : "AND (IdDmKhoanphiCo = :IdDmKhoanphi) ") +
                        (VnsCheck.IsNullGuid(IdDmKhoanphiDu) ? "" : "AND (IdDmKhoanphiNo = :IdDmKhoanphiDu) ") +
                        (VnsCheck.IsNullGuid(CthNxId) ? "" : "AND (CthNxId != :CthNxId) ");

            IQuery qbcketoan = NHibernateSession.CreateQuery(SQL);
            qbcketoan.SetParameter("DonviId", DonviId);
            if (!VnsCheck.IsNullGuid(KhoXuatId)) qbcketoan.SetParameter("KhoXuatId", KhoXuatId);
            qbcketoan.SetParameter("HanghoaId", HanghoaId);
            qbcketoan.SetParameter("DenNgay", DenNgay);
            if (TuNgay != DateTime.MinValue) qbcketoan.SetParameter("TuNgay", TuNgay);
            if (!String.IsNullOrEmpty(MaTk)) qbcketoan.SetParameter("MaTk", String.Format("{0}%", MaTk));
            if (!String.IsNullOrEmpty(MaTkDu)) qbcketoan.SetParameter("MaTkDu", String.Format("{0}%", MaTkDu));
            if (!VnsCheck.IsNullGuid(IdDmKhang)) qbcketoan.SetParameter("IdDmKhang", IdDmKhang);
            if (!VnsCheck.IsNullGuid(IdDmKhangDu)) qbcketoan.SetParameter("IdDmKhangDu", IdDmKhangDu);
            if (!VnsCheck.IsNullGuid(IdDmHopDong)) qbcketoan.SetParameter("IdDmHopDong", IdDmHopDong);
            if (!VnsCheck.IsNullGuid(IdDmHopDongDu)) qbcketoan.SetParameter("IdDmHopDongDu", IdDmHopDongDu);
            if (!VnsCheck.IsNullGuid(IdDmPtqt)) qbcketoan.SetParameter("IdDmPtqt", IdDmPtqt);
            if (!VnsCheck.IsNullGuid(IdDmPtqtDu)) qbcketoan.SetParameter("IdDmPtqtDu", IdDmPtqtDu);
            if (!VnsCheck.IsNullGuid(IdDmPhongban)) qbcketoan.SetParameter("IdDmPhongban", IdDmPhongban);
            if (!VnsCheck.IsNullGuid(IdDmPhongbanDu)) qbcketoan.SetParameter("IdDmPhongbanDu", IdDmPhongbanDu);
            if (!VnsCheck.IsNullGuid(IdDmVuviec)) qbcketoan.SetParameter("IdDmVuviec", IdDmVuviec);
            if (!VnsCheck.IsNullGuid(IdDmVuviecDu)) qbcketoan.SetParameter("IdDmVuviecDu", IdDmVuviecDu);
            if (!VnsCheck.IsNullGuid(IdDmTudo1)) qbcketoan.SetParameter("IdDmTudo1", IdDmTudo1);
            if (!VnsCheck.IsNullGuid(IdDmTudo1Du)) qbcketoan.SetParameter("IdDmTudo1Du", IdDmTudo1Du);
            if (!VnsCheck.IsNullGuid(IdDmTudo2)) qbcketoan.SetParameter("IdDmTudo2", IdDmTudo2);
            if (!VnsCheck.IsNullGuid(IdDmTudo2Du)) qbcketoan.SetParameter("IdDmTudo2Du", IdDmTudo2Du);
            if (!VnsCheck.IsNullGuid(IdDmTudo3)) qbcketoan.SetParameter("IdDmTudo3", IdDmTudo3);
            if (!VnsCheck.IsNullGuid(IdDmTudo3Du)) qbcketoan.SetParameter("IdDmTudo3Du", IdDmTudo3Du);
            if (!VnsCheck.IsNullGuid(IdDmTudo4)) qbcketoan.SetParameter("IdDmTudo4", IdDmTudo4);
            if (!VnsCheck.IsNullGuid(IdDmTudo4Du)) qbcketoan.SetParameter("IdDmTudo4Du", IdDmTudo4Du);
            if (!VnsCheck.IsNullGuid(IdDmTudo5)) qbcketoan.SetParameter("IdDmTudo5", IdDmTudo5);
            if (!VnsCheck.IsNullGuid(IdDmTudo5Du)) qbcketoan.SetParameter("IdDmTudo5Du", IdDmTudo5Du);
            if (!VnsCheck.IsNullGuid(CthNxId)) qbcketoan.SetParameter("CthNxId", CthNxId);

            return qbcketoan.UniqueResult<decimal>();
        }

        public Decimal fn_sl_xuat_kho(String MaTk, String MaTkDu, Guid KhoNhapId, Guid HanghoaId, Guid DonviId,
            DateTime TuNgay, DateTime DenNgay,
            Guid IdDmHopDong, Guid IdDmHopDongDu,
            Guid IdDmPtqt, Guid IdDmPtqtDu,
            Guid IdDmPhongban, Guid IdDmPhongbanDu,
            Guid IdDmVuviec, Guid IdDmVuviecDu,
            Guid IdDmKhang, Guid IdDmKhangDu,
            Guid IdDmKhoanphi, Guid IdDmKhoanphiDu,
            Guid IdDmTudo1, Guid IdDmTudo1Du,
            Guid IdDmTudo2, Guid IdDmTudo2Du,
            Guid IdDmTudo3, Guid IdDmTudo3Du,
            Guid IdDmTudo4, Guid IdDmTudo4Du,
            Guid IdDmTudo5, Guid IdDmTudo5Du)
        {
            return fn_xuat_kho("SoLuong", MaTk, MaTkDu, KhoNhapId, HanghoaId, DonviId,
                TuNgay, DenNgay,
                 IdDmHopDong, IdDmHopDongDu,
             IdDmPtqt, IdDmPtqtDu,
             IdDmPhongban, IdDmPhongbanDu,
             IdDmVuviec, IdDmVuviecDu,
             IdDmKhang, IdDmKhangDu,
             IdDmKhoanphi, IdDmKhoanphiDu,
             IdDmTudo1, IdDmTudo1Du,
             IdDmTudo2, IdDmTudo2Du,
             IdDmTudo3, IdDmTudo3Du,
             IdDmTudo4, IdDmTudo4Du,
             IdDmTudo5, IdDmTudo5Du);
        }

        public Decimal fn_SoTien_xuat_kho(String MaTk, String MaTkDu, Guid KhoNhapId, Guid HanghoaId, Guid DonviId,
            DateTime TuNgay, DateTime DenNgay,
            Guid IdDmHopDong, Guid IdDmHopDongDu,
            Guid IdDmPtqt, Guid IdDmPtqtDu,
            Guid IdDmPhongban, Guid IdDmPhongbanDu,
            Guid IdDmVuviec, Guid IdDmVuviecDu,
            Guid IdDmKhang, Guid IdDmKhangDu,
            Guid IdDmKhoanphi, Guid IdDmKhoanphiDu,
            Guid IdDmTudo1, Guid IdDmTudo1Du,
            Guid IdDmTudo2, Guid IdDmTudo2Du,
            Guid IdDmTudo3, Guid IdDmTudo3Du,
            Guid IdDmTudo4, Guid IdDmTudo4Du,
            Guid IdDmTudo5, Guid IdDmTudo5Du)
        {
            return fn_xuat_kho("GiaVon", MaTk, MaTkDu, KhoNhapId, HanghoaId, DonviId,
                TuNgay, DenNgay, 
                 IdDmHopDong, IdDmHopDongDu,
             IdDmPtqt, IdDmPtqtDu,
             IdDmPhongban, IdDmPhongbanDu,
             IdDmVuviec, IdDmVuviecDu,
             IdDmKhang, IdDmKhangDu,
             IdDmKhoanphi, IdDmKhoanphiDu,
             IdDmTudo1, IdDmTudo1Du,
             IdDmTudo2, IdDmTudo2Du,
             IdDmTudo3, IdDmTudo3Du,
             IdDmTudo4, IdDmTudo4Du,
             IdDmTudo5, IdDmTudo5Du);
        }
        #endregion
    }
}
