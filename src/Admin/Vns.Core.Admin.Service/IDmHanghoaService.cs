
/*
insert license info here
*/
using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Admin.Service;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System.ServiceModel;
namespace Vns.Erp.Core.Admin.Service.Interface
{
    [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
    public interface IDmHanghoaService : IErpService<DmHanghoa, Guid>
    {
        [OperationContract]
        IList<DmHanghoa> GetAllByDonviID(Guid DonviId);
        [OperationContract(Name = "GetAllByDonviIDAndHangHoa")]
        IList<DmHanghoa> GetAllByDonviID(int PageIndex, int PageSize, Guid DonviId,Decimal LoaiHangHoa, out int TotalResult);
        [OperationContract]
        int GetNumberHangHoaByKyHieu(String KyHieu, Guid DonviId);
        void DeleteAllByDonviId(Guid DonviId);
    }
}
