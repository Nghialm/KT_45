using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;

namespace Vns.Erp.Core.Accounting.Domain
{
	public partial class KtCtDHddv : DomainObject<System.Guid>
    {
        public virtual KtCtHHddv ObjKtCtHHddv { get; set; }

        public IList<BcKetoan> GenBcKetoan(KtCtHHddv objCtH)
        {
            List<DinhKhoanInfo> lsdk = new List<DinhKhoanInfo>();
            lsdk.Add(new DinhKhoanInfo(TkNoId, MaTkNo, TenTkNo,
                              TkCoId, MaTkCo, TenTkCo,
                              SoTien, SoTienNte, 0));

            lsdk.Add(new DinhKhoanInfo(TkNoIdGtgt, MaTkNoGtgt, "",
                              TkCoIdGtgt, MaTkCoGtgt, "",
                              SoTienThueGtgt, 0, 1));

            //lsdk.Add(new DinhKhoanInfo(TkNoIdCk, MaTkNoCk, "",
            //                  TkCoIdCk, MaTkCoCk, "",
            //                  SoTienCk, SoTienCkNte, 7));

            List<BcKetoan> lstKetoan = new List<BcKetoan>();
            foreach (DinhKhoanInfo tmp in lsdk)
            {
                if (tmp.SoTien == 0) continue;

                BcKetoan objkt = new BcKetoan();
                objkt.CthId = CthHddvId;
                objkt.CtdId = Id;
                objkt.DonviId = objCtH.DonviId;
                objkt.MaDonvi = objCtH.MaDonvi;
                objkt.IdLoaiCt = objCtH.IdLoaiCt;
                objkt.MaLoaiCt = objCtH.MaLoaiCt;
                objkt.KyHieuLoaiCt = objCtH.KyHieuLoaiCt;
                objkt.NgayGhi = objCtH.NgayGhi;
                objkt.CtSo = objCtH.CtSo;
                objkt.NgayCt = objCtH.NgayCt;
                objkt.NteId = objCtH.NteId;
                objkt.MaNte = objCtH.MaNte;
                objkt.TyGia = objCtH.TyGia;
                objkt.SoTien = tmp.SoTien;
                objkt.SoTienNte = tmp.SoTienNte;
                objkt.TkNoId = tmp.IdTkNo;
                objkt.MaTkNo = tmp.MaTkNo;
                //objkt.TenTkNo = lsdk(indx).TENTKNO;
                objkt.TkCoId = tmp.IdTkCo;
                objkt.MaTkCo = tmp.MaTkCo;
                //objkt.TenTkCo = lsdk(indx).TENTKCO;
                objkt.IdPtqtNo = IdDmPtqtNo;
                //objkt.MAPTQTNO = OBJDMPTQTNO.MADM;
                //objkt.IDPTQTCO = IDDMPTQTCO;

                //objkt.MaPtqtCo = 	OBJDMPTQTCO.MADM;
                objkt.IdPhongbanNo = IdDmPhongbanNo;
                //objkt.MaPhongbanNo = 	OBJDMPHONGBANNO.MADM;
                objkt.IdPhongbanCo = IdDmPhongbanCo;
                //objkt.MaPhongbanCo = 	OBJDMPHONGBANCO.MADM;
                objkt.IdVuviecNo = IdDmVuviecNo;
                //objkt.MaVuviecNo = 	MaDmVuviecNo;
                objkt.IdVuviecCo = IdDmVuviecCo;
                //objkt.MaVuviecCo = 	MaDmVuviecCo;
                objkt.IdDmTudo1No = IdDmTudo1No;
                //objkt.MaDmTudo1No = 	OBJDMTUDO1NO.MADM;
                objkt.IdDmTudo1Co = IdDmTudo1Co;
                //objkt.MaDmTudo1Co = 	OBJDMTUDO1CO.MADM;
                objkt.IdDmTudo2No = IdDmTudo2No;
                //objkt.MaDmTudo2No = 	OBJDMTUDO2NO.MADM;
                objkt.IdDmTudo2Co = IdDmTudo2Co;
                //objkt.MaDmTudo2Co = 	OBJDMTUDO2CO.MADM;
                objkt.IdDmTudo3No = IdDmTudo3No;
                //objkt.MaDmTudo3No = 	OBJDMTUDO3NO.MADM;
                objkt.IdDmTudo3Co = IdDmTudo3Co;
                //objkt.MaDmTudo3Co = 	OBJDMTUDO3CO.MADM;
                objkt.IdDmTudo4No = IdDmTudo4No;
                //objkt.MaDmTudo4No = 	OBJDMTUDO4NO.MADM;
                objkt.IdDmTudo4Co = IdDmTudo4Co;
                //objkt.MaDmTudo4Co = 	OBJDMTUDO4CO.MADM;
                objkt.IdDmTudo5No = IdDmTudo5No;
                //objkt.MaDmTudo5No = 	OBJDMTUDO5NO.MADM;
                objkt.IdDmTudo5Co = IdDmTudo5Co;
                //objkt.MaDmTudo5Co = 	OBJDMTUDO5CO.MADM;
                objkt.LoaiNghiepVu = tmp.LoaiNghiepVu;
                objkt.IdHopdongNo = IdDmHopdongNo;
                //objkt.MaHopdongNo = 	MaDmHopdongNo;
                objkt.IdHopdongCo = IdDmHopdongCo;
                //objkt.MaHopdongCo = 	MaDmHopdongCo;
                objkt.IdKhangNo = IdKhangNo;
                objkt.MaKhangNo = MaKhangNo;
                objkt.TenKhangNo = TenKhangNo;
                objkt.IdKhangCo = IdKhangCo;
                objkt.MaKhangCo = MaKhangCo;
                objkt.TenKhangCo = TenKhangCo;
                objkt.DienGiai = NoiDung;
                objkt.DonviCt = objCtH.DonviCt;
                objkt.MaDonviCt = objCtH.MaDonviCt;
                objkt.PhanHe = 0;
                objkt.IdDmKhoanphiNo = IdDmKhoanphiNo;
                //objkt.MaDmKhoanphiNo = 	OBJDMKHOANPHINO.MADM;
                //objkt.KyHieuKhoanphiNo = 	OBJDMKHOANPHINO.KYHIEU;
                //objkt.TenDmKhoanphiNo = 	OBJDMKHOANPHINO.TEN;
                objkt.IdDmKhoanphiCo = IdDmKhoanphiCo;
                //objkt.MaDmKhoanphiCo = 	OBJDMKHOANPHICO.MADM;
                //objkt.KyHieuKhoanphiCo = 	OBJDMKHOANPHICO.KYHIEU;
                //objkt.TenDmKhoanphiCo = 	OBJDMKHOANPHICO.TEN;
                objkt.SoDu = 0;
                objkt.IdDoituongHoadon = IdDoituongHoadon;
                
                lstKetoan.Add(objkt);
            }

            return lstKetoan;
        }
	}
}