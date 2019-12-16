using System;
using Vns.Erp.Core.Produce.Domain;
using Vns.Erp.Core.Produce.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using System.Collections.Generic;
using NHibernate;

namespace Vns.Erp.Core.Produce.Dao.NHibernate
{
	[Serializable]
	public sealed class SxLenhsanxuatDao:GenericDao<SxLenhsanxuat,System.Guid>,ISxLenhsanxuatDao
	{
        public IList<SxLenhsanxuat> LoadByPhanCongId(int PageIndex, int PageSize, Guid PhanCongId, Guid DonviId, out int TotalResult)
        {
            String sql = "from SxLenhsanxuat h where h.PhancongId =:PhanCongId and h.DonviId = :DonviId";
            String countsql = "select count(h) from SxLenhsanxuat h where h.PhancongId =:PhanCongId  and h.DonviId = :DonviId";

            IQuery query = Session.CreateQuery(sql);
            IQuery countQuery = Session.CreateQuery(countsql);

            query.SetParameter("PhanCongId", PhanCongId);
            query.SetParameter("DonviId", DonviId);

            countQuery.SetParameter("PhanCongId", PhanCongId);
            countQuery.SetParameter("DonviId", DonviId);

            if ((PageIndex > 0) && (PageSize > 0))
            {
                int startRescord = (PageIndex - 1) * PageSize;
                query.SetFirstResult(startRescord);
                query.SetMaxResults(PageSize);
            }
            long numberRet = (long)countQuery.UniqueResult();
            TotalResult = (int)numberRet;
            return query.List<SxLenhsanxuat>();
        }

        public IList<SxLenhsanxuat> LoadByToSanXuat(Guid ToSanXuatId)
        {
            String sql = "from SxLenhsanxuat lsx where lsx.TosanxuatId =:ToSanXuatId";
            IQuery q = Session.CreateQuery(sql);
            q.SetParameter("ToSanXuatId", ToSanXuatId);
            return q.List<SxLenhsanxuat>();
        }

        public IList<SxLenhsanxuat> GetbyDonviId(int PageIndex, int PageSize, Guid DonviId, out int TotalResult)
        {
            String sql = "from SxLenhsanxuat h where h.DonviId = :DonviId";
            String countsql = "select count(h) from SxLenhsanxuat h where h.DonviId = :DonviId";

            IQuery query = Session.CreateQuery(sql);
            IQuery countQuery = Session.CreateQuery(countsql);

            query.SetParameter("DonviId", DonviId);

            countQuery.SetParameter("DonviId", DonviId);

            if ((PageIndex > 0) && (PageSize > 0))
            {
                int startRescord = (PageIndex - 1) * PageSize;
                query.SetFirstResult(startRescord);
                query.SetMaxResults(PageSize);
            }
            long numberRet = (long)countQuery.UniqueResult();
            TotalResult = (int)numberRet;
            return query.List<SxLenhsanxuat>();
        }

        public IList<SxLenhsanxuat> GetbyDonviId(Guid DonviId)
        {
            String sql = "from SxLenhsanxuat h where h.DonviId = :DonviId";

            IQuery query = Session.CreateQuery(sql);

            query.SetParameter("DonviId", DonviId);

            return query.List<SxLenhsanxuat>();
        }


        #region Implement Interface
        SxLenhsanxuat IDao<SxLenhsanxuat, Guid>.Save(SxLenhsanxuat entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Save(entity);
            return entity;
        }

        SxLenhsanxuat IDao<SxLenhsanxuat, Guid>.SaveOrUpdate(SxLenhsanxuat entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.SaveOrUpdate(entity);
            return entity;
        }

        SxLenhsanxuat IDao<SxLenhsanxuat, Guid>.Merge(SxLenhsanxuat entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Merge(entity);
            return entity;
        }
        #endregion
    }
}
