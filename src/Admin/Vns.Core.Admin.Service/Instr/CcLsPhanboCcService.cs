using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Admin.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;

namespace Vns.Erp.Core.Admin.Service
{
	public class CcLsPhanboCcService:GenericService<CcLsPhanboCc,System.Guid>, ICcLsPhanboCcService
	{
	    public ICcLsPhanboCcDao CcLsPhanboCcDao
        {
            get { return (ICcLsPhanboCcDao)Dao; }
            set { Dao = value; }
        }
	}
}