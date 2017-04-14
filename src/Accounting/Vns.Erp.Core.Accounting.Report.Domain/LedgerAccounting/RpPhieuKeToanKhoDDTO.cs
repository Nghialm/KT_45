using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Vns.Erp.Core.Accounting.Domain;

namespace Vns.Erp.Core.Accounting.Report.Domain
{
    public class RpPhieuKeToanKhoDDTO
    {
        public virtual Guid HanghoaId { get; set; }
        public virtual String KyHieuHanghoa { get; set; }
        public virtual String TenHanghoa { get; set; }
        public virtual Guid KhoNhapId { get; set; }
        public virtual String KyHieuKhoNhap { get; set; }
        public virtual Guid KhoXuatId { get; set; }
        public virtual String KyHieuKhoXuat { get; set; }
        public virtual String KyHieuDvt { get; set; }
        public virtual String MaTknGiavon { get; set; }
        public virtual String MaTkcGiavon { get; set; }
        public virtual String MaTknGiaban { get; set; }
        public virtual String MaTkcGiaban { get; set; }
        public virtual Decimal SoLuong { get; set; }
        public virtual Decimal DonGiaVon { get; set; }
        public virtual Decimal GiaVon { get; set; }
        public virtual Decimal DonGiaBan { get; set; }
        public virtual Decimal GiaBan { get; set; }
        public virtual String NoiDung { get; set; }
        public virtual Guid CtHId { get; set; }
        public virtual Guid CtDId { get; set; }

        public RpPhieuKeToanKhoDDTO(CtDNx objCtDNx)
        {
            CtHId = objCtDNx.CthNxId;
            CtDId = objCtDNx.Id;
            KyHieuDvt = objCtDNx.MaDvt;
            HanghoaId = objCtDNx.HanghoaId;
            KyHieuHanghoa = objCtDNx.KyHieuHanghoa ;
            TenHanghoa = objCtDNx.TenHanghoa;
            KhoNhapId = objCtDNx.KhoNhapId;
            KhoXuatId = objCtDNx.KhoXuatId;
            MaTknGiavon = objCtDNx.MaTknGiavon;
            MaTkcGiavon = objCtDNx.MaTkcGiavon;

            MaTknGiaban = objCtDNx.MaTknGiaban;
            MaTkcGiaban = objCtDNx.MaTkcGiaban;

            SoLuong = objCtDNx.SoLuong;
            DonGiaBan = objCtDNx.DonGiaBan;
            DonGiaVon = objCtDNx.DonGiaVon;

            GiaBan = objCtDNx.SoTienBan;
            GiaVon = objCtDNx.GiaVon;

            NoiDung = objCtDNx.NoiDung;
        }

        public RpPhieuKeToanKhoDDTO(KtCtDHddv  objHddv)
        {
            CtHId = objHddv.CthHddvId;
            CtDId = objHddv.Id;
            KyHieuDvt = objHddv.Dvt ;
            //HanghoaId = objHddv.HanghoaId;
            //KyHieuHanghoa = objHddv.KyHieuHanghoa;
            TenHanghoa = objHddv.TenHhDv ;
            //KhoNhapId = objHddv.KhoNhapId;
            //KhoXuatId = objHddv.KhoXuatId;
            MaTknGiavon = objHddv.MaTkNo ;
            MaTkcGiavon = objHddv.MaTkCo ;

            //MaTknGiaban = objHddv.MaTknGiaban;
            //MaTkcGiaban = objHddv.MaTkcGiaban;

            SoLuong = objHddv.SoLuong;
            DonGiaBan = objHddv.DonGia ;
            GiaBan = objHddv.DoanhThu;

            //GiaBan = objHddv.SoTienBan;
            //GiaVon = objHddv.GiaVon;

            NoiDung = objHddv.NoiDung;
        }

    }
}
