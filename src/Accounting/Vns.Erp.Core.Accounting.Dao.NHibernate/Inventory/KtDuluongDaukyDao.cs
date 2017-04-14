
using System;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using NHibernate;
namespace Vns.Erp.Core.Accounting.Dao.NHibernate
{
	[Serializable]
	public sealed class KtDuluongDaukyDao:GenericDao<KtDuluongDauky,string>,IKtDuluongDaukyDao
	{
        public KtDuluongDauky Get(Guid _DonviId, Guid _HanghoaId, Guid _KhoId, DateTime _NgayTinh)
        {
            KtDuluongDauky tmp = Session.Get<KtDuluongDauky>(new KtDuluongDauky() { DonviId = _DonviId, HanghoaId = _HanghoaId, KhoId = _KhoId, NgayTinh = _NgayTinh });
            return tmp;
        }

        public void DeleteBy(Guid _DonviId, Guid _HanghoaId, Guid _KhoId, DateTime _NgayTinh)
        {
            String nQuery = "Delete KtDuluongDauky where DonviId = :DonviId and HanghoaId = :HanghoaId and KhoId = :KhoId and NgayTinh > :NgayTinh";

            IQuery query = Session.CreateQuery(nQuery);

            query.SetParameter("DonviId", _DonviId);
            query.SetParameter("HanghoaId", _HanghoaId);
            query.SetParameter("KhoId", _KhoId);
            query.SetParameter("NgayTinh", _NgayTinh);

            query.ExecuteUpdate();
        }
	}
}
