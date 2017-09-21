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
	public interface ISxLenhsanxuatDao:IDao<SxLenhsanxuat,System.Guid>
	{
        IList<SxLenhsanxuat> GetbyDonviId(int PageIndex, int PageSize, Guid DonviId, out int TotalResult);
        IList<SxLenhsanxuat> LoadByPhanCongId(int PageIndex, int PageSize, Guid PhanCongId, Guid DonviId, out int TotalResult);

        IList<SxLenhsanxuat> LoadByToSanXuat(Guid ToSanXuatId);

        IList<SxLenhsanxuat> GetbyDonviId(Guid DonviId);

    }
}