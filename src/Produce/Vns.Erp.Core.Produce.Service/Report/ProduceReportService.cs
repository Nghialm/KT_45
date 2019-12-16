using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Produce.Domain;
using Vns.Erp.Core.Produce.Dao;
using Vns.Erp.Core.Produce.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using Vns.Erp.Core.Produce.Service.Interface.Report;
using Vns.Erp.Core.Produce.Domain.Report;
using Vns.Erp.Core.Produce.Dao.Report;

using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;

//using Vns.Erp.Core.ac

namespace Vns.Erp.Core.Produce.Service.Report
{
    public class ProduceReportService : GenericService<SxKehoachM, System.Guid>, IProduceReportService
    {
        public IProduceReportDao ProduceReportDao
        {
            get { return (IProduceReportDao)Dao; }
            set { Dao = value; }
        }

        public IDmKhoDao DmKhoDao
        {
            get;set;
        }

        public IDmHanghoaDao DmHanghoaDao
        { get; set; }

        public IDmNhomvattu1Dao DmNhomvattu1Dao
        { get; set; }

        public IDmHopdongDao DmHopdongDao
        { get; set; }

        public IHtDanhmucDao HtDanhmucDao
        { get; set; }

        public IBangGiaHDao BangGiaHDao
        { get; set; }

        public IBangGiaDDao BangGiaDDao
        { get; set; }

        #region Report quan ly san xuat
        public IList<SxRpQtSanXuatDTO> GetDataSanXuatNguyenVatLieu(DateTime TuNgay, DateTime DenNgay,
            Guid KeHoachId, Guid LenhSxId, Guid KhoId, Guid PhanXuongId, Guid HanghoaId,
            Guid DonviId)
        {
            List<String> lst = Produce.Common.Common.lstMtkNvl();
            
            return ProduceReportDao.GetDataSanXuat(TuNgay, DenNgay, KeHoachId, LenhSxId, KhoId, PhanXuongId, HanghoaId, lst, DonviId);
        }

        public IList<SxRpQtSanXuatDTO> GetDataSanXuatVatTu(DateTime TuNgay, DateTime DenNgay,
            Guid KeHoachId, Guid LenhSxId, Guid KhoId, Guid PhanXuongId, Guid HanghoaId,
            Guid DonviId)
        {
            List<String> lst = Produce.Common.Common.lstMtkVatTu();
            
            return ProduceReportDao.GetDataSanXuat(TuNgay, DenNgay, KeHoachId, LenhSxId, KhoId, PhanXuongId, HanghoaId, lst, DonviId);
        }

        public IList<SxRpQtSanXuatDTO> GetDataKeHoach(DateTime TuNgay, DateTime DenNgay,
            Guid KeHoachId, Guid LenhSxId, Guid KhoId, Guid PhanXuongId, Guid HanghoaId,
            Guid DonviId)
        {
            return ProduceReportDao.GetDataKeHoach(TuNgay, DenNgay, KeHoachId, LenhSxId, KhoId, PhanXuongId, HanghoaId, DonviId);
        }

        public IList<SxRpQtSanXuatDTO> GetDataSanXuat(DateTime TuNgay, DateTime DenNgay,
            Guid KeHoachId, Guid LenhSxId, Guid KhoId, Guid PhanXuongId, Guid HanghoaId,
            Guid DonviId, int LoaiVatTu)
        {
            List<String> lst = Produce.Common.Common.lstMtkVatTu();
            switch (LoaiVatTu)
            {
                case (int)Produce.Common.LoaiVatTu.VatTu:
                    lst = Produce.Common.Common.lstMtkVatTu();
                    break;
                case (int)Produce.Common.LoaiVatTu.NguyenVatLieu:
                    lst = Produce.Common.Common.lstMtkNvl();
                    break;
                default:
                    lst = new List<string>();
                    break;
            }

            return ProduceReportDao.GetDataSanXuat(TuNgay, DenNgay, KeHoachId, LenhSxId, KhoId, PhanXuongId, HanghoaId, lst, DonviId);
        }

        public IList<SxRpQtSanXuatThDTO> GetDataTongHopSanXuat(DateTime TuNgay, DateTime DenNgay,
            Guid KeHoachId, Guid LenhSxId, Guid KhoId, Guid PhanXuongId, Guid HanghoaId,
            Guid DonviId, int LoaiVatTu)
        {
            IList<SxRpQtSanXuatThDTO> lstrptt = new List<SxRpQtSanXuatThDTO>();
            List<String> lst = Produce.Common.Common.lstMtkVatTu();
            switch (LoaiVatTu)
            {
                case (int)Produce.Common.LoaiVatTu.VatTu:
                    lst = Produce.Common.Common.lstMtkVatTu();
                    break;
                case (int)Produce.Common.LoaiVatTu.NguyenVatLieu:
                    lst = Produce.Common.Common.lstMtkNvl();
                    break;
                default:
                    lst = new List<string>();
                    break;
            }

            IList<SxRpQtSanXuatDTO> thucte = ProduceReportDao.GetDataSanXuat(TuNgay, DenNgay, KeHoachId, LenhSxId, KhoId, PhanXuongId, HanghoaId, lst, DonviId);
            List<SxRpQtSanXuatDTO> lsttt = new List<SxRpQtSanXuatDTO>(thucte);
            lsttt.Sort(SxRpQtSanXuatDTO.CompareGroupId);

            string groupid = "";
            SxRpQtSanXuatThDTO tmp = new SxRpQtSanXuatThDTO();
            foreach (SxRpQtSanXuatDTO tt in lsttt)
            {
                if (tt.IdGroup != groupid)
                {
                    groupid = tt.IdGroup;
                    tmp = new SxRpQtSanXuatThDTO(tt);
                    lstrptt.Add(tmp);
                }

                tmp.SoLuongThucTe += tt.SoLuong;
            }

            IList<SxRpQtSanXuatDTO> kehoach = ProduceReportDao.GetDataKeHoach(TuNgay, DenNgay, KeHoachId, LenhSxId, KhoId, PhanXuongId, HanghoaId, DonviId);
            List<SxRpQtSanXuatDTO> lstkh = new List<SxRpQtSanXuatDTO>(kehoach);
            lstkh.Sort(SxRpQtSanXuatDTO.CompareGroupId);

            IList<SxRpQtSanXuatThDTO> lstrpkh = new List<SxRpQtSanXuatThDTO>();

            groupid = "";
            tmp = new SxRpQtSanXuatThDTO();
            foreach (SxRpQtSanXuatDTO kh in lstkh)
            {
                if (kh.IdGroup != groupid)
                {
                    groupid = kh.IdGroup;
                    tmp = new SxRpQtSanXuatThDTO(kh);
                    lstrpkh.Add(tmp);
                }

                tmp.SoLuongKeHoach += kh.SoLuong;
            }

            foreach (SxRpQtSanXuatThDTO tmpkh in lstrpkh)
            {
                Boolean isexist = false;
                foreach (SxRpQtSanXuatThDTO tmptt in lstrptt)
                {
                    if (tmpkh.IdGroup == tmptt.IdGroup)
                    {
                        tmptt.SoLuongKeHoach = tmpkh.SoLuongKeHoach;
                        isexist = true;
                        break;
                    }
                }
                if (!isexist) lstrptt.Add(tmpkh);
            }

            return lstrptt;
        }

        public IList<SxBkSanLuongDTO> GetBangKeSanLuong(DateTime TuNgay, DateTime DenNgay,
            Guid KeHoachId, Guid LenhSxId, Guid KhoId, Guid PhanXuongId, Guid SanPhamId,
            Guid DonviId)
        {
            return ProduceReportDao.GetBangKeSanLuong(TuNgay, DenNgay, KeHoachId, LenhSxId, KhoId, PhanXuongId, SanPhamId, DonviId);
        }

        public IList<SxBkVatLieuDTO> GetBangKeVatLieu(DateTime TuNgay, DateTime DenNgay,
            Guid KeHoachId, Guid LenhSxId, Guid KhoId, Guid PhanXuongId, Guid VatTuId,
            Guid DonviId)
        {
            return ProduceReportDao.GetBangKeVatLieu(TuNgay, DenNgay, KeHoachId, LenhSxId, KhoId, PhanXuongId, VatTuId, DonviId);
        }
        #endregion

        #region Report bang gia
        /// <summary>
        /// Lay thong tin cho bang gia moi nhat theo ngay
        /// </summary>
        /// <param name="DenNgay"></param>
        /// <param name="DonviId"></param>
        /// <returns></returns>
        public IList<BangGiaD> GetBangGiaTheoNgay(DateTime DenNgay, Guid DonviId)
        {
            IList<DonGiaDTO> lstThongTinHdd = new List<DonGiaDTO>();
            IList<DonGiaDTO> lstThongTinHtk = new List<DonGiaDTO>();

            IList<BcKeToanKhoDTO> lstNhapHdd = ProduceReportDao.GetTongHopHangDiDuong(DenNgay, DonviId, true);
            IList<BcKeToanKhoDTO> lstXuatHdd = ProduceReportDao.GetTongHopHangDiDuong(DenNgay, DonviId, false);

            IList<BcKeToanKhoDTO> lstNhap = ProduceReportDao.GetTongHopKho(DenNgay, DonviId, true);
            IList<BcKeToanKhoDTO> lstXuat = ProduceReportDao.GetTongHopKho(DenNgay, DonviId, false);

            #region Hang di duong
            foreach (BcKeToanKhoDTO nhap in lstNhapHdd)
            {
                Boolean IsMapping = false;
                foreach (BcKeToanKhoDTO xuat in lstXuatHdd)
                {
                    if (nhap.HanghoaId == xuat.HanghoaId &&
                        nhap.KhoNhapId == xuat.KhoXuatId &&
                        nhap.MaTknGiavon == xuat.MaTkcGiavon)
                    {
                        lstThongTinHdd.Add(new DonGiaDTO(nhap, xuat));
                        IsMapping = true;
                        continue;
                    }
                }
                if (!IsMapping)
                    lstThongTinHdd.Add(new DonGiaDTO(nhap));
            }
            #endregion

            #region hang trong kho
            foreach (BcKeToanKhoDTO nhap in lstNhap)
            {
                Boolean IsMapping = false;
                foreach (BcKeToanKhoDTO xuat in lstXuat)
                {
                    if (nhap.HanghoaId == xuat.HanghoaId &&
                        nhap.KhoNhapId == xuat.KhoXuatId &&
                        nhap.MaTknGiavon == xuat.MaTkcGiavon)
                    {
                        lstThongTinHtk.Add(new DonGiaDTO(nhap, xuat));
                        IsMapping = true;
                        continue;
                    }
                }
                if (!IsMapping)
                    lstThongTinHtk.Add(new DonGiaDTO(nhap));
            }
            #endregion

            List<DonGiaDTO> lst = new List<DonGiaDTO>();
            lst.AddRange(lstThongTinHtk);
            lst.AddRange(lstThongTinHdd);

            IList<BangGiaD> lstThongtinBangGia = new List<BangGiaD>();
            foreach (DonGiaDTO dg in lst)
            {
                lstThongtinBangGia.Add(new BangGiaD(dg));
            }

            //Lay thong tin bang gia moi nhat theo ngay
            BangGiaH banggiaH = new BangGiaH();
            banggiaH = BangGiaHDao.GetBangGiaLastest(DenNgay, DonviId);
            if (banggiaH == null) return null;
            banggiaH.lstBangGiaD = BangGiaDDao.GetByH(banggiaH.Id);
            List<BangGiaD> lstBangGia = new List<BangGiaD>(banggiaH.lstBangGiaD);
            foreach (BangGiaD ttbg in lstThongtinBangGia)
            {
                foreach (BangGiaD bg in lstBangGia)
                {
                    if (ttbg.HanghoaId == bg.HanghoaId && 
                        ttbg.KhoId == bg.KhoId && 
                        ttbg.Cang == bg.Cang && 
                        ttbg.MaVanChuyen == bg.MaVanChuyen && 
                        ttbg.MaNghiepVu == bg.MaNghiepVu)
                    {
                        ttbg.DonGia = bg.DonGia;
                        ttbg.DonGiaUsd = bg.DonGiaUsd;
                    }
                }
            }

            lstThongtinBangGia = LayThongtinLienQuanBangGia(lstThongtinBangGia, DonviId);

            return lstThongtinBangGia;
        }

        /// <summary>
        /// Lay bang gia moi nhat theo ngay
        /// </summary>
        /// <param name="DenNgay"></param>
        /// <param name="DonviId"></param>
        /// <returns></returns>
        public BangGiaH GetBangGiaDaLuuNgay(DateTime DenNgay, Guid DonviId)
        {
            BangGiaH banggiaH = new BangGiaH();
            banggiaH = BangGiaHDao.GetBangGiaLastest(DenNgay, DonviId);

            //Gan gia tri mac dinh
            banggiaH.lstBangGiaD = LayThongtinLienQuanBangGia(banggiaH.lstBangGiaD, DonviId);

            return banggiaH;
        }

        public BangGiaH GetBangGia(BangGiaH banggiaH)
        {
            banggiaH.lstBangGiaD = BangGiaDDao.GetByH(banggiaH.Id);

            //Gan gia tri mac dinh
            banggiaH.lstBangGiaD = LayThongtinLienQuanBangGia(banggiaH.lstBangGiaD, banggiaH.DonviId);

            return banggiaH;
        }

        //public IList<BangGiaD> GetBangGia(DateTime DenNgay, Guid DonviId)
        //{
        //    //IList<DonGiaDTO> lstBangGiaHdd = new List<DonGiaDTO>();
        //    //IList<DonGiaDTO> lstBangGia = new List<DonGiaDTO>();
            
        //    IList<DmHanghoa> lstHanghoa = DmHanghoaDao.GetAllByDonviID(DonviId);
        //    IList<DmNhomvattu1> lstNhomvattu = DmNhomvattu1Dao.GetObjectAllByDonviID(DonviId);
        //    IList<DmKho> lstDmKho = DmKhoDao.GetAllByDonviID(DonviId);
        //    ArrayList props = new ArrayList();
        //    ArrayList values = new ArrayList();
        //    props.Add("Doituong");
        //    values.Add("CANG");
        //    IList<HtDanhmuc> lstHtDanhmuc = HtDanhmucDao.List(-1, -1, props, values);
            
        //    IList<BangGiaD> lstBangGiaD = new List<BangGiaD>();
        //    lstBangGiaD = GetBangGiaTheoNgay(DenNgay, DonviId);

        //    foreach (BangGiaD banggia in lstBangGiaD)
        //    {
        //        foreach (DmHanghoa hh in lstHanghoa)
        //        {
        //            if (banggia.HanghoaId == hh.Id)
        //            {
        //                banggia.TypeId = hh.IdNhomVt1;
        //                banggia.ApplicationId = hh.IdNhomVt2;
        //                break;
        //            }

        //            if (banggia.MaNghiepVu == "151")
        //            {
        //                foreach (HtDanhmuc dm in lstHtDanhmuc)
        //                {
        //                    if (banggia.Cang == dm.GiaTri)
        //                    {
        //                        banggia.Cang = dm.Loai;
        //                        banggia.KhuVuc = dm.TenDanhmuc;
        //                        break;
        //                    }
        //                }
        //            }

        //            if (banggia.MaNghiepVu == "152")
        //            {
        //                foreach (DmKho kho in lstDmKho)
        //                {
        //                    if (banggia.KhoId == kho.Id)
        //                    {
        //                        banggia.KhuVuc = kho.TenKho;
        //                        break;
        //                    }
        //                }
        //            }
        //        }
        //    }
            
        //    return lstBangGiaD;
        //}

        private IList<BangGiaD> LayThongtinLienQuanBangGia(IList<BangGiaD> lstBangGiaD, Guid DonviId)
        {
            IList<DmHanghoa> lstHanghoa = DmHanghoaDao.GetAllByDonviID(DonviId);
            IList<DmNhomvattu1> lstNhomvattu = DmNhomvattu1Dao.GetObjectAllByDonviID(DonviId);
            IList<DmKho> lstDmKho = DmKhoDao.GetAllByDonviID(DonviId);
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("Doituong");
            values.Add("CANG");
            IList<HtDanhmuc> lstHtDanhmuc = HtDanhmucDao.List(-1, -1, props, values);

            foreach (BangGiaD banggia in lstBangGiaD)
            {
                foreach (DmHanghoa hh in lstHanghoa)
                {
                    if (banggia.HanghoaId == hh.Id)
                    {
                        banggia.TypeId = hh.IdNhomVt1;
                        banggia.ApplicationId = hh.IdNhomVt2;
                        break;
                    }

                    if (banggia.MaNghiepVu == "151")
                    {
                        foreach (HtDanhmuc dm in lstHtDanhmuc)
                        {
                            if (banggia.Cang == dm.GiaTri)
                            {
                                banggia.Cang = dm.Loai;
                                banggia.KhuVuc = dm.TenDanhmuc;
                                break;
                            }
                        }
                    }

                    if (banggia.MaNghiepVu == "152")
                    {
                        foreach (DmKho kho in lstDmKho)
                        {
                            if (banggia.KhoId == kho.Id)
                            {
                                banggia.KhuVuc = kho.TenKho;
                                break;
                            }
                        }
                    }
                }
            }

            return lstBangGiaD;
        }

        public IList<BcKeToanKhoDTO> GetBangKe(DateTime TuNgay, DateTime DenNgay, Guid DonviId)
        {
            IList<DmHopdong> lstDmHopdong = DmHopdongDao.GetAllByDonviID(DonviId);
            IList<DmKho> lstDmKho = DmKhoDao.GetAllByDonviID(DonviId);

            IList<BcKeToanKhoDTO> lstNhap = ProduceReportDao.GetBangKeOpec(TuNgay, DenNgay, DonviId, true);
            IList<BcKeToanKhoDTO> lstXuat = ProduceReportDao.GetBangKeOpec(TuNgay, DenNgay, DonviId, false);

            IList<DmHanghoa> lstHanghoa = DmHanghoaDao.GetAllByDonviID(DonviId);

            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("Doituong");
            values.Add("CANG");
            IList<HtDanhmuc> lstCang = HtDanhmucDao.List(-1, -1, props, values);

            List<BcKeToanKhoDTO> lstBangKe = new List<BcKeToanKhoDTO>(lstNhap);
            lstBangKe.AddRange(lstXuat);

            foreach (BcKeToanKhoDTO obj in lstBangKe)
            {
                foreach (DmHanghoa hh in lstHanghoa)
                {
                    if (obj.HanghoaId == hh.Id)
                    {
                        obj.TypeId = hh.IdNhomVt1;
                        obj.ApplicationId = hh.IdNhomVt2;
                    }
                }

                if (obj.MaTk == "152")
                {
                    foreach (DmKho kho in lstDmKho)
                    {
                        if (obj.KhoId == kho.Id)
                        {
                            obj.DiaLy = kho.DiaLy;
                            obj.KhuVuc = kho.TenKho;
                            break;
                        }
                    }
                }

                if (obj.MaTk == "151")
                {
                    foreach (HtDanhmuc dm in lstCang)
                    {
                        if (obj.Cang == dm.GiaTri)
                        {
                            obj.DiaLy = dm.Loai;
                            obj.KhuVuc = dm.TenDanhmuc;
                            break;
                        }
                    }
                }
                
            }

            return lstBangKe;
        }
        #endregion
    }
}
