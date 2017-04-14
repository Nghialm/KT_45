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
	public interface ISxDmQuytrinhService:IErpService<SxDmQuytrinh, System.Guid>
	{
        void SaveQuyTrinhDinhMuc(SxDmQuytrinh objQuyTrinh, IList<SxQuytrinhDinhmuc> lstVatTu, IList<SxQuytrinhDinhmuc> lstSanPham, IList<SxQuytrinhDinhmuc> lstDelVatTu, IList<SxQuytrinhDinhmuc> lstDelSanPham);

        IList<SxDmQuytrinh> GetByDonviId(Guid DonviId);
        void DeleteAllByDonviId(Guid DonviId);
	}
}
