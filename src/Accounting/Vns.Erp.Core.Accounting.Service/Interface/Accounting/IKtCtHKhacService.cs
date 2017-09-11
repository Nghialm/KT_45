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
    [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
	public interface IKtCtHKhacService:IErpService<KtCtHKhac, System.Guid>
	{
        IList<KtCtHKhac> GetByDonviId(Guid DonviId);
        IList<KtCtHKhac> GetByLoaiChungTu(Guid DonviId, string MaLoaiCt);
        IList<KtCtHKhac> GetByLoaiChungTu(int PageIndex, int PageSize, Guid DonviId, string MaLoaiCt, out int TotalResult);
        Boolean DeleteChungTu(KtCtHKhac objCtH, IList<KtCtDKhac> lstCtD);
        void SaveCTDK(Vns.Erp.Core.FormGlobals.DataInputState status, ref KtCtHKhac _cthInfo, List<KtCtDKhac> lstCTDK, List<KtCtDKhac> del_lstobj_ct_d_k);

        #region syn function
        [OperationContract]
        void SaveData4Syn(KtCtHKhac _cth, List<KtCtDKhac> _lstctd);
        #endregion
    }
}
