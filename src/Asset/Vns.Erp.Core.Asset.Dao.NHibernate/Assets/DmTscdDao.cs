
using System;
using Vns.Erp.Core;
using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using System.Collections;
using System.Collections.Generic;
using NHibernate;
namespace Vns.Erp.Core.Asset.Dao.NHibernate
{
    [Serializable]
    public sealed class DmTscdDao : GenericDao<DmTscd, System.Guid>, IDmTscdDao
    {
        public IList<DmTscd> GetbyParameter(DateTime TuNgay, DateTime DenNgay, String TenTscd, Guid LoaitaisanId, Guid DonviId)
        {
            string sql = "from DmTscd a where a.TenTscd like (:TenTscd)" + 
                " And NgayTang >= :TuNgay " +
                " And NgayTang <= :DenNgay " +
                " And TenTscd like :TenTscd " +
                (VnsCheck.IsNullGuid(LoaitaisanId)? "": " And LoaitaisanId = :LoaitaisanId ") + 
                " And DonviId = :DonviId ";

            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("TuNgay", TuNgay);
            q.SetParameter("DenNgay", DenNgay);
            q.SetParameter("TenTscd", String.Format("%{0}%", TenTscd));
            if (!VnsCheck.IsNullGuid(LoaitaisanId)) q.SetParameter("LoaitaisanId", LoaitaisanId);
            q.SetParameter("DonviId", DonviId);
            return q.List<DmTscd>();
        }
    }
}
