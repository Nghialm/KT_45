using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Service;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System;
using System.ServiceModel;

namespace Vns.Erp.Core.Admin.Service.Interface
{
    [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
    public interface IHtLoaichungtuService : IErpService<HtLoaichungtu, System.Guid>
    {
        //[OperationContract]
        //HtLoaichungtu GetByMA_LOAI_CT(string p_MA_CT);
        [OperationContract]
        IList<HtLoaichungtu> LikeObjetMA_LOAI_CT(string p_MA_CT, Guid DONVI_ID);
        [OperationContract]
        List<string> GetSoCT_prefix(Guid LOAICHUNGTU_ID, decimal THANG, decimal NAM, Guid DONVI_ID);
        [OperationContract]
        HtLoaichungtu GetByMA_LOAI_CT(string p_MA_CT, Guid DonviId);
        [OperationContract]
        IList<HtLoaichungtu> GetByDonvi(Guid DonviId);

        List<HtLoaichungtu> ImportList(List<HtLoaichungtu> lst, Guid DONVI_ID);
    }
}
