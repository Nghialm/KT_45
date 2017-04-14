
using System;
using Vns.Erp.Core.Spa.Domain;
using Vns.Erp.Core.Spa.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using System.Collections.Generic;
using NHibernate;
namespace Vns.Erp.Core.Spa.Dao.NHibernate
{
	[Serializable]
	public sealed class SpaDmNhanvienDao:GenericDao<SpaDmNhanvien,System.Guid>,ISpaDmNhanvienDao
	{
        public IList<SpaDmNhanvien> GetByTrangThai(bool trangThai)
        {
            string sql = "from  SpaDmNhanvien a where (a.DaNghiViec=:trangThai)";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("trangThai", trangThai);
            return q.List<SpaDmNhanvien>();
        }
        
    }
}
