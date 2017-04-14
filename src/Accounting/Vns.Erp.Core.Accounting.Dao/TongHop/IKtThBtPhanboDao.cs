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
	public interface IKtThBtPhanboDao:IDao<KtThBtPhanbo,System.Guid>
    {
        void DeleteByThangNam(decimal Thang, decimal Nam, System.Guid DonviId);
	}
}