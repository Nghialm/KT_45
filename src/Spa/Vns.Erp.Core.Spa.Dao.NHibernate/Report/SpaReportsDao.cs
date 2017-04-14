
using System;
using Vns.Erp.Core.Spa.Domain;
using Vns.Erp.Core.Spa.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using NHibernate;
using System.Collections.Generic;
using NHibernate.Transform;
namespace Vns.Erp.Core.Spa.Dao.NHibernate
{
    [Serializable]
    public sealed class SpaReportsDao : GenericDao<SpaDmDichVu, System.Guid>, ISpaReportsDao
    {
        public IList<SpaRpNhanVienDTO> ListNhanVienPhucVu(Guid DonviId, Guid IdNhanVien, Guid IdGuongDichVu, DateTime tungay, DateTime denngay)
        {
            String HQuery =
                "select m.NgayCt as NgayCt, m.IdNhanVien as NhanVienID, m.TenKhang as TenKhachHang" +
                ", m.TuGio as TuGio, m.DenGio as DenGio, m.IdGuongDichVu as GuongID, g.Kyhieu as TenGuong, d.TenHhDv as TenDichVu " +
                ", d.DoanhThu as DoanhThu, d.SoTienGiamGia as SoTienGiamGia, d.SoTienHh as SoTienHh " +
            " from CtHHddv m inner join m.LstCtHHddv d " +
            " inner join m.ObjDmGuong g " +
            " where d.LoaiNghiepVu = 1 And m.DonviId = :DonviId " + 
            (VnsCheck.IsNullGuid(IdNhanVien) ? "" : " And (m.IdNhanVien = :IdNhanVien) ") +
            " And (m.NgayCt >= :TuNgay And m.NgayCt <= :DenNgay) " +
            (VnsCheck.IsNullGuid(IdGuongDichVu) ? "" : " And (m.IdGuongDichVu = :IdGuongDichVu) ") +
            " Order by m.NgayCt";
            
            IQuery query = NHibernateSession.CreateQuery(HQuery);
            if (!VnsCheck.IsNullGuid(IdNhanVien)) query.SetParameter("IdNhanVien", IdNhanVien);
            if (!VnsCheck.IsNullGuid(IdGuongDichVu)) query.SetParameter("IdGuongDichVu", IdGuongDichVu);
            query.SetParameter("DonviId", DonviId);
            query.SetParameter("TuNgay", tungay);
            query.SetParameter("DenNgay", denngay);

            query.SetResultTransformer(Transformers.AliasToBean<SpaRpNhanVienDTO>());
            IList<SpaRpNhanVienDTO> ilist = query.List<SpaRpNhanVienDTO>();
            return ilist;
        }

        public IList<SpaRpDoanhThuDTO> BaoCaoDoanhThuDichVuChiTiet(DateTime TuNgay, DateTime DenNgay, Guid NhomKhang1, Decimal LoaiDichVu, Guid DonviId)
        {
            String HQuery =
                            "select m.NgayCt as NgayCt, m.CtSo as CtSo, m.TenKhang as TenKhachHang" +
                            ", d.TenHhDv as TenHhDv, d.LoaiNghiepVu as LoaiNghiepVu, n.TenNhomKhang as TenNhomKhang1 " +
                            ", d.DoanhThu as DoanhThuChiTiet, d.SoTienGiamGia as SoTienGiamGia, d.SoTienHh as SoTienHh " +
                        " from CtHHddv m inner join m.LstCtHHddv d " +
                        " inner join m.ObjDmKhachhang k " +
                        " left join k.ObjDmNhomKhang1 n" +
                        " where 1 = 1 " + 
                        (LoaiDichVu == -1 ? "" : " And d.LoaiNghiepVu = :LoaiDichVu ") + 
                        " And m.DonviId = :DonviId " +
                        " And (m.NgayCt >= :TuNgay And m.NgayCt <= :DenNgay) " +
                        (VnsCheck.IsNullGuid(NhomKhang1) ? "" : " And k.NhomKhang1 = :NhomKhang1") + 
                        " Order by m.NgayCt";

            IQuery query = NHibernateSession.CreateQuery(HQuery);
            if (!VnsCheck.IsNullGuid(NhomKhang1)) query.SetParameter("NhomKhang1", NhomKhang1);
            if (LoaiDichVu != -1) query.SetParameter("LoaiDichVu", LoaiDichVu);
            query.SetParameter("DonviId", DonviId);
            query.SetParameter("TuNgay", TuNgay);
            query.SetParameter("DenNgay", DenNgay);

            query.SetResultTransformer(Transformers.AliasToBean<SpaRpDoanhThuDTO>());
            IList<SpaRpDoanhThuDTO> ilist = query.List<SpaRpDoanhThuDTO>();
            return ilist;
        }

        public IList<SpaRpDoanhThuDTO> BaoCaoDoanhThuDichVu(DateTime TuNgay, DateTime DenNgay, Guid NhomKhang1, Guid DonviId)
        {
            String HQuery =
                            "select m.NgayCt as NgayCt, m.CtSo as CtSo, m.TenKhang as TenKhachHang" +
                            ", n.TenNhomKhang as TenNhomKhang1, t.Ma as MaThe " +
                            ", m.DoanhThu as DoanhThu, m.TtTienMat as TtTienMat, m.TtTienNh as TtTienNh " +
                            ", m.TtTienThe1 as TtTienThe1, m.TheTienThe1 as TheTienThe1, m.TheTienKm1 as TheTienKm1 " +
                            ", m.SoTienGiamGia as SoTienGiamGia " +
                        " from CtHHddv m " +
                        " inner join m.ObjDmKhachhang k " +
                        " left join k.ObjDmNhomKhang1 n" +
                        " left join m.ObjSpaDmThe t" +
                        " where 1 = 1 " +
                        " And m.DonviId = :DonviId " +
                        " And (m.NgayCt >= :TuNgay And m.NgayCt <= :DenNgay) " +
                        (VnsCheck.IsNullGuid(NhomKhang1) ? "" : " And k.NhomKhang1 = :NhomKhang1") +
                        " Order by m.NgayCt";

            IQuery query = NHibernateSession.CreateQuery(HQuery);
            if (!VnsCheck.IsNullGuid(NhomKhang1)) query.SetParameter("NhomKhang1", NhomKhang1);
            query.SetParameter("DonviId", DonviId);
            query.SetParameter("TuNgay", TuNgay);
            query.SetParameter("DenNgay", DenNgay);

            query.SetResultTransformer(Transformers.AliasToBean<SpaRpDoanhThuDTO>());
            IList<SpaRpDoanhThuDTO> ilist = query.List<SpaRpDoanhThuDTO>();
            return ilist;
        }

        public IList<SpaRpThanhToanTheDTO> BaoCaoThanhToanThe(DateTime TuNgayPhatHanh, DateTime DenNgayPhatHanh, Guid DonviId)
        {
            String HQuery =
                           "select m.Ngayphathanh as Ngayphathanh, m.Ngayban as Ngayban, m.Ngayhethan as Ngayhethan" +
                           ", m.Id as TheId, m.Ma as MaThe " +
                           ", m.Giatien as SoTien, m.Menhgia as MenhGia " +
                           ", l.Ngaythanhtoan as Ngaythanhtoan, l.TienThe as TienThe, l.TienKhuyenMai as TienKhuyenMai " +
                           ", l.Tenkhachhang as Tenkhachhang, l.Noidung as NoiDungThanhToan" +
                       " from SpaDmThe m " +
                       " inner join m.LstLsThe l " +
                       " where 1 = 1 " +
                       " And m.DonviId = :DonviId " +
                       " And (m.Ngayphathanh >= :TuNgayPhatHanh And m.Ngayphathanh <= :DenNgayPhatHanh) " +
                       " Order by m.Ngayphathanh";

            IQuery query = NHibernateSession.CreateQuery(HQuery);
            query.SetParameter("DonviId", DonviId);
            query.SetParameter("TuNgayPhatHanh", TuNgayPhatHanh);
            query.SetParameter("DenNgayPhatHanh", DenNgayPhatHanh);

            query.SetResultTransformer(Transformers.AliasToBean<SpaRpThanhToanTheDTO>());
            IList<SpaRpThanhToanTheDTO> ilist = query.List<SpaRpThanhToanTheDTO>();
            return ilist;
        }
    }
}
