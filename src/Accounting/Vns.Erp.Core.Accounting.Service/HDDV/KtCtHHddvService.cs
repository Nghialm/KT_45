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
using Vns.Erp.Core.Domain;
using Spring.Transaction.Interceptor;
using System.ServiceModel.Activation;

namespace Vns.Erp.Core.Accounting.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class KtCtHHddvService : GenericService<KtCtHHddv, System.Guid>, IKtCtHHddvService
    {
        #region Property
        public IKtCtHHddvDao KtCtHHddvDao
        {
            get { return (IKtCtHHddvDao)Dao; }
            set { Dao = value; }
        }

        private IKtCtDHddvDao _KtCtDHddvDao;
        public IKtCtDHddvDao KtCtDHddvDao
        {
            get { return _KtCtDHddvDao; }
            set { _KtCtDHddvDao = value; }
        }

        private IBcKetoanDao _BcKetoanDao;
        public IBcKetoanDao BcKetoanDao
        {
            get { return _BcKetoanDao; }
            set { _BcKetoanDao = value; }
        }

        private ICtHoadonDao _CtHoadonDao;
        public ICtHoadonDao CtHoadonDao
        {
            get { return _CtHoadonDao; }
            set { _CtHoadonDao = value; }
        }

        private ICtThueDao _CtThueDao;
        public ICtThueDao CtThueDao
        {
            get { return _CtThueDao; }
            set { _CtThueDao = value; }
        }
        #endregion

        #region Syn function
        [Transaction]
        public void SaveData4Syn(KtCtHHddv _cth, List<KtCtDHddv> _lstctd)
        {
            //Xoa du lieu
            //_cth. = null;
            _cth.LstCtDHddv = null;
            KtCtHHddvDao.SaveOrUpdate(_cth);

            if (_cth.IsDeleted != 1)
            {
                _KtCtDHddvDao.DeleteByCtH(_cth.Id);
                foreach (KtCtDHddv _tempctdnx in _lstctd)
                {
                    _KtCtDHddvDao.SaveOrUpdate(_tempctdnx);
                }
            }
        }


        public void UpdateSynFlag(Guid id)
        {
            KtCtHHddvDao.UpdateSynFlag(id);
        }
        #endregion

        public IList<KtCtHHddv> GetByDonviId(Guid DonviId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("DonviId");
            values.Add(DonviId);
            return List(-1, -1, props, values, null);
        }

        public IList<KtCtHHddv> GetByLoaiChungTu(int PageIndex, int PageSize,Guid DonviId, string MaLoaiCt, int SoCTHienThi,out int TotalResult)
        {
            if (SoCTHienThi <= 0)
                SoCTHienThi = -1;

            return KtCtHHddvDao.GetByLoaiChungTu(PageIndex,PageSize,DonviId, MaLoaiCt, SoCTHienThi,out TotalResult);
        }

        [Transaction]
        public Boolean DeleteChungTu(KtCtHHddv objCtH, IList<KtCtDHddv> lstCtD)
        {
            _BcKetoanDao.DeleteByChungTu(objCtH.Id, new Guid());
            _CtHoadonDao.DeleteById(objCtH.IdDoituongHoadon);
            DeleteById(objCtH.Id);

            return true;
        }

        [Transaction]
        public void SaveHDDVMuaBanHang(Boolean IsInsert, ref KtCtHHddv _cthHddvInfo, ref CtHoadon _ctHoaDonInfo, ref List<KtCtDHddv> _lstctdHddvInfo, List<KtCtDHddv> _dellstctdHddv)
        {
            CtHoadon objctHoaDon = _ctHoaDonInfo;
            KtCtHHddv objcthHddv = _cthHddvInfo;

            objcthHddv.SynDate = Null.MIN_DATE;
            objctHoaDon.SynDate = Null.MIN_DATE;

            switch (IsInsert)
            {
                case true:
                    objctHoaDon = _CtHoadonDao.Save(objctHoaDon);
                    objcthHddv.IdDoituongHoadon = objctHoaDon.Id;
                    objcthHddv.NgayTao = DateTime.Now;
                    objcthHddv = KtCtHHddvDao.Save(objcthHddv);
                    break;
                case false:
                    _BcKetoanDao.DeleteByChungTu(objcthHddv.Id, Null.NullGuid);
                    _CtThueDao.DeleteByHoaDon(objctHoaDon.Id);

                    _CtHoadonDao.Update(objctHoaDon);
                    objcthHddv.NgaySua = DateTime.Now;
                    KtCtHHddvDao.Update(objcthHddv);
                    break;
            }

            CtThue _objctt = new CtThue();
            foreach (KtCtDHddv _tempctdHddv in _lstctdHddvInfo)
            {
                _tempctdHddv.CthHddvId = objcthHddv.Id;
                _tempctdHddv.IdDoituongHoadon = objctHoaDon.Id;

                _objctt.ThueId = _tempctdHddv.ThueId;
                _objctt.TenThue = _tempctdHddv.TenThue;
                _objctt.SoLuong = _tempctdHddv.SoLuong;
                _objctt.KhangId = objcthHddv.KhangId;
                _objctt.TenKhang = objcthHddv.TenKhang;
                _objctt.Mst = objcthHddv.MstKhang;
                _objctt.NgayHoadon = objcthHddv.NgayCt;
                _objctt.DonviId = Generals.DON_VI.Id;
                _objctt.TenHanghoa = _tempctdHddv.TenHhDv;
                _objctt.CtHoadonId = objctHoaDon.Id;
                _objctt.CthId = objcthHddv.Id;
                _objctt.PhanHe = 2;
                _objctt.TyLe = _tempctdHddv.TyLeThueGtgt;
                _objctt.NgayTao = objcthHddv.NgayTao;
                _objctt.LoaiTaikhoan = "C";
                _objctt.SoTien = _tempctdHddv.SoTienThueGtgt;

                _objctt.TaikhoanId = _tempctdHddv.TkCoIdGtgt;
                _objctt.MaTaikhoan = _tempctdHddv.MaTkCoGtgt;
                _objctt.DoanhSo = _tempctdHddv.SoTien;
                _objctt.DoanhSoNte = _tempctdHddv.SoTienNte;
                _objctt.SoSeri = objcthHddv.SoSeriHd;
                _objctt.KyHieuHd = objcthHddv.SoHd;

                if (VnsCheck.IsNullGuid(_tempctdHddv.Id))
                {
                    _KtCtDHddvDao.Save(_tempctdHddv);
                    _objctt.CtdId = _tempctdHddv.Id;
                    _objctt = _CtThueDao.Save(_objctt);
                }
                else
                {
                    _KtCtDHddvDao.Merge(_tempctdHddv);
                    _objctt.CtdId = _tempctdHddv.Id;
                    _objctt = _CtThueDao.Save(_objctt);
                }

                //Save to General
                IList<BcKetoan> tmpbc = _tempctdHddv.GenBcKetoan(objcthHddv);
                foreach (BcKetoan tmp in tmpbc)
                {
                    _BcKetoanDao.Save(tmp);
                }
            }

            if ((_dellstctdHddv != null))
            {
                foreach (KtCtDHddv _tempdelctdHddv in _dellstctdHddv)
                {
                    _KtCtDHddvDao.Delete(_tempdelctdHddv);
                }
            }

        }

        public IList<KtCtHHddv> SearchChungTu(Guid DONVI_ID, string MA_LOAI_CT, string CT_SO, DateTime NGAY_CT_TU, DateTime NGAY_CT_DEN, decimal GHI, string TenKhachHang, string MA_TK_NO, string MA_TK_CO, string Ma_tk_thue,
                                   decimal SO_TIEN_TU, decimal SO_TIEN_DEN, string NOI_DUNG, Decimal So_Luong_Tu, Decimal So_Luong_Den, String TenHangHoa,
                                   Guid ID_DM_KHOANPHI, Guid ID_DM_VUVIEC, Guid ID_DM_HOPDONG, Guid ID_DM_PHONGBAN, Guid ID_DM_TUDO_1, Guid ID_DM_TUDO_2, Guid ID_DM_TUDO_3,
                                   Guid ID_DM_TUDO_4, Guid ID_DM_TUDO_5)
        {
            return KtCtHHddvDao.SearchChungTu(DONVI_ID, MA_LOAI_CT, CT_SO, NGAY_CT_TU, NGAY_CT_DEN, GHI, TenKhachHang,
                MA_TK_NO, MA_TK_CO, Ma_tk_thue,
                SO_TIEN_TU, SO_TIEN_DEN, NOI_DUNG,
                So_Luong_Tu, So_Luong_Den, TenHangHoa,
                Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid);
        }

        
    }
}