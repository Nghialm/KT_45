using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Produce.Domain;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using Vns.Erp.Core.Produce.Domain.Report;
using System;
using System.Collections.Generic;

namespace Vns.Erp.Core.Produce.Service.Interface.Report
{
    public interface IProduceReportService : IErpService<SxKehoachM, System.Guid>
    {
        IList<SxRpQtSanXuatDTO> GetDataSanXuatNguyenVatLieu(DateTime TuNgay, DateTime DenNgay,
            Guid KeHoachId, Guid LenhSxId, Guid KhoId, Guid PhanXuongId, Guid HanghoaId,
            Guid DonviId);

        IList<SxRpQtSanXuatDTO> GetDataSanXuatVatTu(DateTime TuNgay, DateTime DenNgay,
            Guid KeHoachId, Guid LenhSxId, Guid KhoId, Guid PhanXuongId, Guid HanghoaId,
            Guid DonviId);

        IList<SxRpQtSanXuatDTO> GetDataKeHoach(DateTime TuNgay, DateTime DenNgay,
            Guid KeHoachId, Guid LenhSxId, Guid KhoId, Guid PhanXuongId, Guid HanghoaId,
            Guid DonviId);

        IList<SxRpQtSanXuatDTO> GetDataSanXuat(DateTime TuNgay, DateTime DenNgay,
            Guid KeHoachId, Guid LenhSxId, Guid KhoId, Guid PhanXuongId, Guid HanghoaId,
            Guid DonviId, int LoaiVatTu);

        IList<SxRpQtSanXuatThDTO> GetDataTongHopSanXuat(DateTime TuNgay, DateTime DenNgay,
            Guid KeHoachId, Guid LenhSxId, Guid KhoId, Guid PhanXuongId, Guid HanghoaId,
            Guid DonviId, int LoaiVatTu);

        IList<SxBkSanLuongDTO> GetBangKeSanLuong(DateTime TuNgay, DateTime DenNgay,
            Guid KeHoachId, Guid LenhSxId, Guid KhoId, Guid PhanXuongId, Guid SanPhamId,
            Guid DonviId);

        IList<SxBkVatLieuDTO> GetBangKeVatLieu(DateTime TuNgay, DateTime DenNgay,
            Guid KeHoachId, Guid LenhSxId, Guid KhoId, Guid PhanXuongId, Guid VatTuId,
            Guid DonviId);
    }
}
