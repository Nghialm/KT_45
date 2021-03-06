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
	public sealed class DmVuviecDao:GenericDao<DmVuviec,Guid>,IDmVuviecDao
	{
        public int GetNumberVuViecByMaVuViec(string MaVuviec, Guid DonviId)
        {
            string sql = "select count(*) from DmVuviec a where a.MaVuviec=:MaVuviec and a.DonviId=:DonviId";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("MaVuviec", MaVuviec);
            q.SetParameter("DonviId", DonviId);
            
            long ret = q.UniqueResult<long>();
            return (int)ret;
        }
        public IList<DmVuviec> GetAllByDonviID(Guid DonviId)
        {
            string sql = "from DmVuviec a where a.DonviId=:DonviId";
            IQuery q = NHibernateSession.CreateQuery(sql);            
            q.SetParameter("DonviId", DonviId);
            return q.List<DmVuviec>();
        }
	}
}
