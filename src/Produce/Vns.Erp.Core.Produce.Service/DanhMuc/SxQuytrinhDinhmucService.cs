using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Produce.Domain;
using Vns.Erp.Core.Produce.Dao;
using Vns.Erp.Core.Produce.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;

namespace Vns.Erp.Core.Produce.Service
{
	public class SxQuytrinhDinhmucService:GenericService<SxQuytrinhDinhmuc,System.Guid>, ISxQuytrinhDinhmucService
	{
	    public ISxQuytrinhDinhmucDao SxQuytrinhDinhmucDao
        {
            get { return (ISxQuytrinhDinhmucDao)Dao; }
            set { Dao = value; }
        }
	}
}