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
    public class SxKehoachMService : GenericService<SxKehoachM, System.Guid>, ISxKehoachMService
    {
        public ISxKehoachMDao SxKehoachMDao
        {
            get { return (ISxKehoachMDao)Dao; }
            set { Dao = value; }
        }

        public ISxKehoachDDao SxKehoachDDao;
        public ISxPhancongDao SxPhancongDao;

        public void SaveKeHoach(SxKehoachM objKeHoach, IList<SxKehoachD> lstSanXuat, IList<SxKehoachD> lstVatTu, IList<SxPhancong> lstKeHoach, IList<SxKehoachD> lstDelSanXuat, IList<SxKehoachD> lstDelVatTu, IList<SxPhancong> lstDelKeHoach)
        {
            SxKehoachMDao.SaveOrUpdate(objKeHoach);

            foreach (SxKehoachD obj in lstSanXuat)
            {
                obj.KehoachMId = objKeHoach.Id;
                obj.LoaiKeHoach = (int)FormGlobals.DinhMucType.SanPham;
                SxKehoachDDao.SaveOrUpdate(obj);
            }

            foreach (SxKehoachD obj in lstVatTu)
            {
                obj.KehoachMId = objKeHoach.Id;
                obj.LoaiKeHoach = (int)FormGlobals.DinhMucType.VatTu;
                SxKehoachDDao.SaveOrUpdate(obj);
            }

            foreach (SxKehoachD obj in lstDelSanXuat)
            {
                if (obj.Id != new Guid())
                    SxKehoachDDao.DeleteById(obj.Id);
            }

            foreach (SxKehoachD obj in lstDelVatTu)
            {
                if (obj.Id != new Guid())
                    SxKehoachDDao.DeleteById(obj.Id);
            }

            foreach (SxPhancong obj in lstKeHoach)
            {
                obj.KehoachMId = objKeHoach.Id;
                SxPhancongDao.SaveOrUpdate(obj); 
            }

            foreach (SxPhancong obj in lstDelKeHoach)
            {
                if (obj.Id != new Guid())
                    SxPhancongDao.DeleteById(obj.Id);
            }
        }

        public IList<SxKehoachM> getByMaCt(int PageIndex, int PageSize, string MaLoaiCt, Guid DonviId, out int TotalResult)
        {
            return SxKehoachMDao.getByMaCt(PageIndex, PageSize, MaLoaiCt, DonviId, out TotalResult);
        }

        public IList<SxKehoachM> GetByDonviId(Guid DonviId)
        {
            return SxKehoachMDao.GetByDonviId(DonviId);
        }
    }
}