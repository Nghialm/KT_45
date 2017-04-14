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

namespace Vns.Erp.Core.Asset.Service
{
	public class CcCtCcdcNvonService:GenericService<CcCtCcdcNvon,System.Guid>, ICcCtCcdcNvonService
	{
	    public ICcCtCcdcNvonDao CcCtCcdcNvonDao
        {
            get { return (ICcCtCcdcNvonDao)Dao; }
            set { Dao = value; }
        }

        public IList<CcCtCcdcNvon> GetByCtCcdcId(Guid CtCcdcId)
        {
            return CcCtCcdcNvonDao.GetByCtCcdcId(CtCcdcId); 
        }

        public Boolean DeleteByCtCcdcId(Guid CtCcdcId)
        {
            return CcCtCcdcNvonDao.DeleteByCtCcdcId(CtCcdcId);
        }
	}
}