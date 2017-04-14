using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Dao;
using Vns.Erp.Core.Asset.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;

namespace Vns.Erp.Core.Asset.Service
{
	public class CcLsCcdcService:GenericService<CcLsCcdc,System.Guid>, ICcLsCcdcService
	{
	    public ICcLsCcdcDao CcLsCcdcDao
        {
            get { return (ICcLsCcdcDao)Dao; }
            set { Dao = value; }
        }
	}
}