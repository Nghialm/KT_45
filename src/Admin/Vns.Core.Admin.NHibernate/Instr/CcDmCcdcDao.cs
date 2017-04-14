
using System;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using System.Collections.Generic;
using System.Collections;
using NHibernate;
namespace Vns.Erp.Core.Admin.Dao.NHibernate
{
	[Serializable]
	public sealed class CcDmCcdcDao:GenericDao<CcDmCcdc,System.Guid>,ICcDmCcdcDao
	{
        public IList<CcDmCcdc> GetAllByDonviID(Guid DonviId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("DonviId");
            values.Add(DonviId);
            return List(-1, -1, props, values, null);
        }

        public IList<CcDmCcdc> GetByMaCCDC(string  MaCcdc)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("MaCcdc");
            values.Add(MaCcdc);
            return List(-1, -1, props, values, null);
        }

        public void UpdateGiamCcdc(Guid CcdcId, Decimal GiamCcdc)
        {
            String sql = "Update CcDmCcdc Set GiamCcdc =:GiamCcdc Where Id = :CcdcId";

            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("Id", CcdcId);
            q.SetParameter("GiamCcdc", GiamCcdc);
            q.ExecuteUpdate();
        } 
    }
}
