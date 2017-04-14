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
	public interface ISxPhieuKiemkeService:IErpService<SxPhieuKiemke, System.Guid>
	{
        IList<SxPhieuKiemke> getByMaCt(string MaLoaiCt, Guid DonviId);
        void saveKiemKe(SxPhieuKiemke objKiemKe, IList<SxPhieuKiemkeSlD> lstKiemKeSl, IList<SxPhieuKiemkeVtD> lstKiemKeVt, IList<SxPhieuKiemkeSlD> lstDelKiemKeSl, IList<SxPhieuKiemkeVtD> lstDelKiemKeVt);
	}
}
