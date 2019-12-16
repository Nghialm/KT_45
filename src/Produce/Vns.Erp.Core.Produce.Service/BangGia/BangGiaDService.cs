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
    public class BangGiaDService : GenericService<BangGiaD, System.Guid>, IBangGiaDService
    {
        public IBangGiaDDao BangGiaDDao
        {
            get { return (IBangGiaDDao)Dao; }
            set { Dao = value; }
        }
    }
}