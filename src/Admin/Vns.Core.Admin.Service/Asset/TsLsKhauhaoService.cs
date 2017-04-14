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
using System.ServiceModel.Activation;

namespace Vns.Erp.Core.Admin.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	public class TsLsKhauhaoService:GenericService<TsLsKhauhao,System.Guid>, ITsLsKhauhaoService
	{
	    public ITsLsKhauhaoDao TsLsKhauhaoDao
        {
            get { return (ITsLsKhauhaoDao)Dao; }
            set { Dao = value; }
        }

        public IList<TsLsKhauhao> GetByThangNam(Guid DonviId, Decimal Thang, Decimal Nam)
        {
            return TsLsKhauhaoDao.GetByThangNam(DonviId, Thang, Nam);
        }

        public IList<TsLsKhauhao> GetByDonviId(Guid DonviId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("DonviId"); 
            values.Add(DonviId);
            IList<TsLsKhauhao> lst = List(-1, -1, props, values, null);

            return lst;
        }

        public IList<TsLsKhauhao> GetByID_CHA(Guid IdCha)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("IdCha");
            values.Add(IdCha);
            IList<TsLsKhauhao> lst = List(-1, -1, props, values, null);

            return lst;
        }

        public void DeleteByThangNam_TscdId(Decimal Thang, Decimal Nam, Guid DmTscdId)
        {
            TsLsKhauhaoDao.DeleteByThangNam_TscdId(Thang, Nam, DmTscdId);
        }

        public void DeleteByThangNam(Guid DonviId, Decimal Thang, Decimal Nam)
        {
            TsLsKhauhaoDao.DeleteByThangNam(DonviId, Thang, Nam);
        }
	}
}