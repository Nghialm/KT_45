using System;
using System.Collections.Generic;
using Vns.Erp.Core.Produce.Domain;
using Vns.Erp.Core.Produce.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using Vns.Erp.Core.Produce.Dao.Report;
using Vns.Erp.Core.Produce.Domain.Report;
using NHibernate;
using NHibernate.Transform;

namespace Vns.Erp.Core.Produce.Dao.NHibernate.Report
{
    [Serializable]
    public sealed class ProduceReportDao : GenericDao<SxKehoachM, System.Guid>, IProduceReportDao
    {
        public IList<SxRpQtSanXuatDTO> GetDataSanXuat(DateTime TuNgay, DateTime DenNgay,
            Guid KeHoachId, Guid LenhSxId, Guid KhoId, Guid PhanXuongId, Guid HanghoaId, List<String> dsMaTk,
            Guid DonviId)
        {
            String sqlNhapKho = "select bc.CtSo as SoChungTu, bc.NgayCt as NgayChungTu, bc.DienGiai as DienGiai, bc.KyHieuLoaiCt as LoaiNghiepVu, " +
                "bc.DonGiaVon as DonGia, " +
                "Case When bc.Xuat = 0 Then bc.SoLuong " +
                "When bc.Xuat = 1 Then 0 End as SoLuong, " +
                "Case When bc.Xuat = 0 Then bc.GiaVon " +
                "When bc.Xuat = 1 Then 0 End as SoTien, " +
                "bc.CthNxId as CthNxId, bc.CtdNxId as CtdNxId, " +
                "bc.HanghoaId as HanghoaId, bc.MaHanghoa as MaHanghoa, bc.TenHanghoa as TenHanghoa, bc.DonviId as DonviId, bc.IdLoaiCt as IdLoaiCt, bc.Xuat as Xuat, " +
                "lsx.Id as LenhSanXuatId, lsx.SoLenhSanXuat as SoLenhSanXuat, lsx.KehoachMId as KeHoachId, lsx.SoKeHoach as SoKeHoach, " +
                "bc.PhanXuongNhapId as PhanXuongId, bc.MaPhanXuongNhap as MaPhanXuong, " +
                "bc.TenDvt as TenDvt, " +
                "qt.TenQuytrinh as TenQuytrinh, kh.TenSanpham as TenSanpham " +
             "from SxLenhsanxuat lsx inner join lsx.LstVatTuNhap bc " +
             "inner join lsx.ObjKeHoachSx kh " +
             "inner join lsx.ObjDmQuyTrinh as qt " +
             "where 1 = 1 " +
             (VnsCheck.IsNullGuid(HanghoaId) ? "" : "AND bc.HanghoaId = :HanghoaId ") +
             (VnsCheck.IsNullGuid(LenhSxId) ? "" : "AND (lsx.Id = :LenhSxId) ") +
             (VnsCheck.IsNullGuid(KeHoachId) ? "" : "AND (lsx.KehoachMId = :KeHoachId) ") +
             (dsMaTk.Count == 0 ? "" : "AND bc.HanghoaId in (Select hh.Id From DmHanghoa hh Where hh.MdTkKho in (:dsMaTk)) ") +
               "AND bc.NgayCt >= :TuNgay And bc.NgayCt <= :DenNgay " +
               "AND bc.DonviId = :DonviId " +
               "AND bc.SoDu = 0 AND bc.Xuat = 0 ";

            String sqlXuat = "select bc.CtSo as SoChungTu, bc.NgayCt as NgayChungTu, bc.DienGiai as DienGiai, bc.KyHieuLoaiCt as LoaiNghiepVu, " +
                "bc.DonGiaVon as DonGia, " +
                "Case When bc.Xuat = 1 Then bc.SoLuong " +
                "When bc.Xuat = 0 Then 0 End as SoLuong, " +
                "Case When bc.Xuat = 1 Then bc.GiaVon " +
                "When bc.Xuat = 0 Then 0 End as SoTien, " +
                "bc.CthNxId as CthNxId, bc.CtdNxId as CtdNxId, " +
                "bc.HanghoaId as HanghoaId, bc.MaHanghoa as MaHanghoa, bc.TenHanghoa as TenHanghoa, bc.DonviId as DonviId, bc.IdLoaiCt as IdLoaiCt, bc.Xuat as Xuat, " +
                "lsx.Id as LenhSanXuatId, lsx.SoLenhSanXuat as SoLenhSanXuat, lsx.KehoachMId as KeHoachId, lsx.SoKeHoach as SoKeHoach, " +
                "bc.PhanXuongXuatId as PhanXuongId, bc.MaPhanXuongXuat as MaPhanXuong, " +
                "bc.TenDvt as TenDvt, " +
                "qt.TenQuytrinh as TenQuytrinh, kh.TenSanpham as TenSanpham " +
             "from SxLenhsanxuat lsx inner join lsx.LstVatTuXuat bc " +
             "inner join lsx.ObjKeHoachSx kh " +
             "inner join lsx.ObjDmQuyTrinh as qt " +
             "where 1 = 1 " +
             (VnsCheck.IsNullGuid(HanghoaId) ? "" : "AND bc.HanghoaId = :HanghoaId ") +
             (VnsCheck.IsNullGuid(LenhSxId) ? "" : "AND (lsx.Id = :LenhSxId) ") +
             (VnsCheck.IsNullGuid(KeHoachId) ? "" : "AND (lsx.KehoachMId = :KeHoachId) ") +
             (dsMaTk.Count == 0 ? "" : "AND bc.HanghoaId in (Select hh.Id From DmHanghoa hh Where hh.MdTkKho in (:dsMaTk)) ") +
               "AND bc.NgayCt >= :TuNgay And bc.NgayCt <= :DenNgay " +
               "AND bc.DonviId = :DonviId " +
               "AND bc.SoDu = 0 AND bc.Xuat = 1 ";

            IQuery qbcketoan = NHibernateSession.CreateQuery(sqlNhapKho);
            qbcketoan.SetParameter("TuNgay", TuNgay);
            qbcketoan.SetParameter("DenNgay", DenNgay);
            if (!VnsCheck.IsNullGuid(HanghoaId)) qbcketoan.SetParameter("HanghoaId", HanghoaId);
            if (!VnsCheck.IsNullGuid(LenhSxId)) qbcketoan.SetParameter("LenhSxId", LenhSxId);
            if (!VnsCheck.IsNullGuid(KeHoachId)) qbcketoan.SetParameter("KeHoachId", KeHoachId);
            if (dsMaTk.Count > 0) qbcketoan.SetParameterList("dsMaTk", dsMaTk);
            qbcketoan.SetParameter("DonviId", DonviId);

            qbcketoan.SetResultTransformer(Transformers.AliasToBean<SxRpQtSanXuatDTO>());
            IList<SxRpQtSanXuatDTO> lstNhap = qbcketoan.List<SxRpQtSanXuatDTO>();

            qbcketoan = NHibernateSession.CreateQuery(sqlXuat);
            qbcketoan.SetParameter("TuNgay", TuNgay);
            qbcketoan.SetParameter("DenNgay", DenNgay);
            if (!VnsCheck.IsNullGuid(HanghoaId)) qbcketoan.SetParameter("HanghoaId", HanghoaId);
            if (!VnsCheck.IsNullGuid(LenhSxId)) qbcketoan.SetParameter("LenhSxId", LenhSxId);
            if (!VnsCheck.IsNullGuid(KeHoachId)) qbcketoan.SetParameter("KeHoachId", KeHoachId);
            if (dsMaTk.Count > 0) qbcketoan.SetParameterList("dsMaTk", dsMaTk);
            qbcketoan.SetParameter("DonviId", DonviId);

            qbcketoan.SetResultTransformer(Transformers.AliasToBean<SxRpQtSanXuatDTO>());
            IList<SxRpQtSanXuatDTO> lstXuat = qbcketoan.List<SxRpQtSanXuatDTO>();

            List<SxRpQtSanXuatDTO> lst = new List<SxRpQtSanXuatDTO>(lstNhap);
            lst.AddRange(lstXuat);

            return lst;
        }

        public IList<SxRpQtSanXuatDTO> GetDataKeHoach(DateTime TuNgay, DateTime DenNgay,
            Guid KeHoachId, Guid LenhSxId, Guid KhoId, Guid PhanXuongId, Guid HanghoaId,
            Guid DonviId)
        {
            String sqlNhapKho = "select lsx.SoLenhSanXuat as SoChungTu, lsx.NgayGiaoLenh as NgayChungTu, lsx.MoTa as DienGiai, lsx.KyHieuLoaiCt as LoaiNghiepVu, lsx.IdLoaiCt as IdLoaiCt, " +
                //"0 as DonGia, " +
                "lsxd.SoLuong as SoLuong," +
                //"0 as SoTien, " +
                "lsx.Id as CthNxId, lsxd.Id as CtdNxId, " +
                "lsxd.VatlieuDauraId as HanghoaId, vt.MaHanghoa as MaHanghoa, vt.TenHanghoa as TenHanghoa, " + 
                "lsx.DonviId as DonviId, cast(0 as decimal) as Xuat, " +
                "lsx.Id as LenhSanXuatId, lsx.SoLenhSanXuat as SoLenhSanXuat, lsx.KehoachMId as KeHoachId, lsx.SoKeHoach as SoKeHoach, " +
                "lsx.TosanxuatId as PhanXuongId, lsx.MaToSanXuat as MaPhanXuong, " +
                "qt.TenQuytrinh as TenQuytrinh, kh.TenSanpham as TenSanpham " +
                //"bc.TenDvt as TenDvt " +
             "from SxLenhsanxuat lsx inner join lsx.LstLenhSanXuatDetail lsxd " +
             "inner join lsx.ObjKeHoachSx kh " +
             "inner join lsxd.ObjVatlieuDaura as vt " +
             "inner join lsx.ObjDmQuyTrinh as qt " +
             "where 1 = 1 " +
             (VnsCheck.IsNullGuid(HanghoaId) ? "" : "AND lsxd.VatlieuDauraId = :HanghoaId ") +
             (VnsCheck.IsNullGuid(LenhSxId) ? "" : "AND (lsx.Id = :LenhSxId) ") +
             (VnsCheck.IsNullGuid(KeHoachId) ? "" : "AND (lsx.KehoachMId = :KeHoachId) ") +
               //"AND lsx.NgayBanHanh >= :TuNgay And lsx.NgayBanHanh <= :DenNgay " +
               "AND lsxd.VatlieuDauraId <> :NullGuid " +
               "AND lsx.DonviId = :DonviId ";

            String sqlXuat = "select lsx.SoLenhSanXuat as SoChungTu, lsx.NgayGiaoLenh as NgayChungTu, lsx.MoTa as DienGiai, lsx.KyHieuLoaiCt as LoaiNghiepVu, lsx.IdLoaiCt as IdLoaiCt, " +
                //"0 as DonGia, " +
                "lsxd.SoLuong as SoLuong," +
                //"0 as SoTien, " +
                "lsx.Id as CthNxId, lsxd.Id as CtdNxId, " +
                "lsxd.VatlieuDauvaoId as HanghoaId, vt.MaHanghoa as MaHanghoa, vt.TenHanghoa as TenHanghoa, " +
                "lsx.DonviId as DonviId, cast(1 as decimal) as Xuat, " +
                "lsx.Id as LenhSanXuatId, lsx.SoLenhSanXuat as SoLenhSanXuat, lsx.KehoachMId as KeHoachId, lsx.SoKeHoach as SoKeHoach, " +
                "lsx.TosanxuatId as PhanXuongId, lsx.MaToSanXuat as MaPhanXuong, " +
                "qt.TenQuytrinh as TenQuytrinh, kh.TenSanpham as TenSanpham " +
                //"bc.TenDvt as TenDvt " +
             "from SxLenhsanxuat lsx inner join lsx.LstLenhSanXuatDetail lsxd " +
             "inner join lsx.ObjKeHoachSx kh " +
             "inner join lsxd.ObjVatlieuDauvao as vt " +
             "inner join lsx.ObjDmQuyTrinh as qt " +
             "where 1 = 1 " +
             (VnsCheck.IsNullGuid(HanghoaId) ? "" : "AND lsxd.VatlieuDauraId = :HanghoaId ") +
             (VnsCheck.IsNullGuid(LenhSxId) ? "" : "AND (lsx.Id = :LenhSxId) ") +
             (VnsCheck.IsNullGuid(KeHoachId) ? "" : "AND (lsx.KehoachMId = :KeHoachId) ") +
               //"AND lsx.NgayBanHanh >= :TuNgay And lsx.NgayBanHanh <= :DenNgay " +
               "AND lsxd.VatlieuDauvaoId <> :NullGuid " +
               "AND lsx.DonviId = :DonviId ";

            IQuery qbcketoan = NHibernateSession.CreateQuery(sqlNhapKho);
            //qbcketoan.SetParameter("TuNgay", TuNgay);
            //qbcketoan.SetParameter("DenNgay", DenNgay);
            if (!VnsCheck.IsNullGuid(HanghoaId)) qbcketoan.SetParameter("HanghoaId", HanghoaId);
            if (!VnsCheck.IsNullGuid(LenhSxId)) qbcketoan.SetParameter("LenhSxId", LenhSxId);
            if (!VnsCheck.IsNullGuid(KeHoachId)) qbcketoan.SetParameter("KeHoachId", KeHoachId);
            qbcketoan.SetParameter("NullGuid", Null.NullGuid);
            qbcketoan.SetParameter("DonviId", DonviId);

            qbcketoan.SetResultTransformer(Transformers.AliasToBean<SxRpQtSanXuatDTO>());
            IList<SxRpQtSanXuatDTO> lstNhap = qbcketoan.List<SxRpQtSanXuatDTO>();

            qbcketoan = NHibernateSession.CreateQuery(sqlXuat);
            //qbcketoan.SetParameter("TuNgay", TuNgay);
            //qbcketoan.SetParameter("DenNgay", DenNgay);
            if (!VnsCheck.IsNullGuid(HanghoaId)) qbcketoan.SetParameter("HanghoaId", HanghoaId);
            if (!VnsCheck.IsNullGuid(LenhSxId)) qbcketoan.SetParameter("LenhSxId", LenhSxId);
            if (!VnsCheck.IsNullGuid(KeHoachId)) qbcketoan.SetParameter("KeHoachId", KeHoachId);
            qbcketoan.SetParameter("NullGuid", Null.NullGuid);
            qbcketoan.SetParameter("DonviId", DonviId);

            qbcketoan.SetResultTransformer(Transformers.AliasToBean<SxRpQtSanXuatDTO>());
            IList<SxRpQtSanXuatDTO> lstXuat = qbcketoan.List<SxRpQtSanXuatDTO>();

            List<SxRpQtSanXuatDTO> lst = new List<SxRpQtSanXuatDTO>(lstNhap);
            lst.AddRange(lstXuat);

            return lst;
        }

        public IList<SxBkSanLuongDTO> GetBangKeSanLuong(DateTime TuNgay, DateTime DenNgay,
            Guid KeHoachId, Guid LenhSxId, Guid KhoId, Guid PhanXuongId, Guid SanPhamId,
            Guid DonviId)
        {
            String sqlSanLuong = "Select m.Id as KiemKeHId, d.Id as KiemKeDId, d.LenhSanXuatId as LenhSanXuatId, " +
                " m.NgayKiemKe as NgayKiemKe, m.CaKiemKe as CaKiemKe, " +
                " lsx.SoKeHoach as SoLenhSanXuat, " +
                " m.TosanxuatId as ToSanXuatId, " +
                " d.SanPhamId as HanghoaId, sp.MaHanghoa as MaHanghoa, sp.TenHanghoa as TenHanghoa, " +
                " d.DvtId as DvtId, " +
                " d.SoLuong as SoLuong, d.LoaiKiemKe as LoaiKiemKe " +
                " From SxPhieuKiemke m inner join m.LstSxPhieuKiemkeSlD d " +
                " inner join d.ObjLenhSanXuat lsx " +
                " inner join d.ObjSanPham sp " +
                 "where 1 = 1 " +
             (VnsCheck.IsNullGuid(SanPhamId) ? "" : "AND m.SanPhamId = :SanPhamId ") +
             (VnsCheck.IsNullGuid(LenhSxId) ? "" : "AND (d.LenhSanXuatId = :LenhSxId) ") +
             (VnsCheck.IsNullGuid(PhanXuongId) ? "" : "AND (m.TosanxuatId = :PhanXuongId) ") +
               "AND m.DonviId = :DonviId ";

            IQuery qbcketoan = NHibernateSession.CreateQuery(sqlSanLuong);
            //qbcketoan.SetParameter("TuNgay", TuNgay);
            //qbcketoan.SetParameter("DenNgay", DenNgay);
            if (!VnsCheck.IsNullGuid(SanPhamId)) qbcketoan.SetParameter("SanPhamId", SanPhamId);
            if (!VnsCheck.IsNullGuid(LenhSxId)) qbcketoan.SetParameter("LenhSxId", LenhSxId);
            if (!VnsCheck.IsNullGuid(PhanXuongId)) qbcketoan.SetParameter("PhanXuongId", PhanXuongId);
            qbcketoan.SetParameter("DonviId", DonviId);

            qbcketoan.SetResultTransformer(Transformers.AliasToBean<SxBkSanLuongDTO>());
            IList<SxBkSanLuongDTO> lstSanLuong = qbcketoan.List<SxBkSanLuongDTO>();
            return lstSanLuong;
        }

        public IList<SxBkVatLieuDTO> GetBangKeVatLieu(DateTime TuNgay, DateTime DenNgay,
            Guid KeHoachId, Guid LenhSxId, Guid KhoId, Guid PhanXuongId, Guid VatTuId,
            Guid DonviId)
        {
            String sqlVatLieu = "Select m.Id as KiemKeHId, d.Id as KiemKeDId, d.LenhSanXuatId as LenhSanXuatId, " +
                           " m.NgayKiemKe as NgayKiemKe, m.CaKiemKe as CaKiemKe, " +
                           " lsx.SoKeHoach as SoLenhSanXuat, " +
                           " m.TosanxuatId as ToSanXuatId, " +
                           " d.VatTuId as HanghoaId, vt.MaHanghoa as MaHanghoa, vt.TenHanghoa as TenHanghoa, " +
                           " d.DvtId as DvtId, " +
                           " d.SoLuong as SoLuong, d.LoaiChiPhi as LoaiKiemKe " +
                           " From SxPhieuKiemke m inner join m.LstSxPhieuKiemkeVtD d " +
                           " inner join d.ObjLenhSanXuat lsx " +
                           " inner join d.ObjVatLieu vt " +
                            "where 1 = 1 " +
                        (VnsCheck.IsNullGuid(VatTuId) ? "" : "AND d.VatTuId = :VatTuId ") +
                        (VnsCheck.IsNullGuid(LenhSxId) ? "" : "AND (d.LenhSanXuatId = :LenhSxId) ") +
                        (VnsCheck.IsNullGuid(PhanXuongId) ? "" : "AND (m.TosanxuatId = :PhanXuongId) ") +
                          "AND m.DonviId = :DonviId ";

            IQuery qbcketoan = NHibernateSession.CreateQuery(sqlVatLieu);
            //qbcketoan.SetParameter("TuNgay", TuNgay);
            //qbcketoan.SetParameter("DenNgay", DenNgay);
            if (!VnsCheck.IsNullGuid(VatTuId)) qbcketoan.SetParameter("VatTuId", VatTuId);
            if (!VnsCheck.IsNullGuid(LenhSxId)) qbcketoan.SetParameter("LenhSxId", LenhSxId);
            if (!VnsCheck.IsNullGuid(PhanXuongId)) qbcketoan.SetParameter("PhanXuongId", PhanXuongId);
            qbcketoan.SetParameter("DonviId", DonviId);

            qbcketoan.SetResultTransformer(Transformers.AliasToBean<SxBkVatLieuDTO>());
            IList<SxBkVatLieuDTO> lstVatLieu = qbcketoan.List<SxBkVatLieuDTO>();
            return lstVatLieu;
        }

        public IList<BcKeToanKhoDTO> GetTongHopHangDiDuong(DateTime DenNgay, Guid DonviId, Boolean IsNhap)
        {
            IList<BcKeToanKhoDTO> lstSoLuong = new List<BcKeToanKhoDTO>();

            string MaNghiepVu = "MaTknGiavon";
            if (!IsNhap) { MaNghiepVu = "MaTkcGiavon"; }
            
            string sSoLuong = "SoLuongNhap";
            if (!IsNhap) { sSoLuong = "SoLuongXuat"; }

            List<String> lstNghiepVu = new List<string>();
            lstNghiepVu.Add("151");

            string dkSoLuong = "";
            string dkXuat = "";
            int icount = 0;
            foreach (string nv in lstNghiepVu)
            {
                if (!String.IsNullOrEmpty(dkSoLuong))
                {
                    dkSoLuong += " OR ";
                    dkXuat += " OR ";
                }
                dkSoLuong += String.Format(" bc.{0} like :MaTk{1} ", MaNghiepVu, icount);
                icount++;
            }
            String sqlSanLuongNhap = "Select bc.HanghoaId as HanghoaId, bc.MaVuviec as MaVuviec, " +
                String.Format("bc.{0} as {0}, bc.{1} as {1}, Sum(bc.SoLuong) as {2} ", MaNghiepVu, "Cang", sSoLuong) +
                "From BcKetoanKho bc " +
                "Where bc.NgayCt <= :DenNgay " +
                (string.IsNullOrEmpty(dkSoLuong) ? "" : String.Format("AND ({0}) ", dkSoLuong)) +
                "And bc.DonviId = :DonviId " +
                String.Format("Group by bc.HanghoaId, bc.{0}, bc.{1}, bc.MaVuviec ", MaNghiepVu, "Cang");

            IQuery qSoLuong = NHibernateSession.CreateQuery(sqlSanLuongNhap);
            qSoLuong.SetParameter("DenNgay", DenNgay);
            icount = 0;
            foreach (string nv in lstNghiepVu)
            {
                qSoLuong.SetParameter(String.Format("MaTk{0}", icount), nv);
                icount++;
            }
            qSoLuong.SetParameter("DonviId", DonviId);
            qSoLuong.SetResultTransformer(Transformers.AliasToBean<BcKeToanKhoDTO>());
            lstSoLuong = qSoLuong.List<BcKeToanKhoDTO>();

            return lstSoLuong;
        }

        public IList<BcKeToanKhoDTO> GetTongHopKho(DateTime DenNgay, Guid DonviId, Boolean IsNhap)
        {
            IList<BcKeToanKhoDTO> lstSoLuong = new List<BcKeToanKhoDTO>();

            string MaNghiepVu = "MaTknGiavon";
            if (!IsNhap) { MaNghiepVu = "MaTkcGiavon"; }

            string MaKho = "KhoNhapId";
            if (!IsNhap) { MaKho = "KhoXuatId"; }

            string sSoLuong = "SoLuongNhap";
            if (!IsNhap) { sSoLuong = "SoLuongXuat"; }

            List<String> lstNghiepVu = new List<string>();
            lstNghiepVu.Add("152");

            string dkSoLuong = "";
            string dkXuat = "";
            int icount = 0;
            foreach (string nv in lstNghiepVu)
            {
                if (!String.IsNullOrEmpty(dkSoLuong))
                {
                    dkSoLuong += " OR ";
                    dkXuat += " OR ";
                }
                dkSoLuong += String.Format(" bc.{0} like :MaTk{1} ", MaNghiepVu, icount);
                icount++;
            }
            String sqlSanLuongNhap = "Select bc.HanghoaId as HanghoaId, bc.MaVuviec as MaVuviec, " +
                String.Format("bc.{0} as {0}, bc.{1} as {1}, Sum(bc.SoLuong) as {2} ", MaNghiepVu, MaKho, sSoLuong) +
                "From BcKetoanKho bc " +
                "Where bc.NgayCt <= :DenNgay " +
                (string.IsNullOrEmpty(dkSoLuong) ? "" : String.Format("AND ({0}) ", dkSoLuong)) +
                "And bc.DonviId = :DonviId " +
                String.Format("Group by bc.HanghoaId, bc.{0}, bc.{1}, bc.MaVuviec ", MaNghiepVu, MaKho);
            
            IQuery qSoLuong = NHibernateSession.CreateQuery(sqlSanLuongNhap);
            qSoLuong.SetParameter("DenNgay", DenNgay);
            icount = 0;
            foreach (string nv in lstNghiepVu)
            {
                qSoLuong.SetParameter(String.Format("MaTk{0}", icount), nv);
                icount++;
            }
            qSoLuong.SetParameter("DonviId", DonviId);
            qSoLuong.SetResultTransformer(Transformers.AliasToBean<BcKeToanKhoDTO>());
            lstSoLuong = qSoLuong.List<BcKeToanKhoDTO>();

            return lstSoLuong;
        }
        
        public IList<BcKeToanKhoDTO> GetBangKeOpec(DateTime TuNgay, DateTime DenNgay, Guid DonviId, Boolean IsNhap)
        {
            IList<BcKeToanKhoDTO> lstSoLuong = new List<BcKeToanKhoDTO>();

            string MaNghiepVu = "MaTknGiavon";
            if (!IsNhap) { MaNghiepVu = "MaTkcGiavon"; }

            string MaKho = "KhoNhapId";
            if (!IsNhap) { MaKho = "KhoXuatId"; }

            string sSoLuong = "SoLuongNhap";
            if (!IsNhap) { sSoLuong = "SoLuongXuat"; }

            List<String> lstNghiepVu = new List<string>();
            lstNghiepVu.Add("151");
            lstNghiepVu.Add("152");

            string dkSoLuong = "";
            string dkXuat = "";
            int icount = 0;
            foreach (string nv in lstNghiepVu)
            {
                if (!String.IsNullOrEmpty(dkSoLuong))
                {
                    dkSoLuong += " OR ";
                    dkXuat += " OR ";
                }
                dkSoLuong += String.Format(" bc.{0} like :MaTk{1} ", MaNghiepVu, icount);
                icount++;
            }
            String sqlSanLuongNhap = "Select bc.KyHieuLoaiCt as KyHieuLoaiCt, bc.NgayCt as NgayCt, bc.HanghoaId as HanghoaId, bc.MaVuviec as MaVuviec, bc.MaHopdong as MaHopdong, " +
                String.Format("bc.Cang as Cang, bc.{0} as MaTk, bc.{1} as KhoId, bc.SoLuong as {2} ", MaNghiepVu, MaKho, sSoLuong) +
                "From BcKetoanKho bc " +
                "Where bc.NgayCt <= :DenNgay And bc.NgayCt >= :TuNgay " +
                (string.IsNullOrEmpty(dkSoLuong) ? "" : String.Format("AND ({0}) ", dkSoLuong)) +
                "And bc.DonviId = :DonviId ";

            IQuery qSoLuong = NHibernateSession.CreateQuery(sqlSanLuongNhap);
            qSoLuong.SetParameter("TuNgay", TuNgay);
            qSoLuong.SetParameter("DenNgay", DenNgay);
            icount = 0;
            foreach (string nv in lstNghiepVu)
            {
                qSoLuong.SetParameter(String.Format("MaTk{0}", icount), nv);
                icount++;
            }
            qSoLuong.SetParameter("DonviId", DonviId);
            qSoLuong.SetResultTransformer(Transformers.AliasToBean<BcKeToanKhoDTO>());
            lstSoLuong = qSoLuong.List<BcKeToanKhoDTO>();

            return lstSoLuong;
        }
    }
}
