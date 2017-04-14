using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Service;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System;

namespace Vns.Erp.Core.Admin.Service.Interface
{
	public interface ICcDmCcdcService:IErpService<CcDmCcdc, System.Guid>
	{
        IList<CcDmCcdc> GetAllByDonviID(Guid DonviId);
        Boolean SaveCCDC(Boolean isInsert, ref CcDmCcdc obj_CCDC, CcCtCcdc obj_CCDC_CT, IList<CcCtCcdcNvon> lst_NguonVon, IList<CcCtCcdcNvon> lst_Del_NguonVon);
        Boolean DeleteCCDC(Guid ccdcId);
        IList<CcDmCcdc> GetByMaCCDC(string MaCcdc);
        void UpdateGiamCcdc(Guid CcdcId, Decimal GiamCcdc);
        Boolean SaveKhaiBaoGiam(Boolean IsInsert, CcDmCcdc objCcDmCcdc, CcCtCcdc objCcCtCcdc);
        Boolean DeleteKhaiBaoGiamCcdc(Guid CcdcId, Decimal GiamCcdc);
	}
}
