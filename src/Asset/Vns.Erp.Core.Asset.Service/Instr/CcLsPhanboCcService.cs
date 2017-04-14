using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Dao;
using Vns.Erp.Core.Asset.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using Spring.Transaction.Interceptor;

namespace Vns.Erp.Core.Asset.Service
{
	public class CcLsPhanboCcService:GenericService<CcLsPhanboCc,System.Guid>, ICcLsPhanboCcService
	{
	    public ICcLsPhanboCcDao CcLsPhanboCcDao
        {
            get { return (ICcLsPhanboCcDao)Dao; }
            set { Dao = value; }
        }

        public void DeleteByThangNam(Guid DonviId, Decimal Thang, Decimal Nam)
        {
            CcLsPhanboCcDao.DeleteByThangNam(DonviId, Thang, Nam);
        }

        [Transaction]
        public void SavePhanBoThang(List<CcLsPhanboCc> lstPhanbo)
        {
            foreach (CcLsPhanboCc objPhanbo in lstPhanbo)
            {
                CcLsPhanboCcDao.Save(objPhanbo);
            }
        }
	}
}