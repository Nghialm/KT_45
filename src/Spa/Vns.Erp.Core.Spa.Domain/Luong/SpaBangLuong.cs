using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using Vns.Erp.Core.Accounting.Domain;

namespace Vns.Erp.Core.Spa.Domain
{
	public partial class SpaBangLuong : DomainObject<string>
    {
        public SpaBangLuong(SpaDmNhanvien nhanvien)
        {
            _NhanVienId = nhanvien.Id;
            //_DonViId = nhanvien.
            _SoTienHoaHong = 0;
            _SoTienLuong = 0;
            _SoTienPhat = 0;
            _SoTienThuong = 0;
        }

        public Decimal TongTien
        {
            get
            {
                Decimal _tongtien = 0;
                _tongtien = _SoTienLuong + _SoTienThuong - _SoTienPhat;
                return _tongtien;
            }
        }

	}
}