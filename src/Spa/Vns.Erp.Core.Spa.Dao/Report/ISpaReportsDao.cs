using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Spa.Domain;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;

namespace Vns.Erp.Core.Spa.Dao
{
    public interface ISpaReportsDao : IDao<SpaDmDichVu, System.Guid>
    {
        IList<SpaRpNhanVienDTO> ListNhanVienPhucVu(Guid DonviId, Guid IdNhanVien, Guid IdGuongDichVu, DateTime tungay, DateTime denngay);
        IList<SpaRpDoanhThuDTO> BaoCaoDoanhThuDichVuChiTiet(DateTime TuNgay, DateTime DenNgay, Guid NhomKhang1, Decimal LoaiDichVu, Guid DonviId);
        IList<SpaRpDoanhThuDTO> BaoCaoDoanhThuDichVu(DateTime TuNgay, DateTime DenNgay, Guid NhomKhang1, Guid DonviId);
        IList<SpaRpThanhToanTheDTO> BaoCaoThanhToanThe(DateTime TuNgayPhatHanh, DateTime DenNgayPhatHanh, Guid DonviId);
    }
}