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
using Vns.Erp.Core.Dao.Util;

namespace Vns.Erp.Core.Accounting.Report.Dao.NHibernate
{
    [Serializable]
    public sealed class RpLedgerS38DnDao : GenericDao<BcKetoan, System.Guid>, IRpLedgerS38DnDao
    {
        public DataTable GetDataS38Dn(String p_Ma_Tk, Guid p_DonviId, DateTime p_Tu_Ngay, DateTime p_Den_Ngay)
        {
            String SQL = " SELECT " +
                            "CthId as CthId,CtdId as CtdId,NgayCt as NgayCt,NgayGhi as NgayGhi," +
                            "MaTkNo as MaTk,MaTkCo as MaTkDu," +
                            "DonviId as DonviId,CtSo as CtSo," +
                            "DienGiai as DienGiai," +
                            "Case When MaTkNo Like :p_Ma_Tk || '%' Then SoTien " +
                            "Else CAST(0 as Decimal) End as PsNo, " +
                            "Case When MaTkCo Like :p_Ma_Tk || '%' Then SoTien " +
                            "Else CAST(0 as Decimal) End as PsCo, " +
                            "CAST(0 as Decimal) as DuNo," +
                            "CAST(0 as Decimal) as DuCo," +
                            "2 as Nhom," +
                            "IdLoaiCt as IdLoaiCt " +
                        "FROM BcKetoan " +
                        "WHERE (SoDu = 0) " +
                            "AND ((MaTkNo LIKE :p_Ma_Tk || '%') Or (MaTkCo LIKE :p_Ma_Tk || '%')) " +
                            "AND NgayCt >= :p_Tu_Ngay " +
                            "AND NgayCt <= :p_Den_Ngay " +
                            "AND DonviId = :p_DonviId ";
            //p_Tu_Ngay, p_Den_Ngay
            //p_DonviId, p_Ma_Tk

            //So du dau ky
            Decimal du_no_dk, du_co_dk = 0;
            du_no_dk = fn_Du_co(p_Ma_Tk, null, p_Tu_Ngay, p_DonviId, "", Null.NullGuid, Null.NullGuid,
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
            du_co_dk = du_no_dk * -1;
            RpLedgerS38DnDTO dk = new RpLedgerS38DnDTO();
            dk.DienGiai = "Số dư đầu kỳ";
            dk.DuNo = du_no_dk > 0 ? du_no_dk : 0;
            dk.DuCo = du_co_dk > 0 ? du_co_dk : 0;
            dk.Nhom = 0;
            //Ps Trong ky
            Decimal ps_no_dk, ps_co_dk = 0;

            ps_no_dk = fn_Ps_No(p_Ma_Tk, null, p_Tu_Ngay, p_Den_Ngay, p_DonviId, "", Null.NullGuid, Null.NullGuid,
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

            ps_co_dk = fn_Ps_Co(p_Ma_Tk, null, p_Tu_Ngay, p_Den_Ngay, p_DonviId, "", Null.NullGuid, Null.NullGuid,
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

            RpLedgerS38DnDTO ps = new RpLedgerS38DnDTO();
            ps.DienGiai = "Phát sinh trong kỳ";
            ps.PsNo = ps_no_dk;
            ps.PsCo = ps_co_dk;
            ps.Nhom = 1;
            //Chung tu phat sinh

            //Ps Trong ky
            RpLedgerS38DnDTO ps1 = new RpLedgerS38DnDTO();
            ps1.DienGiai = "Phát sinh trong kỳ";
            ps1.PsNo = ps_no_dk;
            ps1.PsCo = ps_co_dk;
            ps1.Nhom = 3;
            //So du cuoi ky
            Decimal du_no_ck, du_co_ck = 0;
            du_no_ck = fn_Du_co(p_Ma_Tk, null, p_Den_Ngay, p_DonviId, "", Null.NullGuid, Null.NullGuid,
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
            du_co_ck = du_no_ck * -1;
            RpLedgerS38DnDTO ck = new RpLedgerS38DnDTO();
            ck.DienGiai = "Số dư cuối kỳ";
            ck.DuNo = du_no_ck > 0 ? du_no_ck : 0;
            ck.DuCo = du_co_ck > 0 ? du_co_dk : 0;
            ck.Nhom = 4;

            IQuery qbcketoan = NHibernateSession.CreateQuery(SQL);
            qbcketoan.SetParameter("p_Ma_Tk", p_Ma_Tk);
            qbcketoan.SetParameter("p_DonviId", p_DonviId);
            qbcketoan.SetParameter("p_Tu_Ngay", p_Tu_Ngay);
            qbcketoan.SetParameter("p_Den_Ngay", p_Den_Ngay);
            System.Collections.IList zzz = qbcketoan.List();
            qbcketoan.SetResultTransformer(Transformers.AliasToBean<RpLedgerS38DnDTO>());
            IList<RpLedgerS38DnDTO> lst = qbcketoan.List<RpLedgerS38DnDTO>();
            lst.Add(dk);
            lst.Add(ps);
            lst.Add(ps1);
            lst.Add(ck);

            DataTable dt = DBUtil.ToDataTable<RpLedgerS38DnDTO>(lst);
            dt.DefaultView.Sort = "Nhom, NgayCt";
            return dt;
        }

        private Decimal fn_Ps_No(String MaTk, String MaTkDu, DateTime TuNgay, DateTime DenNgay, Guid DonviId, String MaNte,
            Guid IdHopDong, Guid IdHopDongDu,
            Guid IdPtqt, Guid IdPtqtDu,
            Guid IdPhongban, Guid IdPhongbanDu,
            Guid IdVuviec, Guid IdVuviecDu,
            Guid IdKhang, Guid IdKhangDu,
            Guid IdDmKhoanphi, Guid IdDmKhoanphiDu,
            Guid IdDmTudo1, Guid IdDmTudo1Du,
            Guid IdDmTudo2, Guid IdDmTudo2Du,
            Guid IdDmTudo3, Guid IdDmTudo3Du,
            Guid IdDmTudo4, Guid IdDmTudo4Du,
            Guid IdDmTudo5, Guid IdDmTudo5Du)
        {
            String SQL = "select sum(SoTien) from BcKetoan " +
                         " where " +
                         "(SoDu = 0) " +
                        "AND NgayCt <= :DenNgay " +
                        (TuNgay == DateTime.MinValue ? "" : "AND NgayCt >= :TuNgay ") +
                        "AND (MaTkNo like :MaTk)" +
                        (String.IsNullOrEmpty(MaTkDu) ? "" : "AND (MaTkCo like :MaTkDu)") +
                        "AND DonviId = :DonviId " +
                        (String.IsNullOrEmpty( MaNte) ? "" : "AND (MaNte = :MaNte)") +
                        (VnsCheck.IsNullGuid(IdKhang) ? "" : "AND (IdKhangNo = :IdKhang) ") +
                        (VnsCheck.IsNullGuid(IdKhangDu) ? "" : "AND (IdKhangCo = :IdKhangDu) ") +
                        (VnsCheck.IsNullGuid(IdHopDong) ? "" : "AND (IdHopdongNo =  :IdHopDong) ") +
                        (VnsCheck.IsNullGuid(IdHopDongDu) ? "" : "AND (IdHopdongCo =  :IdHopDongDu) ") +
                        (VnsCheck.IsNullGuid(IdPtqt) ? "" : "AND (IdPtqtNo = :IdPtqt) ") +
                        (VnsCheck.IsNullGuid(IdPtqtDu) ? "" : "AND (IdPtqtCo = :IdPtqtDu) ") +
                        (VnsCheck.IsNullGuid(IdPhongban) ? "" : "AND (IdPhongbanNo = :IdPhongban) ") +
                        (VnsCheck.IsNullGuid(IdPhongbanDu) ? "" : "AND (IdPhongbanCo = :IdPhongbanDu) ") +
                        (VnsCheck.IsNullGuid(IdVuviec) ? "" : "AND (IdVuviecNo = :IdVuviec) ") +
                        (VnsCheck.IsNullGuid(IdVuviecDu) ? "" : "AND (IdVuviecCo = :IdVuviecDu) ") +
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
                        (VnsCheck.IsNullGuid(IdDmKhoanphiDu) ? "" : "AND (IdDmKhoanphiCo = :IdDmKhoanphiDu) ");

            IQuery qbcketoan = NHibernateSession.CreateQuery(SQL);
            qbcketoan.SetParameter("DenNgay", DenNgay);
            if (TuNgay != DateTime.MinValue) qbcketoan.SetParameter("TuNgay", TuNgay);
            qbcketoan.SetParameter("MaTk", String.Format("{0}%", MaTk));
            if (!String.IsNullOrEmpty(MaTkDu)) qbcketoan.SetParameter("MaTkDu", String.Format("{0}%", MaTkDu));
            qbcketoan.SetParameter("DonviId", DonviId);
            if (!String.IsNullOrEmpty(MaNte)) qbcketoan.SetParameter("MaNte", MaNte);
            if (!VnsCheck.IsNullGuid(IdKhang)) qbcketoan.SetParameter("IdKhang", IdKhang);
            if (!VnsCheck.IsNullGuid(IdKhangDu)) qbcketoan.SetParameter("IdKhangDu", IdKhangDu);
            if (!VnsCheck.IsNullGuid(IdHopDong)) qbcketoan.SetParameter("IdHopDong", IdHopDong);
            if (!VnsCheck.IsNullGuid(IdHopDongDu)) qbcketoan.SetParameter("IdHopDongDu", IdHopDongDu);
            if (!VnsCheck.IsNullGuid(IdPtqt)) qbcketoan.SetParameter("IdPtqt", IdPtqt);
            if (!VnsCheck.IsNullGuid(IdPtqtDu)) qbcketoan.SetParameter("IdPtqtDu", IdPtqtDu);
            if (!VnsCheck.IsNullGuid(IdPhongban)) qbcketoan.SetParameter("IdPhongban", IdPhongban);
            if (!VnsCheck.IsNullGuid(IdPhongbanDu)) qbcketoan.SetParameter("IdPhongbanDu", IdPhongbanDu);
            if (!VnsCheck.IsNullGuid(IdVuviec)) qbcketoan.SetParameter("IdVuviec", IdVuviec);
            if (!VnsCheck.IsNullGuid(IdVuviecDu)) qbcketoan.SetParameter("IdVuviecDu", IdVuviecDu);
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

            return qbcketoan.UniqueResult<decimal>();
        }

        private Decimal fn_Ps_Co(String MaTk, String MaTkDu, DateTime TuNgay, DateTime DenNgay, Guid DonviId, String MaNte,
            Guid IdHopDong, Guid IdHopDongDu,
            Guid IdPtqt, Guid IdPtqtDu,
            Guid IdPhongban, Guid IdPhongbanDu,
            Guid IdVuviec, Guid IdVuviecDu,
            Guid IdKhang, Guid IdKhangDu,
            Guid IdDmKhoanphi, Guid IdDmKhoanphiDu,
            Guid IdDmTudo1, Guid IdDmTudo1Du,
            Guid IdDmTudo2, Guid IdDmTudo2Du,
            Guid IdDmTudo3, Guid IdDmTudo3Du,
            Guid IdDmTudo4, Guid IdDmTudo4Du,
            Guid IdDmTudo5, Guid IdDmTudo5Du)
        {
            String SQL = "select sum(SoTien) from BcKetoan " +
                         " where " +
                         "(SoDu = 0) " +
                        "AND NgayCt <= :DenNgay " +
                        (TuNgay == DateTime.MinValue ? "" : "AND NgayCt >= :TuNgay ") +
                        "AND (MaTkCo like :MaTk)" +
                        (String.IsNullOrEmpty(MaTkDu) ? "" : "AND (MaTkNo like :MaTkDu)") +
                        "AND DonviId = :DonviId " +
                        (String.IsNullOrEmpty(MaNte) ? "" : "AND (MaNte = :MaNte)") +
                        (VnsCheck.IsNullGuid(IdKhang) ? "" : "AND (IdKhangCo = :IdKhang) ") +
                        (VnsCheck.IsNullGuid(IdKhangDu) ? "" : "AND (IdKhangNo = :IdKhangDu) ") +
                        (VnsCheck.IsNullGuid(IdHopDong) ? "" : "AND (IdHopdongCo =  :IdHopDong) ") +
                        (VnsCheck.IsNullGuid(IdHopDongDu) ? "" : "AND (IdHopdongNo =  :IdHopDongDu) ") +
                        (VnsCheck.IsNullGuid(IdPtqt) ? "" : "AND (IdPtqtCo = :IdPtqt) ") +
                        (VnsCheck.IsNullGuid(IdPtqtDu) ? "" : "AND (IdPtqtNo = :IdPtqtDu) ") +
                        (VnsCheck.IsNullGuid(IdPhongban) ? "" : "AND (IdPhongbanCo = :IdPhongban) ") +
                        (VnsCheck.IsNullGuid(IdPhongbanDu) ? "" : "AND (IdPhongbanNo = :IdPhongbanDu) ") +
                        (VnsCheck.IsNullGuid(IdVuviec) ? "" : "AND (IdVuviecCo = :IdVuviec) ") +
                        (VnsCheck.IsNullGuid(IdVuviecDu) ? "" : "AND (IdVuviecNo = :IdVuviecDu) ") +
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
                        (VnsCheck.IsNullGuid(IdDmKhoanphiDu) ? "" : "AND (IdDmKhoanphiNo = :IdDmKhoanphiDu) ");

            IQuery qbcketoan = NHibernateSession.CreateQuery(SQL);
            qbcketoan.SetParameter("DenNgay", DenNgay);
            if (TuNgay != DateTime.MinValue) qbcketoan.SetParameter("TuNgay", TuNgay);
            qbcketoan.SetParameter("MaTk", String.Format("{0}%", MaTk));
            if (!String.IsNullOrEmpty(MaTkDu)) qbcketoan.SetParameter("MaTkDu", String.Format("{0}%", MaTkDu));
            qbcketoan.SetParameter("DonviId", DonviId);
            if (!String.IsNullOrEmpty(MaNte)) qbcketoan.SetParameter("MaNte", MaNte);
            if (!VnsCheck.IsNullGuid(IdKhang)) qbcketoan.SetParameter("IdKhang", IdKhang);
            if (!VnsCheck.IsNullGuid(IdKhangDu)) qbcketoan.SetParameter("IdKhangDu", IdKhangDu);
            if (!VnsCheck.IsNullGuid(IdHopDong)) qbcketoan.SetParameter("IdHopDong", IdHopDong);
            if (!VnsCheck.IsNullGuid(IdHopDongDu)) qbcketoan.SetParameter("IdHopDongDu", IdHopDongDu);
            if (!VnsCheck.IsNullGuid(IdPtqt)) qbcketoan.SetParameter("IdPtqt", IdPtqt);
            if (!VnsCheck.IsNullGuid(IdPtqtDu)) qbcketoan.SetParameter("IdPtqtDu", IdPtqtDu);
            if (!VnsCheck.IsNullGuid(IdPhongban)) qbcketoan.SetParameter("IdPhongban", IdPhongban);
            if (!VnsCheck.IsNullGuid(IdPhongbanDu)) qbcketoan.SetParameter("IdPhongbanDu", IdPhongbanDu);
            if (!VnsCheck.IsNullGuid(IdVuviec)) qbcketoan.SetParameter("IdVuviec", IdVuviec);
            if (!VnsCheck.IsNullGuid(IdVuviecDu)) qbcketoan.SetParameter("IdVuviecDu", IdVuviecDu);
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

            return qbcketoan.UniqueResult<decimal>();
        }

        private Decimal fn_Du_No(String MaTk, String MaTkDu, DateTime NgayTinh, Guid DonviId, String MaNte,
            Guid IdHopDong, Guid IdHopDongDu,
            Guid IdPtqt, Guid IdPtqtDu,
            Guid IdPhongban, Guid IdPhongbanDu,
            Guid IdVuviec, Guid IdVuviecDu,
            Guid IdKhang, Guid IdKhangDu,
            Guid IdDmKhoanphi, Guid IdDmKhoanphiDu,
            Guid IdDmTudo1, Guid IdDmTudo1Du,
            Guid IdDmTudo2, Guid IdDmTudo2Du,
            Guid IdDmTudo3, Guid IdDmTudo3Du,
            Guid IdDmTudo4, Guid IdDmTudo4Du,
            Guid IdDmTudo5, Guid IdDmTudo5Du)
        {
            DateTime TuNgay = DateTime.MinValue;
            DateTime DenNgay = NgayTinh;
            Decimal ps_no, ps_co = 0;
            ps_no = fn_Ps_No(MaTk, MaTkDu, TuNgay, DenNgay, DonviId, MaNte,
                            IdHopDong, IdHopDongDu,
                            IdPtqt, IdPtqtDu,
                             IdPhongban,  IdPhongbanDu,
                             IdVuviec,  IdVuviecDu,
                             IdKhang,  IdKhangDu,
                             IdDmKhoanphi,  IdDmKhoanphiDu,
                             IdDmTudo1,  IdDmTudo1Du,
                             IdDmTudo2,  IdDmTudo2Du,
                             IdDmTudo3,  IdDmTudo3Du,
                             IdDmTudo4,  IdDmTudo4Du,
                             IdDmTudo5,  IdDmTudo5Du);

            ps_co = fn_Ps_Co(MaTk, MaTkDu, TuNgay, DenNgay, DonviId, MaNte,
                            IdHopDong, IdHopDongDu,
                            IdPtqt, IdPtqtDu,
                             IdPhongban, IdPhongbanDu,
                             IdVuviec, IdVuviecDu,
                             IdKhang, IdKhangDu,
                             IdDmKhoanphi, IdDmKhoanphiDu,
                             IdDmTudo1, IdDmTudo1Du,
                             IdDmTudo2, IdDmTudo2Du,
                             IdDmTudo3, IdDmTudo3Du,
                             IdDmTudo4, IdDmTudo4Du,
                             IdDmTudo5, IdDmTudo5Du);
            decimal du_no = ps_no - ps_co;
            return du_no > 0 ? du_no : 0;
        }

        private Decimal fn_Du_co(String MaTk, String MaTkDu, DateTime NgayTinh, Guid DonviId, String MaNte,
            Guid IdHopDong, Guid IdHopDongDu,
            Guid IdPtqt, Guid IdPtqtDu,
            Guid IdPhongban, Guid IdPhongbanDu,
            Guid IdVuviec, Guid IdVuviecDu,
            Guid IdKhang, Guid IdKhangDu,
            Guid IdDmKhoanphi, Guid IdDmKhoanphiDu,
            Guid IdDmTudo1, Guid IdDmTudo1Du,
            Guid IdDmTudo2, Guid IdDmTudo2Du,
            Guid IdDmTudo3, Guid IdDmTudo3Du,
            Guid IdDmTudo4, Guid IdDmTudo4Du,
            Guid IdDmTudo5, Guid IdDmTudo5Du)
        {
            DateTime TuNgay = DateTime.MinValue;
            DateTime DenNgay = NgayTinh;
            Decimal ps_no, ps_co = 0;
            ps_no = fn_Ps_No(MaTk, MaTkDu, TuNgay, DenNgay, DonviId, MaNte,
                            IdHopDong, IdHopDongDu,
                            IdPtqt, IdPtqtDu,
                             IdPhongban, IdPhongbanDu,
                             IdVuviec, IdVuviecDu,
                             IdKhang, IdKhangDu,
                             IdDmKhoanphi, IdDmKhoanphiDu,
                             IdDmTudo1, IdDmTudo1Du,
                             IdDmTudo2, IdDmTudo2Du,
                             IdDmTudo3, IdDmTudo3Du,
                             IdDmTudo4, IdDmTudo4Du,
                             IdDmTudo5, IdDmTudo5Du);

            ps_co = fn_Ps_Co(MaTk, MaTkDu, TuNgay, DenNgay, DonviId, MaNte,
                            IdHopDong, IdHopDongDu,
                            IdPtqt, IdPtqtDu,
                             IdPhongban, IdPhongbanDu,
                             IdVuviec, IdVuviecDu,
                             IdKhang, IdKhangDu,
                             IdDmKhoanphi, IdDmKhoanphiDu,
                             IdDmTudo1, IdDmTudo1Du,
                             IdDmTudo2, IdDmTudo2Du,
                             IdDmTudo3, IdDmTudo3Du,
                             IdDmTudo4, IdDmTudo4Du,
                             IdDmTudo5, IdDmTudo5Du);
            decimal du_co = ps_co - ps_no;
            return du_co > 0 ? du_co : 0;
        }
    }
}
