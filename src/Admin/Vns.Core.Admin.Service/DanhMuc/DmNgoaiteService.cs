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
    public class DmNgoaiteService : GenericService<DmNgoaite, Guid>, IDmNgoaiteService
    {
        public IDmNgoaiteDao DmNgoaiteDao
        {
            get { return (IDmNgoaiteDao)Dao; }
            set { Dao = value; }
        }
        public IList<DmNgoaite> GetAllByKyHieu(string KyHieu)
        {
            return DmNgoaiteDao.GetAllByKyHieu(KyHieu);
        }

        public IList<DmNgoaite> GetAllByDonviID(Guid DonviId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("DonviId");
            values.Add(DonviId);
            return DmNgoaiteDao.List(-1, -1, props, values, null);
        }
    }
}