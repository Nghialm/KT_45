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
    public class HtFileBaocaoService : GenericService<HtFileBaocao, Guid>, IHtFileBaocaoService
    {
        public IHtFileBaocaoDao HtFileBaocaoDao
        {
            get { return (IHtFileBaocaoDao)Dao; }
            set { Dao = value; }
        }

        public IList<HtFileBaocao> GetByHTBAOCAOID(Guid BaoCaoId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("HtBaocaoId");
            values.Add(BaoCaoId);
            return HtFileBaocaoDao.List(-1, -1, props, values, null);
        }
    }
}
