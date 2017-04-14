using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Service;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System;
using System.ServiceModel;

namespace Vns.Erp.Core.Accounting.Service.Interface
{
    [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
	public interface IBcKetoanKhoService:IErpService<BcKetoanKho, System.Guid>
	{
        [OperationContract]
        void TinhGiaXuatHangHoaVoiKho(DateTime p_tu_ngay, DateTime p_den_ngay, Guid p_hanghoa_id, Guid p_kho_id,
                Decimal p_phuongphap, Guid DonviId,
                Guid p_nhom1_id, Guid p_nhom2_id, Guid p_nhom3_id);
	}
}
