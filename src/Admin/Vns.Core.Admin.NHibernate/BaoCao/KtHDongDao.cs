
using System;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;
using System.Collections;
namespace Vns.Erp.Core.Admin.Dao.NHibernate
{
	[Serializable]
	public sealed class KtHDongDao:GenericDao<KtHDong,System.Guid>,IKtHDongDao
	{
        public IList<KtHDong> GetBy_BAOCAO_Id(System.Guid BaocaoId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("BaocaoId");
            values.Add(BaocaoId);

            IList<Core.Domain.VnsOrder> lstorder = new List<Core.Domain.VnsOrder>();
            lstorder.Add(new Core.Domain.VnsOrder(true, "ThuTu"));
            lstorder.Add(new Core.Domain.VnsOrder(true, "MaSo"));

            return List(-1, -1, props, values, lstorder);
        }

        public IList<KtHDong> GetByBaocaoId4Report(System.Guid BaocaoId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("BaocaoId");
            values.Add(BaocaoId);

            IList<Core.Domain.VnsOrder> lstorder = new List<Core.Domain.VnsOrder>();
            lstorder.Add(new Core.Domain.VnsOrder(true, "TsKhac"));
            lstorder.Add(new Core.Domain.VnsOrder(true, "ThuTu"));
            lstorder.Add(new Core.Domain.VnsOrder(true, "MaSo"));

            return List(-1, -1, props, values, lstorder);
        }

        public void DeleteByBaoCaoId(System.Guid BaocaoId)
        {
            string sql = "Delete from KtHDong a where a.BaocaoId like :BaocaoId";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("BaocaoId", BaocaoId);

            q.ExecuteUpdate();
        }
	}
}
