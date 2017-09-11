using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Service;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System;
using System.ServiceModel;


namespace Vns.Erp.Core.Accounting.Service.Interface
{
	public interface IKtCtDKhacService:IErpService<KtCtDKhac, System.Guid>
	{
        IList<KtCtDKhac> GetByCtHandNghiepVu(Guid CthId, Decimal LoaiNghiepVu);
        bool CheckValidateCTDK(List<KtCtDKhac> lstCTDK, bool save);
        int Count_tk_thue(List<KtCtDKhac> lstCTDK);
        List<List<KtCtDKhac>> GetLstNhom(List<KtCtDKhac> lstCTDK);
	}
}
