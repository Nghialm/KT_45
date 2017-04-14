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
	public class DmLoaitaisanService:GenericService<DmLoaitaisan,Guid>, IDmLoaitaisanService
	{
	     public IDmLoaitaisanDao DmLoaitaisanDao
        {
            get { return (IDmLoaitaisanDao)Dao; }
            set { Dao = value; }
        }
        public IList<DmLoaitaisan> GetByKyHieu(string KyHieu){
            return DmLoaitaisanDao.GetByKyHieu(KyHieu);
        }
        public IList<DmLoaitaisan> GetAllSortByKyHieu()
        {
            IList<Core.Domain.VnsOrder> lstOrder = new List<Core.Domain.VnsOrder>();
            lstOrder.Add(new Core.Domain.VnsOrder(true, "KyHieu"));
            return DmLoaitaisanDao.List(-1, -1, null, null, lstOrder);
        }
	}
}