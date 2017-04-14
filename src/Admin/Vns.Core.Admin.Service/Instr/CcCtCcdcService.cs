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

namespace Vns.Erp.Core.Admin.Service
{
	public class CcCtCcdcService:GenericService<CcCtCcdc,System.Guid>, ICcCtCcdcService
	{
	    public ICcCtCcdcDao CcCtCcdcDao
        {
            get { return (ICcCtCcdcDao)Dao; }
            set { Dao = value; }
        }

        public IList<CcCtCcdc> GetByCCDCId(Guid CcdcId)
        {
            return CcCtCcdcDao.GetByCCDCId(CcdcId);
        }

        public IList<CcCtCcdc> GetByCCDCIdAndTT(Guid CcdcId)
        {
            return CcCtCcdcDao.GetByCCDCIdAndTT(CcdcId);
        }

        public Boolean DeleteByCcdcId(Guid CcdcId)
        {
            return CcCtCcdcDao .DeleteByCcdcId (CcdcId );
        }

        public IList<CcCtCcdc> GetByTrangThai(decimal GiamCcdc)
        {
            return CcCtCcdcDao.GetByTrangThai(GiamCcdc);
        }

        public Boolean DeleteByTrangThai(Guid CcdcId, Decimal GiamCcdc)
        {
            return CcCtCcdcDao.DeleteByTrangThai(CcdcId, GiamCcdc);
        }

        public Decimal GetThuTuMax(Guid CcdcId)
        {
            Decimal i = 0;

            IList<CcCtCcdc> lst = GetByCCDCId(CcdcId);

            foreach (CcCtCcdc obj in lst)
            {
                if (i < obj.ThuTu)
                {
                    i = obj.ThuTu;
                }
            }

            return i;
        }

        public IList<CcCtCcdc> GetByCcDcId_TrangThai(Guid CcdcId, decimal GiamCcdc)
        {
            return CcCtCcdcDao.GetByCcDcId_TrangThai(CcdcId, GiamCcdc);
        }

	}
}