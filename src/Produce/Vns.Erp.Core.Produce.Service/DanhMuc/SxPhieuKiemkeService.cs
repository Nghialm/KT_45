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
    public class SxPhieuKiemkeService : GenericService<SxPhieuKiemke, System.Guid>, ISxPhieuKiemkeService
    {
        public ISxPhieuKiemkeDao SxPhieuKiemkeDao
        {
            get { return (ISxPhieuKiemkeDao)Dao; }
            set { Dao = value; }
        }

        public ISxPhieuKiemkeSlDDao SxPhieuKiemkeSlDDao;
        public ISxPhieuKiemkeVtDDao SxPhieuKiemkeVtDDao;

        public IList<SxPhieuKiemke> getByMaCt(string MaLoaiCt, Guid DonviId)
        {
            return SxPhieuKiemkeDao.getByMaCt(MaLoaiCt, DonviId);
        }

        public IList<SxPhieuKiemke> getByMaCt(int PageIndex, int PageSize, string MaLoaiCt, Guid DonviId, out int TotalResult)
        {
            return SxPhieuKiemkeDao.getByMaCt(PageIndex, PageSize, MaLoaiCt, DonviId, out TotalResult);
        }

        public void saveKiemKe(SxPhieuKiemke objKiemKe, IList<SxPhieuKiemkeSlD> lstKiemKeSl, IList<SxPhieuKiemkeVtD> lstKiemKeVt, IList<SxPhieuKiemkeSlD> lstDelKiemKeSl, IList<SxPhieuKiemkeVtD> lstDelKiemKeVt)
        {
            objKiemKe = SxPhieuKiemkeDao.SaveOrUpdate(objKiemKe);

            foreach (SxPhieuKiemkeSlD obj in lstKiemKeSl)
            {
                obj.KiemkemId = objKiemKe.Id;
                SxPhieuKiemkeSlDDao.SaveOrUpdate(obj);
            }

            foreach (SxPhieuKiemkeVtD obj in lstKiemKeVt)
            {
                obj.KiemkemId = objKiemKe.Id;
                SxPhieuKiemkeVtDDao.SaveOrUpdate(obj);
            }


            foreach (SxPhieuKiemkeSlD obj in lstDelKiemKeSl)
            {
                if (obj.Id != new Guid())
                    SxPhieuKiemkeSlDDao.DeleteById(obj.Id);
            }

            foreach (SxPhieuKiemkeVtD obj in lstDelKiemKeVt)
            {
                if (obj.Id != new Guid())
                    SxPhieuKiemkeVtDDao.DeleteById(obj.Id);
            }

        }
    }
}