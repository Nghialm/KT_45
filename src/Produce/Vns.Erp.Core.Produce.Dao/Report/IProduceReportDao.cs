using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Produce.Domain;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;
using Vns.Erp.Core.Produce.Domain.Report;

namespace Vns.Erp.Core.Produce.Dao.Report
{
    public interface IProduceReportDao : IDao<SxKehoachM, System.Guid>
    {
        IList<SxRpQtSanXuatDTO> GetDataSanXuat(DateTime TuNgay, DateTime DenNgay,
            Guid KeHoachId, Guid LenhSxId, Guid KhoId, Guid PhanXuongId, Guid HanghoaId, List<String> dsMaTk,
            Guid DonviId);

        IList<SxRpQtSanXuatDTO> GetDataKeHoach(DateTime TuNgay, DateTime DenNgay,
            Guid KeHoachId, Guid LenhSxId, Guid KhoId, Guid PhanXuongId, Guid HanghoaId,
            Guid DonviId);

        IList<SxBkSanLuongDTO> GetBangKeSanLuong(DateTime TuNgay, DateTime DenNgay,
            Guid KeHoachId, Guid LenhSxId, Guid KhoId, Guid PhanXuongId, Guid SanPhamId,
            Guid DonviId);

        IList<SxBkVatLieuDTO> GetBangKeVatLieu(DateTime TuNgay, DateTime DenNgay,
            Guid KeHoachId, Guid LenhSxId, Guid KhoId, Guid PhanXuongId, Guid VatTuId,
            Guid DonviId);

        IList<BcKeToanKhoDTO> GetTongHopHangDiDuong(DateTime DenNgay, Guid DonviId, Boolean IsNhap);

        IList<BcKeToanKhoDTO> GetTongHopKho(DateTime DenNgay, Guid DonviId, Boolean IsNhap);

        IList<BcKeToanKhoDTO> GetBangKeOpec(DateTime TuNgay, DateTime DenNgay, Guid DonviId, Boolean IsNhap);
    }
}
