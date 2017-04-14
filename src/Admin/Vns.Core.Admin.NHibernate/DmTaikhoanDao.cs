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
	public sealed class DmTaikhoanDao:GenericDao<DmTaikhoan,Guid>,IDmTaikhoanDao
	{
        public IList<DmTaikhoan> GetAllByDonviID(Guid DonviId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("DonviId");
            values.Add(DonviId);

            List<Vns.Erp.Core.Domain.VnsOrder> lstOrder = new List<Core.Domain.VnsOrder>();
            lstOrder.Add(new Core.Domain.VnsOrder(true, "MaTaikhoan"));
            return List(-1, -1, props, values, lstOrder);            
        }

        public void DeleteAllByDonvi(Guid DonviId)
        {
            String sql = "Delete from DmTaikhoan a " +
                          " where a.DonviId = :DonviId ";

            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("DonviId", DonviId);

            q.ExecuteUpdate();
        }

        public void SetChiTietTKCha(Guid parent_id, int ChiTiet)
        { 
            String sql ="Update DmTaikhoan Set ChiTiet = :ChiTiet Where Id = :parent_id";

            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("ChiTiet", ChiTiet);
            q.SetParameter("parent_id", parent_id);
            q.ExecuteUpdate();
        }

        public IList<DmTaikhoan> GetAllByParentID(Guid parentId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("TaikhoanIdCha");
            values.Add(parentId);

            List<Vns.Erp.Core.Domain.VnsOrder> lstOrder = new List<Core.Domain.VnsOrder>();
            lstOrder.Add(new Core.Domain.VnsOrder(true, "MaTaikhoan"));
            return List(-1, -1, props, values, lstOrder);
        }

        public void SetParentId(DmTaikhoan ObjPar)
        {
            String sql = "Update DmTaikhoan Set TaikhoanIdCha = :TaikhoanIdCha " +
                "Where Cap = :Cap + 1 and MaTaikhoan like :MaTaikhoan and DonviId = :DonviId";

            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("DonviId", ObjPar.DonviId);
            q.SetParameter("Cap", ObjPar.Cap);
            q.SetParameter("MaTaikhoan",String.Format("{0}%", ObjPar.MaTaikhoan));
            q.SetParameter("TaikhoanIdCha", ObjPar.Id);

            q.ExecuteUpdate();
        }
	}
}
