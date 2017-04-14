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
using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Dao.Util;
using System.Collections;

namespace Vns.Erp.Core.Accounting.Report.Dao.NHibernate
{
    public class RpLedgerAssetDao : GenericDao<BcKetoan, System.Guid>, IRpLedgerAssetDao
    {
        public DataTable GetBangTinhKhauHao(DateTime TuNgay, DateTime DenNgay, Guid DonviId)
        {
            IList<CtTscd> lstTscd = new List<CtTscd>();
            IList<RpLedgerAssetDnDTO> lstAsset = new List<RpLedgerAssetDnDTO>();

            IQuery qbc_tk = NHibernateSession.CreateQuery("Select b from DmTscd a inner join a.LstCtTscd b where a.DonviId = :DonviId Order by b.Id");
            qbc_tk.SetParameter("DonviId", DonviId);
            lstTscd = qbc_tk.List<CtTscd>();

            Decimal Nam = DenNgay.Year;
            //String sqlKhauHao = "Select Thang as Thang, Nam as Nam, CtTscdId as CtTscdId, Sum(HaoMonThang) as HaoMonThang, Max(HaoMonLk) as HaoMonLk from TsLsKhauhao " +
            String sqlKhauHao = "Select Thang as Thang, Nam as Nam, CtTscdId as CtTscdId, HaoMonThang as HaoMonThang, HaoMonLk as HaoMonLk from TsLsKhauhao " +
                 " Where BaoCao = 1 " +
                 " and NgayKhauHao >= :TuNgay " +
                 " and NgayKhauHao <= :DenNgay " +
                 " and DonviId = :DonviId " +
                 //" Group by CtTscdId " +
                 " Order by Thang, Nam, CtTscdId ";

            IQuery qbc_kh = NHibernateSession.CreateQuery(sqlKhauHao);
            qbc_kh.SetParameter("TuNgay", VnsConvert.CStartOfDate(TuNgay));
            qbc_kh.SetParameter("DenNgay", VnsConvert.CEndOfDate(DenNgay));
            qbc_kh.SetParameter("DonviId", DonviId);
            qbc_kh.SetResultTransformer(Transformers.AliasToBean<RpLedgerAssetDnDTO>());
            IList<RpLedgerAssetDnDTO> lstKhauHao = qbc_kh.List<RpLedgerAssetDnDTO>();

            foreach (RpLedgerAssetDnDTO tmp in lstKhauHao)
            {
                foreach (CtTscd tmpCt in lstTscd)
                {
                    if (tmp.CtTscdId == tmpCt.Id)
                    {
                        tmp.DmTscdId = tmpCt.TscdId;
                        tmp.MaTscd = tmpCt.MaTscd;
                        tmp.TenTscd = tmpCt.ObjDmTscd.TenTscd;
                        tmp.NgayBdKh = tmpCt.NgayBdKh.Value;
                        tmp.NguyenGia = tmpCt.NguyenGia;
                        tmp.MaLoaiTs = tmpCt.ObjDmTscd.MaLoaitaisan;
                        tmp.TenLoaiTs = tmpCt.ObjDmTscd.TenLoaitaisan;
                    }
                }
            }

            DataTable dt = DBUtil.ToDataTable<RpLedgerAssetDnDTO>(lstKhauHao);
            //dt.DefaultView.Sort = "Nhom, NgayCt";
            return dt;
        }

        public DataTable GetTheTscd(Guid TscdId)
        {
            IList<CtTscd> lstTscd = new List<CtTscd>();
            IList<RpLedgerAssetDnDTO> lstAsset = new List<RpLedgerAssetDnDTO>();

            IQuery qbc_tk = NHibernateSession.CreateQuery("Select a from CtTscd a where TscdId = :TscdId");
            qbc_tk.SetParameter("TscdId", TscdId);
            lstTscd = qbc_tk.List<CtTscd>();

            String sqlKhauHao = "Select CtTscdId as CtTscdId, Nam as Nam, Sum(HaoMonThang) as HaoMonThang from TsLsKhauhao " +
                 " Where BaoCao = 1 " +
                 " and DmTscdId = :TscdId " +
                 " Group by Nam, CtTscdId " +
                 " Order by CtTscdId ";

            IQuery qbc_kh = NHibernateSession.CreateQuery(sqlKhauHao);
            qbc_kh.SetParameter("TscdId", TscdId);
            qbc_kh.SetResultTransformer(Transformers.AliasToBean<RpLedgerAssetDnDTO>());
            IList<RpLedgerAssetDnDTO> lstKhauHao = qbc_kh.List<RpLedgerAssetDnDTO>();

            foreach (RpLedgerAssetDnDTO tmp in lstKhauHao)
            {
                foreach (CtTscd tmpCt in lstTscd)
                {
                    if (tmp.CtTscdId == tmpCt.Id)
                    {
                        tmp.DmTscdId = tmpCt.TscdId;
                        tmp.MaTscd = tmpCt.MaTscd;
                        tmp.TenTscd = tmpCt.TenTscd;
                        tmp.NgayBdKh = tmpCt.NgayBdKh.Value;
                        tmp.NguyenGia = tmpCt.NguyenGia;
                        //tmp.MucKhauHao = tmpCt.HaoMonThang;
                    }
                }
            }

            DataTable dt = DBUtil.ToDataTable<RpLedgerAssetDnDTO>(lstKhauHao);
            //dt.DefaultView.Sort = "Nhom, NgayCt";
            return dt;
        }

        public DataTable GetSoTscdS21(DateTime TuNgay, DateTime DenNgay, Guid DonviId)
        {
            IList<CtTscd> lstTscd = new List<CtTscd>();
            IList<RpLedgerAssetDnDTO> lstAsset = new List<RpLedgerAssetDnDTO>();

            IQuery qbc_tk = NHibernateSession.CreateQuery("Select b from DmTscd a inner join a.LstCtTscd b where a.DonviId = :DonviId Order by b.NgayCt");
            qbc_tk.SetParameter("DonviId", DonviId);
            lstTscd = qbc_tk.List<CtTscd>();

            Decimal Nam = DenNgay.Year;
            String sqlKhauHao = "Select CtTscdId as CtTscdId, Sum(HaoMonThang) as HaoMonThang, Max(HaoMonLk) as HaoMonLk from TsLsKhauhao " +
                 " Where BaoCao = 1 " +
                 " and NgayKhauHao >= :TuNgay " +
                 " and NgayKhauHao <= :DenNgay " +
                 " and DonviId = :DonviId " +
                 " Group by CtTscdId " +
                 " Order by CtTscdId ";

            IQuery qbc_kh = NHibernateSession.CreateQuery(sqlKhauHao);
            qbc_kh.SetParameter("TuNgay", VnsConvert.CStartOfDate(TuNgay));
            qbc_kh.SetParameter("DenNgay", VnsConvert.CEndOfDate(DenNgay));
            qbc_kh.SetParameter("DonviId", DonviId);
            qbc_kh.SetResultTransformer(Transformers.AliasToBean<RpLedgerAssetDnDTO>());
            IList<RpLedgerAssetDnDTO> lstKhauHao = qbc_kh.List<RpLedgerAssetDnDTO>();

            foreach (RpLedgerAssetDnDTO tmp in lstKhauHao)
            {
                foreach (CtTscd tmpCt in lstTscd)
                {
                    if (tmp.CtTscdId == tmpCt.Id)
                    {
                        tmp.DmTscdId = tmpCt.TscdId;
                        tmp.MaTscd = tmpCt.MaTscd;
                        tmp.TenTscd = tmpCt.TenTscd;
                        tmp.NgayBdKh = tmpCt.NgayBdKh.Value;
                        tmp.NguyenGia = tmpCt.NguyenGia;
                        tmp.SoCt = tmpCt.SoCt;
                        tmp.NgayCt = tmpCt.NgayCt.Value;
                        tmp.NgayBdKh = tmpCt.NgayBdKh.Value;
                        tmp.NgayKtKh = tmpCt.NgayKtKh.Value;
                        tmp.TangTscd = tmpCt.TangTscd;
                        tmp.SoThangSd = tmpCt.SoThangSd;
                        tmp.KyHieu = tmpCt.KyHieuTscd;
                        tmp.NuocSx = tmpCt.ObjDmTscd.NuocSx;
                    }
                }
            }

            DataTable dt = DBUtil.ToDataTable<RpLedgerAssetDnDTO>(lstKhauHao);
            //dt.DefaultView.Sort = "Nhom, NgayCt";
            return dt;
        }
    }
}
