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
	public class SxLenhsanxuatService:GenericService<SxLenhsanxuat,System.Guid>, ISxLenhsanxuatService
	{
	    public ISxLenhsanxuatDao SxLenhsanxuatDao
        {
            get { return (ISxLenhsanxuatDao)Dao; }
            set { Dao = value; }
        }

        public ISxLenhsanxuatDDao SxLenhsanxuatDDao;

        public IList<SxLenhsanxuat> LoadByPhanCongId(Guid PhanCongId)
        {
            return SxLenhsanxuatDao.LoadByPhanCongId(PhanCongId);
        }

        public IList<SxLenhsanxuat> LoadByToSanXuat(Guid ToSanXuatId)
        {
            return SxLenhsanxuatDao.LoadByToSanXuat(ToSanXuatId);
        }

        public void SaveLenhSanXuat(SxLenhsanxuat objLenhSanXuat, IList<SxLenhsanxuatD> lstDetail, IList<SxLenhsanxuatD> lstDel)
        {
            objLenhSanXuat.LstLenhSanXuatDetail = null; 
            SxLenhsanxuatDao.Merge(objLenhSanXuat);

            foreach (SxLenhsanxuatD objLenhSxD in lstDetail)
            {
                objLenhSxD.LenhsanxuatId = objLenhSanXuat.Id;
                SxLenhsanxuatDDao.SaveOrUpdate(objLenhSxD);
            }


            foreach (SxLenhsanxuatD objDelLenhSxD in lstDel)
            {
                if (objDelLenhSxD.Id != new Guid())
                {
                    SxLenhsanxuatDDao.DeleteById(objDelLenhSxD.Id);
                }
            }
        }

        public IList<SxLenhsanxuat> GetbyDonviId(Guid DonviId)
        {
            return SxLenhsanxuatDao.GetbyDonviId(DonviId);
        }
	}
}