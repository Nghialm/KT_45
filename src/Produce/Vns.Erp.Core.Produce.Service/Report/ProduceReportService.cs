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

namespace Vns.Erp.Core.Produce.Service.Report
{
    public class ProduceReportService : GenericService<SxKehoachM, System.Guid>, IProduceReportService
    {
        public IProduceReportDao ProduceReportDao
        {
            get { return (IProduceReportDao)Dao; }
            set { Dao = value; }
        }

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
    }
}
