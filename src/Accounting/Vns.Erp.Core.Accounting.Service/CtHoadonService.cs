using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Dao;
using Vns.Erp.Core.Accounting.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using Spring.Transaction.Interceptor;
using System.ServiceModel.Activation;

namespace Vns.Erp.Core.Accounting.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class CtHoadonService : GenericService<CtHoadon, System.Guid>, ICtHoadonService
    {
        public ICtHoadonDao CtHoadonDao
        {
            get { return (ICtHoadonDao)Dao; }
            set { Dao = value; }
        }

        private ICtThueDao _CtThueDao;

        public ICtThueDao CtThueDao
        {
            get { return _CtThueDao; }
            set { _CtThueDao = value; }
        }


        public IList<CtHoadon> GetAllByDonviID(Guid DonviId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("DonviId");
            values.Add(DonviId);
            return List(-1, -1, props, values, null);
        }

        public IList<CtHoadon> SearchBy(DateTime TuNgay, DateTime DenNgay, Guid DonviId, String SoHoadon)
        {
            return CtHoadonDao.SearchBy(TuNgay, DenNgay, DonviId, SoHoadon);
        }

        [Transaction]
        public Boolean SaveHoaDonThueGTGT(CtHoadon objHoaDon, IList<CtThue> lstSave, IList<CtThue> lstDel)
        {
            CtHoadonDao.SaveOrUpdate(objHoaDon);

            if (lstDel != null)
            foreach (CtThue objdel in lstDel)
            {
                _CtThueDao.Delete(objdel);
            }

            foreach (CtThue objsave in lstSave)
            {
                objsave.CtHoadonId = objHoaDon.Id;
                _CtThueDao.SaveOrUpdate(objsave);
            }

            return true;
        }
    }
}
