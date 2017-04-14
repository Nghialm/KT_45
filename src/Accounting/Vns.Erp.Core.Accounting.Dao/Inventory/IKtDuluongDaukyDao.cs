using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;

namespace Vns.Erp.Core.Accounting.Dao
{
	public interface IKtDuluongDaukyDao:IDao<KtDuluongDauky,string>
	{
        KtDuluongDauky Get(Guid _DonviId, Guid _HanghoaId, Guid _KhoId, DateTime _NgayTinh);
        void DeleteBy(Guid _DonviId, Guid _HanghoaId, Guid _KhoId, DateTime _NgayTinh);
	}
}