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
using Spring.Transaction.Interceptor;
using Vns.Erp.Core.Domain;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Spa.Common;
using Vns.Erp.Core.Accounting.Dao;

namespace Vns.Erp.Core.Spa.Service
{
    public class CtHHddvService : GenericService<CtHHddv, System.Guid>, ICtHHddvService
    {
        #region Property
        public ICtHHddvDao CtHHddvDao
        {
            get { return (ICtHHddvDao)Dao; }
            set { Dao = value; }
        }

        private ICtDHddvDao _CtDHddvDao;
        public ICtDHddvDao CtDHddvDao
        {
            get { return _CtDHddvDao; }
            set { _CtDHddvDao = value; }
        }

        private ISpaLsTheDao _SpaLsTheDao;
        public ISpaLsTheDao SpaLsTheDao
        {
            get { return _SpaLsTheDao; }
            set { _SpaLsTheDao = value; }
        }

        public IBcKetoanDao BcKetoanDao { get; set; }
        public IBcKetoanKhoDao BcKetoanKhoDao { get; set; }
        #endregion

        #region Generate Accounting
        private IList<BcKetoan> GenNghiepVuKeToan(CtHHddv objCtH, IList<CtDHddv> lstCtD)
        {
            //Dinh khoan doanh thu
            Decimal SoTienDoanhThuDichVu = 0;
            //Decimal SoTienDoanhThuHangHoa = 0;
            Decimal SoTienKhuyenMaiThe = objCtH.TheTienKm1;
            Decimal SoTienThanhToanThe = objCtH.TheTienThe1;
            Decimal SoTienMat = objCtH.TtTienMat;
            Decimal SoTienNH = objCtH.TtTienNh;
            Decimal SoTienNo = objCtH.TtTienNo;
            Decimal SoTienGiamGia = objCtH.SoTienGiamGia;

            foreach (CtDHddv tmp in lstCtD)
            {
                SoTienDoanhThuDichVu += tmp.DoanhThu;
            }

            IList<BcKetoan> lstKeToan = new List<BcKetoan>();
            if (SoTienMat > 0)
            {
                BcKetoan tmp = new BcKetoan();
                tmp = objCtH.GenNghiepVuKeToan(objCtH, lstCtD);

                tmp.SoTien = SoTienMat;
                tmp.TkNoId = SpaGeneral.TkTienMatInfo.Id;
                tmp.MaTkNo = SpaGeneral.TkTienMatInfo.MaTaikhoan;
                tmp.TenTkNo = SpaGeneral.TkTienMatInfo.TenTaikhoan;

                lstKeToan.Add(tmp);
            }

            if (SoTienNH > 0)
            {
                BcKetoan tmp = new BcKetoan();
                tmp = objCtH.GenNghiepVuKeToan(objCtH, lstCtD);

                tmp.SoTien = SoTienNH;
                tmp.TkNoId = SpaGeneral.TkTienNganHangInfo.Id;
                tmp.MaTkNo = SpaGeneral.TkTienNganHangInfo.MaTaikhoan;
                tmp.TenTkNo = SpaGeneral.TkTienNganHangInfo.TenTaikhoan;

                lstKeToan.Add(tmp);
            }

            if (SoTienNo > 0)
            {
                BcKetoan tmp = new BcKetoan();
                tmp = objCtH.GenNghiepVuKeToan(objCtH, lstCtD);

                tmp.SoTien = SoTienNo;
                tmp.TkNoId = SpaGeneral.TkTienPhaiThuKhachInfo.Id;
                tmp.MaTkNo = SpaGeneral.TkTienPhaiThuKhachInfo.MaTaikhoan;
                tmp.TenTkNo = SpaGeneral.TkTienPhaiThuKhachInfo.TenTaikhoan;

                lstKeToan.Add(tmp);
            }


            if (SoTienThanhToanThe > 0)
            {
                BcKetoan tmp = new BcKetoan();
                tmp = objCtH.GenNghiepVuKeToan(objCtH, lstCtD);

                tmp.SoTien = SoTienThanhToanThe;
                tmp.TkNoId = SpaGeneral.TkDoanhThuChuaThucHienInfo.Id;
                tmp.MaTkNo = SpaGeneral.TkDoanhThuChuaThucHienInfo.MaTaikhoan;
                tmp.TenTkNo = SpaGeneral.TkDoanhThuChuaThucHienInfo.TenTaikhoan;

                lstKeToan.Add(tmp);
            }


            if (SoTienDoanhThuDichVu > 0)
            {
                BcKetoan tmp = new BcKetoan();
                tmp = objCtH.GenNghiepVuKeToan(objCtH, lstCtD);

                tmp.SoTien = SoTienDoanhThuDichVu;
                tmp.TkCoId = SpaGeneral.TkDoanhThuDichVuInfo.Id;
                tmp.MaTkCo = SpaGeneral.TkDoanhThuDichVuInfo.MaTaikhoan;
                tmp.TenTkCo = SpaGeneral.TkDoanhThuDichVuInfo.TenTaikhoan;

                lstKeToan.Add(tmp);
            }

            if (SoTienKhuyenMaiThe > 0)
            {
                //Tang tai khoan chiet khau thuong mai
                BcKetoan tmpChietKhau = new BcKetoan();
                tmpChietKhau = objCtH.GenNghiepVuKeToan(objCtH, lstCtD);
                tmpChietKhau.SoTien = SoTienKhuyenMaiThe;
                tmpChietKhau.TkCoId = SpaGeneral.TkChietKhauDichVuTheInfo.Id;
                tmpChietKhau.MaTkCo = SpaGeneral.TkChietKhauDichVuTheInfo.MaTaikhoan;
                tmpChietKhau.TenTkCo = SpaGeneral.TkChietKhauDichVuTheInfo.TenTaikhoan;
                lstKeToan.Add(tmpChietKhau);

                //Giam tru doanh thu khi phat sinh tien khuyen mai the
                BcKetoan tmpGiamDoanhThu = new BcKetoan();
                tmpGiamDoanhThu = objCtH.GenNghiepVuKeToan(objCtH, lstCtD);
                tmpGiamDoanhThu.SoTien = SoTienKhuyenMaiThe;
                tmpGiamDoanhThu.TkNoId = SpaGeneral.TkDoanhThuDichVuInfo.Id;
                tmpGiamDoanhThu.MaTkNo = SpaGeneral.TkDoanhThuDichVuInfo.MaTaikhoan;
                tmpGiamDoanhThu.TenTkNo = SpaGeneral.TkDoanhThuDichVuInfo.TenTaikhoan;
                lstKeToan.Add(tmpGiamDoanhThu);
            }

            if (SoTienGiamGia > 0)
            {
                //Tang tai khoan chiet khau thuong mai
                BcKetoan tmpChietKhau = new BcKetoan();
                tmpChietKhau = objCtH.GenNghiepVuKeToan(objCtH, lstCtD);
                tmpChietKhau.SoTien = SoTienGiamGia;
                tmpChietKhau.TkCoId = SpaGeneral.TKChietKhauGiamGiaDvInfo.Id;
                tmpChietKhau.MaTkCo = SpaGeneral.TKChietKhauGiamGiaDvInfo.MaTaikhoan;
                tmpChietKhau.TenTkCo = SpaGeneral.TKChietKhauGiamGiaDvInfo.TenTaikhoan;
                lstKeToan.Add(tmpChietKhau);

                //Giam tru doanh thu khi phat sinh tien khuyen mai, giam gia dich vu
                BcKetoan tmpGiamDoanhThu = new BcKetoan();
                tmpGiamDoanhThu = objCtH.GenNghiepVuKeToan(objCtH, lstCtD);
                tmpGiamDoanhThu.SoTien = SoTienKhuyenMaiThe;
                tmpGiamDoanhThu.TkNoId = SpaGeneral.TkDoanhThuDichVuInfo.Id;
                tmpGiamDoanhThu.MaTkNo = SpaGeneral.TkDoanhThuDichVuInfo.MaTaikhoan;
                tmpGiamDoanhThu.TenTkNo = SpaGeneral.TkDoanhThuDichVuInfo.TenTaikhoan;
                lstKeToan.Add(tmpGiamDoanhThu);
            }

            return lstKeToan;
        }

        private IList<BcKetoanKho> GenNghiepVuKeToanKho(CtHHddv objCtH, IList<CtDHddv> lstCtD)
        {
            CtHHddv tmpH = new CtHHddv();
            return tmpH.GenNghiepVuKeToanKho(objCtH, lstCtD, SpaGeneral.TkKhoInfo,
                SpaGeneral.TkGiaVonInfo, null, null, SpaGeneral.ObjDmKhoDefault);
        }
        #endregion

        public IList<CtHHddv> GetCthByDonViID(Guid DonviId)
        {
            return CtHHddvDao.GetCthByDonViID(DonviId);
        }

        public IList<CtHHddv> GetByLoaiChungTu(Guid DonviId, string MaLoaiCt, int SoCTHienThi)
        {
            return CtHHddvDao.GetByLoaiChungTu(DonviId, MaLoaiCt, SoCTHienThi);
        }

        [Transaction]
        public Boolean DeleteChungTu(CtHHddv objCtH)
        {
            //Delete Accounting
            BcKetoanKhoDao.DeleteByChungTu(objCtH.Id, Null.NullGuid);
            BcKetoanDao.DeleteByChungTu(objCtH.Id, Null.NullGuid);

            //Delete history card
            _SpaLsTheDao.DeleteByPhieu(objCtH.Id);

            //Delete voucher
            _CtDHddvDao.DeleteByCtH(objCtH.Id);
            Delete(objCtH);

            return true;
        }

        [Transaction]
        public Boolean SaveChungTu(CtHHddv objCtH, IList<CtDHddv> lst_hh, IList<CtDHddv> lst_dv, IList<CtDHddv> lst_del)
        {
            Guid idCth;
            //Save Ct_H_Hddv
            if (objCtH.Id == Null.NullGuid)
                idCth = CtHHddvDao.Save(objCtH).Id;
            else
            {
                idCth = objCtH.Id;
                CtHHddvDao.SaveOrUpdate(objCtH);
            }

            _SpaLsTheDao.DeleteByPhieu(idCth);
            //Save LsThanhToan neu co
            if (objCtH.TtTienThe1 > 0)
            {
                SpaLsThe lsThe = new SpaLsThe(objCtH);
                _SpaLsTheDao.SaveOrUpdate(lsThe);
            }

            //Save Service
            foreach (CtDHddv tmp in lst_dv)
            {
                if (VnsCheck.IsNullGuid(tmp.Id))
                {
                    tmp.LoaiNghiepVu = 1;
                    tmp.SoLuong = 1;
                    tmp.CthHddvId = idCth;
                    _CtDHddvDao.Save(tmp);
                }
                else _CtDHddvDao.SaveOrUpdate(tmp);
            }

            //Save Produce
            foreach (CtDHddv tmp in lst_hh)
            {
                if (VnsCheck.IsNullGuid(tmp.Id))
                {
                    tmp.LoaiNghiepVu = 2;
                    tmp.CthHddvId = idCth;
                    _CtDHddvDao.Save(tmp);
                }
                else _CtDHddvDao.SaveOrUpdate(tmp);
            }

            //Delete 
            foreach (CtDHddv tmp in lst_del)
            {
                if (!VnsCheck.IsNullGuid(tmp.Id)) _CtDHddvDao.Delete(tmp);
            }

            //Save 4 Accounting
            //Delete first
            BcKetoanKhoDao.DeleteByChungTu(objCtH.Id, Null.NullGuid);
            BcKetoanDao.DeleteByChungTu(objCtH.Id, Null.NullGuid);
            //Save
            IList<CtDHddv> lstAll = new List<CtDHddv>();
            foreach (CtDHddv tmp in lst_dv)
                lstAll.Add(tmp);

            foreach (CtDHddv tmp in lst_hh)
                lstAll.Add(tmp);

            IList<BcKetoan> lstKeToan = GenNghiepVuKeToan(objCtH, lstAll);
            foreach (BcKetoan tmpkt in lstKeToan)
                BcKetoanDao.SaveOrUpdate(tmpkt);

            IList<BcKetoanKho> lstKeToanKho = GenNghiepVuKeToanKho(objCtH, lst_hh);
            foreach (BcKetoanKho tmpkho in lstKeToanKho)
            {
                BcKetoanKhoDao.SaveOrUpdate(tmpkho);
                IList<BcKetoan> lstKt4Kho = tmpkho.GenBcKetoan();
                foreach (BcKetoan tmp in lstKt4Kho)
                    BcKetoanDao.SaveOrUpdate(tmp);
            }
            return true;
        }
    }
}