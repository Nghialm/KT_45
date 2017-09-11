using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Service;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Vns.Erp.Core.Accounting.Service.Interface
{
    [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
	public interface ICtHoadonService:IErpService<CtHoadon, System.Guid>
	{
        IList<CtHoadon> GetAllByDonviID(Guid DonviId);

        IList<CtHoadon> SearchBy(int PageIndex, int PageSize,
            DateTime TuNgay, DateTime DenNgay, Guid DonviId, String SoHoadon,
            String MaSoThue, String TenKhachhang,
            out int totalResult);

        Boolean SaveHoaDonThueGTGT(CtHoadon objHoaDon, IList<CtThue> lstSave, IList<CtThue> lstDel);

        #region Syn function
        [OperationContract]
        void SaveData4Syn(CtHoadon _hoadon, List<CtThue> _lstthue);
        #endregion
    }
}
