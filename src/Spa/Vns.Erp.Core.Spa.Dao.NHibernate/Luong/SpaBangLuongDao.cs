
using System;
using Vns.Erp.Core.Spa.Domain;
using Vns.Erp.Core.Spa.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using NHibernate;
namespace Vns.Erp.Core.Spa.Dao.NHibernate
{
	[Serializable]
	public sealed class SpaBangLuongDao:GenericDao<SpaBangLuong,string>,ISpaBangLuongDao
	{
        public Boolean DeleteSalaryByMonth(DateTime ThangLuong)
        {
            String sql = " delete from SpaBangLuong a where " +
                         " a.ThangLuong <= :ThangLuong";

            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("ThangLuong", ThangLuong);
            int i = q.ExecuteUpdate();

            return true;
        }
	}
}
