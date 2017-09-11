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
	public sealed class DmNhomKhangDao:GenericDao<DmNhomKhang,Guid>,IDmNhomKhangDao
	{
        #region IDao
        DmNhomKhang IDao<DmNhomKhang, Guid>.Merge(DmNhomKhang entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Merge(entity);

            return entity;
        }

        DmNhomKhang IDao<DmNhomKhang, Guid>.Save(DmNhomKhang entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.Save(entity);

            return entity;
        }

        DmNhomKhang IDao<DmNhomKhang, Guid>.SaveOrUpdate(DmNhomKhang entity)
        {
            if (VnsCheck.IsNullGuid(entity.Id)) entity.Id = Guid.NewGuid();
            HibernateTemplate.SaveOrUpdate(entity);

            return entity;
        }
        #endregion

        public IList<DmNhomKhang> GetObjectAllByDonviID(Guid DonviId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("DonviId");
            values.Add(DonviId);
            return List(-1, -1, props, values, null);
        }
        public IList<DmNhomKhang> GetObjectByMa(string Ma)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("MaNhomKhang");
            values.Add(Ma);
            return List(-1, -1, props, values, null);

        }
	}
}