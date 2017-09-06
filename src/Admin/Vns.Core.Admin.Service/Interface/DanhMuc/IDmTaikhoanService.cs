
/*
insert license info here
*/
using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Admin.Service;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Service.Interface;
using System;
using System.Collections.Generic;
using System.ServiceModel;
namespace Vns.Erp.Core.Admin.Service.Interface
{
    [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
    public interface IDmTaikhoanService : IErpService<DmTaikhoan, Guid>
    {
        [OperationContract]
        IList<DmTaikhoan> GetAllByDonviID(Guid DonviId);
        //[OperationContract(Name = "GetAllByDonviIDAndTaiKhoan")]
        //IList<DmTaikhoan> GetAllByDonviID(int PageIndex,int PageSize,Guid DonviId, out int TotalResult);
        [OperationContract]
        DmTaikhoan GetObjectByMaTK(String MaTaikhoan, Guid DonviId);
        [OperationContract]
        void SetChiTietTKCha(Guid parent_id, int  ChiTiet);
        [OperationContract]
        IList<DmTaikhoan> GetAllByParentID(Guid parentId);
    }
}
