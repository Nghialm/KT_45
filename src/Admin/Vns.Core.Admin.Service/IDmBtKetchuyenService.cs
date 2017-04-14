
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
    public interface IDmBtKetchuyenService : IErpService<DmBtKetchuyen, Guid>
    {
        [OperationContract]
        IList<DmBtKetchuyen> GetObjectAllByDonviID(Guid DonviId);
        //private GenSQLLaySoDuTaiKhoan(DateTime Tu_ngay, DateTime Den_ngay, Guid Donvi_id, string LoaiTaiKhoan, DmBtKetchuyen _obj_dm_bt_ketchuyen);
        [OperationContract]
        DataTable LaySoDuTaiKhoan(DateTime Tu_ngay, DateTime Den_ngay, Guid Donvi_id, DmBtKetchuyen _obj_dm_bt_ketchuyen);
    }
}
