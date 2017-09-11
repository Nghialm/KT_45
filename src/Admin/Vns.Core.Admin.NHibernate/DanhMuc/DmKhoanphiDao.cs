/*
insert license info here
*/
using System;
using NHibernate;
using NHibernate.Cfg;
using Nullables;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Collections.Generic;
using Vns.Erp.Core.Dao.NHibernate;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Dao;
using Spring.Transaction.Interceptor;
namespace Vns.Erp.Core.Admin.Dao.NHibernate
{
	/// <summary>
	///	Generated by MyGeneration using the NHibernate Object Mapping adapted by Gustavo
	/// </summary>
	[Serializable]
	public sealed class DmKhoanphiDao:GenericDao<DmKhoanphi,Guid>,IDmKhoanphiDao
	{
        #region IDao
        DmKhoanphi IDao<DmKhoanphi, Guid>.Merge(DmKhoanphi entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Merge(entity);

            return entity;
        }

        DmKhoanphi IDao<DmKhoanphi, Guid>.Save(DmKhoanphi entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Save(entity);

            return entity;
        }

        DmKhoanphi IDao<DmKhoanphi, Guid>.SaveOrUpdate(DmKhoanphi entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.SaveOrUpdate(entity);

            return entity;
        }
        #endregion
        public int GetNumberDmKhoanphiByKyHieu(Guid DonviId, string KyHieu)
        {
            string sql = "select count(*) from DmKhoanphi a where a.KyHieu like (:KyHieu) and a.DonviId=:DonviId";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("KyHieu", KyHieu);
            q.SetParameter("DonviId", DonviId);
            long ret = q.UniqueResult<long>();
            return (int)ret;
        }
        public IList<DmKhoanphi>  GetAllByDonviID(Guid DonviId)
        {
            string sql = "from DmKhoanphi a where a.DonviId=:DonviId";
            IQuery q = NHibernateSession.CreateQuery(sql);            
            q.SetParameter("DonviId", DonviId);
            return q.List<DmKhoanphi>();
        }
	}
}