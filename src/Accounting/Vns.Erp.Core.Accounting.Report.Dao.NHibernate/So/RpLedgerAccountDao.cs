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
    public class RpLedgerAccountDao : GenericDao<BcKetoan, System.Guid>, IRpLedgerAccountDao
    {
        public IList<RpLedgerAdminDTO> GetDataDetail(String MaTk, String MaTkDu, DateTime TuNgay, DateTime DenNgay, Guid DonviId, Guid KhachHangId, Guid HopDongId)
        {
            IList<RpLedgerAdminDTO> lst = new List<RpLedgerAdminDTO>();

            string sql = "Select bc.CthId as CthId, bc.CtdId as CtdId, " +
                "bc.MaTk{0} as MaTk, bc.MaTk{1} as MaTkDu, bc.NgayGhi as NgayGhi, " +
                "bc.NgayCt as NgayCt, bc.CtSo as CtSo, bc.DienGiai as DienGiai, " +
                "bc.SoTien as Ps{0}, cast(0 as Decimal) as Ps{1}, " +
                "bc.IdLoaiCt as IdLoaiCt, " +
                "bc.IdKhang{0} as IdKhang, " +
                "bc.IdKhang{1} as IdKhangDu " +
                "From BcKetoan bc " +
                "Where " +
                "bc.MaTk{0} like :MaTk " +
                   "AND bc.MaTk{1} like :MaTkDu " +
                   (VnsCheck.IsNullGuid(KhachHangId) ? " " : "AND (bc.IdKhangNo = :KhachHangId OR bc.IdKhangCo = :KhachHangId) ") +
                   "AND bc.NgayCt >= :TuNgay " +
                   "AND bc.NgayCt <= :DenNgay " +
                   "AND bc.DonviId = :DonviId";

            IQuery qbcketoan_no = NHibernateSession.CreateQuery(string.Format(sql, "No", "Co"));
            qbcketoan_no.SetParameter("MaTk", String.Format("{0}%", MaTk));
            qbcketoan_no.SetParameter("MaTkDu", String.Format("{0}%", MaTkDu));
            if (!VnsCheck.IsNullGuid(KhachHangId)) qbcketoan_no.SetParameter("KhachHangId", KhachHangId);
            qbcketoan_no.SetParameter("TuNgay", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CStartOfDate(TuNgay));
            qbcketoan_no.SetParameter("DenNgay", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CEndOfDate(DenNgay));
            qbcketoan_no.SetParameter("DonviId", DonviId);

            qbcketoan_no.SetResultTransformer(Transformers.AliasToBean<RpLedgerAdminDTO>());
            IList<RpLedgerAdminDTO> lstNo = qbcketoan_no.List<RpLedgerAdminDTO>();
            foreach (RpLedgerAdminDTO tmp in lstNo)
                lst.Add(tmp);

            IQuery qbcketoan_co = NHibernateSession.CreateQuery(string.Format(sql, "Co", "No"));
            qbcketoan_co.SetParameter("MaTk", String.Format("{0}%", MaTk));
            qbcketoan_co.SetParameter("MaTkDu", String.Format("{0}%", MaTkDu));
            if (!VnsCheck.IsNullGuid(KhachHangId)) qbcketoan_co.SetParameter("KhachHangId", KhachHangId);
            qbcketoan_co.SetParameter("TuNgay", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CStartOfDate(TuNgay));
            qbcketoan_co.SetParameter("DenNgay", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CEndOfDate(DenNgay));
            qbcketoan_co.SetParameter("DonviId", DonviId);

            qbcketoan_co.SetResultTransformer(Transformers.AliasToBean<RpLedgerAdminDTO>());
            IList<RpLedgerAdminDTO> lstCo = qbcketoan_co.List<RpLedgerAdminDTO>();
            foreach (RpLedgerAdminDTO tmp in lstCo)
                lst.Add(tmp);

            return lst;
        }

        public DataTable GetDataS06Dn(String MaTk, String MaTkDu, DateTime TuNgay, DateTime DenNgay, Guid DonviId)
        {
            IList<DmTaikhoan> lstTaiKhoan = new List<DmTaikhoan>();
            List<RpLedgerS06DnDTO> lstRp = new List<RpLedgerS06DnDTO>();

            string sql = "Select a from DmTaikhoan a " + 
                "where a.DonviId = :DonviId " + 
                (String.IsNullOrEmpty(MaTk) ? "" : "AND MaTaikhoan like :MaTaikhoan ") +
                "Order by a.Cap Desc";
            IQuery qbc_tk = NHibernateSession.CreateQuery(sql);
            qbc_tk.SetParameter("DonviId", DonviId);
            if (!String.IsNullOrEmpty(MaTk)) qbc_tk.SetParameter("MaTaikhoan", MaTk + "%");
            lstTaiKhoan = qbc_tk.List<DmTaikhoan>();

            foreach (DmTaikhoan tmptk in lstTaiKhoan)
            {
                RpLedgerS06DnDTO RpLedger = new RpLedgerS06DnDTO() { TkId = tmptk.Id, MaTk = tmptk.MaTaikhoan, TenTk = tmptk.TenTaikhoan, Cap = tmptk.Cap };
                RpLedger.ChiTiet = tmptk.ChiTiet;
                RpLedger.SortOrder = 0;
                if (tmptk.ChiTiet == 1)
                {
                    DateTime NgayTinhDauKy = TuNgay.AddDays(-1);
                    Decimal DuNoDk, DuCoDk = 0;
                    DuNoDk = fn_Du_No(RpLedger.MaTk, MaTkDu, NgayTinhDauKy, DonviId, "",
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
                    RpLedger.DuNoDk = DuNoDk > 0 ? DuNoDk : 0;
                    DuCoDk = fn_Du_co(RpLedger.MaTk, MaTkDu, NgayTinhDauKy, DonviId, "",
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
                    RpLedger.DuCoDk = DuCoDk > 0 ? DuCoDk : 0;

                    RpLedger.PsNoTk = fn_Ps_No(RpLedger.MaTk, MaTkDu, TuNgay, DenNgay, DonviId, "", Null.NullGuid, Null.NullGuid,
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

                    RpLedger.PsCoTk = fn_Ps_Co(RpLedger.MaTk, MaTkDu, TuNgay, DenNgay, DonviId, "", Null.NullGuid, Null.NullGuid,
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

                    DateTime NgayCuoiKy = DenNgay;
                    Decimal DuNoCk, DuCoCk = 0;
                    DuNoCk = fn_Du_No(RpLedger.MaTk, MaTkDu, NgayCuoiKy, DonviId, "",
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
                    RpLedger.DuNoCk = DuNoCk > 0 ? DuNoCk : 0;
                    DuCoCk = fn_Du_co(RpLedger.MaTk, MaTkDu, NgayCuoiKy, DonviId, "",
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
                    RpLedger.DuCoCk = DuCoCk > 0 ? DuCoCk : 0;
                }
                lstRp.Add(RpLedger);


            }

            foreach (RpLedgerS06DnDTO tmpRp in lstRp)
            {
                if (tmpRp.ChiTiet == 1) continue;

                RpLedgerS06DnDTO tmpLg = tmpRp;
                var lsttmp =
                from p in lstRp
                where p.MaTk.StartsWith(tmpLg.MaTk) && p.Cap == tmpLg.Cap + 1
                select p;

                foreach (RpLedgerS06DnDTO tmp1 in lsttmp)
                {
                    tmpRp.DuNoDk = tmpRp.DuNoDk + tmp1.DuNoDk;
                    tmpRp.DuCoDk = tmpRp.DuCoDk + tmp1.DuCoDk;
                    tmpRp.PsNoTk = tmpRp.PsNoTk + tmp1.PsNoTk;
                    tmpRp.PsCoTk = tmpRp.PsCoTk + tmp1.PsCoTk;
                    tmpRp.DuNoCk = tmpRp.DuNoCk + tmp1.DuNoCk;
                    tmpRp.DuCoCk = tmpRp.DuCoCk + tmp1.DuCoCk;
                }
            }

            RpLedgerS06DnDTO rpTong = new RpLedgerS06DnDTO();
            var lstCap1 =
            from p in lstRp
            where p.Cap == 0
            select p;

            foreach (RpLedgerS06DnDTO tmp1 in lstCap1)
            {
                //if (tmp1.Cap != 0) continue;
                rpTong.DuNoDk = rpTong.DuNoDk + tmp1.DuNoDk;
                rpTong.DuCoDk = rpTong.DuCoDk + tmp1.DuCoDk;
                rpTong.PsNoTk = rpTong.PsNoTk + tmp1.PsNoTk;
                rpTong.PsCoTk = rpTong.PsCoTk + tmp1.PsCoTk;
                rpTong.DuNoCk = rpTong.DuNoCk + tmp1.DuNoCk;
                rpTong.DuCoCk = rpTong.DuCoCk + tmp1.DuCoCk;
            }

            for (int i = lstRp.Count - 1; i >= 0; i--)
            {
                if (lstRp[i].DuNoDk == 0 &&
                    lstRp[i].DuCoDk == 0 &&
                    lstRp[i].PsNoTk == 0 &&
                    lstRp[i].PsCoTk == 0 &&
                    lstRp[i].DuNoCk == 0 &&
                    lstRp[i].DuCoCk == 0)
                {
                    lstRp.RemoveAt(i);
                }
            }
            rpTong.TenTk = "Tổng cộng";
            rpTong.Cap = 100;
            rpTong.SortOrder =1;
            lstRp.Add(rpTong);

            DataTable dt = DBUtil.ToDataTable<RpLedgerS06DnDTO>(lstRp);
            dt.DefaultView.Sort = "SortOrder, MaTk, Cap";
            return dt;
        }
        public DataTable GetDataS06DnDetailGetDataS06Dn(String MaTk, String MaTkDu, DateTime TuNgay, DateTime DenNgay, Guid DonviId)
        {
            List<RpLedgerS06DnDTO> lstRp = new List<RpLedgerS06DnDTO>();

            DateTime NgayTinhDauKy = TuNgay.AddDays(-1);
            Decimal DuNoDk, DuCoDk = 0;
            RpLedgerS06DnDTO RpLedger = new RpLedgerS06DnDTO() { MaTk = MaTk, SortOrder =0 };
            DuNoDk = fn_Du_No(RpLedger.MaTk, MaTkDu, NgayTinhDauKy, DonviId, "",
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
            RpLedger.DuNoDk = DuNoDk > 0 ? DuNoDk : 0;
            DuCoDk = fn_Du_co(RpLedger.MaTk, MaTkDu, NgayTinhDauKy, DonviId, "",
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
            RpLedger.DuCoDk = DuCoDk > 0 ? DuCoDk : 0;

            DataTable dt = DBUtil.ToDataTable<RpLedgerS06DnDTO>(lstRp);
            dt.DefaultView.Sort = "SortOrder, MaTk, Cap";
            return dt;
        }
        public DataTable GetDataS06DnWithDetail(String MaTk, String MaTkDu, Guid KhangId, DateTime TuNgay, DateTime DenNgay, Guid DonviId)
        {
            IList<DmKhang> lstKhang = new List<DmKhang>();
            List<RpLedgerS06DetailDTO> lstRp = new List<RpLedgerS06DetailDTO>();

            string sql = "Select a from DmKhang a " +
                "where a.DonviId = :DonviId " +
                "Order by a.TenKhang";
            IQuery qbc_tk = NHibernateSession.CreateQuery(sql);
            qbc_tk.SetParameter("DonviId", DonviId);
            lstKhang = qbc_tk.List<DmKhang>();

            foreach (DmKhang tmp in lstKhang)
                lstRp.Add(new RpLedgerS06DetailDTO(tmp));

            //Lay so du dau ky
            IList<RpLedgerS06DetailDTO> dk_no = new List<RpLedgerS06DetailDTO>();
            IList<RpLedgerS06DetailDTO> dk_co = new List<RpLedgerS06DetailDTO>();

            dk_no = fn_ps_cn("N", MaTk, MaTkDu, DateTime.MinValue, TuNgay.AddDays(-1), 2,
                DonviId, "",
                Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, KhangId, Null.NullGuid,
                Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);

            dk_co = fn_ps_cn("C", MaTk, MaTkDu, DateTime.MinValue, TuNgay.AddDays(-1), 2,
                DonviId, "",
                Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, KhangId, Null.NullGuid,
                Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);

            IList<RpLedgerS06DetailDTO> dk_cn = new List<RpLedgerS06DetailDTO>();
            dk_cn = UnionPsNoCo(dk_no, dk_co);

            foreach (RpLedgerS06DetailDTO tmp in lstRp)
            {
                foreach (RpLedgerS06DetailDTO tmpdk in dk_cn)
                {
                    if (tmp.KHangId == tmpdk.KHangId)
                    {
                        tmp.DuNoDk = tmpdk.DuNoCk > 0 ? tmpdk.DuNoCk : 0;
                        tmp.DuCoDk = tmpdk.DuCoCk > 0 ? tmpdk.DuCoCk : 0;

                        break;
                    }
                }
            }

            //Lay so du trong ky
            IList<RpLedgerS06DetailDTO> tk_no = new List<RpLedgerS06DetailDTO>();
            IList<RpLedgerS06DetailDTO> tk_co = new List<RpLedgerS06DetailDTO>();

            tk_no = fn_ps_cn("N", MaTk, MaTkDu, TuNgay, DenNgay, 2,
                DonviId, "",
                Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, KhangId, Null.NullGuid,
                Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);

            tk_co = fn_ps_cn("C", MaTk, MaTkDu, TuNgay, DenNgay, 2,
                DonviId, "",
                Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, KhangId, Null.NullGuid,
                Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);

            IList<RpLedgerS06DetailDTO> tk_cn = new List<RpLedgerS06DetailDTO>();
            tk_cn = UnionPsNoCo(tk_no, tk_co);

            foreach (RpLedgerS06DetailDTO tmp in lstRp)
            {
                foreach (RpLedgerS06DetailDTO tmptk in tk_cn)
                {
                    if (tmp.KHangId == tmptk.KHangId)
                    {
                        tmp.PsNoTk = tmptk.PsNoTk;
                        tmp.PsCoTk = tmptk.PsCoTk;

                        break;
                    }
                }
            }

            List<RpLedgerS06DetailDTO> rp = new List<RpLedgerS06DetailDTO>();
            foreach (RpLedgerS06DetailDTO tmp in lstRp)
            {
                if (tmp.DuNoDk == 0 && tmp.DuCoDk == 0 &&
                    tmp.PsNoTk == 0 && tmp.PsCoTk == 0 &&
                    tmp.DuCoCk == 0 && tmp.DuCoCk == 0)
                {
                }
                else
                {
                    //tmp.DuNoCk = tmp.DuNoDk - tmp.DuCoDk + tmp.PsNoTk - tmp.PsCoTk;

                    rp.Add(tmp);
                }
            }

            DataTable dt = DBUtil.ToDataTable<RpLedgerS06DetailDTO>(rp);
            return dt;
        }

        /// <summary>
        /// So nhat ky chung (Giong so S07DN)
        /// </summary>
        /// <param name="MaTk"></param>
        /// <param name="MaTkDu"></param>
        /// <param name="TuNgay"></param>
        /// <param name="DenNgay"></param>
        /// <param name="DonviId"></param>
        /// <returns></returns>
        public DataTable GetDataS03a_SoNhatKyChung(String MaTk, String MaTkDu, DateTime TuNgay, DateTime DenNgay, Guid DonviId)
        {
            IList<RpLedgerS07DnDTO> lst = new List<RpLedgerS07DnDTO>();

            //Trong ky
            string sql = "Select CthId as CthId, CtdId as CtdId, 2 as Nhom, " +
                            "MaTk{0} as MaTk,MaTk{1} as MaTkDu,NgayGhi as NgayGhi, " +
                            "NgayCt as NgayCt, CtSo as CtSo{0},'' as CtSo{1}, DienGiai as DienGiai, " +
                            "SoTien as Ps{0},cast(0 as Decimal) as Ps{1},cast(0 as Decimal) as SoTon, " +
                            "IdLoaiCt as IdLoaiCt " +
              "FROM BcKetoan " +
              "WHERE (SoDu = 0) " +
                   "AND MaTk{0} like :MaTk " +
                   "AND MaTk{1} like :MaTkDu " +
                   "AND NgayCt >= :TuNgay " +
                   "AND NgayCt <= :DenNgay " +
                   "AND DonviId = :DonviId";


            IQuery qbcketoan_no = NHibernateSession.CreateQuery(string.Format(sql, "No", "Co"));
            qbcketoan_no.SetParameter("MaTk", String.Format("{0}%", MaTk));
            qbcketoan_no.SetParameter("MaTkDu", String.Format("{0}%", MaTkDu));
            qbcketoan_no.SetParameter("TuNgay", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CStartOfDate(TuNgay));
            qbcketoan_no.SetParameter("DenNgay", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CEndOfDate(DenNgay));
            qbcketoan_no.SetParameter("DonviId", DonviId);

            qbcketoan_no.SetResultTransformer(Transformers.AliasToBean<RpLedgerS07DnDTO>());
            IList<RpLedgerS07DnDTO> lstNo = qbcketoan_no.List<RpLedgerS07DnDTO>();
            foreach (RpLedgerS07DnDTO tmp in lstNo)
                lst.Add(tmp);

            IQuery qbcketoan_co = NHibernateSession.CreateQuery(string.Format(sql, "Co", "No"));
            qbcketoan_co.SetParameter("MaTk", String.Format("{0}%", MaTk));
            qbcketoan_co.SetParameter("MaTkDu", String.Format("{0}%", MaTkDu));
            qbcketoan_co.SetParameter("TuNgay", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CStartOfDate(TuNgay));
            qbcketoan_co.SetParameter("DenNgay", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CEndOfDate(DenNgay));
            qbcketoan_co.SetParameter("DonviId", DonviId);

            qbcketoan_co.SetResultTransformer(Transformers.AliasToBean<RpLedgerS07DnDTO>());
            IList<RpLedgerS07DnDTO> lstCo = qbcketoan_co.List<RpLedgerS07DnDTO>();
            foreach (RpLedgerS07DnDTO tmp in lstCo)
                lst.Add(tmp);

            DataTable dt = DBUtil.ToDataTable<RpLedgerS07DnDTO>(lst);
            dt.DefaultView.Sort = "Nhom, NgayCt";
            return dt;
        }

        public DataTable GetDataS03A_ThuChi(Boolean IsNo, String MaTk, String MaTkDu, DateTime TuNgay, DateTime DenNgay, Guid DonviId)
        {
            IList<RpLedgerS03DnDTO> lst = new List<RpLedgerS03DnDTO>();

            //Trong ky
            string sql = "Select CthId as CthId, CtdId as CtdId, 2 as Nhom, " +
                            "MaTk{0} as MaTk,MaTk{1} as MaTkDu,NgayGhi as NgayGhi, " +
                            "NgayCt as NgayCt, CtSo as CtSo, DienGiai as DienGiai, " +
                            "SoTien as Ps{0},cast(0 as Decimal) as Ps{1},cast(0 as Decimal) as SoTon, " +
                            "IdLoaiCt as IdLoaiCt, TenKhang{0} as TenKHang " +
              "FROM BcKetoan " +
              "WHERE (SoDu = 0) " +
                   "AND MaTk{0} like :MaTk " +
                   (String.IsNullOrEmpty(MaTkDu) ? "" : "AND MaTk{1} like :MaTkDu ") +
                   "AND NgayCt >= :TuNgay " +
                   "AND NgayCt <= :DenNgay " +
                   "AND DonviId = :DonviId";

            IQuery qbcketoan;
            if (IsNo)
                qbcketoan = NHibernateSession.CreateQuery(string.Format(sql, "No", "Co"));
            else
                qbcketoan = NHibernateSession.CreateQuery(string.Format(sql, "Co", "No"));

            qbcketoan.SetParameter("MaTk", String.Format("{0}%", MaTk));
            if (!String.IsNullOrEmpty(MaTkDu)) qbcketoan.SetParameter("MaTkDu", String.Format("{0}%", MaTkDu));
            qbcketoan.SetParameter("TuNgay", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CStartOfDate(TuNgay));
            qbcketoan.SetParameter("DenNgay", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CEndOfDate(DenNgay));
            qbcketoan.SetParameter("DonviId", DonviId);

            qbcketoan.SetResultTransformer(Transformers.AliasToBean<RpLedgerS03DnDTO>());
            lst = qbcketoan.List<RpLedgerS03DnDTO>();
             
            DataTable dt = DBUtil.ToDataTable<RpLedgerS03DnDTO>(lst);
            dt.DefaultView.Sort = "Nhom, NgayCt";
            return dt;
        }

        public DataTable GetDataS03A_MuaHang(String MaTk, DateTime TuNgay, DateTime DenNgay, Guid DonviId)
        {
            IList<RpLedgerS03Dn_MuaHangDTO> lst = new List<RpLedgerS03Dn_MuaHangDTO>();

            //Trong ky
            string sql = "Select CthNxId as CthId, CtdNxId as CtdId, " +
                            "NgayGhi as NgayGhi, NgayCt as NgayCt, CtSo as CtSo, DienGiai as DienGiai, " +
                            "MaTkcGiavon as MaTk, MaTknGiavon as MaTkKho, SoLuong as SoLuong, DonGiaVon as DonGia, GiaVon as TienHang, " +
                            "MaTknThueGtgt as MaTkThueGtgt, TyLeThueGtgt as TyLeThueGtgt, SoTienThueGtgt as SoTienThueGtgt, " +
                            "MaTknThueTtdb as MaTkThueTtdb, TyLeThueTtdb as TyLeThueTtdb, SoTienThueTtdb as SoTienThueTtdb, " +
                            "MaTknThueXnk as MaTkThueXnk, TyLeThueXnk as TyLeThueXnk, SoTienThueXnk as SoTienThueXnk," +
                            "HanghoaId as HanghoaId, TenHanghoa as TenHanghoa, " +
                            "IdDmKhangCo as KhangId, TenDmKhangCo as TenKhang, " +
                            "IdLoaiCt as IdLoaiCt " +
              "FROM BcKetoanKho " +
              "WHERE (SoDu = 0) " +
                   (String.IsNullOrEmpty(MaTk) ? "" : "AND MaTkcGiavon like :MaTk ") +
                   //(String.IsNullOrEmpty(MaTkDu) ? "" : "AND MaTk{1} like :MaTkDu ") +
                   "AND NgayCt >= :TuNgay " +
                   "AND NgayCt <= :DenNgay " +
                   "AND DonviId = :DonviId";

            IQuery qbcketoan = NHibernateSession.CreateQuery(sql);

            if (!String.IsNullOrEmpty(MaTk)) qbcketoan.SetParameter("MaTk", String.Format("{0}%", MaTk));
            //if (!String.IsNullOrEmpty(MaTkDu)) qbcketoan.SetParameter("MaTkDu", String.Format("{0}%", MaTkDu));
            qbcketoan.SetParameter("TuNgay", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CStartOfDate(TuNgay));
            qbcketoan.SetParameter("DenNgay", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CEndOfDate(DenNgay));
            qbcketoan.SetParameter("DonviId", DonviId);

            qbcketoan.SetResultTransformer(Transformers.AliasToBean<RpLedgerS03Dn_MuaHangDTO>());
            lst = qbcketoan.List<RpLedgerS03Dn_MuaHangDTO>();

            DataTable dt = DBUtil.ToDataTable<RpLedgerS03Dn_MuaHangDTO>(lst);
            dt.DefaultView.Sort = "NgayCt";
            return dt;
        }

        public DataTable GetDataS03A_Banhang(String MaTk, DateTime TuNgay, DateTime DenNgay, Guid DonviId)
        {
            IList<RpLedgerS03Dn_BanHangDTO> lst = new List<RpLedgerS03Dn_BanHangDTO>();

            //Trong ky
            string sql = "Select CthNxId as CthId, CtdNxId as CtdId, " +
                            "NgayGhi as NgayGhi, NgayCt as NgayCt, CtSo as CtSo, DienGiai as DienGiai, " +
                            "MaTknGiaban as MaTk, MaTkcGiaban as MaTkDoanhThu, SoLuong as SoLuong, DonGiaBan as DonGiaBan, GiaVon as TienHang, " +
                            "MaTkcThueGtgt as MaTkThueGtgt, TyLeThueGtgt as TyLeThueGtgt, SoTienThueGtgt as SoTienThueGtgt, " +
                            "HanghoaId as HanghoaId, TenHanghoa as TenHanghoa, " +
                            "IdDmKhangCo as KhangId, TenDmKhangCo as TenKhang, " +
                            "IdLoaiCt as IdLoaiCt " +
              "FROM BcKetoanKho " +
              "WHERE (SoDu = 0) " +
                   (String.IsNullOrEmpty(MaTk) ? "" : "AND TknGiaban like :MaTk ") +
                   //(String.IsNullOrEmpty(MaTkDu) ? "" : "AND MaTk{1} like :MaTkDu ") +
                   "AND NgayCt >= :TuNgay " +
                   "AND NgayCt <= :DenNgay " +
                   "AND DonviId = :DonviId";

            IQuery qbcketoan = NHibernateSession.CreateQuery(sql);

            if (!String.IsNullOrEmpty(MaTk)) qbcketoan.SetParameter("MaTk", String.Format("{0}%", MaTk));
            //if (!String.IsNullOrEmpty(MaTkDu)) qbcketoan.SetParameter("MaTkDu", String.Format("{0}%", MaTkDu));
            qbcketoan.SetParameter("TuNgay", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CStartOfDate(TuNgay));
            qbcketoan.SetParameter("DenNgay", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CEndOfDate(DenNgay));
            qbcketoan.SetParameter("DonviId", DonviId);

            qbcketoan.SetResultTransformer(Transformers.AliasToBean<RpLedgerS03Dn_BanHangDTO>());
            lst = qbcketoan.List<RpLedgerS03Dn_BanHangDTO>();

            DataTable dt = DBUtil.ToDataTable<RpLedgerS03Dn_BanHangDTO>(lst);
            dt.DefaultView.Sort = "NgayCt";
            return dt;
        }

        public DataTable GetDataS07Dn(String MaTk, String MaTkDu, DateTime TuNgay, DateTime DenNgay, Guid DonviId, String MaNte)
        {
            List<RpLedgerS07DnDTO> lst = new List<RpLedgerS07DnDTO>();
            //So ton dau ky
            RpLedgerS07DnDTO du_dk = new RpLedgerS07DnDTO();
            DateTime NgayTinhDauKy = TuNgay.AddDays(-1);
            Decimal du_no_dk = fn_Du_No(MaTk, MaTkDu, NgayTinhDauKy, DonviId, "",
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

            //du_dk.NgayCt = TuNgay;
            du_dk.SoTon = du_no_dk;
            du_dk.Nhom = 0;
            du_dk.DienGiai = "Số tồn đầu kỳ";
            //lst.Add(du_dk);

            //So phat sinh trong ky
            RpLedgerS07DnDTO ps_dk = new RpLedgerS07DnDTO();

            Decimal ps_no_dk, ps_co_dk = 0;

            ps_no_dk = fn_Ps_No(MaTk, MaTkDu, TuNgay, DenNgay, DonviId, "", Null.NullGuid, Null.NullGuid,
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

            ps_co_dk = fn_Ps_Co(MaTk, MaTkDu, TuNgay, DenNgay, DonviId, "", Null.NullGuid, Null.NullGuid,
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

            //ps_dk.NgayCt = TuNgay;
            ps_dk.PsNo = ps_no_dk;
            ps_dk.PsCo = ps_co_dk;
            ps_dk.Nhom = 1;
            ps_dk.DienGiai = "Số phát sinh trong kỳ";
            //lst.Add(ps_dk);

            //Trong ky
            string sql = "Select CthId as CthId, CtdId as CtdId, 2 as Nhom, " +
                            "MaTk{0} as MaTk,MaTk{1} as MaTkDu,NgayGhi as NgayGhi, " +
                            "NgayCt as NgayCt, CtSo as CtSo{0},'' as CtSo{1}, DienGiai as DienGiai, " +
                            "SoTien as Ps{0},cast(0 as Decimal) as Ps{1},cast(0 as Decimal) as SoTon, " +
                            "IdLoaiCt as IdLoaiCt " +
              "FROM BcKetoan " +
              "WHERE (SoDu = 0) " +
                   "AND MaTk{0} like :MaTk " +
                   "AND MaTk{1} like :MaTkDu " +
                   "AND NgayCt >= :TuNgay " +
                   "AND NgayCt <= :DenNgay " +
                   "AND DonviId = :DonviId";


            IQuery qbcketoan_no = NHibernateSession.CreateQuery(string.Format(sql, "No", "Co"));
            qbcketoan_no.SetParameter("MaTk", String.Format("{0}%", MaTk));
            qbcketoan_no.SetParameter("MaTkDu", String.Format("{0}%", MaTkDu));
            qbcketoan_no.SetParameter("TuNgay", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CStartOfDate(TuNgay));
            qbcketoan_no.SetParameter("DenNgay", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CEndOfDate(DenNgay));
            qbcketoan_no.SetParameter("DonviId", DonviId);

            qbcketoan_no.SetResultTransformer(Transformers.AliasToBean<RpLedgerS07DnDTO>());
            IList<RpLedgerS07DnDTO> lstNo = qbcketoan_no.List<RpLedgerS07DnDTO>();
            lst.AddRange(lstNo);
            //foreach (RpLedgerS07DnDTO tmp in lstNo)
            //    lst.Add(tmp);

            IQuery qbcketoan_co = NHibernateSession.CreateQuery(string.Format(sql, "Co", "No"));
            qbcketoan_co.SetParameter("MaTk", String.Format("{0}%", MaTk));
            qbcketoan_co.SetParameter("MaTkDu", String.Format("{0}%", MaTkDu));
            qbcketoan_co.SetParameter("TuNgay", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CStartOfDate(TuNgay));
            qbcketoan_co.SetParameter("DenNgay", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CEndOfDate(DenNgay));
            qbcketoan_co.SetParameter("DonviId", DonviId);

            qbcketoan_co.SetResultTransformer(Transformers.AliasToBean<RpLedgerS07DnDTO>());
            IList<RpLedgerS07DnDTO> lstCo = qbcketoan_co.List<RpLedgerS07DnDTO>();
            lst.AddRange(lstCo);
            //foreach (RpLedgerS07DnDTO tmp in lstCo)
            //    lst.Add(tmp);

            //Tinh so ton
            //du_no_dk
            //    for (e
            RpLedgerComparer rpComparer = new RpLedgerComparer();
            lst.Sort(rpComparer);
            decimal tmpSoTon = du_no_dk;
            foreach (RpLedgerS07DnDTO obj in lst)
            {
                obj.SoTon = tmpSoTon + obj.PsNo - obj.PsCo;
                tmpSoTon = obj.SoTon;
            }

            //Du no dau ky
            lst.Add(du_dk);
            //So phat sinh trong ky
            lst.Add(ps_dk);

            //Cong so phat sinh trong ky
            RpLedgerS07DnDTO ps_ck = new RpLedgerS07DnDTO();
            //ps_ck.NgayCt = DenNgay;
            ps_ck.PsCo = ps_dk.PsCo;
            ps_ck.PsNo = ps_dk.PsNo;
            ps_ck.Nhom = 3;
            ps_ck.DienGiai = "- Cộng số phát sinh trong kỳ";
            lst.Add(ps_ck);
            //So ton cuoi ky
            RpLedgerS07DnDTO du_ck = new RpLedgerS07DnDTO();
            Decimal du_no_ck = fn_Du_No(MaTk, MaTkDu, DenNgay, DonviId, "",
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

            //du_ck.NgayCt = DenNgay;
            du_ck.SoTon = du_no_ck;
            du_ck.Nhom = 4;
            du_ck.DienGiai = "Số tồn cuối kỳ";
            lst.Add(du_ck);

            DataTable dt = DBUtil.ToDataTable<RpLedgerS07DnDTO>(lst);
            dt.DefaultView.Sort = "Nhom, NgayCt, PsCo";
            return dt;
        }
        public DataTable GetDataS38Dn(String p_Ma_Tk, Guid p_DonviId, DateTime p_Tu_Ngay, DateTime p_Den_Ngay)
        {
            String SQL = " SELECT " +
                            "CthId as CthId,CtdId as CtdId,NgayCt as NgayCt,NgayGhi as NgayGhi," +
                            "Case When MaTkNo Like :p_Ma_Tk || '%' Then MaTkNo " +
                            "Else MaTkCo End as MaTk, " +
                            "Case When MaTkCo Not Like :p_Ma_Tk || '%' Then MaTkCo " +
                            "Else MaTkNo End as MaTkDu, " +
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
            DateTime NgayTinhDauKy = p_Tu_Ngay.AddDays(-1);
            du_no_dk = fn_Du_No(p_Ma_Tk, null, NgayTinhDauKy, p_DonviId, "", Null.NullGuid, Null.NullGuid,
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
            dk.DienGiai = "So du dau ky";
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
            ps.DienGiai = "Phat sinh trong ky";
            ps.PsNo = ps_no_dk;
            ps.PsCo = ps_co_dk;
            ps.Nhom = 1;
            //Chung tu phat sinh

            //Ps Trong ky
            RpLedgerS38DnDTO ps1 = new RpLedgerS38DnDTO();
            ps1.DienGiai = "Phat sinh trong ky";
            ps1.PsNo = ps_no_dk;
            ps1.PsCo = ps_co_dk;
            ps1.Nhom = 3;
            //So du cuoi ky
            Decimal du_no_ck, du_co_ck = 0;
            du_no_ck = fn_Du_No(p_Ma_Tk, null, p_Den_Ngay, p_DonviId, "", Null.NullGuid, Null.NullGuid,
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
            ck.DienGiai = "So du cuoi ky";
            ck.DuNo = du_no_ck > 0 ? du_no_ck : 0;
            ck.DuCo = du_co_ck > 0 ? du_co_ck : 0;
            ck.Nhom = 4;

            IQuery qbcketoan = NHibernateSession.CreateQuery(SQL);
            qbcketoan.SetParameter("p_Ma_Tk", p_Ma_Tk);
            qbcketoan.SetParameter("p_DonviId", p_DonviId);
            qbcketoan.SetParameter("p_Tu_Ngay", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CStartOfDate(p_Tu_Ngay));
            qbcketoan.SetParameter("p_Den_Ngay", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CEndOfDate(p_Den_Ngay));
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

        #region In phieu ke toan
        public RpPhieuKeToanDTO GetPhieuKetoan(Guid CtHId)
        {

            return null;
        }
        #endregion

        #region Function
        public Decimal Get_GiaTri_BaoCao(KtHDong objKtHDong, DateTime TuNgay, DateTime DenNgay, Guid DonviId)
        {
            Decimal GiaTri = 0;
            Boolean IsNegative = false;
            String HamTinh = "";

            if (objKtHDong.TsThoigian == "1N")
            {
                TuNgay = TuNgay.AddYears(-1);
                DenNgay = DenNgay.AddYears(-1);
            }

            if (String.IsNullOrEmpty(objKtHDong.HamTinh)) return 0;

            if ( objKtHDong.HamTinh[0] == '-')
            {
                IsNegative = true;
                HamTinh = objKtHDong.HamTinh.Remove(0,1);
            }
            else
            {
                HamTinh = objKtHDong.HamTinh;
            }

            DateTime _DenNgay;
            switch (HamTinh)
            {
                case "DU_NO_DK":
                    GiaTri = fn_Du_No(objKtHDong.DkMaTk, objKtHDong.DkMaTkDu, TuNgay, DonviId, String.Empty,
                        Null.NullGuid, Null.NullGuid, 
                        VnsConvert.CGuid(objKtHDong.DkMaPtqt), VnsConvert.CGuid(objKtHDong.DkMaDmPtqtDu), 
                        Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);
                    break;
                case "DU_NO_CN_DK":
                    _DenNgay = TuNgay.AddDays(-1);
                    GiaTri = fn_Du_no_cn(objKtHDong.DkMaTk, objKtHDong.DkMaTkDu, DateTime.MinValue,_DenNgay, DonviId, String.Empty,
                        Null.NullGuid, Null.NullGuid, 
                        VnsConvert.CGuid(objKtHDong.DkMaPtqt), VnsConvert.CGuid(objKtHDong.DkMaDmPtqtDu), 
                        Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);
                    break;
                case "DU_NO_TK":
                    GiaTri = fn_Du_No(objKtHDong.DkMaTk, objKtHDong.DkMaTkDu, TuNgay, DenNgay, DonviId, String.Empty,
                        Null.NullGuid, Null.NullGuid, 
                        VnsConvert.CGuid(objKtHDong.DkMaPtqt), VnsConvert.CGuid(objKtHDong.DkMaDmPtqtDu), 
                        Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);
                    break;
                case "DU_NO_CK":
                    GiaTri = fn_Du_No(objKtHDong.DkMaTk, objKtHDong.DkMaTkDu, DenNgay, DonviId, String.Empty,
                        Null.NullGuid, Null.NullGuid, 
                        VnsConvert.CGuid(objKtHDong.DkMaPtqt), VnsConvert.CGuid(objKtHDong.DkMaDmPtqtDu), 
                        Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);
                    break;
                case "DU_NO_CN_CK":
                    _DenNgay = DenNgay;
                    GiaTri = fn_Du_no_cn(objKtHDong.DkMaTk, objKtHDong.DkMaTkDu, DateTime.MinValue,_DenNgay, DonviId, String.Empty,
                        Null.NullGuid, Null.NullGuid, VnsConvert.CGuid(objKtHDong.DkMaPtqt), VnsConvert.CGuid(objKtHDong.DkMaDmPtqtDu), Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);
                    break;
                case "DU_CO_DK":
                    GiaTri = fn_Du_co(objKtHDong.DkMaTk, objKtHDong.DkMaTkDu, TuNgay, DonviId, String.Empty,
                        Null.NullGuid, Null.NullGuid, 
                        VnsConvert.CGuid(objKtHDong.DkMaPtqt), VnsConvert.CGuid(objKtHDong.DkMaDmPtqtDu), 
                        Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);
                    break;
                case "DU_CO_TK":
                    GiaTri = fn_Du_co(objKtHDong.DkMaTk, objKtHDong.DkMaTkDu, TuNgay, DenNgay, DonviId, String.Empty,
                        Null.NullGuid, Null.NullGuid, 
                        VnsConvert.CGuid(objKtHDong.DkMaPtqt), VnsConvert.CGuid(objKtHDong.DkMaDmPtqtDu), 
                        Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);
                    break;
                case "DU_CO_CN_DK":
                    _DenNgay = TuNgay.AddDays(-1);
                    GiaTri = fn_Du_co_cn(objKtHDong.DkMaTk, objKtHDong.DkMaTkDu, DateTime.MinValue,_DenNgay, DonviId, String.Empty,
                        Null.NullGuid, Null.NullGuid, 
                        VnsConvert.CGuid(objKtHDong.DkMaPtqt), VnsConvert.CGuid(objKtHDong.DkMaDmPtqtDu), 
                        Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);
                    break;
                case "DU_CO_CK":
                    GiaTri = fn_Du_co(objKtHDong.DkMaTk, objKtHDong.DkMaTkDu, DenNgay, DonviId, String.Empty,
                        Null.NullGuid, Null.NullGuid, VnsConvert.CGuid(objKtHDong.DkMaPtqt), VnsConvert.CGuid(objKtHDong.DkMaDmPtqtDu), Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);
                    break;
                case "DU_CO_CN_CK":
                    _DenNgay = DenNgay;
                    GiaTri = fn_Du_co_cn(objKtHDong.DkMaTk, objKtHDong.DkMaTkDu, DateTime.MinValue,_DenNgay, DonviId, String.Empty,
                        Null.NullGuid, Null.NullGuid, 
                        VnsConvert.CGuid(objKtHDong.DkMaPtqt), VnsConvert.CGuid(objKtHDong.DkMaDmPtqtDu), 
                        Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);
                    break;
                case "PS_NO_DK":
                    GiaTri = fn_Ps_No(objKtHDong.DkMaTk, objKtHDong.DkMaTkDu, DateTime.MinValue, TuNgay, DonviId, String.Empty,
                        Null.NullGuid, Null.NullGuid, VnsConvert.CGuid(objKtHDong.DkMaPtqt), VnsConvert.CGuid(objKtHDong.DkMaDmPtqtDu), Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);
                    break;
                case "PS_CO_DK":
                    GiaTri = fn_Ps_Co(objKtHDong.DkMaTk, objKtHDong.DkMaTkDu, DateTime.MinValue, TuNgay, DonviId, String.Empty,
                        Null.NullGuid, Null.NullGuid, 
                        VnsConvert.CGuid(objKtHDong.DkMaPtqt), VnsConvert.CGuid(objKtHDong.DkMaDmPtqtDu), 
                        Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);
                    break;
                case "PS_NO_CK":
                    GiaTri = fn_Ps_No(objKtHDong.DkMaTk, objKtHDong.DkMaTkDu, DateTime.MinValue, DenNgay, DonviId, String.Empty,
                        Null.NullGuid, Null.NullGuid, 
                        VnsConvert.CGuid(objKtHDong.DkMaPtqt), VnsConvert.CGuid(objKtHDong.DkMaDmPtqtDu), 
                        Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);
                    break;
                case "PS_CO_CK":
                    GiaTri = fn_Ps_Co(objKtHDong.DkMaTk, objKtHDong.DkMaTkDu, DateTime.MinValue, DenNgay, DonviId, String.Empty,
                        Null.NullGuid, Null.NullGuid, 
                        VnsConvert.CGuid(objKtHDong.DkMaPtqt), VnsConvert.CGuid(objKtHDong.DkMaDmPtqtDu), 
                        Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);
                    break;
                case "PS_NO_TK":
                    GiaTri = fn_Ps_No(objKtHDong.DkMaTk, objKtHDong.DkMaTkDu, TuNgay, DenNgay, DonviId, String.Empty,
                        Null.NullGuid, Null.NullGuid, 
                        VnsConvert.CGuid(objKtHDong.DkMaPtqt), VnsConvert.CGuid(objKtHDong.DkMaDmPtqtDu), 
                        Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);
                    break;
                case "PS_CO_TK":
                    GiaTri = fn_Ps_Co(objKtHDong.DkMaTk, objKtHDong.DkMaTkDu, TuNgay, DenNgay, DonviId, String.Empty,
                        Null.NullGuid, Null.NullGuid, 
                        VnsConvert.CGuid(objKtHDong.DkMaPtqt), VnsConvert.CGuid(objKtHDong.DkMaDmPtqtDu), 
                        Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);
                    break;
                default:
                    break;
            }
            if (IsNegative) return GiaTri;

            return GiaTri < 0 ? 0 : GiaTri;
        }

        private Decimal fn_Ps(String LoaiTk, String MaTk, String MaTkDu, DateTime TuNgay, DateTime DenNgay, 
            Int16 Kieu,
            Guid DonviId, String MaNte,
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
            String TK = LoaiTk == "N" ? "No": "Co";
            String TkDu = LoaiTk == "N" ? "Co" : "No";

            MaTk = String.IsNullOrEmpty(MaTk) ? "" : MaTk;
            MaTkDu = String.IsNullOrEmpty(MaTkDu) ? "" : MaTkDu;

            String[] arrTk = MaTk.Split(';');
            String[] arrTkDu = MaTkDu.Split(';');

            String dkTk = String.Empty;
            for (int i = 0; i <= arrTk.Length-1; i++)
            {
                if (String.IsNullOrEmpty(arrTk[i])) continue;
                if (!String.IsNullOrEmpty(dkTk)) dkTk += " Or ";
                dkTk += String.Format("(MaTk{0} like :MaTk{1})", TK, i.ToString());
            }

            String dkTkDu = String.Empty;
            for (int i = 0; i <= arrTkDu.Length - 1; i++)
            {
                if (String.IsNullOrEmpty(arrTkDu[i])) continue;
                if (!String.IsNullOrEmpty(dkTkDu)) dkTkDu += " Or ";
                dkTkDu += String.Format("(MaTk{0} like :MaTkDu{1})", TkDu, i.ToString());
            }

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

            String SQL = "select sum(SoTien) from BcKetoan " +
                         " where 1 = 1 " +
                         KieuSQL +
                        "AND NgayCt <= :DenNgay " +
                        (TuNgay == DateTime.MinValue ? "" : "AND NgayCt >= :TuNgay ") +
                        (String.IsNullOrEmpty(MaTk) ? "" : "AND (" + dkTk + ") ") +
                        (String.IsNullOrEmpty(MaTkDu) ? "" : " AND ( " + dkTkDu + ")") +
                        "AND DonviId = :DonviId " +
                        (String.IsNullOrEmpty(MaNte) ? "" : "AND (MaNte = :MaNte)") +
                        (VnsCheck.IsNullGuid(IdKhang) ? "" : String.Format("AND (IdKhang{0} = :IdKhang) ", TK)) +
                        (VnsCheck.IsNullGuid(IdKhangDu) ? "" : String.Format("AND (IdKhang{0} = :IdKhangDu) ", TkDu)) +
                        (VnsCheck.IsNullGuid(IdHopDong) ? "" : String.Format("AND (IdHopDong{0} = :IdHopDong) ", TK)) +
                        (VnsCheck.IsNullGuid(IdHopDongDu) ? "" : String.Format("AND (IdHopDong{0} = :IdHopDongDu) ", TkDu)) +
                        (VnsCheck.IsNullGuid(IdPtqt) ? "" : String.Format("AND (IdPtqt{0} = :IdPtqt) ", TK)) +
                        (VnsCheck.IsNullGuid(IdPtqtDu) ? "" : String.Format("AND (IdPtqt{0} = :IdPtqtDu) ", TkDu)) +
                        (VnsCheck.IsNullGuid(IdPhongban) ? "" : String.Format("AND (IdPhongban{0} = :IdPhongban) ", TK)) +
                        (VnsCheck.IsNullGuid(IdPhongbanDu) ? "" : String.Format("AND (IdPhongban{0} = :IdPhongbanDu) ", TkDu)) +
                        (VnsCheck.IsNullGuid(IdVuviec) ? "" : String.Format("AND (IdVuviec{0} = :IdVuviec) ", TK)) +
                        (VnsCheck.IsNullGuid(IdVuviecDu) ? "" : String.Format("AND (IdVuviec{0} = :IdVuviecDu) ", TkDu)) +
                        (VnsCheck.IsNullGuid(IdDmTudo1) ? "" : String.Format("AND (IdDmTudo1{0} = :IdDmTudo1) ", TK)) +
                        (VnsCheck.IsNullGuid(IdDmTudo1Du) ? "" : String.Format("AND (IdDmTudo1{0} = :IdDmTudo1Du) ", TkDu)) +
                        (VnsCheck.IsNullGuid(IdDmTudo2) ? "" : String.Format("AND (IdDmTudo2{0} = :IdDmTudo2) ", TK)) +
                        (VnsCheck.IsNullGuid(IdDmTudo2Du) ? "" : String.Format("AND (IdDmTudo2{0} = :IdDmTudo2Du) ", TkDu)) +
                        (VnsCheck.IsNullGuid(IdDmTudo3) ? "" : String.Format("AND (IdDmTudo3{0} = :IdDmTudo3) ", TK)) +
                        (VnsCheck.IsNullGuid(IdDmTudo3Du) ? "" : String.Format("AND (IdDmTudo3{0} = :IdDmTudo3Du) ", TkDu)) +
                        (VnsCheck.IsNullGuid(IdDmTudo4) ? "" : String.Format("AND (IdDmTudo4{0} = :IdDmTudo4) ", TK)) +
                        (VnsCheck.IsNullGuid(IdDmTudo4Du) ? "" : String.Format("AND (IdDmTudo4{0} = :IdDmTudo4Du) ", TkDu)) +
                        (VnsCheck.IsNullGuid(IdDmTudo5) ? "" : String.Format("AND (IdDmTudo5{0} = :IdDmTudo5) ", TK)) +
                        (VnsCheck.IsNullGuid(IdDmTudo5Du) ? "" : String.Format("AND (IdDmTudo5{0} = :IdDmTudo5Du) ", TkDu)) +
                        (VnsCheck.IsNullGuid(IdDmKhoanphi) ? "" : String.Format("AND (IdDmKhoanphi{0} = :IdDmKhoanphi) ", TK)) +
                        (VnsCheck.IsNullGuid(IdDmKhoanphiDu) ? "" : String.Format("AND (IdDmKhoanphi{0} = :IdDmKhoanphiDu) ", TkDu));

            IQuery qbcketoan = NHibernateSession.CreateQuery(SQL);
            qbcketoan.SetParameter("DenNgay", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CEndOfDate(DenNgay));

            if (TuNgay != DateTime.MinValue) qbcketoan.SetParameter("TuNgay", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CStartOfDate(TuNgay));
            for (int i = 0; i <= arrTk.Length -1; i++)
            {
                if (String.IsNullOrEmpty(arrTk[i])) continue;
                qbcketoan.SetParameter("MaTk" + i.ToString(), String.Format("{0}%", arrTk[i]));
            }
            
            if (!String.IsNullOrEmpty(MaTkDu)) 
            {
                for (int i = 0; i<= arrTkDu.Length -1; i++)
                {
                    if (String.IsNullOrEmpty(arrTkDu[i])) continue;
                    qbcketoan.SetParameter("MaTkDu" + i.ToString(), String.Format("{0}%", arrTkDu[i]));
                }
            }

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
            return fn_Ps("N", MaTk, MaTkDu, TuNgay, DenNgay, 0,
                DonviId, MaNte,
                IdHopDong, IdHopDongDu, IdPtqt, IdPtqtDu,
                IdPhongban, IdPhongbanDu, IdVuviec, IdVuviecDu, IdKhang, IdKhangDu,
                IdDmKhoanphi, IdDmKhoanphiDu, IdDmTudo1, IdDmTudo1Du,
                IdDmTudo2, IdDmTudo2Du, IdDmTudo3, IdDmTudo3Du,
                IdDmTudo4, IdDmTudo4Du, IdDmTudo5, IdDmTudo5Du);
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
            return fn_Ps("C", MaTk, MaTkDu, TuNgay, DenNgay, 0,
                DonviId, MaNte,
                IdHopDong, IdHopDongDu, IdPtqt, IdPtqtDu,
                IdPhongban, IdPhongbanDu, IdVuviec, IdVuviecDu, IdKhang, IdKhangDu,
                IdDmKhoanphi, IdDmKhoanphiDu, IdDmTudo1, IdDmTudo1Du,
                IdDmTudo2, IdDmTudo2Du, IdDmTudo3, IdDmTudo3Du,
                IdDmTudo4, IdDmTudo4Du, IdDmTudo5, IdDmTudo5Du);
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
            ps_no = fn_Ps("N", MaTk, MaTkDu, TuNgay, DenNgay, 2,
                DonviId, MaNte,
                IdHopDong, IdHopDongDu, IdPtqt, IdPtqtDu,
                IdPhongban, IdPhongbanDu, IdVuviec, IdVuviecDu, IdKhang, IdKhangDu,
                IdDmKhoanphi, IdDmKhoanphiDu, IdDmTudo1, IdDmTudo1Du,
                IdDmTudo2, IdDmTudo2Du, IdDmTudo3, IdDmTudo3Du,
                IdDmTudo4, IdDmTudo4Du, IdDmTudo5, IdDmTudo5Du);

            ps_co = fn_Ps("C", MaTk, MaTkDu, TuNgay, DenNgay, 2,
                DonviId, MaNte,
                IdHopDong, IdHopDongDu, IdPtqt, IdPtqtDu,
                IdPhongban, IdPhongbanDu, IdVuviec, IdVuviecDu, IdKhang, IdKhangDu,
                IdDmKhoanphi, IdDmKhoanphiDu, IdDmTudo1, IdDmTudo1Du,
                IdDmTudo2, IdDmTudo2Du, IdDmTudo3, IdDmTudo3Du,
                IdDmTudo4, IdDmTudo4Du, IdDmTudo5, IdDmTudo5Du);
            decimal du_no = ps_no - ps_co;
            return du_no;
        }

        private Decimal fn_Du_No(String MaTk, String MaTkDu, DateTime TuNgay, DateTime DenNgay, Guid DonviId, String MaNte,
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
            Decimal ps_no, ps_co = 0;
            ps_no = fn_Ps("N", MaTk, MaTkDu, TuNgay, DenNgay, 2,
                DonviId, MaNte,
                IdHopDong, IdHopDongDu, IdPtqt, IdPtqtDu,
                IdPhongban, IdPhongbanDu, IdVuviec, IdVuviecDu, IdKhang, IdKhangDu,
                IdDmKhoanphi, IdDmKhoanphiDu, IdDmTudo1, IdDmTudo1Du,
                IdDmTudo2, IdDmTudo2Du, IdDmTudo3, IdDmTudo3Du,
                IdDmTudo4, IdDmTudo4Du, IdDmTudo5, IdDmTudo5Du);

            ps_co = fn_Ps("C", MaTk, MaTkDu, TuNgay, DenNgay, 2,
                DonviId, MaNte,
                IdHopDong, IdHopDongDu, IdPtqt, IdPtqtDu,
                IdPhongban, IdPhongbanDu, IdVuviec, IdVuviecDu, IdKhang, IdKhangDu,
                IdDmKhoanphi, IdDmKhoanphiDu, IdDmTudo1, IdDmTudo1Du,
                IdDmTudo2, IdDmTudo2Du, IdDmTudo3, IdDmTudo3Du,
                IdDmTudo4, IdDmTudo4Du, IdDmTudo5, IdDmTudo5Du);
            decimal du_no = ps_no - ps_co;
            return du_no;
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
            ps_no = fn_Ps("N", MaTk, MaTkDu, TuNgay, DenNgay, 2,
                DonviId, MaNte,
                IdHopDong, IdHopDongDu, IdPtqt, IdPtqtDu,
                IdPhongban, IdPhongbanDu, IdVuviec, IdVuviecDu, IdKhang, IdKhangDu,
                IdDmKhoanphi, IdDmKhoanphiDu, IdDmTudo1, IdDmTudo1Du,
                IdDmTudo2, IdDmTudo2Du, IdDmTudo3, IdDmTudo3Du,
                IdDmTudo4, IdDmTudo4Du, IdDmTudo5, IdDmTudo5Du);

            ps_co = fn_Ps("C", MaTk, MaTkDu, TuNgay, DenNgay, 2,
                DonviId, MaNte,
                IdHopDong, IdHopDongDu, IdPtqt, IdPtqtDu,
                IdPhongban, IdPhongbanDu, IdVuviec, IdVuviecDu, IdKhang, IdKhangDu,
                IdDmKhoanphi, IdDmKhoanphiDu, IdDmTudo1, IdDmTudo1Du,
                IdDmTudo2, IdDmTudo2Du, IdDmTudo3, IdDmTudo3Du,
                IdDmTudo4, IdDmTudo4Du, IdDmTudo5, IdDmTudo5Du);
            decimal du_co = ps_co - ps_no;
            return du_co;
        }

        private Decimal fn_Du_co(String MaTk, String MaTkDu, DateTime TuNgay, DateTime DenNgay, Guid DonviId, String MaNte,
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
            Decimal ps_no, ps_co = 0;
            ps_no = fn_Ps("N", MaTk, MaTkDu, TuNgay, DenNgay, 2,
                DonviId, MaNte,
                IdHopDong, IdHopDongDu, IdPtqt, IdPtqtDu,
                IdPhongban, IdPhongbanDu, IdVuviec, IdVuviecDu, IdKhang, IdKhangDu,
                IdDmKhoanphi, IdDmKhoanphiDu, IdDmTudo1, IdDmTudo1Du,
                IdDmTudo2, IdDmTudo2Du, IdDmTudo3, IdDmTudo3Du,
                IdDmTudo4, IdDmTudo4Du, IdDmTudo5, IdDmTudo5Du);

            ps_co = fn_Ps("C", MaTk, MaTkDu, TuNgay, DenNgay, 2,
                DonviId, MaNte,
                IdHopDong, IdHopDongDu, IdPtqt, IdPtqtDu,
                IdPhongban, IdPhongbanDu, IdVuviec, IdVuviecDu, IdKhang, IdKhangDu,
                IdDmKhoanphi, IdDmKhoanphiDu, IdDmTudo1, IdDmTudo1Du,
                IdDmTudo2, IdDmTudo2Du, IdDmTudo3, IdDmTudo3Du,
                IdDmTudo4, IdDmTudo4Du, IdDmTudo5, IdDmTudo5Du);
            decimal du_co = ps_co - ps_no;
            return du_co;
        }

        private Decimal fn_Du_no_cn(String MaTk, String MaTkDu, DateTime TuNgay, DateTime DenNgay, Guid DonviId, String MaNte,
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
            IList<RpLedgerS06DetailDTO> ps_no = new List<RpLedgerS06DetailDTO>();
            IList<RpLedgerS06DetailDTO> ps_co = new List<RpLedgerS06DetailDTO>();

            ps_no = fn_ps_cn("N", MaTk, MaTkDu, TuNgay, DenNgay, 2,
                DonviId, MaNte,
                IdHopDong, IdHopDongDu, IdPtqt, IdPtqtDu,
                IdPhongban, IdPhongbanDu, IdVuviec, IdVuviecDu, IdKhang, IdKhangDu,
                IdDmKhoanphi, IdDmKhoanphiDu, IdDmTudo1, IdDmTudo1Du,
                IdDmTudo2, IdDmTudo2Du, IdDmTudo3, IdDmTudo3Du,
                IdDmTudo4, IdDmTudo4Du, IdDmTudo5, IdDmTudo5Du);

            ps_co = fn_ps_cn("C", MaTk, MaTkDu, TuNgay, DenNgay, 2,
                DonviId, MaNte,
                IdHopDong, IdHopDongDu, IdPtqt, IdPtqtDu,
                IdPhongban, IdPhongbanDu, IdVuviec, IdVuviecDu, IdKhang, IdKhangDu,
                IdDmKhoanphi, IdDmKhoanphiDu, IdDmTudo1, IdDmTudo1Du,
                IdDmTudo2, IdDmTudo2Du, IdDmTudo3, IdDmTudo3Du,
                IdDmTudo4, IdDmTudo4Du, IdDmTudo5, IdDmTudo5Du);

            IList<RpLedgerS06DetailDTO> pscn = new List<RpLedgerS06DetailDTO>();
            pscn = UnionPsNoCo(ps_no, ps_co);

            Decimal so_du = 0;
            foreach (RpLedgerS06DetailDTO cn in pscn)
            {
                if (cn.DuNoCk > 0)
                    so_du += cn.DuNoCk;
            }
            return so_du;
        }

        private Decimal fn_Du_co_cn(String MaTk, String MaTkDu, DateTime TuNgay, DateTime DenNgay, Guid DonviId, String MaNte,
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
            IList<RpLedgerS06DetailDTO> ps_no = new List<RpLedgerS06DetailDTO>();
            IList<RpLedgerS06DetailDTO> ps_co = new List<RpLedgerS06DetailDTO>();

            ps_no = fn_ps_cn("N", MaTk, MaTkDu, TuNgay, DenNgay, 2,
                DonviId, MaNte,
                IdHopDong, IdHopDongDu, IdPtqt, IdPtqtDu,
                IdPhongban, IdPhongbanDu, IdVuviec, IdVuviecDu, IdKhang, IdKhangDu,
                IdDmKhoanphi, IdDmKhoanphiDu, IdDmTudo1, IdDmTudo1Du,
                IdDmTudo2, IdDmTudo2Du, IdDmTudo3, IdDmTudo3Du,
                IdDmTudo4, IdDmTudo4Du, IdDmTudo5, IdDmTudo5Du);

            ps_co = fn_ps_cn("C", MaTk, MaTkDu, TuNgay, DenNgay, 2,
                DonviId, MaNte,
                IdHopDong, IdHopDongDu, IdPtqt, IdPtqtDu,
                IdPhongban, IdPhongbanDu, IdVuviec, IdVuviecDu, IdKhang, IdKhangDu,
                IdDmKhoanphi, IdDmKhoanphiDu, IdDmTudo1, IdDmTudo1Du,
                IdDmTudo2, IdDmTudo2Du, IdDmTudo3, IdDmTudo3Du,
                IdDmTudo4, IdDmTudo4Du, IdDmTudo5, IdDmTudo5Du);

            IList<RpLedgerS06DetailDTO> pscn = new List<RpLedgerS06DetailDTO>();
            pscn = UnionPsNoCo(ps_no, ps_co);

            Decimal so_du = 0;
            foreach (RpLedgerS06DetailDTO cn in pscn)
            {
                if (cn.DuCoCk > 0)
                    so_du += cn.DuCoCk;
            }
            return so_du;
        }

        private IList<RpLedgerS06DetailDTO> fn_ps_cn(String LoaiTk, String MaTk, String MaTkDu, DateTime TuNgay, DateTime DenNgay,
            Int16 Kieu,
            Guid DonviId, String MaNte,
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

            String TK = LoaiTk == "N" ? "No" : "Co";
            String TkDu = LoaiTk == "N" ? "Co" : "No";

            MaTk = String.IsNullOrEmpty(MaTk) ? "" : MaTk;
            MaTkDu = String.IsNullOrEmpty(MaTkDu) ? "" : MaTkDu;

            String[] arrTk = MaTk.Split(';');
            String[] arrTkDu = MaTkDu.Split(';');

            String dkTk = String.Empty;
            for (int i = 0; i <= arrTk.Length - 1; i++)
            {
                if (String.IsNullOrEmpty(arrTk[i])) continue;
                if (!String.IsNullOrEmpty(dkTk)) dkTk += " Or ";
                dkTk += String.Format("(MaTk{0} like :MaTk{1})", TK, i.ToString());
            }

            String dkTkDu = String.Empty;
            for (int i = 0; i <= arrTkDu.Length - 1; i++)
            {
                if (String.IsNullOrEmpty(arrTkDu[i])) continue;
                if (!String.IsNullOrEmpty(dkTkDu)) dkTkDu += " Or ";
                dkTkDu += String.Format("(MaTk{0} like :MaTkDu{1})", TkDu, i.ToString());
            }

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

            String SQL = (String.Format("select IdKhang{0} as KHangId, sum(SoTien) as Ps{0}Tk from BcKetoan ", TK)) +
                         " where 1 = 1 " +
                         KieuSQL +
                        "AND NgayCt <= :DenNgay " +
                        (TuNgay == DateTime.MinValue ? "" : "AND NgayCt >= :TuNgay ") +
                        (String.IsNullOrEmpty(MaTk) ? "" : "AND (" + dkTk + ") ") +
                        (String.IsNullOrEmpty(MaTkDu) ? "" : " AND ( " + dkTkDu + ")") +
                        "AND DonviId = :DonviId " +
                        (String.IsNullOrEmpty(MaNte) ? "" : "AND (MaNte = :MaNte)") +
                        (VnsCheck.IsNullGuid(IdKhang) ? "" : String.Format("AND (IdKhang{0} = :IdKhang) ", TK)) +
                        (VnsCheck.IsNullGuid(IdKhangDu) ? "" : String.Format("AND (IdKhang{0} = :IdKhangDu) ", TkDu)) +
                        (VnsCheck.IsNullGuid(IdHopDong) ? "" : String.Format("AND (IdHopDong{0} = :IdHopDong) ", TK)) +
                        (VnsCheck.IsNullGuid(IdHopDongDu) ? "" : String.Format("AND (IdHopDong{0} = :IdHopDongDu) ", TkDu)) +
                        (VnsCheck.IsNullGuid(IdPtqt) ? "" : String.Format("AND (IdPtqt{0} = :IdPtqt) ", TK)) +
                        (VnsCheck.IsNullGuid(IdPtqtDu) ? "" : String.Format("AND (IdPtqt{0} = :IdPtqtDu) ", TkDu)) +
                        (VnsCheck.IsNullGuid(IdPhongban) ? "" : String.Format("AND (IdPhongban{0} = :IdPhongban) ", TK)) +
                        (VnsCheck.IsNullGuid(IdPhongbanDu) ? "" : String.Format("AND (IdPhongban{0} = :IdPhongbanDu) ", TkDu)) +
                        (VnsCheck.IsNullGuid(IdVuviec) ? "" : String.Format("AND (IdVuviec{0} = :IdVuviec) ", TK)) +
                        (VnsCheck.IsNullGuid(IdVuviecDu) ? "" : String.Format("AND (IdVuviec{0} = :IdVuviecDu) ", TkDu)) +
                        (VnsCheck.IsNullGuid(IdDmTudo1) ? "" : String.Format("AND (IdDmTudo1{0} = :IdDmTudo1) ", TK)) +
                        (VnsCheck.IsNullGuid(IdDmTudo1Du) ? "" : String.Format("AND (IdDmTudo1{0} = :IdDmTudo1Du) ", TkDu)) +
                        (VnsCheck.IsNullGuid(IdDmTudo2) ? "" : String.Format("AND (IdDmTudo2{0} = :IdDmTudo2) ", TK)) +
                        (VnsCheck.IsNullGuid(IdDmTudo2Du) ? "" : String.Format("AND (IdDmTudo2{0} = :IdDmTudo2Du) ", TkDu)) +
                        (VnsCheck.IsNullGuid(IdDmTudo3) ? "" : String.Format("AND (IdDmTudo3{0} = :IdDmTudo3) ", TK)) +
                        (VnsCheck.IsNullGuid(IdDmTudo3Du) ? "" : String.Format("AND (IdDmTudo3{0} = :IdDmTudo3Du) ", TkDu)) +
                        (VnsCheck.IsNullGuid(IdDmTudo4) ? "" : String.Format("AND (IdDmTudo4{0} = :IdDmTudo4) ", TK)) +
                        (VnsCheck.IsNullGuid(IdDmTudo4Du) ? "" : String.Format("AND (IdDmTudo4{0} = :IdDmTudo4Du) ", TkDu)) +
                        (VnsCheck.IsNullGuid(IdDmTudo5) ? "" : String.Format("AND (IdDmTudo5{0} = :IdDmTudo5) ", TK)) +
                        (VnsCheck.IsNullGuid(IdDmTudo5Du) ? "" : String.Format("AND (IdDmTudo5{0} = :IdDmTudo5Du) ", TkDu)) +
                        (VnsCheck.IsNullGuid(IdDmKhoanphi) ? "" : String.Format("AND (IdDmKhoanphi{0} = :IdDmKhoanphi) ", TK)) +
                        (VnsCheck.IsNullGuid(IdDmKhoanphiDu) ? "" : String.Format("AND (IdDmKhoanphi{0} = :IdDmKhoanphiDu) ", TkDu)) +
                        (String.Format(" Group by IdKhang{0} ", TK));

            IQuery qbcketoan = NHibernateSession.CreateQuery(SQL);
            qbcketoan.SetParameter("DenNgay", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CEndOfDate(DenNgay));

            if (TuNgay != DateTime.MinValue) qbcketoan.SetParameter("TuNgay", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CStartOfDate(TuNgay));
            for (int i = 0; i <= arrTk.Length - 1; i++)
            {
                if (String.IsNullOrEmpty(arrTk[i])) continue;
                qbcketoan.SetParameter("MaTk" + i.ToString(), String.Format("{0}%", arrTk[i]));
            }

            if (!String.IsNullOrEmpty(MaTkDu))
            {
                for (int i = 0; i <= arrTkDu.Length - 1; i++)
                {
                    if (String.IsNullOrEmpty(arrTkDu[i])) continue;
                    qbcketoan.SetParameter("MaTkDu" + i.ToString(), String.Format("{0}%", arrTkDu[i]));
                }
            }

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

            qbcketoan.SetResultTransformer(Transformers.AliasToBean<RpLedgerS06DetailDTO>());
            IList<RpLedgerS06DetailDTO> lstPsChiTiet = qbcketoan.List<RpLedgerS06DetailDTO>();

            return lstPsChiTiet;
        }

        private IList<RpLedgerS06DetailDTO> UnionPsNoCo(IList<RpLedgerS06DetailDTO> ps_no,IList<RpLedgerS06DetailDTO> ps_co )
        {
            IList<RpLedgerS06DetailDTO> pscn = new List<RpLedgerS06DetailDTO>();

            foreach (RpLedgerS06DetailDTO rpno in ps_no)
            {
                pscn.Add(rpno);
            }

            foreach (RpLedgerS06DetailDTO rpco in ps_co)
            {
                Boolean HasExist = false;
                foreach (RpLedgerS06DetailDTO rpcn in pscn)
                {
                    if (rpcn.KHangId == rpco.KHangId)
                    {
                        rpcn.PsCoTk = rpco.PsCoTk;
                        HasExist = true;
                        break;
                    }
                }

                if (!HasExist)
                {
                    pscn.Add(rpco);
                }
            }

            return pscn;
        }
        #endregion
    }
}
