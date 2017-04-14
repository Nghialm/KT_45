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

namespace Vns.Erp.Core.Produce.Service
{
    public class SxDmQuytrinhService : GenericService<SxDmQuytrinh, System.Guid>, ISxDmQuytrinhService
    {
        public ISxDmQuytrinhDao SxDmQuytrinhDao
        {
            get { return (ISxDmQuytrinhDao)Dao; }
            set { Dao = value; }
        }

        public ISxQuytrinhDinhmucDao SxQuytrinhDinhmucDao;

        public void SaveQuyTrinhDinhMuc(SxDmQuytrinh objQuyTrinh, IList<SxQuytrinhDinhmuc> lstVatTu, IList<SxQuytrinhDinhmuc> lstSanPham, IList<SxQuytrinhDinhmuc> lstDelVatTu, IList<SxQuytrinhDinhmuc> lstDelSanPham)
        {
            SxDmQuytrinhDao.SaveOrUpdate(objQuyTrinh);

            foreach (SxQuytrinhDinhmuc objVatTu in lstVatTu)
            {
                objVatTu.QuytrinhId = objQuyTrinh.Id;
                objVatTu.LoaiQuyTrinh = (int)FormGlobals.DinhMucType.VatTu;
                SxQuytrinhDinhmucDao.SaveOrUpdate(objVatTu);
            }

            foreach (SxQuytrinhDinhmuc objSanPham in lstSanPham)
            {
                objSanPham.QuytrinhId = objQuyTrinh.Id;
                objSanPham.LoaiQuyTrinh = (int)FormGlobals.DinhMucType.SanPham;
                SxQuytrinhDinhmucDao.SaveOrUpdate(objSanPham);
            }

            foreach (SxQuytrinhDinhmuc objDelVatTu in lstDelVatTu)
            {
                if (objDelVatTu.Id != new Guid())
                    SxQuytrinhDinhmucDao.DeleteById(objDelVatTu.Id);
            }

            foreach (SxQuytrinhDinhmuc objDelSanPham in lstDelSanPham)
            {
                if (objDelSanPham.Id != new Guid())
                    SxQuytrinhDinhmucDao.DeleteById(objDelSanPham.Id);
            }
        }

        public IList<SxDmQuytrinh> GetByDonviId(Guid DonviId)
        {
            return SxDmQuytrinhDao.GetByDonviId(DonviId);
        }

        public void DeleteAllByDonviId(Guid DonviId)
        {
            SxDmQuytrinhDao.DeleteAllByDonviId(DonviId);
        }

    }
}