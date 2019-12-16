
using System;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using NHibernate;
using System.Collections.Generic;
using NHibernate.Criterion;
namespace Vns.Erp.Core.Accounting.Dao.NHibernate
{
    [Serializable]
    public sealed class BcKetoanKhoDao : GenericDao<BcKetoanKho, System.Guid>, IBcKetoanKhoDao
    {
        #region IDao
        BcKetoanKho IDao<BcKetoanKho, Guid>.Merge(BcKetoanKho entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Merge(entity);

            return entity;
        }

        BcKetoanKho IDao<BcKetoanKho, Guid>.Save(BcKetoanKho entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Save(entity);

            return entity;
        }

        BcKetoanKho IDao<BcKetoanKho, Guid>.SaveOrUpdate(BcKetoanKho entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.SaveOrUpdate(entity);

            return entity;
        }
        #endregion

        /// <summary>
        /// Delete BcKetoanKho by Chung tu kho
        /// </summary>
        /// <param name="CthNxId"></param>
        /// <param name="CtdNxId"></param>
        /// <returns></returns>
        public Boolean DeleteByChungTu(Guid CthNxId, Guid CtdNxId)
        {
            String sql = " delete from BcKetoanKho a where 1 = 1" +
                (VnsCheck.IsNullGuid(CthNxId) ? "" : " And a.CthNxId=:CthNxId ") +
                (VnsCheck.IsNullGuid(CtdNxId) ? "" : " And a.CtdNxId=:CtdNxId ");

            IQuery q = NHibernateSession.CreateQuery(sql);
            if (!VnsCheck.IsNullGuid(CthNxId)) q.SetParameter("CthNxId", CthNxId);
            if (!VnsCheck.IsNullGuid(CtdNxId)) q.SetParameter("CtdNxId", CtdNxId);
            int i = q.ExecuteUpdate();

            return true;
        }

        public IList<BcKetoanKho> GetNhap4FIFO(DateTime TuNgay, DateTime DenNgay, Guid HanghoaId, Guid KhoId, Guid DonviId)
        {
            ICriteria isearch = NHibernateSession.CreateCriteria<BcKetoanKho>();

            isearch.Add(Restrictions.Eq("DonviId", DonviId));

            isearch.Add(Restrictions.Le("NgayCt", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CEndOfDate(DenNgay)));
            isearch.Add(Restrictions.Eq("HanghoaId", HanghoaId));
            isearch.Add(Restrictions.Eq("KhoNhapId", KhoId));
            //isearch.Add(Restrictions.Gt("DuLuong", 0));

            isearch.AddOrder(new Order("NgayCt", true));
            return isearch.List<BcKetoanKho>();
        }

        public IList<BcKetoanKho> GetBy(DateTime TuNgay, DateTime DenNgay, Guid HanghoaId, Guid KhoId, Guid DonviId, Boolean XuatKho)
        {
            ICriteria isearch = NHibernateSession.CreateCriteria<BcKetoanKho>();

            isearch.Add(Restrictions.Eq("DonviId", DonviId));
            if (TuNgay != Null.NULL_DATE)
            {
                isearch.Add(Restrictions.Ge("NgayCt", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CStartOfDate(TuNgay)));
            }

            if (DenNgay != Null.NULL_DATE)
            {
                isearch.Add(Restrictions.Le("NgayCt", Vns.Erp.Core.Dao.NHibernate.Util.VnsConvert.CEndOfDate(DenNgay)));
            }
            isearch.Add(Restrictions.Eq("HanghoaId", HanghoaId));

            if (XuatKho)
                isearch.Add(Restrictions.Eq("KhoXuatId", KhoId));
            else
                isearch.Add(Restrictions.Eq("KhoNhapId", KhoId));

            isearch.AddOrder(new Order("NgayCt", true));

            return isearch.List<BcKetoanKho>();
        }

        public void UpdateGiaXuat(BcKetoanKho tmp)
        {
            String SQuery = "Update BcKetoanKho Set GiaVon = :GiaVon, DonGiaVon = :DonGiaVon " +
                "Where CthNxId = :CthNxId and CtdNxId = :CtdNxId";

            IQuery q = NHibernateSession.CreateQuery(SQuery);
            q.SetParameter("GiaVon", tmp.GiaVon);
            q.SetParameter("DonGiaVon", tmp.DonGiaVon);
            q.SetParameter("CthNxId", tmp.CthNxId);
            q.SetParameter("CtdNxId", tmp.CtdNxId);

            int i = q.ExecuteUpdate();
        }

        public IList<BcKetoanKho> SearchBy(Guid ID_Loai_CT,
               Decimal So_Tien_Tu, Decimal So_Tien_Den,
               string ma_taikhoan,
               string ma_taikhoan_du,
               DateTime ngay_dau_ky,
               DateTime ngay_cuoi_ky,
               Guid donvi_id,
               string ma_nte,
               string ma_hopdong, string ma_hopdong_du,
               string ma_ptqt, string ma_ptqt_du,
               string ma_phongban, string ma_phongban_du,
               Guid id_vuviec, Guid id_vuviec_du,
               Guid id_khang, Guid id_khang_du,
               Guid id_dm_tudo_1, Guid id_dm_tudo_1_du,
               Guid id_dm_tudo_2, Guid id_dm_tudo_2_du,
               Guid id_dm_tudo_3, Guid id_dm_tudo_3_du,
               Guid id_dm_tudo_4, Guid id_dm_tudo_4_du,
               Guid id_dm_tudo_5, Guid id_dm_tudo_5_du)
        {
            ICriteria isearch = NHibernateSession.CreateCriteria<BcKetoanKho>();
            isearch.Add(Restrictions.Eq("DonviId", donvi_id));

            isearch.AddOrder(new Order("NgayCt", true));
            return isearch.List<BcKetoanKho>();
        }

    }
}
