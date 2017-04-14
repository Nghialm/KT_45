using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Produce.Domain;
using Vns.Erp.Core.Produce.Dao;
using Vns.Erp.Core.Produce.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;

namespace Vns.Erp.Core.Produce.Service
{
	public class SxPhancongService:GenericService<SxPhancong,System.Guid>, ISxPhancongService
	{
	    public ISxPhancongDao SxPhancongDao
        {
            get { return (ISxPhancongDao)Dao; }
            set { Dao = value; }
        }

        public IList<SxPhancong> LoadByKeHoachId(Guid KeHoachId)
        {
            return SxPhancongDao.LoadByKeHoachId(KeHoachId);

        }
	}
}