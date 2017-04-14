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
	public class SxLenhsanxuatDService:GenericService<SxLenhsanxuatD,System.Guid>, ISxLenhsanxuatDService
	{
	    public ISxLenhsanxuatDDao SxLenhsanxuatDDao
        {
            get { return (ISxLenhsanxuatDDao)Dao; }
            set { Dao = value; }
        }
	}
}