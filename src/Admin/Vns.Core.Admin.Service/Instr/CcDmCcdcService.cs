using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Admin.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using Spring.Transaction.Interceptor;

namespace Vns.Erp.Core.Admin.Service
{
	public class CcDmCcdcService:GenericService<CcDmCcdc,System.Guid>, ICcDmCcdcService
    {

        #region Property
        public ICcDmCcdcDao CcDmCcdcDao
        {
            get { return (ICcDmCcdcDao)Dao; }
            set { Dao = value; }
        }

        private ICcCtCcdcDao  _CtDao;
        public ICcCtCcdcDao CcCtCcdcDao
        {
            get { return _CtDao; }
            set { _CtDao = value; }
        }

        private ICcCtCcdcNvonDao  _NVDao;
        public ICcCtCcdcNvonDao CcCtCcdcNvonDao
        {
            get { return _NVDao; }
            set { _NVDao = value; }
        }

        #endregion

        public IList<CcDmCcdc> GetAllByDonviID(Guid DonviId)
        {
            return CcDmCcdcDao.GetAllByDonviID(DonviId); 
        }

        public IList<CcDmCcdc> GetByMaCCDC(string MaCcdc)
        {
            return CcDmCcdcDao.GetByMaCCDC(MaCcdc);
        }

        public void UpdateGiamCcdc(Guid CcdcId, Decimal GiamCcdc)
        {
            CcDmCcdcDao.UpdateGiamCcdc(CcdcId, GiamCcdc);
        }

        [Transaction]
        public Boolean SaveCCDC(Boolean isInsert,ref CcDmCcdc obj_CCDC,CcCtCcdc obj_CCDC_CT, IList<CcCtCcdcNvon> lst_NguonVon, IList<CcCtCcdcNvon> lst_Del_NguonVon)
        {
            if (isInsert)
            {
                CcDmCcdcDao.Save(obj_CCDC);

                obj_CCDC_CT.CcdcId  = obj_CCDC.Id;
                CcCtCcdcDao.Save(obj_CCDC_CT);
            }
            else
            {
                CcDmCcdcDao.SaveOrUpdate(obj_CCDC);
                CcCtCcdcDao.SaveOrUpdate(obj_CCDC_CT);
            }

            foreach (CcCtCcdcNvon _tempNguonVon in lst_NguonVon)
            {
                if (_tempNguonVon.Id == new Guid())
                {
                    _tempNguonVon.CtCcdcId = obj_CCDC_CT.Id;
                    CcCtCcdcNvonDao.Save(_tempNguonVon);
                }
                else
                {
                    CcCtCcdcNvonDao.SaveOrUpdate (_tempNguonVon);
                }
            }

            foreach (CcCtCcdcNvon _tempDelNV in lst_Del_NguonVon)
            { 
                if (_tempDelNV .Id != new Guid())
                {
                    CcCtCcdcNvonDao .Delete (_tempDelNV );
                }
            }

            return true;
        }

        [Transaction]
        public Boolean DeleteCCDC(Guid ccdcId)
        {
            CcDmCcdcDao.DeleteById(ccdcId);

            IList<CcCtCcdc> lstCtCcdc = new List<CcCtCcdc>();
            lstCtCcdc = CcCtCcdcDao.GetByCCDCId(ccdcId);

            foreach (CcCtCcdc obj in lstCtCcdc)
            {
                CcCtCcdcDao.Delete(obj);
                CcCtCcdcNvonDao.DeleteByCtCcdcId(obj.Id);
            }
            return true;
        }

        [Transaction]
        public Boolean SaveKhaiBaoGiam(Boolean IsInsert, CcDmCcdc objCcDmCcdc, CcCtCcdc objCcCtCcdc)
        {
            if (IsInsert)
            {
                CcCtCcdcDao.Save(objCcCtCcdc);
            }
            else
            {
                CcCtCcdcDao.SaveOrUpdate(objCcCtCcdc);
            }

            CcDmCcdcDao.SaveOrUpdate(objCcDmCcdc);


            return true;
        }

        public Boolean DeleteKhaiBaoGiamCcdc(Guid CcdcId, Decimal GiamCcdc)
        {
            CcCtCcdcDao.DeleteByTrangThai (CcdcId, GiamCcdc);
            UpdateGiamCcdc(CcdcId, 0);
            return true;
        }

    }
}