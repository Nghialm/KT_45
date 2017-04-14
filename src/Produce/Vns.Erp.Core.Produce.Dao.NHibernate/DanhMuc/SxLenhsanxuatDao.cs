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
        public IList<SxLenhsanxuat> LoadByPhanCongId(Guid PhanCongId)
        {
            String sql = "from SxLenhsanxuat lsx where lsx.PhancongId =:PhanCongId";
            IQuery q = Session.CreateQuery(sql);
            q.SetParameter("PhanCongId", PhanCongId);
            return q.List<SxLenhsanxuat>();
        }

        public IList<SxLenhsanxuat> LoadByToSanXuat(Guid ToSanXuatId)
        {
            String sql = "from SxLenhsanxuat lsx where lsx.TosanxuatId =:ToSanXuatId";
            IQuery q = Session.CreateQuery(sql);
            q.SetParameter("ToSanXuatId", ToSanXuatId);
            return q.List<SxLenhsanxuat>();
        }

        public IList<SxLenhsanxuat> GetbyDonviId(Guid DonviId)
        {
            String sql = "from SxLenhsanxuat lsx where lsx.DonviId =:DonviId";
            IQuery q = Session.CreateQuery(sql);
            q.SetParameter("DonviId", DonviId);
            return q.List<SxLenhsanxuat>();
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
