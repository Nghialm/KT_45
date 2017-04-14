using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Spa.Domain
{
	public partial class SpaLsThe : DomainObject<string>
    {
        public SpaLsThe(SpaDmThe objThe)
        {
            _Theid = objThe.Id;
            _Mathe = objThe.Ma;
            //Mac dinh
            _Mphieuid = Null.NullGuid;
            _Sotien = objThe.Menhgia;
            _TienThe = objThe.Giatien;
            _TienKhuyenMai = objThe.Menhgia - objThe.Giatien;

            _Tenkhachhang = objThe.Tenkhachhang;
            _Ngaythanhtoan = objThe.Ngayban.Value;
        }

        public SpaLsThe(CtHHddv objHoaDon)
        {
            _Theid = objHoaDon.SoThe1;
            //_Mathe = objThe.Ma;
            //Mac dinh
            _Mphieuid = objHoaDon.Id;
            _Sotien = objHoaDon.TtTienThe1;
            _TienKhuyenMai = objHoaDon .TheTienKm1 ;
            _TienThe = objHoaDon.TheTienThe1;
            _Tenkhachhang = objHoaDon.TenKhang;
            _Ngaythanhtoan = objHoaDon.NgayCt.Value;
 
        }
	}
}