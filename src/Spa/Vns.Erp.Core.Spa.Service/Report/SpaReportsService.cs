using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Spa.Domain;
using Vns.Erp.Core.Spa.Dao;
using Vns.Erp.Core.Spa.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;

namespace Vns.Erp.Core.Spa.Service
{
    public class SpaReportsService : GenericService<SpaDmDichVu, System.Guid>, ISpaReportsService
    {
        public ISpaReportsDao SpaReportsDao
        {
            get { return (ISpaReportsDao)Dao; }
            set { Dao = value; }
        }

        public IList<SpaRpNhanVienDTO> ListNhanVienPhucVu(Guid DonviId, Guid IdNhanVien, Guid IdGuongDichVu, DateTime tungay, DateTime denngay)
        {
            return SpaReportsDao.ListNhanVienPhucVu(DonviId, IdNhanVien, IdGuongDichVu, tungay, denngay);
        }

        public IList<SpaRpDoanhThuDTO> BaoCaoDoanhThuDichVuChiTiet(DateTime TuNgay, DateTime DenNgay, Guid NhomKhang1, Decimal LoaiDichVu, Guid DonviId)
        {
            return SpaReportsDao.BaoCaoDoanhThuDichVuChiTiet(TuNgay, DenNgay, NhomKhang1, LoaiDichVu, DonviId);
        }

        public IList<SpaRpDoanhThuDTO> BaoCaoDoanhThuDichVu(DateTime TuNgay, DateTime DenNgay, Guid NhomKhang1, Guid DonviId)
        {
            return SpaReportsDao.BaoCaoDoanhThuDichVu(TuNgay, DenNgay, NhomKhang1, DonviId);
        }

        public IList<SpaRpThanhToanTheDTO> BaoCaoThanhToanThe(DateTime TuNgayPhatHanh, DateTime DenNgayPhatHanh, Guid DonviId)
        {
            return SpaReportsDao.BaoCaoThanhToanThe(TuNgayPhatHanh, DenNgayPhatHanh, DonviId);
        }
    }
}