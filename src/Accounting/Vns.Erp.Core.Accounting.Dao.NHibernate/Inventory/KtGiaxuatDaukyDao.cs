
using System;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
namespace Vns.Erp.Core.Accounting.Dao.NHibernate
{
	[Serializable]
	public sealed class KtGiaxuatDaukyDao:GenericDao<KtGiaxuatDauky,string>,IKtGiaxuatDaukyDao
	{
        public KtGiaxuatDauky Get(Guid _DonviId, Guid _HanghoaId, Guid _KhoId, DateTime _NgayTinh)
        {
            KtGiaxuatDauky tmp = Session.Get<KtGiaxuatDauky>(new KtGiaxuatDauky() { DonviId = _DonviId, HanghoaId = _HanghoaId, KhoId = _KhoId, NgayTinh = _NgayTinh});
            return tmp;
        }
	}
}
