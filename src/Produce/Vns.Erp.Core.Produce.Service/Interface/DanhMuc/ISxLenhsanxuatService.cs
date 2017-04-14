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
	public interface ISxLenhsanxuatService:IErpService<SxLenhsanxuat, System.Guid>
	{
       void SaveLenhSanXuat(SxLenhsanxuat objLenhSanXuat, IList<SxLenhsanxuatD> lstDetail, IList<SxLenhsanxuatD> lstDel);
       IList<SxLenhsanxuat> LoadByPhanCongId(Guid PhanCongId);
       IList<SxLenhsanxuat> LoadByToSanXuat(Guid ToSanXuatId);
       IList<SxLenhsanxuat> GetbyDonviId(Guid DonviId);
	}
}
