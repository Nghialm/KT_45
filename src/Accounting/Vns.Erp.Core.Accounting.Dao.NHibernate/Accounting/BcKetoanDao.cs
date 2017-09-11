
using System;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using Vns.Erp.Core.Dao.NHibernate.Util;
using NHibernate;
using NHibernate.Criterion;
using System.Collections.Generic;
namespace Vns.Erp.Core.Accounting.Dao.NHibernate
{
	[Serializable]
	public sealed class BcKetoanDao:GenericDao<BcKetoan,System.Guid>,IBcKetoanDao
	{
        #region IDao
        BcKetoan IDao<BcKetoan, Guid>.Merge(BcKetoan entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Merge(entity);

            return entity;
        }

        BcKetoan IDao<BcKetoan, Guid>.Save(BcKetoan entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Save(entity);

            return entity;
        }

        BcKetoan IDao<BcKetoan, Guid>.SaveOrUpdate(BcKetoan entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.SaveOrUpdate(entity);

            return entity;
        }
        #endregion

        public Boolean DeleteByChungTu(Guid CtHId, Guid CtDId)
        {
            Decimal LoaiNghiepVu = -1;
            return DeleteByBcKeToanKho(CtHId, CtDId, LoaiNghiepVu);
        }

        public Boolean DeleteByLoaiCt(Guid IdLoaiCt, DateTime TuNgay, DateTime DenNgay)
        {
            String sql = " delete from BcKetoan a where " +
                         " a.IdLoaiCt=:IdLoaiCt" +
                         " And a.NgayCt <= :DenNgay and a.NgayCt >= :TuNgay";

            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("IdLoaiCt", IdLoaiCt);
            q.SetParameter("TuNgay", TuNgay);
            q.SetParameter("DenNgay", DenNgay);
            int i = q.ExecuteUpdate();

            return true;
        }

        public Boolean DeleteByBcKeToanKho(Guid CtHId, Guid CtDId, Decimal LoaiNghiepVu)
        {
            String sql = " delete from BcKetoan a where " +
                         " (a.CthId=:CthId) " +
                         (VnsCheck.IsNullGuid(CtDId) ? "" : " and (a.CtdId=:CtDId) and ") +
                         (LoaiNghiepVu == -1? "" : " and (a.LoaiNghiepVu=:LoaiNghiepVu)");

            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("CthId", CtHId);
            if (!VnsCheck.IsNullGuid(CtDId)) q.SetParameter("CtDId", CtDId);
            if (LoaiNghiepVu != -1) q.SetParameter("LoaiNghiepVu", LoaiNghiepVu);
            int i = q.ExecuteUpdate();

            return true;
        }

        public BcKetoan GetBy(Guid CtHId, Guid CtDId, Decimal LoaiNghiepVu)
        {
            String sql = " Select a from BcKetoan a where 1 = 1 and " +
                (VnsCheck.IsNullGuid(CtHId) ? "" : " (a.CthId=:CthId) and ") +
                (VnsCheck.IsNullGuid(CtDId)? "" : " (a.CtdId=:CtDId) and ") +
                (LoaiNghiepVu == -1 ? "" : " (a.LoaiNghiepVu=:LoaiNghiepVu)");
            
            IQuery q = NHibernateSession.CreateQuery(sql);
            if (!VnsCheck.IsNullGuid(CtHId)) q.SetParameter("CthId", CtHId);
            if (!VnsCheck.IsNullGuid(CtDId)) q.SetParameter("CtDId", CtDId);
            if (LoaiNghiepVu != -1) q.SetParameter("LoaiNghiepVu", LoaiNghiepVu);

            IList<BcKetoan> lst = q.List<BcKetoan>();
            if (lst.Count > 0) return lst[0];
            else return null;
        }

        public IList< BcKetoan> SearchBy(int PageIndex, int PageSize, Guid ID_Loai_CT,
                Decimal So_Tien_Tu, Decimal So_Tien_Den,
                string ma_taikhoan,
                string ma_taikhoan_du,
                DateTime ngay_dau_ky,
                DateTime ngay_cuoi_ky,
                Guid donvi_id,
                string ma_nte,
                string ma_hopdong,
                string ma_hopdong_du,
                string ma_ptqt,
                string ma_ptqt_du,
                string ma_phongban,
                string ma_phongban_du,
                Guid id_vuviec,
                Guid id_vuviec_du,
                Guid id_khang,
                Guid id_khang_du,
                Guid id_dm_tudo_1,
                Guid id_dm_tudo_1_du,
                Guid id_dm_tudo_2,
                Guid id_dm_tudo_2_du,
                Guid id_dm_tudo_3,
                Guid id_dm_tudo_3_du,
                Guid id_dm_tudo_4,
                Guid id_dm_tudo_4_du,
                Guid id_dm_tudo_5,
                Guid id_dm_tudo_5_du, out int totalResult)
        {
            ICriteria isearch = NHibernateSession.CreateCriteria<BcKetoan>();
            ICriteria iCount = NHibernateSession.CreateCriteria<BcKetoan>();
            isearch.Add(Restrictions.Eq("DonviId", donvi_id));

            if (!VnsCheck.IsNullGuid(ID_Loai_CT))
            {
                isearch.Add(Restrictions.Eq("IdLoaiCt", ID_Loai_CT));
                iCount.Add(Restrictions.Eq("IdLoaiCt", ID_Loai_CT));
            }

            if (So_Tien_Den >= 0)
            {
                isearch.Add(Restrictions.Le("SoTien", So_Tien_Den));
                iCount.Add(Restrictions.Le("SoTien", So_Tien_Den)); 
            }

            if (So_Tien_Tu >= 0)
            {
                isearch.Add(Restrictions.Ge("SoTien", So_Tien_Tu));
                iCount.Add(Restrictions.Ge("SoTien", So_Tien_Tu));
            }

            if (ngay_dau_ky != Null.NULL_DATE)
            {
                isearch.Add(Restrictions.Ge("NgayCt", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CStartOfDate(ngay_dau_ky)));
                iCount.Add(Restrictions.Ge("NgayCt", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CStartOfDate(ngay_dau_ky)));
            }

            if (ngay_cuoi_ky != Null.NULL_DATE)
            {
                isearch.Add(Restrictions.Le("NgayCt", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CEndOfDate(ngay_cuoi_ky)));
                iCount.Add(Restrictions.Le("NgayCt", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CEndOfDate(ngay_cuoi_ky)));
            }

            if (!string.IsNullOrEmpty(ma_nte))
            {
                isearch.Add(Restrictions.Eq("MaNte", ma_nte));
                iCount.Add(Restrictions.Eq("MaNte", ma_nte));
            }

            if (!string.IsNullOrEmpty(ma_hopdong))
            {
                isearch.Add(Restrictions.Eq("MaHopdongNo", ma_hopdong));
                iCount.Add(Restrictions.Eq("MaHopdongNo", ma_hopdong));
            }

            if (!string.IsNullOrEmpty(ma_hopdong_du))
            {
                isearch.Add(Restrictions.Eq("MaHopdongCo", ma_hopdong_du));
                iCount.Add(Restrictions.Eq("MaHopdongCo", ma_hopdong_du));
            }

            if (!string.IsNullOrEmpty(ma_ptqt))
            {
                isearch.Add(Restrictions.Eq("MaPtqtNo", ma_ptqt));
                iCount.Add(Restrictions.Eq("MaPtqtNo", ma_ptqt));
            }

            if (!string.IsNullOrEmpty(ma_ptqt_du))
            {
                isearch.Add(Restrictions.Eq("MaPtqtCo", ma_ptqt_du));
                iCount.Add(Restrictions.Eq("MaPtqtCo", ma_ptqt_du));
            }

            if (!string.IsNullOrEmpty(ma_phongban))
            {
                isearch.Add(Restrictions.Eq("MaPhongbanNo", ma_phongban));
                iCount.Add(Restrictions.Eq("MaPhongbanNo", ma_phongban));
            }

            if (!string.IsNullOrEmpty(ma_phongban_du))
            {
                isearch.Add(Restrictions.Eq("MaPhongbanCo", ma_phongban_du));
                iCount.Add(Restrictions.Eq("MaPhongbanCo", ma_phongban_du));
            }

            if (!VnsCheck.IsNullGuid(id_vuviec))
            {
                isearch.Add(Restrictions.Eq("IdVuviecNo", id_vuviec));
                iCount.Add(Restrictions.Eq("IdVuviecNo", id_vuviec));
            }

            if (!VnsCheck.IsNullGuid(id_vuviec_du))
            {
                isearch.Add(Restrictions.Eq("IdVuviecCo", id_vuviec_du));
                iCount.Add(Restrictions.Eq("IdVuviecCo", id_vuviec_du));
            }

            if (!VnsCheck.IsNullGuid(id_dm_tudo_1))
            {
                isearch.Add(Restrictions.Eq("IdDmTudo1No", id_dm_tudo_1));
                iCount.Add(Restrictions.Eq("IdDmTudo1No", id_dm_tudo_1));
            }

            if (!VnsCheck.IsNullGuid(id_dm_tudo_1_du))
            {
                isearch.Add(Restrictions.Eq("IdDmTudo1Co", id_dm_tudo_1_du));
                iCount.Add(Restrictions.Eq("IdDmTudo1Co", id_dm_tudo_1_du));
            }

            if (!VnsCheck.IsNullGuid(id_dm_tudo_2))
            {
                isearch.Add(Restrictions.Eq("IdDmTudo2No", id_dm_tudo_2));
                iCount.Add(Restrictions.Eq("IdDmTudo2No", id_dm_tudo_2));
            }

            if (!VnsCheck.IsNullGuid(id_dm_tudo_2_du))
            {
                isearch.Add(Restrictions.Eq("IdDmTudo2Co", id_dm_tudo_2_du));
                iCount.Add(Restrictions.Eq("IdDmTudo2Co", id_dm_tudo_2_du));
            }

            if (!VnsCheck.IsNullGuid(id_dm_tudo_3))
            {
                isearch.Add(Restrictions.Eq("IdDmTudo3No", id_dm_tudo_3));
                iCount.Add(Restrictions.Eq("IdDmTudo3No", id_dm_tudo_3));
            }

            if (!VnsCheck.IsNullGuid(id_dm_tudo_3_du))
            {
                isearch.Add(Restrictions.Eq("IdDmTudo3Co", id_dm_tudo_3_du));
                iCount.Add(Restrictions.Eq("IdDmTudo3Co", id_dm_tudo_3_du));
            }

            if (!VnsCheck.IsNullGuid(id_dm_tudo_4))
            {
                isearch.Add(Restrictions.Eq("IdDmTudo4No", id_dm_tudo_4));
                iCount.Add(Restrictions.Eq("IdDmTudo4No", id_dm_tudo_4));
            }

            if (!VnsCheck.IsNullGuid(id_dm_tudo_4_du))
            {
                isearch.Add(Restrictions.Eq("IdDmTudo4Co", id_dm_tudo_4_du));
                iCount.Add(Restrictions.Eq("IdDmTudo4Co", id_dm_tudo_4_du));
            }

            if (!VnsCheck.IsNullGuid(id_dm_tudo_5))
            {
                isearch.Add(Restrictions.Eq("IdDmTudo5No", id_dm_tudo_5));
                iCount.Add(Restrictions.Eq("IdDmTudo5No", id_dm_tudo_5));
            }

            if (!VnsCheck.IsNullGuid(id_dm_tudo_5_du))
            {
                isearch.Add(Restrictions.Eq("IdDmTudo5Co", id_dm_tudo_5_du));
                iCount.Add(Restrictions.Eq("IdDmTudo5Co", id_dm_tudo_5_du));
            }

            if (!VnsCheck.IsNullGuid(id_khang))
            {
                isearch.Add(Restrictions.Eq("IdKhangNo", id_khang));
                iCount.Add(Restrictions.Eq("IdKhangNo", id_khang));
            }

            if (!VnsCheck.IsNullGuid(id_khang_du))
            {
                isearch.Add(Restrictions.Eq("IdKhangCo", id_khang_du));
                iCount.Add(Restrictions.Eq("IdKhangCo", id_khang_du));
            }

            ma_taikhoan = string.IsNullOrEmpty(ma_taikhoan) ? "": ma_taikhoan;
            String[] arrMaTk  =  ma_taikhoan.Split(';');
            Disjunction resMaTk = new Disjunction();
            for (int i =0; i < arrMaTk.Length ; i++)
            {
                if (String.IsNullOrEmpty(arrMaTk[i])) continue;
                resMaTk.Add(Restrictions.Like("MaTkNo", arrMaTk[i], MatchMode.Start));
                resMaTk.Add(Restrictions.Like("MaTkCo", arrMaTk[i], MatchMode.Start));
            }

            if (!string.IsNullOrEmpty(ma_taikhoan))
            {
                isearch.Add(resMaTk);
                iCount.Add(resMaTk);
            }
            ma_taikhoan_du = string.IsNullOrEmpty(ma_taikhoan_du) ? "" : ma_taikhoan_du;
            String[] arrMaTkDu = ma_taikhoan_du.Split(';');
            Disjunction resMaTkDu = new Disjunction();
            for (int i = 0; i < arrMaTkDu.Length; i++)
            {
                if (String.IsNullOrEmpty(arrMaTkDu[i])) continue;
                resMaTkDu.Add(Restrictions.Like("MaTkCo", arrMaTkDu[i], MatchMode.Start));
                resMaTkDu.Add(Restrictions.Like("MaTkNo", arrMaTkDu[i], MatchMode.Start));
            }
            if (!string.IsNullOrEmpty(ma_taikhoan_du))
            {
                isearch.Add(resMaTkDu);
                iCount.Add(resMaTkDu);
            }

            isearch.AddOrder(new Order("NgayCt", true));
            iCount.SetProjection(Projections.Count(Projections.Id()));
            totalResult = (int)iCount.UniqueResult();
            if ((PageIndex > 0) && (PageSize > 0))
            {
                isearch.SetFirstResult((PageIndex - 1) * PageSize);
                isearch.SetMaxResults(PageSize);
            }            
            return isearch.List<BcKetoan>();
        }
    }
}
