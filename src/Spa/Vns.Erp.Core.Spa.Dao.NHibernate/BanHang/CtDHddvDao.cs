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
	public sealed class CtDHddvDao:GenericDao<CtDHddv,System.Guid>,ICtDHddvDao
	{
        public IList<CtDHddv> GetCtdBycth(Guid CthHddvId)
        {
            string sql = "from CtDHddv a where (a.CthHddvId=:CthHddvId)";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("CthHddvId", CthHddvId);
            return q.List<CtDHddv>();
        }

        public IList<CtDHddv > GetCtdByLoaiNV(Guid cthId,int LoaiNghiepVu)
        {
            String nHQL = " Select h " +
                                     " From CtDHddv h" +
                                     " Where h.CthHddvId = :cthId " +
                                     " And h.LoaiNghiepVu = :LoaiNghiepVu ";

            IQuery query = NHibernateSession.CreateQuery(nHQL);
            query.SetParameter("cthId", cthId);
            query.SetParameter("LoaiNghiepVu", LoaiNghiepVu);
            return query.List<CtDHddv>();
        }


        public Boolean DeleteByCtH(Guid CthHddvId)
        {
            String nHQL = "Delete from CtDHddv h where h.CthHddvId = :CthHddvId ";

            IQuery q = NHibernateSession.CreateQuery(nHQL);
            q.SetParameter("CthHddvId", CthHddvId);
            int i = q.ExecuteUpdate();

            return true;

        }


	}
}
