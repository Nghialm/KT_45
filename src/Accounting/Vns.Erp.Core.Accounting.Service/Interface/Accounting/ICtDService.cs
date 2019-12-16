using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Service;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System;
using Vns.Erp.Core.Accounting.Domain.Extend;
using System.ServiceModel;

namespace Vns.Erp.Core.Accounting.Service.Interface
{
    [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
	public interface ICtDService:IErpService<CtD, System.Guid>
	{
        [OperationContract]
        bool KiemTraChiTietDinhKhoan(ref string ErpMessage, CtD objValue);
        [OperationContract]
        IList<CtD> GetByCtHandNghiepVu(Guid CthId, Decimal LoaiNghiepVu);
        [OperationContract]
        List<List<CT_D_KInfo>> GetLstNhom(List<CT_D_KInfo> lstCTDK);
        [OperationContract]
        int Count_tk_thue(List<CT_D_KInfo> lstCTDK);
        [OperationContract]
        bool CheckValidateCTDK(List<CT_D_KInfo> lstCTDK, bool save);
        //void SaveCTDK(Vns.Erp.Core.FormGlobals.DataInputState status, ref CtH _cthInfo, List<CT_D_KInfo> lstCTDK, List<CT_D_KInfo> del_lstobj_ct_d_k);
        [OperationContract]
        List<CT_D_KInfo> ConvertToCtDK(List<CtD> lstCTDK);
	}
}
