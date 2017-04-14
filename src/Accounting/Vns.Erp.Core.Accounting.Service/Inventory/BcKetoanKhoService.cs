using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Accounting.Dao;
using Vns.Erp.Core.Accounting.Report.Dao;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Accounting.Service.Interface;

using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System.ServiceModel.Activation;


namespace Vns.Erp.Core.Accounting.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class BcKetoanKhoService : GenericService<BcKetoanKho, System.Guid>, IBcKetoanKhoService
    {
        public IBcKetoanKhoDao BcKetoanKhoDao
        {
            get { return (IBcKetoanKhoDao)Dao; }
            set { Dao = value; }
        }

        private IBcKetoanDao _BcKetoanDao;
        public IBcKetoanDao BcKetoanDao
        {
            get { return _BcKetoanDao; }
            set { _BcKetoanDao = value; }
        }

        private IDmHanghoaDao _DmHanghoaDao;
        public IDmHanghoaDao DmHanghoaDao
        {
            get { return _DmHanghoaDao; }
            set { _DmHanghoaDao = value; }
        }

        private IDmKhoDao _DmKhoDao;
        public IDmKhoDao DmKhoDao
        {
            get { return _DmKhoDao; }
            set { _DmKhoDao = value; }
        }

        private IKtGiaxuatDaukyDao _KtGiaxuatDaukyDao;
        public IKtGiaxuatDaukyDao KtGiaxuatDaukyDao
        {
            get { return _KtGiaxuatDaukyDao; }
            set { _KtGiaxuatDaukyDao = value; }
        }

        private IKtDuluongDaukyDao _KtDuluongDaukyDao;
        public IKtDuluongDaukyDao KtDuluongDaukyDao
        {
            get
            {
                return _KtDuluongDaukyDao;
            }
            set { _KtDuluongDaukyDao = value; }
        }

        private IRpLedgerStoreDao _RpLedgerStoreDao;
        public IRpLedgerStoreDao RpLedgerStoreDao
        {
            get { return _RpLedgerStoreDao; }
            set { _RpLedgerStoreDao = value; }
        }

        public void TinhGiaXuatHangHoaVoiKho(DateTime p_tu_ngay, DateTime p_den_ngay, Guid p_hanghoa_id, Guid p_kho_id,
                Decimal p_phuongphap, Guid DonviId,
                Guid p_nhom1_id, Guid p_nhom2_id, Guid p_nhom3_id)
        {
            IList<DmHanghoa> lstDmHanghoa = _DmHanghoaDao.GetAllByDonviID(DonviId);
            if (!VnsCheck.IsNullGuid(p_hanghoa_id))
                for (int i = lstDmHanghoa.Count - 1; i >= 0; i--)
                {
                    if (lstDmHanghoa[i].Id != p_hanghoa_id) lstDmHanghoa.RemoveAt(i);
                }

            IList<DmKho> lstDmKho = _DmKhoDao.GetAllByDonviID(DonviId);
            if (!VnsCheck.IsNullGuid(p_kho_id))
                for (int i = lstDmKho.Count - 1; i >= 0; i--)
                {
                    if (lstDmKho[i].Id != p_kho_id) lstDmKho.RemoveAt(i);
                }
            
            foreach (DmKho tmpKho in lstDmKho)
            {
                foreach (DmHanghoa tmpHH in lstDmHanghoa)
                {
                    switch (Convert.ToInt32( tmpHH.PpKtHtk))
                    {
                        case 2:
                            TinhGiaBinhQuanCuoiKy(p_tu_ngay, p_den_ngay, tmpHH, tmpKho, 2, DonviId);
                            break;
                        case 3:
                            TinhGiaFIFO(p_tu_ngay, p_den_ngay, tmpHH, tmpKho, 3, DonviId);
                            break;
                    }
                    
                }
            }
 
        }

        public void TinhGiaBinhQuanCuoiKy(DateTime p_tu_ngay, DateTime p_den_ngay, DmHanghoa tmpHH, DmKho tmpKho,
                Decimal p_phuongphap, Guid DonviId)
        {
            KtGiaxuatDauky GiaDauKy = _KtGiaxuatDaukyDao.Get(DonviId, tmpHH.Id, tmpKho.Id, p_tu_ngay);

            Decimal sl_nhap_tk, st_nhap_tk = 0;
            if (GiaDauKy == null)
            {
                DateTime NgayDauKy = p_tu_ngay.AddDays(-1);
                sl_nhap_tk = _RpLedgerStoreDao.fn_so_luong_ton_kho(String.Empty, String.Empty, tmpKho.Id, tmpHH.Id, DonviId, NgayDauKy,
                Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid) +
                            _RpLedgerStoreDao.fn_sl_nhap_kho(String.Empty, String.Empty, tmpKho.Id, tmpHH.Id, DonviId, p_tu_ngay, p_den_ngay,
                               Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                               Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                               Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                               Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);

                st_nhap_tk = _RpLedgerStoreDao.fn_so_tien_ton_kho(String.Empty, String.Empty, tmpKho.Id, tmpHH.Id, DonviId, NgayDauKy,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid) +
                    _RpLedgerStoreDao.fn_SoTien_nhap_kho(String.Empty, String.Empty, tmpKho.Id, tmpHH.Id, DonviId, p_tu_ngay, p_den_ngay,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);
            }
            else
            {
                sl_nhap_tk = _RpLedgerStoreDao.fn_sl_nhap_kho(String.Empty, String.Empty, tmpKho.Id, tmpHH.Id, DonviId, p_tu_ngay, p_den_ngay,
                               Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                               Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                               Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                               Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);

                st_nhap_tk = _RpLedgerStoreDao.fn_SoTien_nhap_kho(String.Empty, String.Empty, tmpKho.Id, tmpHH.Id, DonviId, p_tu_ngay, p_den_ngay,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                    Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);
            }

            

            KtGiaxuatDauky GiaCuoiKy = new KtGiaxuatDauky();
            GiaCuoiKy.DonviId = DonviId;
            GiaCuoiKy.HanghoaId = tmpHH.Id;
            GiaCuoiKy.KhoId = tmpKho.Id;
            GiaCuoiKy.NgayTinh = p_den_ngay.AddDays(1);
            if (GiaDauKy == null) GiaDauKy = new KtGiaxuatDauky();

            GiaCuoiKy.SoLuong = GiaDauKy.SoLuong + sl_nhap_tk;
            GiaCuoiKy.SoTienTon = GiaDauKy.SoTienTon + st_nhap_tk;
            if (GiaCuoiKy.SoLuong != 0)
                GiaCuoiKy.DonGia = GiaCuoiKy.SoTienTon / GiaCuoiKy.SoLuong;

            IList<BcKetoanKho> lstXuat = BcKetoanKhoDao.GetBy(p_tu_ngay, p_den_ngay, tmpHH.Id, tmpKho.Id, DonviId, true);

            foreach (BcKetoanKho tmpXuat in lstXuat)
            {
                if (tmpXuat.SoLuong == GiaCuoiKy.SoLuong)
                    tmpXuat.GiaVon = GiaCuoiKy.SoTienTon;
                else
                    tmpXuat.GiaVon = GiaCuoiKy.DonGia * tmpXuat.SoLuong;

                tmpXuat.DonGiaVon = GiaCuoiKy.DonGia;
                GiaCuoiKy.SoLuong = GiaCuoiKy.SoLuong - tmpXuat.SoLuong;
                GiaCuoiKy.SoTienTon = GiaCuoiKy.SoTienTon - tmpXuat.GiaVon;

                BcKetoanKhoDao.UpdateGiaXuat(tmpXuat);
                BcKetoan tmpkt = _BcKetoanDao.GetBy(tmpXuat.CthNxId, tmpXuat.CtdNxId, 3);
                tmpkt.SoTien = tmpXuat.GiaVon;

                _BcKetoanDao.SaveOrUpdate(tmpkt);
            }

            if (GiaCuoiKy.SoLuong != 0)
                _KtGiaxuatDaukyDao.SaveOrUpdate(GiaCuoiKy);
        }

        public void TinhGiaFIFO(DateTime p_tu_ngay, DateTime p_den_ngay, DmHanghoa tmpHH, DmKho tmpKho,
                Decimal p_phuongphap, Guid DonviId)
        {
            KtDuluongDauky tmpdlck = null;
            KtDuluongDauky tmpdldk = _KtDuluongDaukyDao.Get(DonviId, tmpHH.Id, tmpKho.Id, p_tu_ngay);

            IList<BcKetoanKho> lstNhap = new List<BcKetoanKho>();
            if (tmpdldk == null)
            {
                lstNhap = BcKetoanKhoDao.GetNhap4FIFO(DateTime.MinValue, p_den_ngay, tmpHH.Id, tmpKho.Id, DonviId);
            }
            else
            {
                lstNhap = BcKetoanKhoDao.GetNhap4FIFO(tmpdldk.NgayTinh, p_den_ngay, tmpHH.Id, tmpKho.Id, DonviId);
            }
            

            Boolean UpdateFlg = false;
            if (tmpdldk == null) tmpdldk = new KtDuluongDauky();
            else
                foreach (BcKetoanKho tmpNhap in lstNhap)
                {
                    if (tmpNhap.CtdNxId == tmpdldk.CtdNxId)
                    {
                        tmpNhap.DuLuong = tmpdldk.DuLuong;
                        tmpNhap.SoTienConLai = tmpdldk.SoTienTon;
                        UpdateFlg = true;
                    }
                    else
                    {
                        if (UpdateFlg)
                        {
                            tmpNhap.DuLuong = tmpNhap.SoLuong;
                            tmpNhap.SoTienConLai = tmpNhap.SoTienXuat;
                        }
                    }
                }

            //Save KtDuluongDauky
            if (lstNhap.Count > 0)
            {
                tmpdldk.KhoId = tmpKho.Id;
                tmpdldk.NgayTinh = p_tu_ngay;
                tmpdldk.HanghoaId = tmpHH.Id;
                tmpdldk.DonviId = DonviId;
                tmpdldk.CtdNxId = lstNhap[0].CtdNxId;
                tmpdldk.PpTinh = 3;
                tmpdldk.DuLuong = lstNhap[0].DuLuong;
                if (lstNhap[0].DuLuong == lstNhap[0].SoLuong)
                    tmpdldk.SoTienTon = lstNhap[0].SoTienXuat;
                else
                    tmpdldk.SoTienTon = lstNhap[0].SoTienXuat - lstNhap[0].DonGiaXuat * (lstNhap[0].SoLuong - lstNhap[0].DuLuong);

                //_KtDuluongDaukyDao.SaveOrUpdate(tmpdldk);
            }
            
            IList<BcKetoanKho> lstXuat = BcKetoanKhoDao.GetBy(p_tu_ngay, p_den_ngay, tmpHH.Id, tmpKho.Id, DonviId, true);
            foreach (BcKetoanKho tmpxuat in lstXuat)
            {
                Decimal SoLuongChuaTinh = tmpxuat.SoLuong;
                tmpxuat.GiaVon = 0;

                BcKetoanKho cur = new BcKetoanKho();
                foreach (BcKetoanKho tmpnhap in lstNhap)
                {
                    if (tmpnhap.DuLuong < 0) continue;

                    if (SoLuongChuaTinh < tmpnhap.DuLuong)
                    {
                        if (tmpnhap.DuLuong == tmpnhap.SoLuong)
                            tmpnhap.SoTienConLai = tmpnhap.SoTienXuat - SoLuongChuaTinh * tmpnhap.DonGiaXuat;
                        else
                            tmpnhap.SoTienConLai = tmpnhap.SoTienConLai - SoLuongChuaTinh * tmpnhap.DonGiaXuat;

                        tmpnhap.DuLuong = tmpnhap.DuLuong - SoLuongChuaTinh;
                        //Don gia xuat tuong ung

                        tmpxuat.GiaVon = tmpxuat.GiaVon + SoLuongChuaTinh * tmpnhap.DonGiaXuat;
                        tmpxuat.DonGiaVon = tmpxuat.GiaVon / tmpxuat.SoLuong;

                        cur = tmpnhap;
                        break;
                    }
                    else
                        if (SoLuongChuaTinh == tmpnhap.DuLuong)
                        {
                            tmpxuat.GiaVon = tmpxuat.GiaVon + tmpnhap.SoTienConLai;

                            tmpnhap.DuLuong = 0;
                            tmpnhap.SoTienConLai = 0;

                            cur = tmpnhap;
                            break;
                        }
                        else
                        {
                            tmpxuat.GiaVon = tmpxuat.GiaVon + tmpnhap.SoTienConLai;
                            SoLuongChuaTinh = SoLuongChuaTinh - tmpnhap.DuLuong;

                            tmpnhap.DuLuong = 0;
                            tmpnhap.SoTienConLai = 0;
                        }
                }

                //Gan gia tri cho du luong dau ky
                tmpdlck = new KtDuluongDauky();
                tmpdlck.KhoId = tmpKho.Id;
                tmpdlck.NgayTinh = p_tu_ngay;
                tmpdlck.HanghoaId = tmpHH.Id;
                tmpdlck.DonviId = DonviId;
                tmpdlck.CtdNxId = lstNhap[0].CtdNxId;
                tmpdlck.PpTinh = 3;
                tmpdlck.DuLuong = lstNhap[0].DuLuong;
                if (cur.DuLuong == cur.SoLuong)
                    tmpdlck.SoTienTon = cur.SoTienXuat;
                else
                    tmpdlck.SoTienTon = cur.SoTienXuat - cur.DonGiaXuat * (cur.SoLuong - cur.DuLuong);
            }

            //Xoa du dau ky cac thang ke tiep
            KtDuluongDaukyDao.DeleteBy(DonviId, tmpHH.Id, tmpKho.Id, p_tu_ngay);
            if (tmpdlck != null)
                KtDuluongDaukyDao.SaveOrUpdate(tmpdlck);
            else
            {
                tmpdlck.KhoId = tmpKho.Id;
                tmpdlck.NgayTinh = p_den_ngay.AddDays(1);
                tmpdlck.HanghoaId = tmpHH.Id;
                tmpdlck.DonviId = DonviId;
                tmpdlck.CtdNxId = tmpdldk.CtdNxId;
                tmpdlck.PpTinh = 3;
                tmpdlck.DuLuong = tmpdldk.DuLuong;
                tmpdlck.SoTienTon = tmpdldk.SoTienTon;

                KtDuluongDaukyDao.SaveOrUpdate(tmpdlck);
            }

            //Update nhap kho
            foreach (BcKetoanKho tmpNhap in lstNhap)
            {
                if (tmpNhap.DuLuong == 0) BcKetoanKhoDao.SaveOrUpdate(tmpNhap);
                if (tmpNhap.DuLuong != tmpNhap.SoLuong)
                {
                    BcKetoanKhoDao.SaveOrUpdate(tmpNhap);
                }
            }

            //Update Xuat kho
            foreach (BcKetoanKho tmpXuat in lstXuat)
            {
                BcKetoanKhoDao.UpdateGiaXuat(tmpXuat);
            }
        }

        
    }
}
