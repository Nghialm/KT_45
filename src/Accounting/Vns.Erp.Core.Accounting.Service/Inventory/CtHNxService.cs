using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Dao;
using Vns.Erp.Core.Accounting.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using Spring.Transaction.Interceptor;
using System.ServiceModel.Activation;

namespace Vns.Erp.Core.Accounting.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class CtHNxService : GenericService<CtHNx, System.Guid>, ICtHNxService
    {
        #region Property
        private IBcKetoanDao _BcKetoanDao;
        public IBcKetoanDao BcKetoanDao
        {
            get { return _BcKetoanDao; }
            set { _BcKetoanDao = value; }
        }

        private IBcKetoanKhoDao _BcKetoanKhoDao;
        public IBcKetoanKhoDao BcKetoanKhoDao
        {
            get { return _BcKetoanKhoDao; }
            set { _BcKetoanKhoDao = value; }
        }

        private ICtDNxDao _CtDNxDao;
        public ICtDNxDao CtDNxDao
        {
            get { return _CtDNxDao; }
            set { _CtDNxDao = value; }
        }

        private ICtThueDao _CtThueDao;
        public ICtThueDao CtThueDao
        {
            get { return _CtThueDao; }
            set { _CtThueDao = value; }
        }

        private ICtHoadonDao _CtHoadonDao;
        public ICtHoadonDao CtHoadonDao
        {
            get { return _CtHoadonDao; }
            set { _CtHoadonDao = value; }
        }
        #endregion

        public ICtHNxDao CtHNxDao
        {
            get { return (ICtHNxDao)Dao; }
            set { Dao = value; }
        }

        #region Syn function
        /// <summary>
        /// Ham dong bo du lieu len server
        /// </summary>
        /// <param name="_cthInfo"></param>
        /// <param name="_lstctd"></param>
        [Transaction]
        public void SaveData4Syn(CtHNx _cthInfo, List<CtDNx> _lstctd)
        {
            //Xoa du lieu
            _BcKetoanDao.DeleteByChungTu(_cthInfo.Id, Null.NullGuid);
            _BcKetoanKhoDao.DeleteByChungTu(_cthInfo.Id, Null.NullGuid);

            _cthInfo.LstCtDNx = null;
            CtHNxDao.SaveOrUpdate(_cthInfo);

            if (_cthInfo.IsDeleted != 1)
            {
                _CtDNxDao.DeleteByCtH(_cthInfo.Id);
                foreach (CtDNx _tempctdnx in _lstctd)
                {
                    _CtDNxDao.SaveOrUpdate(_tempctdnx);
                    BcKetoanKho objkho = new BcKetoanKho(_cthInfo, _tempctdnx);
                    if (_tempctdnx.Xuat == 2)
                    {
                        objkho.Xuat = 0;
                        objkho.KhoXuatId = Null.NullGuid;

                        BcKetoanKho objkho1 = new BcKetoanKho(_cthInfo, _tempctdnx);
                        objkho1.Xuat = 1;
                        objkho1.KhoNhapId = Null.NullGuid;
                        _BcKetoanKhoDao.Save(objkho1);
                    }
                    _BcKetoanKhoDao.Save(objkho);

                    List<BcKetoan> lstkt = objkho.GenBcKetoan();
                    foreach (BcKetoan tmpkt in lstkt)
                    {
                        _BcKetoanDao.Save(tmpkt);
                    }
                }
            }
        }

        public void UpdateSynFlag(Guid id)
        {
            CtHNxDao.UpdateSynFlag(id);
        }
        #endregion

        public IList<CtHNx> GetByDonviId(Guid DonviId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("DonviId");
            values.Add(DonviId);
            return List(-1, -1, props, values, null);
        }

        public IList<CtHNx> GetByLoaiChungTu(Guid DonviId, string MaLoaiCt, int SoCTHienThi)
        {
            return CtHNxDao.GetByLoaiChungTu(DonviId, MaLoaiCt, SoCTHienThi);
        }

        public IList<CtHNx> GetByLoaiChungTu(int PageIndex, int PageSize, Guid DonviId, string MaLoaiCt, int SoCTHienThi, out int TotalResult)
        {
            return CtHNxDao.GetByLoaiChungTu(PageIndex, PageSize, DonviId, MaLoaiCt, SoCTHienThi, out TotalResult);
        }

        public IList<CtHNx> SearchChungTu(Guid DONVI_ID, string MA_LOAI_CT, string CT_SO_TU, string CT_SO_DEN, DateTime NGAY_CT_TU, DateTime NGAY_CT_DEN, decimal GHI, string MA_KHANG, string MA_TK_CO, string MA_TK_NO,
                                    decimal SO_TIEN_TU, decimal SO_TIEN_DEN, string NOI_DUNG, Guid ID_DM_KHOANPHI, Guid ID_DM_VUVIEC, Guid ID_DM_HOPDONG, Guid ID_DM_PHONGBAN, Guid ID_DM_TUDO_1, Guid ID_DM_TUDO_2, Guid ID_DM_TUDO_3,
                                    Guid ID_DM_TUDO_4, Guid ID_DM_TUDO_5, Guid KhoId, Decimal So_Luong_Tu, Decimal So_Luong_Den, String TenHangHoa)
        {
            return CtHNxDao.SearchChungTu(DONVI_ID, MA_LOAI_CT, CT_SO_TU, CT_SO_DEN, NGAY_CT_TU, NGAY_CT_DEN, GHI, MA_KHANG, MA_TK_CO, MA_TK_NO,
                SO_TIEN_TU, SO_TIEN_DEN, NOI_DUNG, ID_DM_KHOANPHI, ID_DM_VUVIEC, ID_DM_HOPDONG, ID_DM_PHONGBAN,
                ID_DM_TUDO_1, ID_DM_TUDO_2, ID_DM_TUDO_3, ID_DM_TUDO_4, ID_DM_TUDO_5, KhoId, So_Luong_Tu, So_Luong_Den, TenHangHoa);
        }

        /// <summary>
        /// Xoa tat ca chung tu kho (So du kho, nhap xuat, ban hang, ...)
        /// </summary>
        /// <param name="objCtHNx"></param>
        /// <returns></returns>
        [Transaction]
        public Boolean DeleteChungTu(CtHNx objCtHNx)
        {
            //Xoa Bang tong hop kho
            _BcKetoanKhoDao.DeleteByChungTu(objCtHNx.Id, Null.NullGuid);
            //Xoa bang tong hop ke toan
            _BcKetoanDao.DeleteByBcKeToanKho(objCtHNx.Id, Null.NullGuid, -1);

            if (objCtHNx.IdDoituongHoadon != Null.NullGuid)
            {
                //Xoa hoa don
                _CtHoadonDao.DeleteById(objCtHNx.IdDoituongHoadon);
            }

            //Xoa chung tu
            CtHNxDao.DeleteById(objCtHNx.Id);
            return true;
        }

        /// <summary>
        /// Luu cac chung tu kho (So du kho, Nhap xuat kho, dieu chuyen kho) - Khong lien quan toi ban hang
        /// </summary>
        /// <param name="isUpdate"></param>
        /// <param name="_cthInfo"></param>
        /// <param name="_lstctdInfo"></param>
        /// <param name="_lstDelCtdInfo"></param>
        /// <returns></returns>
        [Transaction]
        public Boolean SaveChungTuKho(Boolean isUpdate, ref CtHNx _cthInfo, ref List<CtDNx> _lstctdInfo, List<CtDNx> _lstDelCtdInfo)
        {
            CtHNx obj = _cthInfo;
            obj.SynDate = Null.MIN_DATE;

            try
            {
                switch (isUpdate)
                {
                    case false:
                        obj.NgayTao = DateTime.Now;
                        obj.NgaySua = DateTime.Now;
                        obj = CtHNxDao.Save(obj);
                        break;
                    case true:
                        _BcKetoanDao.DeleteByChungTu(obj.Id, Null.NullGuid);
                        _BcKetoanKhoDao.DeleteByChungTu(obj.Id, Null.NullGuid);
                        _CtDNxDao.DeleteByCtH(obj.Id);

                        obj.NgaySua = DateTime.Now;
                        CtHNxDao.SaveOrUpdate(obj);
                        break;
                }

                foreach (CtDNx _tempctdnx in _lstctdInfo)
                {
                    _tempctdnx.ObjCtHNx = obj;
                    _tempctdnx.CthNxId = obj.Id;
                    if (_tempctdnx.Id == Null.NullGuid)
                    {
                        _CtDNxDao.Save(_tempctdnx);
                    }
                    else
                    {
                        _CtDNxDao.SaveOrUpdate(_tempctdnx);
                    }

                    BcKetoanKho objkho = new BcKetoanKho(obj, _tempctdnx);
                    if (_tempctdnx.Xuat == 2)
                    {
                        objkho.Xuat = 0;
                        objkho.KhoXuatId = Null.NullGuid;

                        BcKetoanKho objkho1 = new BcKetoanKho(obj, _tempctdnx);
                        objkho1.Xuat = 1;
                        objkho1.KhoNhapId = Null.NullGuid;
                        _BcKetoanKhoDao.Save(objkho1);
                    }
                    _BcKetoanKhoDao.Save(objkho);

                    List<BcKetoan> lstkt = objkho.GenBcKetoan();
                    foreach (BcKetoan tmpkt in lstkt)
                    {
                        _BcKetoanDao.Save(tmpkt);
                    }

                }
            }
            catch (Exception ex)
            {
                //obj = Nothing
                //db.RollbackTransaction();
            }

            return true;
        }

        [Transaction]
        public void SaveChungTuMuaBan(Boolean isUpdate, ref CtHNx _cthnxInfo, ref List<CtDNx> _lstctdnxInfo, List<CtDNx> _lstDelCtdInfo, ref CtHoadon _ctHoaDonInfo, Decimal _phieuXuat)
        {
            CtHoadon objctHoaDon = _ctHoaDonInfo;
            CtHNx objcthnx = _cthnxInfo;

            objctHoaDon.SynDate = Null.MIN_DATE;
            objcthnx.SynDate = Null.MIN_DATE;
            try
            {
                switch (isUpdate)
                {
                    case false:
                        objcthnx.NgayTao = DateTime.Now;
                        objcthnx.NgaySua = DateTime.Now;
                        
                        objctHoaDon = _CtHoadonDao.Save(objctHoaDon);
                        objcthnx.IdDoituongHoadon = objctHoaDon.Id;
                        objcthnx = CtHNxDao.Save(objcthnx);
                        break;
                    case true:
                        objcthnx.NgaySua = DateTime.Now;

                        _BcKetoanDao.DeleteByChungTu(objcthnx.Id, Null.NullGuid);
                        _BcKetoanKhoDao.DeleteByChungTu(objcthnx.Id, Null.NullGuid);
                        _CtThueDao.DeleteByHoaDon(objctHoaDon.Id);
                        _CtDNxDao.DeleteByCtH(objcthnx.Id);

                        _CtHoadonDao.SaveOrUpdate(objctHoaDon);
                        CtHNxDao.SaveOrUpdate(objcthnx);
                        break;
                }
                
                int index = 1;
                foreach (CtDNx _tempctdnx in _lstctdnxInfo)
                {
                    _tempctdnx.ObjCtHNx = objcthnx;
                    _tempctdnx.CthNxId = objcthnx.Id;
                    if (objctHoaDon != null)
                        _tempctdnx.IdDoituongHoadon = objctHoaDon.Id;

                    CtThue _objctt = new CtThue(_tempctdnx, _phieuXuat);
                    _objctt.SoThuTu = index.ToString();
                    _objctt.CtHoadonId = objctHoaDon.Id;
                    _CtDNxDao.Save(_tempctdnx);
                    _objctt.CtdNxId = _tempctdnx.Id;
                    _objctt = _CtThueDao.Save(_objctt);

                    #region tmp
                    //Lay gia tri cho chung tu thue di kem voi moi dong CTDNX
                    //if (_tempctdnx.Id == Null.NullGuid)
                    //{
                    //    CtThue _objctt = new CtThue(_tempctdnx, _phieuXuat);
                    //    _objctt.SoThuTu = index.ToString();
                    //    _objctt.CtHoadonId = objctHoaDon.Id;
                    //    _CtDNxDao.Save(_tempctdnx);
                    //    _objctt.CtdNxId = _tempctdnx.Id;
                    //    _objctt = _CtThueDao.Save(_objctt);
                    //}
                    //else
                    //{
                    //    _CtDNxDao.Update(_tempctdnx);
                    //    CtThue _objctt = GetObjThuebyCtDNxId(lstctThue, _tempctdnx.Id);
                    //    if (_objctt == null) _objctt = new CtThue();

                    //    _objctt.SoThuTu = index.ToString();

                    //    if (_objctt.Id == Null.NullGuid)
                    //    {
                    //        _objctt = new CtThue(_tempctdnx, _phieuXuat);
                    //        _objctt.CtHoadonId = objctHoaDon.Id;
                    //        _objctt.CtdNxId = _tempctdnx.Id;
                    //        _objctt.SoThuTu = index.ToString();
                    //        _CtThueDao.Save(_objctt);
                    //    }
                    //    else
                    //    {
                    //        CtThue tmp = new CtThue(_tempctdnx, _phieuXuat);
                    //        if (_objctt == null) _objctt = new CtThue();
                    //        _objctt.SetProperty(tmp);
                    //        _objctt.CtHoadonId = objctHoaDon.Id;
                    //        _objctt.CtdNxId = _tempctdnx.Id;
                    //        _objctt.SoThuTu = index.ToString();
                    //        _CtThueDao.Update(_objctt);
                    //    }
                    //}
                    #endregion
                    index++;

                    BcKetoanKho objkho = new BcKetoanKho(objcthnx, _tempctdnx);
                    _BcKetoanKhoDao.Save(objkho);

                    List<BcKetoan> lstkt = objkho.GenBcKetoan();
                    foreach (BcKetoan tmpkt in lstkt)
                    {
                        _BcKetoanDao.Save(tmpkt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private CtThue GetObjThuebyCtDNxId(IList<CtThue> lst, Guid ctdnxid)
        {
            if (lst == null) return null;
            foreach (CtThue tmp in lst)
            {
                if (tmp.CtdNxId == ctdnxid) return tmp;
            }
            return null;
        }

        public IList<CtDNx> GetAllSoDu(int PageIndex, int PageSize, Guid DonviId, int NamKeToan, out int TotalResult)
        {
            return CtHNxDao.GetAllSoDu(PageIndex, PageSize, DonviId, NamKeToan, out TotalResult);
        }
    }
}
