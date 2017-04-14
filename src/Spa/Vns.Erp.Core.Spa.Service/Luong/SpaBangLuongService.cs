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
using Vns.Erp.Core.Accounting.Dao;
using Vns.Erp.Core.Spa.Common;
using Vns.Erp.Core.Accounting.Domain;
using Spring.Transaction.Interceptor;

namespace Vns.Erp.Core.Spa.Service
{
	public class SpaBangLuongService:GenericService<SpaBangLuong,System.String>, ISpaBangLuongService
	{
	    public ISpaBangLuongDao SpaBangLuongDao
        {
            get { return (ISpaBangLuongDao)Dao; }
            set { Dao = value; }
        }

        private IBcKetoanDao _BcKetoanDao;
        public IBcKetoanDao BcKetoanDao
        {
            get { return _BcKetoanDao; }
            set { _BcKetoanDao = value; }
        } 

        public ISpaDmNhanvienDao SpaDmNhanvienDao;

        public IList<SpaBangLuong> BangLuongThang(Guid DonViId, DateTime ThangLuong, Guid NhanVienId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("DonViId");
            values.Add(DonViId);
            props.Add("ThangLuong");
            values.Add(ThangLuong);
            if (!VnsCheck.IsNullGuid(NhanVienId))
            {
                props.Add("NhanVienId");
                values.Add(NhanVienId);
            }
            IList<SpaBangLuong> lst = List(-1, -1, props, values, null);

            if (lst == null || lst.Count == 0)
            {
                IList<SpaDmNhanvien> lstNhanVien = SpaDmNhanvienDao.GetAll();

                lst = new List<SpaBangLuong>();
                foreach (SpaDmNhanvien tmpNhanVien in lstNhanVien)
                {
                    SpaBangLuong tmpbangluong = new SpaBangLuong(tmpNhanVien);
                    tmpbangluong.ThangLuong = ThangLuong;
                    tmpbangluong.DonViId = DonViId;
                    lst.Add(tmpbangluong);
                }
            }

            return lst;
        }

        [Transaction]
        public Boolean SaveBangLuongThang(IList<SpaBangLuong> lstBangLuong, DateTime ThangLuong)
        {
            Decimal SoTien = 0;
            DateTime TuNgay = ThangLuong;
            DateTime DenNgay = ThangLuong;

            //Delete old salary
            SpaBangLuongDao.DeleteSalaryByMonth(ThangLuong);

            foreach (SpaBangLuong obj in lstBangLuong)
            {
                SpaBangLuongDao.SaveOrUpdate(obj);
                SoTien += obj.TongTien;
            }
            
            //Save ke toan
            _BcKetoanDao.DeleteByLoaiCt(SpaGeneral.LctLuong.Id, TuNgay, DenNgay);
            if (lstBangLuong.Count <= 0) return false;

            BcKetoan bc = GenNghiepVuKeToan(lstBangLuong[0]);
            bc.SoTien = SoTien;
            _BcKetoanDao.Save(bc);

            return true;
        }

        [Transaction]
        public Boolean DeleteBangLuongThang(DateTime ThangLuong)
        {
            DateTime TuNgay = ThangLuong;
            DateTime DenNgay = ThangLuong;

            //Delete old salary
            SpaBangLuongDao.DeleteSalaryByMonth(ThangLuong);

            //Save ke toan
            _BcKetoanDao.DeleteByLoaiCt(SpaGeneral.LctLuong.Id, TuNgay, DenNgay);
            return true;
        }

        private BcKetoan GenNghiepVuKeToan(SpaBangLuong luong)
        {
            BcKetoan objKeToan = new BcKetoan();

            objKeToan.CthId = new Guid();
            objKeToan.CtdId = Null.NullGuid;
            objKeToan.CtSo = "TRA_LUONG";
            objKeToan.NgayCt = luong.ThangLuong;
            objKeToan.DonviId = Generals.DON_VI.Id;
            objKeToan.MaDonvi = Generals.DON_VI.MaDonvi;
            objKeToan.IdLoaiCt = SpaGeneral.LctLuong.Id;
            objKeToan.MaLoaiCt = SpaGeneral.LctLuong.MaLoaiCt;
            objKeToan.KyHieuLoaiCt = SpaGeneral.LctLuong.KyHieu;
            objKeToan.NgayGhi = luong.ThangLuong;
            objKeToan.NteId = SpaGeneral.NoiTe.Id;
            objKeToan.MaNte = SpaGeneral.NoiTe.MaNte;
            objKeToan.TyGia = 1;

            objKeToan.TkNoId = SpaGeneral.TkLuongInfo.Id;
            objKeToan.MaTkNo = SpaGeneral.TkLuongInfo.MaTaikhoan;
            objKeToan.TenTkNo = SpaGeneral.TkLuongInfo.TenTaikhoan;

            objKeToan.TkCoId = SpaGeneral.TkTienMatInfo.Id;
            objKeToan.MaTkCo = SpaGeneral.TkTienMatInfo.MaTaikhoan;
            objKeToan.TenTkCo = SpaGeneral.TkTienMatInfo.TenTaikhoan;
            //objKeToan.IdKhangCo = objCtH.KhangId;
            //objKeToan.MaKhangCo = objCtH.MaKhang;

            objKeToan.DienGiai = String.Format("Tra luong thang {0}", luong.ThangLuong.Month);
            objKeToan.SoDu = 0;
            
            return objKeToan;
        }
	}
}