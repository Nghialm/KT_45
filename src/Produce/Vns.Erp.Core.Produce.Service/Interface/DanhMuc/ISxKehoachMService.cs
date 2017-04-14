using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Produce.Domain;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System;

namespace Vns.Erp.Core.Produce.Service.Interface
{
    public interface ISxKehoachMService : IErpService<SxKehoachM, System.Guid>
    {
        void SaveKeHoach(SxKehoachM objKeHoach, IList<SxKehoachD> lstSanXuat, IList<SxKehoachD> lstVatTu, IList<SxPhancong> lstKeHoach, IList<SxKehoachD> lstDelSanXuat, IList<SxKehoachD> lstDelVatTu, IList<SxPhancong> lstDelKeHoach);
        IList<SxKehoachM> getByMaCt(string MaLoaiCt, Guid DonviId);
        IList<SxKehoachM> GetByDonviId(Guid DonviId);
    }
}
