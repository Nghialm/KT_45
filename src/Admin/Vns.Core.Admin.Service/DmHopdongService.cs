/*
insert license info here
*/
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
	/// <summary>
	///	Generated by MyGeneration using the NHibernate Object Mapping adapted by Gustavo
	/// </summary>	
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	public class DmHopdongService:GenericService<DmHopdong,Guid>, IDmHopdongService
	{
	    public IDmHopdongDao DmHopdongDao
        {
            get { return (IDmHopdongDao)Dao; }
            set { Dao = value; }
        }
        public IList<DmHopdong> GetAllByDonviID(Guid DonviId)
        {
            return DmHopdongDao.GetAllByDonviID(DonviId);
        }
        public IList<DmHopdong> GetAllByKy_Hieu(string KyHieu, Guid DonviId)
        {
            return DmHopdongDao.GetAllByKy_Hieu(KyHieu, DonviId);
        }
	}
}
