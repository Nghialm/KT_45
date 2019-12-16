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
    public class BangGiaHService : GenericService<BangGiaH, System.Guid>, IBangGiaHService
    {
        public IBangGiaHDao BangGiaHDao
        {
            get { return (IBangGiaHDao)Dao; }
            set { Dao = value; }
        }
        public IBangGiaDDao BangGiaDDao;

        public IList<BangGiaH> GetBangGia(Guid DonviId)
        {
            return BangGiaHDao.GetBangGia(DonviId);
        }

        public BangGiaH GetBangGiaLastest(Guid Donviid)
        {
            return BangGiaHDao.GetBangGiaLastest(DateTime.Now, Donviid);
        }

        public Boolean SaveBangGia(BangGiaH banggiaH)
        {
            BangGiaHDao.SaveOrUpdate(banggiaH);
            
            foreach (BangGiaD d in banggiaH.lstBangGiaD)
            {
                d.BangGiaHId = banggiaH.Id;
                BangGiaDDao.SaveOrUpdate(d);
            }

            return true;
        }
    }
}