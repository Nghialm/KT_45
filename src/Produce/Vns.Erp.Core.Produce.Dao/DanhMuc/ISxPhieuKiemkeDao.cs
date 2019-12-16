using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Produce.Domain;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;

namespace Vns.Erp.Core.Produce.Dao
{
    public interface ISxPhieuKiemkeDao : IDao<SxPhieuKiemke, System.Guid>
    {
        IList<SxPhieuKiemke> getByMaCt(string MaLoaiCt, Guid DonviId);

        IList<SxPhieuKiemke> getByMaCt(int PageIndex, int PageSize, string MaLoaiCt, Guid DonviId, out int TotalResult);
    }    
}