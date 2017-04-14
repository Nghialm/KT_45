using System;
using Vns.Erp.Core.Produce.Domain;
using Vns.Erp.Core.Produce.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using System.Collections.Generic;
using System.Collections;
using NHibernate;

namespace Vns.Erp.Core.Produce.Dao.NHibernate
{
	[Serializable]
	public sealed class SxDmQuytrinhDao:GenericDao<SxDmQuytrinh,System.Guid>,ISxDmQuytrinhDao
	{
        public IList<SxDmQuytrinh> GetByDonviId(Guid DonviId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("DonviId");
            values.Add(DonviId);
            return List(-1, -1, props, values, null);
        }

        public void DeleteAllByDonviId(Guid DonviId)
        {
            string sql = "Delete from SxDmQuytrinh a where a.DonviId= :DonviId ";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("DonviId", DonviId);

            q.ExecuteUpdate();
        }
	}
}
