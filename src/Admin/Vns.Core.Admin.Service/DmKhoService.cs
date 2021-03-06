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
	public class DmKhoService:GenericService<DmKho,Guid>, IDmKhoService
	{
	    public IDmKhoDao DmKhoDao
        {
            get { return (IDmKhoDao)Dao; }
            set { Dao = value; }
        }
        public int GetNumberDmKhoByKyHieu(String KyHieu, Guid DonviId)
        {
            return DmKhoDao.GetNumberDmKhoByKyHieu(KyHieu, DonviId);
        }
        public IList<DmKho> GetAllByDonviID(Guid DonviId)
        {
            return DmKhoDao.GetAllByDonviID(DonviId);
        }
	}
}
