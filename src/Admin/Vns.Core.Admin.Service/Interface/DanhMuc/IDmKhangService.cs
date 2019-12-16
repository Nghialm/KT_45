
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
    public interface IDmKhangService : IErpService<DmKhang, Guid>
    {
        [OperationContract]
        IList<DmKhang> GetAllByDonviID(Guid DonviId);
        [OperationContract]
        int GetNumberKhachHangByKyHieu(string KyHieu, Guid DonviId);
        [OperationContract(Name="GetAllByDonviIDAndLoaiKhachHang")]
        IList<DmKhang> GetAllByDonviID(int PageIndex, int PageSize, Guid DonviId, Decimal LoaiKhang, out int TotalResult);
        [OperationContract]
        IList<DmKhang> GetKhByNgaySinh(int p_thang);

        [OperationContract]
        IList<DmKhang> GetAllByDonviId(Guid DonviId, Decimal LoaiKhang);
    }
}
